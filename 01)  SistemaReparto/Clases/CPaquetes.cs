//Byron Alexander Chiquito Paredes
//0901-23-3747

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaReparto.Clases
{
    internal class CPaquetes
    {
        CConexion objetoConexion = new CConexion();

        public void MostrarPaquetes(DataGridView dgvPaquetes)
        {
            try
            {
                string consulta = "SELECT * FROM paquete;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(
                    consulta,
                    objetoConexion.establecerConexion());

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgvPaquetes.DataSource = tabla;

                dgvPaquetes.Columns["id_paquete"].HeaderText = "ID";
                dgvPaquetes.Columns["id_pedido"].HeaderText = "Pedido";
                dgvPaquetes.Columns["codigo_rastreo_paquete"].HeaderText = "Código";
                dgvPaquetes.Columns["peso_paquete"].HeaderText = "Peso (kg)";
                dgvPaquetes.Columns["alto_paquete"].HeaderText = "Alto (cm)";
                dgvPaquetes.Columns["ancho_paquete"].HeaderText = "Ancho (cm)";
                dgvPaquetes.Columns["largo_paquete"].HeaderText = "Largo (cm)";
                dgvPaquetes.Columns["descripcion_paquete"].HeaderText = "Descripción";
                dgvPaquetes.Columns["fragil_paquete"].HeaderText = "Frágil";
                dgvPaquetes.Columns["valor_declarado_paquete"].HeaderText = "Valor declarado";
                dgvPaquetes.Columns["tipo_paquete"].HeaderText = "Tipo";
                dgvPaquetes.Columns["estado_paquete"].HeaderText = "Estado";

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los paquetes.\n" + ex.Message);
            }
        }

        public void FiltrarPaquetes(
            DataGridView dgvPaquetes,
            ComboBox cboEstadoFiltro,
            ComboBox cboTipoFiltro)
        {
            try
            {
                string consulta = "SELECT * FROM paquete WHERE 1=1";

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = objetoConexion.establecerConexion();

                // Filtrar por estado
                if (cboEstadoFiltro.Text != "Todos")
                {
                    consulta += " AND estado_paquete = @estado";
                    comando.Parameters.AddWithValue("@estado", cboEstadoFiltro.Text);
                }

                // Filtrar por tipo
                if (cboTipoFiltro.Text != "Todos")
                {
                    consulta += " AND tipo_paquete = @tipo";
                    comando.Parameters.AddWithValue("@tipo", cboTipoFiltro.Text);
                }

                comando.CommandText = consulta;

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgvPaquetes.DataSource = tabla;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los paquetes.\n" + ex.Message);
            }
        }


        public void LlenarComboTipoPaquete(ComboBox cboTipoPaquete)
        {
            cboTipoPaquete.Items.Clear();

            cboTipoPaquete.Items.Add("Documento");
            cboTipoPaquete.Items.Add("Sobre");
            cboTipoPaquete.Items.Add("Caja");
            cboTipoPaquete.Items.Add("Paquete");
            cboTipoPaquete.Items.Add("Electrónica");
            cboTipoPaquete.Items.Add("Ropa");
            cboTipoPaquete.Items.Add("Otro");

            cboTipoPaquete.SelectedIndex = 0;
        }

        public void LlenarComboPedido(ComboBox cboPedido)
        {
            try
            {
                string consulta = "SELECT id_pedido FROM pedido ORDER BY id_pedido ASC;";

                MySqlCommand cmd = new MySqlCommand(consulta, objetoConexion.establecerConexion());

                MySqlDataReader reader = cmd.ExecuteReader();

                cboPedido.Items.Clear();

                while (reader.Read())
                {
                    cboPedido.Items.Add(reader["id_pedido"].ToString());
                }

                reader.Close();
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pedidos.\n" + ex.Message);
            }
        }

        public void MostrarRutaPedido(ComboBox cboPedido, ComboBox cboRuta)
        {
            try
            {
                string consulta = @"SELECT
                        r.id_ruta,
                        CONCAT(
                            'Ruta #', r.id_ruta,
                            ' - ',
                            DATE_FORMAT(r.fecha_ruta, '%d/%m/%Y'),
                            ' - ',
                            FORMAT(r.distancia_km_ruta, 2),
                            ' km'
                        ) AS descripcion_ruta
                    FROM pedido p
                    INNER JOIN ruta r
                        ON p.id_ruta = r.id_ruta
                    WHERE p.id_pedido = @idPedido;";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@idPedido", cboPedido.Text);

                MySqlDataReader reader = comando.ExecuteReader();

                cboRuta.Items.Clear();

                if (reader.Read())
                {
                    cboRuta.Items.Add(reader["descripcion_ruta"].ToString());
                    cboRuta.SelectedIndex = 0;
                }

                reader.Close();

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar la ruta.\n" + ex.Message);
            }
        }

        public void GuardarPaquete(
            ComboBox cboPedido,
            TextBox txtCodigoRastreo,
            TextBox txtPeso,
            TextBox txtAlto,
            TextBox txtAncho,
            TextBox txtLargo,
            TextBox txtDescripcion,
            ComboBox cboFragil,
            ComboBox cboEstado,
            TextBox txtValorAgregado,
            ComboBox cboTipoPaquete)
        {
            try
            {
                string consulta = @"INSERT INTO paquete
                                  (id_pedido,
                                    codigo_rastreo_paquete,
                                    peso_paquete,
                                    alto_paquete,
                                    ancho_paquete,
                                    largo_paquete,
                                    descripcion_paquete,
                                    fragil_paquete,
                                    valor_declarado_paquete,
                                    tipo_paquete,
                                    estado_paquete)     
                                    VALUES
                                    (@id_pedido,
                                    @codigo_rastreo,
                                    @peso,
                                    @alto,
                                    @ancho,
                                    @largo,
                                    @descripcion,
                                    @fragil,
                                    @valor_declarado,
                                    @tipo_paquete,
                                    @estado);";


                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@id_pedido", cboPedido.Text);
                comando.Parameters.AddWithValue("@codigo_rastreo", txtCodigoRastreo.Text);
                comando.Parameters.AddWithValue("@peso", txtPeso.Text);
                comando.Parameters.AddWithValue("@alto", txtAlto.Text);
                comando.Parameters.AddWithValue("@ancho", txtAncho.Text);
                comando.Parameters.AddWithValue("@largo", txtLargo.Text);
                comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                comando.Parameters.AddWithValue("@fragil", cboFragil.Text);
                comando.Parameters.AddWithValue("@valor_declarado", txtValorAgregado.Text);
                comando.Parameters.AddWithValue("@tipo_paquete", cboTipoPaquete.Text);
                comando.Parameters.AddWithValue("@estado", cboEstado.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Paquete registrado correctamente.");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el paquete.\n" + ex.Message);
            }
        }

        public void EliminarPaquete(int idPaquete)
        {
            try
            {
                string consulta = "DELETE FROM paquete WHERE id_paquete = @id;";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@id", idPaquete);

                comando.ExecuteNonQuery();

                MessageBox.Show("Paquete eliminado correctamente.");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el paquete.\n" + ex.Message);
            }
        }

        public void ModificarPaquete(
            int idPaquete,
            ComboBox cboPedido,
            TextBox txtCodigoRastreo,
            TextBox txtPeso,
            TextBox txtAlto,
            TextBox txtAncho,
            TextBox txtLargo,
            TextBox txtDescripcion,
            ComboBox cboFragil,
            ComboBox cboEstado,
            TextBox txtValorAgregado,
            ComboBox cboTipoPaquete)
        {
            try
            {
                string consulta = @"UPDATE paquete SET
                 id_pedido = @id_pedido,
                 codigo_rastreo_paquete = @codigo_rastreo,
                 peso_paquete = @peso,
                 alto_paquete = @alto,
                ancho_paquete = @ancho,
                largo_paquete = @largo,
                descripcion_paquete = @descripcion,
                fragil_paquete = @fragil,
                valor_declarado_paquete = @valor_declarado,
                tipo_paquete = @tipo_paquete,
                estado_paquete = @estado
                WHERE id_paquete = @id_paquete;";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@id_paquete", idPaquete);
                comando.Parameters.AddWithValue("@id_pedido", cboPedido.Text);
                comando.Parameters.AddWithValue("@codigo_rastreo", txtCodigoRastreo.Text);
                comando.Parameters.AddWithValue("@peso", txtPeso.Text);
                comando.Parameters.AddWithValue("@alto", txtAlto.Text);
                comando.Parameters.AddWithValue("@ancho", txtAncho.Text);
                comando.Parameters.AddWithValue("@largo", txtLargo.Text);
                comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                comando.Parameters.AddWithValue("@fragil", cboFragil.Text);
                comando.Parameters.AddWithValue("@valor_declarado", txtValorAgregado.Text);
                comando.Parameters.AddWithValue("@tipo_paquete", cboTipoPaquete.Text);
                comando.Parameters.AddWithValue("@estado", cboEstado.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Paquete modificado correctamente.");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el paquete.\n" + ex.Message);
            }
        }


        public void BuscarPaquete(string textoBuscar, DataGridView dgvPaquetes)
        {
            try
            {
                string consulta = @"SELECT * FROM paquete
                            WHERE codigo_rastreo_paquete LIKE @buscar
                            OR descripcion_paquete LIKE @buscar
                            OR CAST(id_pedido AS CHAR) LIKE @buscar;";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@buscar", "%" + textoBuscar + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgvPaquetes.DataSource = tabla;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el paquete.\n" + ex.Message);
            }
        }


        public void SeleccionarPaquete(
            DataGridView dgvPaquetes,
            ComboBox cboPedido,
            TextBox txtCodigoRastreo,
            TextBox txtPeso,
            TextBox txtAlto,
            TextBox txtAncho,
            TextBox txtLargo,
            TextBox txtDescripcion,
            ComboBox cboFragil,
            ComboBox cboEstado,
            TextBox txtValorAgregado,
            ComboBox cboTipoPaquete)
        {
            try
            {
                cboPedido.Text = dgvPaquetes.CurrentRow.Cells["id_pedido"].Value.ToString();
                txtCodigoRastreo.Text = dgvPaquetes.CurrentRow.Cells["codigo_rastreo_paquete"].Value.ToString();
                txtPeso.Text = dgvPaquetes.CurrentRow.Cells["peso_paquete"].Value.ToString();
                txtAlto.Text = dgvPaquetes.CurrentRow.Cells["alto_paquete"].Value.ToString();
                txtAncho.Text = dgvPaquetes.CurrentRow.Cells["ancho_paquete"].Value.ToString();
                txtLargo.Text = dgvPaquetes.CurrentRow.Cells["largo_paquete"].Value.ToString();
                txtDescripcion.Text = dgvPaquetes.CurrentRow.Cells["descripcion_paquete"].Value.ToString();
                cboFragil.Text = dgvPaquetes.CurrentRow.Cells["fragil_paquete"].Value.ToString();
                txtValorAgregado.Text = dgvPaquetes.CurrentRow.Cells["valor_declarado_paquete"].Value.ToString();
                cboTipoPaquete.Text = dgvPaquetes.CurrentRow.Cells["tipo_paquete"].Value.ToString();
                cboEstado.Text = dgvPaquetes.CurrentRow.Cells["estado_paquete"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un registro.");
            }
        }

        public void LimpiarCampos(
            ComboBox cboPedido,
            ComboBox cboRuta,
            TextBox txtDescripcion,
            TextBox txtPeso,
            TextBox txtAlto,
            TextBox txtAncho,
            TextBox txtLargo,
            ComboBox cboFragil,
            TextBox txtCodigoRastreo,
            TextBox txtValorAgregado,
            ComboBox cboTipoPaquete)
        {
            cboPedido.SelectedIndex = -1;
            cboRuta.SelectedIndex = -1;

            txtDescripcion.Clear();
            txtPeso.Clear();
            txtAlto.Clear();
            txtAncho.Clear();
            txtLargo.Clear();

            cboFragil.SelectedIndex = 0;

            txtCodigoRastreo.Clear();

            txtValorAgregado.Clear();

            cboTipoPaquete.SelectedIndex = 0;
        }



    }
}