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
    internal class CSucursales
    {

        public void MostrarSucursales(DataGridView tablaSucursales)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                DataTable dt = new DataTable();

                string consulta = "SELECT * FROM sucursal";

                MySqlDataAdapter adapter = new MySqlDataAdapter(
                    consulta,
                    objetoConexion.establecerConexion());

                adapter.Fill(dt);

                tablaSucursales.DataSource = dt;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar las sucursales.\n" + ex.Message);
            }
        }



        public void SeleccionarSucursal(
        DataGridView tablaSucursales,
        TextBox txtIdSucursal,
        TextBox txtNombre,
        TextBox txtDireccion,
        TextBox txtTelefono,
        TextBox txtCorreo)
        {
            try
            {
                txtIdSucursal.Text = tablaSucursales.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = tablaSucursales.CurrentRow.Cells[1].Value.ToString();
                txtDireccion.Text = tablaSucursales.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = tablaSucursales.CurrentRow.Cells[3].Value.ToString();
                txtCorreo.Text = tablaSucursales.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la sucursal.\n" + ex.Message);
            }
        }

        public void Nuevo(
    TextBox txtIdSucursal,
    TextBox txtNombre,
    TextBox txtDireccion,
    TextBox txtTelefono,
    TextBox txtCorreo)
        {
            txtIdSucursal.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            txtIdSucursal.Text = "Autogenerado";

            txtNombre.Focus();
        }


        private bool ValidarCampos(
    TextBox txtNombre,
    TextBox txtDireccion,
    TextBox txtTelefono,
    TextBox txtCorreo)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la sucursal.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Ingrese la dirección.");
                txtDireccion.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese el teléfono.");
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Ingrese el correo.");
                txtCorreo.Focus();
                return false;
            }

            return true;
        }

        private void InsertarSucursal(
    TextBox txtNombre,
    TextBox txtDireccion,
    TextBox txtTelefono,
    TextBox txtCorreo)
        {
            CConexion objetoConexion = new CConexion();

            string consulta =
                "INSERT INTO sucursal " +
                "(nombre,direccion,telefono,correo) " +
                "VALUES (@nombre,@direccion,@telefono,@correo)";

            MySqlCommand comando = new MySqlCommand(
                consulta,
                objetoConexion.establecerConexion());

            comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
            comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
            comando.Parameters.AddWithValue("@correo", txtCorreo.Text);

            comando.ExecuteNonQuery();

            objetoConexion.cerrarConexion();
        }


        private void ActualizarSucursal(
    TextBox txtIdSucursal,
    TextBox txtNombre,
    TextBox txtDireccion,
    TextBox txtTelefono,
    TextBox txtCorreo)
        {
            CConexion objetoConexion = new CConexion();

            string consulta =
                "UPDATE sucursal SET " +
                "nombre = @nombre, " +
                "direccion = @direccion, " +
                "telefono = @telefono, " +
                "correo = @correo " +
                "WHERE id_sucursal = @id_sucursal";

            MySqlCommand comando = new MySqlCommand(
                consulta,
                objetoConexion.establecerConexion());

            comando.Parameters.AddWithValue("@id_sucursal", txtIdSucursal.Text);
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
            comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
            comando.Parameters.AddWithValue("@correo", txtCorreo.Text);

            comando.ExecuteNonQuery();

            objetoConexion.cerrarConexion();
        }

        private void EliminarSucursal(
            TextBox txtIdSucursal)
        {
            CConexion objetoConexion = new CConexion();

            string consulta =
                "DELETE FROM sucursal WHERE id_sucursal = @id_sucursal";

            MySqlCommand comando = new MySqlCommand(
                consulta,
                objetoConexion.establecerConexion());

            comando.Parameters.AddWithValue("@id_sucursal", txtIdSucursal.Text);

            comando.ExecuteNonQuery();

            objetoConexion.cerrarConexion();
        }





























        public void Guardar(
    TextBox txtNombre,
    TextBox txtDireccion,
    TextBox txtTelefono,
    TextBox txtCorreo,
    DataGridView tablaSucursales,
    TextBox txtIdSucursal)
        {
            if (!ValidarCampos(
                txtNombre,
                txtDireccion,
                txtTelefono,
                txtCorreo))
                return;

            InsertarSucursal(
                txtNombre,
                txtDireccion,
                txtTelefono,
                txtCorreo);

            MessageBox.Show("Sucursal registrada correctamente.");

            MostrarSucursales(tablaSucursales);

            Nuevo(
                txtIdSucursal,
                txtNombre,
                txtDireccion,
                txtTelefono,
                txtCorreo);
        }


        public void Editar(
    TextBox txtIdSucursal,
    TextBox txtNombre,
    TextBox txtDireccion,
    TextBox txtTelefono,
    TextBox txtCorreo,
    DataGridView tablaSucursales)
        {
            if (!ValidarCampos(
                txtNombre,
                txtDireccion,
                txtTelefono,
                txtCorreo))
                return;

            if (!int.TryParse(txtIdSucursal.Text, out int id))
            {
                MessageBox.Show("Seleccione una sucursal válida para eliminar.");
                return;
            }

            ActualizarSucursal(
                txtIdSucursal,
                txtNombre,
                txtDireccion,
                txtTelefono,
                txtCorreo);

            MessageBox.Show("Sucursal actualizada correctamente.");

            MostrarSucursales(tablaSucursales);

            Nuevo(
                txtIdSucursal,
                txtNombre,
                txtDireccion,
                txtTelefono,
                txtCorreo);
        }

        public void Eliminar(
            TextBox txtIdSucursal,
            TextBox txtNombre,
            TextBox txtDireccion,
            TextBox txtTelefono,
            TextBox txtCorreo,
            DataGridView tablaSucursales)
        {
            if (!int.TryParse(txtIdSucursal.Text, out int idSucursal))
            {
                MessageBox.Show("Seleccione una sucursal válida para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea eliminar esta sucursal?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            EliminarSucursal(txtIdSucursal);

            MessageBox.Show("Sucursal eliminada correctamente.");

            MostrarSucursales(tablaSucursales);

            Nuevo(
                txtIdSucursal,
                txtNombre,
                txtDireccion,
                txtTelefono,
                txtCorreo);
        }

        public void Buscar(
    TextBox txtBuscar,
    DataGridView tablaSucursales)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string consulta =
                    "SELECT * FROM sucursal " +
                    "WHERE nombre LIKE @buscar " +
                    "OR direccion LIKE @buscar " +
                    "OR telefono LIKE @buscar " +
                    "OR correo LIKE @buscar";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@buscar",
                    "%" + txtBuscar.Text + "%");

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(comando);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                tablaSucursales.DataSource = dt;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar.\n" + ex.Message);
            }
        }

        public void Actualizar(
    DataGridView tablaSucursales,
    TextBox txtIdSucursal,
    TextBox txtNombre,
    TextBox txtDireccion,
    TextBox txtTelefono,
    TextBox txtCorreo)
        {
            MostrarSucursales(tablaSucursales);

            Nuevo(
                txtIdSucursal,
                txtNombre,
                txtDireccion,
                txtTelefono,
                txtCorreo);
        }













    }

}