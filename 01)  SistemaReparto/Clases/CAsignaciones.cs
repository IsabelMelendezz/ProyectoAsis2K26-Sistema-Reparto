using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaReparto.Clases
{
    internal class CAsignaciones
    {
        //==============================
        // CARGAR RUTAS
        //==============================
        public void CargarRutas(ComboBox cboRuta)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string sql = @"SELECT id_ruta,
                              CONCAT('Ruta ', id_ruta) AS ruta
                       FROM ruta
                       ORDER BY id_ruta";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(sql,
                    objetoConexion.establecerConexion());

                DataTable dt = new DataTable();

                da.Fill(dt);

                cboRuta.DataSource = dt;
                cboRuta.DisplayMember = "ruta";
                cboRuta.ValueMember = "id_ruta";
                cboRuta.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //==============================
        // CARGAR REPARTIDORES
        //==============================
        public void CargarRepartidores(ComboBox cbo)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string sql = @"SELECT id_empleado,
                              CONCAT(nombre_empleado,' ',apellido_empleado) AS nombre
                       FROM empleado
                       ORDER BY nombre_empleado";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(sql,
                    objetoConexion.establecerConexion());

                DataTable dt = new DataTable();

                da.Fill(dt);

                cbo.DataSource = dt;
                cbo.DisplayMember = "nombre";
                cbo.ValueMember = "id_empleado";
                cbo.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //==============================
        // CARGAR VEHICULOS
        //==============================
        public void CargarVehiculos(ComboBox cbo)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string sql = @"SELECT id_vehiculo,
                              CONCAT(marca_vehiculo,' ',modelo_vehiculo) AS vehiculo
                       FROM vehiculo
                       ORDER BY marca_vehiculo";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(sql,
                    objetoConexion.establecerConexion());

                DataTable dt = new DataTable();

                da.Fill(dt);

                cbo.DataSource = dt;
                cbo.DisplayMember = "vehiculo";
                cbo.ValueMember = "id_vehiculo";
                cbo.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //==============================
        // CARGAR ESTADOS
        //==============================
        public void CargarEstados(ComboBox cbo)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string sql = @"SELECT id_estado_ruta,
                              nombre_estado_ruta
                       FROM estado_ruta";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(sql,
                    objetoConexion.establecerConexion());

                DataTable dt = new DataTable();

                da.Fill(dt);

                cbo.DataSource = dt;
                cbo.DisplayMember = "nombre_estado_ruta";
                cbo.ValueMember = "id_estado_ruta";
                cbo.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void ObtenerInformacionRuta(
      int idRuta,
      DateTimePicker dtpFecha,
      DateTimePicker dtpHoraInicio,
      ComboBox cboEstado,
      Label lblBodega,
      Label lblArea,
      Label lblTipo,
      Label lblDistancia)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string consulta = @"
SELECT

    r.fecha_ruta,
    r.hora_inicio_ruta,
    r.id_estado_ruta,
    r.distancia_km_ruta,

    b.nombre_bodega,

    CONCAT(
        a.zona_area_cubierta,
        ' - ',
        a.municipio_area_cubierta,
        ', ',
        a.departamento_area_cubierta
    ) AS area,

    t.nombre_tipo_ruta

FROM ruta r

INNER JOIN bodega b
ON r.id_bodega = b.id_bodega

INNER JOIN area_cubierta a
ON r.id_area = a.id_area

INNER JOIN tipo_ruta t
ON r.id_tipo_ruta = t.id_tipo_ruta

WHERE r.id_ruta = @idRuta";

                MySqlCommand cmd = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                cmd.Parameters.AddWithValue("@idRuta", idRuta);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // FECHA
                    if (dr["fecha_ruta"] != DBNull.Value)
                    {
                        dtpFecha.Value =
                            Convert.ToDateTime(dr["fecha_ruta"]);
                    }

                    // HORA
                    if (dr["hora_inicio_ruta"] != DBNull.Value)
                    {
                        TimeSpan hora =
                            (TimeSpan)dr["hora_inicio_ruta"];

                        dtpHoraInicio.Value =
                            DateTime.Today.Add(hora);
                    }

                    // ESTADO
                    cboEstado.SelectedValue =
                        Convert.ToInt32(dr["id_estado_ruta"]);

                    // INFORMACIÓN DE ORIGEN

                    lblBodega.Text =
                        dr["nombre_bodega"].ToString();

                    lblArea.Text =
                        dr["area"].ToString();

                    lblTipo.Text =
                        dr["nombre_tipo_ruta"].ToString();

                    lblDistancia.Text =
                        dr["distancia_km_ruta"].ToString() + " km";
                }

                dr.Close();

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //======================================
        // MOSTRAR PEDIDOS DISPONIBLES
        //======================================
        public void MostrarPedidosDisponibles(int idRuta, DataGridView dgv)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string consulta = @"
SELECT

    p.id_pedido AS ID,
    p.codigo_pedido AS Pedido,

    CONCAT(
        c.nombres_cliente,
        ' ',
        c.apellidos_cliente
    ) AS Cliente,

    d.direccion_detalle AS Direccion,

    p.peso_total_pedido AS Peso

FROM pedido p

INNER JOIN cliente c
ON p.id_cliente = c.id_cliente

INNER JOIN direccion d
ON p.id_direccion_destino_pedido = d.id_direccion

INNER JOIN ruta r
ON r.id_area = d.id_area

WHERE

r.id_ruta = @idRuta

AND p.id_estado_pedido = 1

ORDER BY p.id_pedido;";

                MySqlDataAdapter adapter =
    new MySqlDataAdapter(
        consulta,
        objetoConexion.establecerConexion());

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@idRuta",
                    idRuta);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgv.DataSource = tabla;

                dgv.Columns["ID"].Visible = false;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //======================================
        // ASIGNAR PEDIDOS SELECCIONADOS
        //======================================
        public void AsignarPedidosSeleccionados(
            DataGridView dgvDisponibles,
            DataGridView dgvAsignados)
        {
            DataTable dtDisponibles =
                (DataTable)dgvDisponibles.DataSource;

            DataTable dtAsignados;

            if (dgvAsignados.DataSource == null)
                dtAsignados = dtDisponibles.Clone();
            else
                dtAsignados = (DataTable)dgvAsignados.DataSource;

            for (int i = dgvDisponibles.Rows.Count - 1; i >= 0; i--)
            {
                bool marcado = false;

                if (dgvDisponibles.Rows[i].Cells["Seleccionar"].Value != null)
                    marcado = Convert.ToBoolean(
                        dgvDisponibles.Rows[i].Cells["Seleccionar"].Value);

                if (marcado)
                {
                    DataRow nuevaFila = dtAsignados.NewRow();

                    foreach (DataColumn columna in dtDisponibles.Columns)
                    {
                        nuevaFila[columna.ColumnName] =
                            ((DataRowView)dgvDisponibles.Rows[i].DataBoundItem)
                            .Row[columna.ColumnName];
                    }

                    dtAsignados.Rows.Add(nuevaFila);

                    dtDisponibles.Rows.RemoveAt(i);
                }
            }

            dgvAsignados.DataSource = dtAsignados;
        }

        public void ActualizarResumen(
       DataGridView dgvAsignados,
       Label lblTotalPedidos,
       Label lblPesoTotal,
       Label lblParadas,
       Label lblTiempo,
       Label lblDistancia,
       decimal distanciaRuta,
       Label lblPedidosAsignadosValor,
       Label lblParadasValor,
       Label lblTiempoEstimadoValor)
        {
            int totalPedidos = dgvAsignados.Rows.Count;
            decimal pesoTotal = 0;

            foreach (DataGridViewRow fila in dgvAsignados.Rows)
            {
                if (fila.Cells["Peso"].Value != null)
                    pesoTotal += Convert.ToDecimal(fila.Cells["Peso"].Value);
            }

            double velocidadPromedio = 40;

            double horas = Convert.ToDouble(distanciaRuta) / velocidadPromedio;

            int minutosParadas = totalPedidos * 5;

            TimeSpan tiempo =
                TimeSpan.FromHours(horas) +
                TimeSpan.FromMinutes(minutosParadas);

            // Resumen inferior
            lblTotalPedidos.Text = totalPedidos.ToString();
            lblPesoTotal.Text = pesoTotal.ToString("0.00") + " kg";
            lblParadas.Text = totalPedidos.ToString();
            lblDistancia.Text = distanciaRuta.ToString("0.00") + " km";
            lblTiempo.Text = tiempo.ToString(@"hh\:mm");

            // Resumen superior
            lblPedidosAsignadosValor.Text = totalPedidos.ToString();
            lblParadasValor.Text = totalPedidos.ToString();
            lblTiempoEstimadoValor.Text = tiempo.ToString(@"hh\:mm");
        }


        public void LimpiarAsignacion(
    DataGridView dgvDisponibles,
    DataGridView dgvAsignados)
        {
            DataTable dtDisponibles = (DataTable)dgvDisponibles.DataSource;
            DataTable dtAsignados = (DataTable)dgvAsignados.DataSource;

            while (dtAsignados.Rows.Count > 0)
            {
                DataRow nueva = dtDisponibles.NewRow();

                foreach (DataColumn col in dtDisponibles.Columns)
                {
                    nueva[col.ColumnName] =
                        dtAsignados.Rows[0][col.ColumnName];
                }

                dtDisponibles.Rows.Add(nueva);

                dtAsignados.Rows.RemoveAt(0);
            }
        }




        public void GuardarAsignacion(
    int idRuta,
    int idVehiculo,
    int idEmpleado,
    DateTime fecha,
    string observacion,
    DataGridView dgvPedidosAsignados)
        {
            CConexion objetoConexion = new CConexion();

            MySqlConnection conexion = objetoConexion.establecerConexion();

            MySqlTransaction transaccion = conexion.BeginTransaction();

            try
            {
                string sqlAsignacion = @"
INSERT INTO asignacion_transp
(
    id_ruta,
    id_vehiculo,
    id_empleado,
    fecha_asignacion_asignacion_transp,
    observaciones
)
VALUES
(
    @ruta,
    @vehiculo,
    @empleado,
    @fecha,
    @observacion
);";

                MySqlCommand cmdAsignacion = new MySqlCommand(
                    sqlAsignacion,
                    conexion,
                    transaccion);

                cmdAsignacion.Parameters.AddWithValue("@ruta", idRuta);
                cmdAsignacion.Parameters.AddWithValue("@vehiculo", idVehiculo);
                cmdAsignacion.Parameters.AddWithValue("@empleado", idEmpleado);
                cmdAsignacion.Parameters.AddWithValue("@fecha", fecha);
                cmdAsignacion.Parameters.AddWithValue("@observacion", observacion);

                cmdAsignacion.ExecuteNonQuery();

                int idAsignacion =
                    Convert.ToInt32(cmdAsignacion.LastInsertedId);
                foreach (DataGridViewRow fila in dgvPedidosAsignados.Rows)
                {
                    int idPedido =
                        Convert.ToInt32(fila.Cells["ID"].Value);

                    string sqlDetalle = @"
            INSERT INTO detalle_asignacion_transp
            (
                id_asignacion,
                id_pedido
            )
            VALUES
            (
                @idAsignacion,
                @idPedido
            );";

                    MySqlCommand cmdDetalle =
                        new MySqlCommand(
                            sqlDetalle,
                            conexion,
                            transaccion);

                    cmdDetalle.Parameters.AddWithValue(
                        "@idAsignacion",
                        idAsignacion);

                    cmdDetalle.Parameters.AddWithValue(
                        "@idPedido",
                        idPedido);

                    cmdDetalle.ExecuteNonQuery();
                    string sqlPedido = @"
            UPDATE pedido
            SET
                id_ruta=@ruta
            WHERE
                id_pedido=@pedido";

                    MySqlCommand cmdPedido =
                        new MySqlCommand(
                            sqlPedido,
                            conexion,
                            transaccion);

                    cmdPedido.Parameters.AddWithValue(
                        "@ruta",
                        idRuta);

                    cmdPedido.Parameters.AddWithValue(
                        "@pedido",
                        idPedido);

                    cmdPedido.ExecuteNonQuery();
                }

                transaccion.Commit();

                MessageBox.Show(
                    "Asignación guardada correctamente.");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();

                MessageBox.Show(ex.Message);

                objetoConexion.cerrarConexion();
            }
        }
    }
}