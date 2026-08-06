using System;
using MySql.Data.MySqlClient;

namespace SistemaReparto.Clases
{
    internal class CBienvenida
    {
        private CConexion conexion = new CConexion();

        public int ContarPaquetesRegistrados()
        {
            return EjecutarConteo(@"SELECT COUNT(*)
                                     FROM paquete p
                                     INNER JOIN pedido pe ON p.id_pedido = pe.id_pedido
                                     WHERE p.estado_paquete = 'Activo'
                                       AND pe.fecha_solicitud_pedido = CURDATE()");
        }

        public int ContarRutasActivas()
        {
            return EjecutarConteo(@"SELECT COUNT(*)
                                     FROM ruta r
                                     INNER JOIN estado_ruta er ON r.id_estado_ruta = er.id_estado_ruta
                                     WHERE er.nombre_estado_ruta = 'En curso'");
        }

        public int ContarBodegasOperativas()
        {
            return EjecutarConteo("SELECT COUNT(*) FROM bodega");
        }

        public int ContarRepartidoresEnServicio()
        {
            return EjecutarConteo(@"SELECT COUNT(*)
                             FROM empleado e
                             WHERE e.id_tipo_empleado = 1
                               AND e.id_estado_empleado = 1");
        }

        private int EjecutarConteo(string query)
        {
        
            MySqlConnection cn = conexion.establecerConexion();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, cn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}