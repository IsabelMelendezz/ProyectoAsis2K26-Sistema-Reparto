using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaReparto.Clases
{
    public class DashboardRepartidorInfo
    {
        public string NombreEmpleado { get; set; }
        public string NombreRol { get; set; }

        public string NombreEstadoRuta { get; set; }   // text_Estado_Ruta
        public string AreaRuta { get; set; }            // text_Area

        public string NombreTipoRuta { get; set; }      // text_Ruta_Asignada / text_Ruta_AsigadaR
        public string AreaAsignada { get; set; }        // text_Area_Asignada

        public int PaquetesPendientes { get; set; }     // text_Paquetes_Registrados
        public int EntregasHoy { get; set; }             // text_Entregas
        public string EstadoEmpleado { get; set; }       // text_Estado

        public int IdRuta { get; set; }
        public int IdAsignacion { get; set; }            // id_asignacion vigente (asignacion_transp)
    }

    // Info de cada pedido dentro del detalle de la asignación de transporte (detalle_asignacion_transp)
    public class PedidoRepartoInfo
    {
        public int IdDetalle { get; set; }
        public int IdPedido { get; set; }
        public string CodigoPedido { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }   // Pendiente / En ruta / Entregado / No entregado
        public decimal Peso { get; set; }
    }

    internal class CMenu_Repartidor
    {
        public DashboardRepartidorInfo ObtenerDashboard(int idUsuario)
        {
            var info = new DashboardRepartidorInfo();
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                // 1. Datos del empleado, rol, ruta/estado de ruta/tipo de ruta asignados HOY
                string query = @"
                    SELECT at.id_asignacion,
                           e.id_empleado, e.nombre_empleado, e.apellido_empleado,
                           es.nombre_estado_empleado,
                           r.nombre_rol,
                           rt.id_ruta,
                           er.nombre_estado_ruta,
                           ac.zona_area_cubierta AS area_ruta,
                           tr.nombre_tipo_ruta
                    FROM asignacion_transp at
                    INNER JOIN empleado e        ON at.id_empleado = e.id_empleado
                    INNER JOIN estado_empleado es ON e.id_estado_empleado = es.id_estado_empleado
                    INNER JOIN ruta rt            ON at.id_ruta = rt.id_ruta
                    INNER JOIN estado_ruta er     ON rt.id_estado_ruta = er.id_estado_ruta
                    INNER JOIN area_cubierta ac   ON rt.id_area = ac.id_area
                    INNER JOIN tipo_ruta tr       ON rt.id_tipo_ruta = tr.id_tipo_ruta
                    INNER JOIN usuario u          ON u.id_empleado = e.id_empleado
                    LEFT JOIN usuario_rol ur      ON ur.id_usuario = u.id_usuario
                    LEFT JOIN rol r                ON r.id_rol = ur.id_rol
                    WHERE u.id_usuario = @idUsuario
                    ORDER BY at.fecha_asignacion_asignacion_transp DESC
                    LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                MySqlDataReader reader = cmd.ExecuteReader();

                int idEmpleado = 0;

                if (reader.Read())
                {
                    idEmpleado = Convert.ToInt32(reader["id_empleado"]);
                    info.NombreEmpleado = reader["nombre_empleado"].ToString();
                    info.EstadoEmpleado = reader["nombre_estado_empleado"].ToString();
                    info.NombreRol = reader["nombre_rol"] == DBNull.Value ? "Sin rol" : reader["nombre_rol"].ToString();
                    info.IdRuta = Convert.ToInt32(reader["id_ruta"]);
                    info.IdAsignacion = Convert.ToInt32(reader["id_asignacion"]);
                    info.NombreEstadoRuta = reader["nombre_estado_ruta"].ToString();
                    info.AreaRuta = reader["area_ruta"].ToString();
                    info.NombreTipoRuta = reader["nombre_tipo_ruta"].ToString();
                }
                reader.Close();

                if (idEmpleado > 0)
                {
                    // 2. Área asignada VIGENTE (asignacion_area)
                    string queryArea = @"
                        SELECT ac.zona_area_cubierta
                        FROM asignacion_area aa
                        INNER JOIN area_cubierta ac ON aa.id_area = ac.id_area
                        WHERE aa.id_empleado = @idEmpleado
                          AND (aa.fecha_fin_asignacion_area IS NULL OR aa.fecha_fin_asignacion_area >= CURDATE())
                        ORDER BY aa.fecha_inicio_asignacion_area DESC
                        LIMIT 1";
                    MySqlCommand cmdArea = new MySqlCommand(queryArea, conexion);
                    cmdArea.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    object resultadoArea = cmdArea.ExecuteScalar();
                    info.AreaAsignada = resultadoArea != null ? resultadoArea.ToString() : "Sin área asignada";
                }

                if (info.IdAsignacion > 0)
                {
                    // 3. Paquetes pendientes por entregar (detalle_asignacion_transp, estado real)
                    string queryPaquetes = @"
                        SELECT COUNT(*)
                        FROM detalle_asignacion_transp dat
                        WHERE dat.id_asignacion = @idAsignacion
                          AND dat.estado_pedido IN ('Pendiente', 'En ruta')";
                    MySqlCommand cmdPaquetes = new MySqlCommand(queryPaquetes, conexion);
                    cmdPaquetes.Parameters.AddWithValue("@idAsignacion", info.IdAsignacion);
                    info.PaquetesPendientes = Convert.ToInt32(cmdPaquetes.ExecuteScalar());

                    // 4. Entregas realizadas HOY (confirmadas en la tabla entrega)
                    string queryEntregas = @"
                        SELECT COUNT(*)
                        FROM detalle_asignacion_transp dat
                        INNER JOIN entrega en ON en.id_pedido = dat.id_pedido
                        WHERE dat.id_asignacion = @idAsignacion
                          AND dat.estado_pedido = 'Entregado'
                          AND en.fecha_entrega = CURDATE()";
                    MySqlCommand cmdEntregas = new MySqlCommand(queryEntregas, conexion);
                    cmdEntregas.Parameters.AddWithValue("@idAsignacion", info.IdAsignacion);
                    info.EntregasHoy = Convert.ToInt32(cmdEntregas.ExecuteScalar());
                }

                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return info;
            }
            finally
            {
                cn.cerrarConexion();
            }
        }

        // Pedidos del detalle de la asignación de transporte, pendientes de entrega (Pendiente / En ruta)
        public List<PedidoRepartoInfo> ObtenerPedidosPendientesAsignacion(int idAsignacion)
        {
            var lista = new List<PedidoRepartoInfo>();
            if (idAsignacion <= 0) return lista;

            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"
                    SELECT dat.id_detalle,
                           pe.id_pedido,
                           pe.codigo_pedido,
                           CONCAT(c.nombres_cliente, ' ', c.apellidos_cliente) AS cliente,
                           CONCAT(d.direccion_detalle,
                                  CASE WHEN ac.zona_area_cubierta IS NULL THEN '' ELSE CONCAT(', ', ac.zona_area_cubierta) END
                           ) AS direccion,
                           dat.estado_pedido AS estado,
                           IFNULL(pe.peso_total_pedido, 0) AS peso
                    FROM asignacion_transp at
                    INNER JOIN detalle_asignacion_transp dat ON dat.id_asignacion = at.id_asignacion
                    INNER JOIN pedido pe        ON pe.id_pedido = dat.id_pedido
                    INNER JOIN cliente c        ON pe.id_cliente = c.id_cliente
                    LEFT JOIN direccion d        ON pe.id_direccion_destino_pedido = d.id_direccion
                    LEFT JOIN area_cubierta ac   ON d.id_area = ac.id_area
                    WHERE at.id_asignacion = @idAsignacion
                      AND dat.estado_pedido <> 'Entregado'
                    ORDER BY dat.id_detalle";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idAsignacion", idAsignacion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new PedidoRepartoInfo
                    {
                        IdDetalle = Convert.ToInt32(reader["id_detalle"]),
                        IdPedido = Convert.ToInt32(reader["id_pedido"]),
                        CodigoPedido = reader["codigo_pedido"].ToString(),
                        Cliente = reader["cliente"].ToString(),
                        Direccion = reader["direccion"] == DBNull.Value ? "Sin dirección" : reader["direccion"].ToString(),
                        Estado = reader["estado"].ToString(),
                        Peso = Convert.ToDecimal(reader["peso"])
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pedidos de la asignación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.cerrarConexion();
            }

            return lista;
        }
    }
}
