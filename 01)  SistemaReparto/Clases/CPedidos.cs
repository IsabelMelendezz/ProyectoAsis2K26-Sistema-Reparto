
//Lourdes Isabel Melendez Pineda 
//9959-23-1379



using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaReparto.Clases
{
    internal class CPedidos
    {
        CConexion objetoConexion = new CConexion();

        public void MostrarPedidos(DataGridView dgvPedidos)
        {
            try
            {
                string consulta = "SELECT * FROM pedido;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(
                    consulta,
                    objetoConexion.establecerConexion());

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgvPedidos.DataSource = tabla;

                ConfigurarEstiloTabla(dgvPedidos);

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los pedidos.\n" + ex.Message);
            }
        }

 
        private void ConfigurarEstiloTabla(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.FromArgb(230, 230, 230);
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
            dgv.MultiSelect = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 66, 143);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersHeight = 38;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 225, 245);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(21, 66, 143);
            dgv.DefaultCellStyle.Padding = new Padding(4);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 252);

            dgv.RowTemplate.Height = 32;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Nombre de columna -> (texto amigable, peso relativo de ancho)
            var config = new Dictionary<string, (string texto, int peso)>
            {
                { "id_pedido",          ("ID", 6) },
                { "codigo_pedido",      ("Código", 12) },
                { "id_cliente",         ("Cliente", 9) },
                { "id_estado_pedido",   ("Estado", 9) },
                { "id_ruta",            ("Ruta", 8) },
                { "fecha_solicitud",    ("Fecha Solicitud", 13) },
                { "direccion_origen",   ("Dirección Origen", 18) },
                { "direccion_destino",  ("Dirección Destino", 18) },
                { "peso_total",         ("Peso (kg)", 9) },
                { "cantidad_paquetes",  ("Paquetes", 9) },
                { "observaciones",      ("Observaciones", 16) },
            };

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (config.TryGetValue(col.Name, out var datos))
                {
                    col.HeaderText = datos.texto;
                    col.FillWeight = datos.peso;
                }
                else
                {
                    col.FillWeight = 10;
                }

                col.MinimumWidth = 60;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }

        public void LlenarComboCliente(ComboBox cboCliente)
        {
            try
            {
                string consulta = "SELECT id_cliente FROM cliente ORDER BY id_cliente ASC;";

                MySqlCommand cmd = new MySqlCommand(consulta, objetoConexion.establecerConexion());

                MySqlDataReader reader = cmd.ExecuteReader();

                cboCliente.Items.Clear();

                while (reader.Read())
                {
                    cboCliente.Items.Add(reader["id_cliente"].ToString());
                }

                reader.Close();
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes.\n" + ex.Message);
            }
        }

        public void LlenarComboRuta(ComboBox cboRuta)
        {
            try
            {
                string consulta = "SELECT id_ruta FROM ruta ORDER BY id_ruta ASC;";

                MySqlCommand cmd = new MySqlCommand(consulta, objetoConexion.establecerConexion());

                MySqlDataReader reader = cmd.ExecuteReader();

                cboRuta.Items.Clear();

                while (reader.Read())
                {
                    cboRuta.Items.Add(reader["id_ruta"].ToString());
                }

                reader.Close();
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las rutas.\n" + ex.Message);
            }
        }

        public void LlenarComboEstadoPedido(ComboBox cboEstadoPedido)
        {
            try
            {
                string consulta = "SELECT id_estado_pedido FROM estado_pedido ORDER BY id_estado_pedido ASC;";

                MySqlCommand cmd = new MySqlCommand(consulta, objetoConexion.establecerConexion());

                MySqlDataReader reader = cmd.ExecuteReader();

                cboEstadoPedido.Items.Clear();

                while (reader.Read())
                {
                    cboEstadoPedido.Items.Add(reader["id_estado_pedido"].ToString());
                }

                reader.Close();
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los estados de pedido.\n" + ex.Message);
            }
        }

        public void GuardarPedido(
            TextBox TxtCodigoPedido,
            ComboBox cboCliente,
            ComboBox cboRuta,
            ComboBox cboEstadoPedido,
            DateTimePicker dateTimePedido,
            TextBox textDireccionOrigen,
            TextBox TxtDireccionDestino,
            TextBox txtPesoTotal,
            TextBox TxtCantidadPaquetes,
            TextBox TxtObservaciones)
        {
            try
            {
                string consulta = @"INSERT INTO pedido
                (codigo_pedido, id_cliente, id_estado_pedido, id_ruta, fecha_solicitud_pedido, direccion_origen_pedido, direccion_destino_pedido, peso_total_pedido, cantidad_paquetes_pedido, observaciones_pedido)
                VALUES
                (@codigo_pedido, @id_cliente, @id_estado_pedido, @id_ruta, @fecha_solicitud, @direccion_origen, @direccion_destino, @peso_total, @cantidad_paquetes, @observaciones);";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@codigo_pedido", TxtCodigoPedido.Text);
                comando.Parameters.AddWithValue("@id_cliente", cboCliente.Text);
                comando.Parameters.AddWithValue("@id_estado_pedido", cboEstadoPedido.Text);

                if (string.IsNullOrWhiteSpace(cboRuta.Text))
                    comando.Parameters.AddWithValue("@id_ruta", DBNull.Value);
                else
                    comando.Parameters.AddWithValue("@id_ruta", cboRuta.Text);

                comando.Parameters.AddWithValue("@fecha_solicitud", dateTimePedido.Value.Date);
                comando.Parameters.AddWithValue("@direccion_origen", textDireccionOrigen.Text);
                comando.Parameters.AddWithValue("@direccion_destino", TxtDireccionDestino.Text);
                comando.Parameters.AddWithValue("@peso_total", txtPesoTotal.Text);
                comando.Parameters.AddWithValue("@cantidad_paquetes", TxtCantidadPaquetes.Text);
                comando.Parameters.AddWithValue("@observaciones", TxtObservaciones.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Pedido registrado correctamente.");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pedido.\n" + ex.Message);
            }
        }

        public void EliminarPedido(int idPedido)
        {
            try
            {
                string consulta = "DELETE FROM pedido WHERE id_pedido = @id;";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@id", idPedido);

                comando.ExecuteNonQuery();

                MessageBox.Show("Pedido eliminado correctamente.");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el pedido.\n" + ex.Message);
            }
        }

        public void ModificarPedido(
            int idPedido,
            TextBox TxtCodigoPedido,
            ComboBox cboCliente,
            ComboBox cboRuta,
            ComboBox cboEstadoPedido,
            DateTimePicker dateTimePedido,
            TextBox textDireccionOrigen,
            TextBox TxtDireccionDestino,
            TextBox txtPesoTotal,
            TextBox TxtCantidadPaquetes,
            TextBox TxtObservaciones)
        {
            try
            {
                string consulta = @"UPDATE pedido SET
                    codigo_pedido = @codigo_pedido,
                    id_cliente = @id_cliente,
                    id_estado_pedido = @id_estado_pedido,
                    id_ruta = @id_ruta,
                    fecha_solicitud = @fecha_solicitud,
                    direccion_origen = @direccion_origen,
                    direccion_destino = @direccion_destino,
                    peso_total = @peso_total,
                    cantidad_paquetes = @cantidad_paquetes,
                    observaciones = @observaciones
                    WHERE id_pedido = @id_pedido;";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@id_pedido", idPedido);
                comando.Parameters.AddWithValue("@codigo_pedido", TxtCodigoPedido.Text);
                comando.Parameters.AddWithValue("@id_cliente", cboCliente.Text);
                comando.Parameters.AddWithValue("@id_estado_pedido", cboEstadoPedido.Text);

                if (string.IsNullOrWhiteSpace(cboRuta.Text))
                    comando.Parameters.AddWithValue("@id_ruta", DBNull.Value);
                else
                    comando.Parameters.AddWithValue("@id_ruta", cboRuta.Text);

                comando.Parameters.AddWithValue("@fecha_solicitud", dateTimePedido.Value.Date);
                comando.Parameters.AddWithValue("@direccion_origen", textDireccionOrigen.Text);
                comando.Parameters.AddWithValue("@direccion_destino", TxtDireccionDestino.Text);
                comando.Parameters.AddWithValue("@peso_total", txtPesoTotal.Text);
                comando.Parameters.AddWithValue("@cantidad_paquetes", TxtCantidadPaquetes.Text);
                comando.Parameters.AddWithValue("@observaciones", TxtObservaciones.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Pedido modificado correctamente.");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el pedido.\n" + ex.Message);
            }
        }

        public void BuscarPedido(string textoBuscar, DataGridView dgvPedidos)
        {
            try
            {
                string consulta = @"SELECT * FROM pedido
                            WHERE codigo_pedido LIKE @buscar
                            OR direccion_origen_pedido LIKE @buscar
                            OR direccion_destino_pedido LIKE @buscar
                            OR CAST(id_pedido AS CHAR) LIKE @buscar;";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@buscar", "%" + textoBuscar + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgvPedidos.DataSource = tabla;

                ConfigurarEstiloTabla(dgvPedidos);

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el pedido.\n" + ex.Message);
            }
        }

        public void SeleccionarPedido(
            DataGridView dgvPedidos,
            TextBox TxtCodigoPedido,
            ComboBox cboCliente,
            ComboBox cboRuta,
            ComboBox cboEstadoPedido,
            DateTimePicker dateTimePedido,
            TextBox textDireccionOrigen,
            TextBox TxtDireccionDestino,
            TextBox txtPesoTotal,
            TextBox TxtCantidadPaquetes,
            TextBox TxtObservaciones)
        {
            try
            {
                TxtCodigoPedido.Text = dgvPedidos.CurrentRow.Cells["codigo_pedido"].Value.ToString();
                cboCliente.Text = dgvPedidos.CurrentRow.Cells["id_cliente"].Value.ToString();
                cboEstadoPedido.Text = dgvPedidos.CurrentRow.Cells["id_estado_pedido"].Value.ToString();

                object valorRuta = dgvPedidos.CurrentRow.Cells["id_ruta"].Value;
                cboRuta.Text = (valorRuta == DBNull.Value) ? string.Empty : valorRuta.ToString();

                dateTimePedido.Value = Convert.ToDateTime(dgvPedidos.CurrentRow.Cells["fecha_solicitud"].Value);
                textDireccionOrigen.Text = dgvPedidos.CurrentRow.Cells["direccion_origen"].Value.ToString();
                TxtDireccionDestino.Text = dgvPedidos.CurrentRow.Cells["direccion_destino"].Value.ToString();
                txtPesoTotal.Text = dgvPedidos.CurrentRow.Cells["peso_total"].Value.ToString();
                TxtCantidadPaquetes.Text = dgvPedidos.CurrentRow.Cells["cantidad_paquetes"].Value.ToString();
                TxtObservaciones.Text = dgvPedidos.CurrentRow.Cells["observaciones"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un registro.");
            }
        }

        public void LimpiarCampos(
            TextBox TxtCodigoPedido,
            ComboBox cboCliente,
            ComboBox cboRuta,
            ComboBox cboEstadoPedido,
            DateTimePicker dateTimePedido,
            TextBox textDireccionOrigen,
            TextBox TxtDireccionDestino,
            TextBox txtPesoTotal,
            TextBox TxtCantidadPaquetes,
            TextBox TxtObservaciones)
        {
            TxtCodigoPedido.Clear();
            cboCliente.SelectedIndex = -1;
            cboRuta.SelectedIndex = -1;
            cboEstadoPedido.SelectedIndex = -1;

            dateTimePedido.Value = DateTime.Now;

            textDireccionOrigen.Clear();
            TxtDireccionDestino.Clear();
            txtPesoTotal.Clear();
            TxtCantidadPaquetes.Clear();
            TxtObservaciones.Clear();
        }
    }
}