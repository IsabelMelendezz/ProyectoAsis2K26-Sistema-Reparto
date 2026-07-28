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
    internal class CBodegas
    {
        CConexion objetoConexion = new CConexion();
        public void MostrarBodegas(DataGridView tablaBodegas)
        {

            try
            {
                CConexion objetoConexion = new CConexion();

                string query =
                    "SELECT " +
                    "id_bodega AS Id_Bodega, " +
                    "id_sucursal AS Id_Sucursal, " +
                    "nombre AS Nombre, " +
                    "direccion AS Direccion, " +
                    "capacidad AS Capacidad, " +
                    "telefono AS Telefono " +
                    "FROM bodega";

                tablaBodegas.DataSource = null;
                tablaBodegas.Columns.Clear();

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query,
                    objetoConexion.establecerConexion());

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                tablaBodegas.AutoGenerateColumns = true;

                tablaBodegas.DataSource = dt;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron las bodegas.\n" + ex.ToString());
            }
        }
        public void LlenarComboSucursal(ComboBox comboSucursal)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string consulta =
                    "SELECT id_sucursal, nombre FROM sucursal";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(
                        consulta,
                        objetoConexion.establecerConexion());

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                comboSucursal.DataSource = dt;

                comboSucursal.DisplayMember = "nombre";

                comboSucursal.ValueMember = "id_sucursal";

                comboSucursal.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sucursales.\n" + ex.Message);
            }
        }
        public void SeleccionarBodega(
    DataGridView tablaBodegas,
    TextBox txtIdBodega,
    ComboBox cbSucursal,
    TextBox txtNombre,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono)
        {
            try
            {
                if (tablaBodegas.CurrentRow == null)
                    return;

                txtIdBodega.Text = tablaBodegas.CurrentRow.Cells["Id_Bodega"].Value.ToString();

                txtNombre.Text = tablaBodegas.CurrentRow.Cells["Nombre"].Value.ToString();

                txtDireccion.Text = tablaBodegas.CurrentRow.Cells["Direccion"].Value.ToString();

                nudCapacidad.Value = Convert.ToDecimal(
                    tablaBodegas.CurrentRow.Cells["Capacidad"].Value);

                txtTelefono.Text = tablaBodegas.CurrentRow.Cells["Telefono"].Value.ToString();

                // Temporalmente mostramos el ID de la sucursal
                cbSucursal.Text = tablaBodegas.CurrentRow.Cells["Id_Sucursal"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la bodega.\n" + ex.Message);
            }
        }


        public void Nuevo(
    TextBox txtIdBodega,
    ComboBox cbSucursal,
    TextBox txtNombre,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono)
        {
            txtIdBodega.Clear();

            cbSucursal.SelectedIndex = -1;

            txtNombre.Clear();

            txtDireccion.Clear();

            nudCapacidad.Value = 0;

            txtTelefono.Clear();

            txtNombre.Focus();
        }


        private bool ValidarCampos(
    ComboBox cbSucursal,
    TextBox txtNombre,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono)
        {
            if (cbSucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una sucursal.");
                cbSucursal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la bodega.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Ingrese la dirección.");
                txtDireccion.Focus();
                return false;
            }

            if (nudCapacidad.Value <= 0)
            {
                MessageBox.Show("La capacidad debe ser mayor que cero.");
                nudCapacidad.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese el teléfono.");
                txtTelefono.Focus();
                return false;
            }

            return true;
        }

        private void InsertarBodega(
    ComboBox cbSucursal,
    TextBox txtNombre,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono)
        {
            CConexion objetoConexion = new CConexion();

            string consulta =
                "INSERT INTO bodega " +
                "(id_sucursal, nombre, direccion, capacidad, telefono) " +
                "VALUES (@id_sucursal,@nombre,@direccion,@capacidad,@telefono)";

            MySqlCommand comando = new MySqlCommand(
                consulta,
                objetoConexion.establecerConexion());

            comando.Parameters.AddWithValue("@id_sucursal", cbSucursal.SelectedValue);

            comando.Parameters.AddWithValue("@nombre", txtNombre.Text);

            comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);

            comando.Parameters.AddWithValue("@capacidad", nudCapacidad.Value);

            comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);

            comando.ExecuteNonQuery();

            objetoConexion.cerrarConexion();
        }

        private void ActualizarBodega(
    TextBox txtIdBodega,
    ComboBox cbSucursal,
    TextBox txtNombre,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono)
        {
            CConexion objetoConexion = new CConexion();

            string consulta =
                "UPDATE bodega SET " +
                "id_sucursal = @id_sucursal, " +
                "nombre = @nombre, " +
                "direccion = @direccion, " +
                "capacidad = @capacidad, " +
                "telefono = @telefono " +
                "WHERE id_bodega = @id_bodega";

            MySqlCommand comando = new MySqlCommand(
                consulta,
                objetoConexion.establecerConexion());

            comando.Parameters.AddWithValue("@id_bodega", txtIdBodega.Text);
            comando.Parameters.AddWithValue("@id_sucursal", cbSucursal.SelectedValue);
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
            comando.Parameters.AddWithValue("@capacidad", nudCapacidad.Value);
            comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);

            comando.ExecuteNonQuery();

            objetoConexion.cerrarConexion();
        }

        private void EliminarBodega(TextBox txtIdBodega)
        {
            CConexion objetoConexion = new CConexion();

            string consulta =
                "DELETE FROM bodega WHERE id_bodega = @id_bodega";

            MySqlCommand comando = new MySqlCommand(
                consulta,
                objetoConexion.establecerConexion());

            comando.Parameters.AddWithValue("@id_bodega", txtIdBodega.Text);

            comando.ExecuteNonQuery();

            objetoConexion.cerrarConexion();
        }

        public void Guardar(
    ComboBox cbSucursal,
    TextBox txtNombre,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono,
    DataGridView tablaBodegas,
    TextBox txtIdBodega)
        {
            if (!ValidarCampos(
                cbSucursal,
                txtNombre,
                txtDireccion,
                nudCapacidad,
                txtTelefono))
                return;

            InsertarBodega(
                cbSucursal,
                txtNombre,
                txtDireccion,
                nudCapacidad,
                txtTelefono);

            MessageBox.Show("Bodega registrada correctamente.");

            MostrarBodegas(tablaBodegas);

            Nuevo(
                txtIdBodega,
                cbSucursal,
                txtNombre,
                txtDireccion,
                nudCapacidad,
                txtTelefono);
        }

        public void Editar(
    TextBox txtIdBodega,
    ComboBox cbSucursal,
    TextBox txtNombre,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono,
    DataGridView tablaBodegas)
        {
            if (!ValidarCampos(
                cbSucursal,
                txtNombre,
                txtDireccion,
                nudCapacidad,
                txtTelefono))
                return;

            if (string.IsNullOrWhiteSpace(txtIdBodega.Text))
            {
                MessageBox.Show("Seleccione una bodega para editar.");
                return;
            }

            ActualizarBodega(
                txtIdBodega,
                cbSucursal,
                txtNombre,
                txtDireccion,
                nudCapacidad,
                txtTelefono);

            MessageBox.Show("Bodega actualizada correctamente.");

            MostrarBodegas(tablaBodegas);

            Nuevo(
                txtIdBodega,
                cbSucursal,
                txtNombre,
                txtDireccion,
                nudCapacidad,
                txtTelefono);
        }



        public void Eliminar(
    TextBox txtIdBodega,
    ComboBox cbSucursal,
    TextBox txtNombre,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono,
    DataGridView tablaBodegas)
        {
            if (string.IsNullOrWhiteSpace(txtIdBodega.Text))
            {
                MessageBox.Show("Seleccione una bodega para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea eliminar esta bodega?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            EliminarBodega(txtIdBodega);

            MessageBox.Show("Bodega eliminada correctamente.");

            MostrarBodegas(tablaBodegas);

            Nuevo(
                txtIdBodega,
                cbSucursal,
                txtNombre,
                txtDireccion,
                nudCapacidad,
                txtTelefono);
        }

        public void Buscar(
    TextBox txtBuscar,
    DataGridView tablaBodegas)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string consulta =
                    "SELECT " +
                    "id_bodega AS Id_Bodega, " +
                    "id_sucursal AS Id_Sucursal, " +
                    "nombre AS Nombre, " +
                    "direccion AS Direccion, " +
                    "capacidad AS Capacidad, " +
                    "telefono AS Telefono " +
                    "FROM bodega " +
                    "WHERE nombre LIKE @buscar";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@buscar", "%" + txtBuscar.Text + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                tablaBodegas.DataSource = dt;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar.\n" + ex.Message);
            }
        }


        public void Actualizar(
    DataGridView tablaBodegas,
    TextBox txtIdBodega,
    ComboBox cbSucursal,
    TextBox txtNombre,
    TextBox txtDireccion,
    NumericUpDown nudCapacidad,
    TextBox txtTelefono)
        {
            MostrarBodegas(tablaBodegas);

            Nuevo(
                txtIdBodega,
                cbSucursal,
                txtNombre,
                txtDireccion,
                nudCapacidad,
                txtTelefono);
        }












    }
}
