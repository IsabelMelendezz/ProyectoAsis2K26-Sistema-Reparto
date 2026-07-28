//Carlos David Calderón Ramirez
//9959-23-848


using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReparto.Clases
{
    internal class CEstado_Transporte
    {
        public void mostrarEstado_Vehiculo(DataGridView Tabla_E_Transporte)
        {
            try
            {
                CConexion objetoConexion = new CConexion();
                String query = "SELECT ev.id_estado_vehiculo AS Id_Estado_Vehiculo, " +
                               "ev.nombre AS Nombre, " +
                               "ev.descripcion AS Descripcion " +
                               "FROM estado_vehiculo ev ";

                Tabla_E_Transporte.DataSource = null;
                Tabla_E_Transporte.Columns.Clear();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Tabla_E_Transporte.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());

            }
        }



        public int GuardarEstadoT(TextBox nombre, TextBox descrip)
        {
            try
            {

                CConexion objetoConexion = new CConexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                string query = "INSERT INTO estado_vehiculo " +
                    "(nombre, descripcion) " +
                    "VALUES (@nombre, @descripcion)";

                MySqlCommand myComand = new MySqlCommand(query, conexion);
                myComand.Parameters.AddWithValue("@nombre", nombre.Text);
                myComand.Parameters.AddWithValue("@descripcion", descrip.Text);


                myComand.ExecuteNonQuery();

                int nuevoId = Convert.ToInt32(myComand.LastInsertedId);

                MessageBox.Show("Se guardó el Estado de Vehiculo correctamente");
                objetoConexion.cerrarConexion();

                return nuevoId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardó el Estado de Vehiculo, error: " + ex.ToString());
                return -1;
            }
        }


        // SELECCIONAR (cargar fila tabla de controles)
        // 
        public int SeleccionarEstadoV(DataGridView Tabla_E_Transporte,
            TextBox nombre, TextBox descrip)
        {
            try
            {
                DataGridViewRow fila = Tabla_E_Transporte.CurrentRow;

                if (fila == null || fila.IsNewRow || fila.Cells["Id_Estado_Vehiculo"].Value == null)
                    return -1;

                int idEstadoV = Convert.ToInt32(fila.Cells["Id_Estado_Vehiculo"].Value);

                nombre.Text = ObtenerTexto(fila, "nombre");
                descrip.Text = ObtenerTexto(fila, "descripcion");

                return idEstadoV;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No logro seleccionar el Estado de vehiculo: " + ex.ToString());
                return -1;
            }
        }

        private string ObtenerTexto(DataGridViewRow fila, string columna)
        {
            object valor = fila.Cells[columna].Value;
            return (valor == null || valor == DBNull.Value) ? string.Empty : valor.ToString();
        }

        // MODIFICAR (UPDATE)

        public void ModificarEstadoT(int idEstadoV, TextBox nombre, TextBox descrip)
        {
            try
            {
                if (idEstadoV <= 0)
                {
                    MessageBox.Show("Debe seleccionar un Estado de vehiculo de la tabla antes de editar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "UPDATE estado_vehiculo SET " +
                    "nombre = @nombre, " +
                    "descripcion = @descrip, ";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@nombre", nombre.Text);
                myComand.Parameters.AddWithValue("@descripcion", descrip.Text);


                int filas = myComand.ExecuteNonQuery();
                if (filas > 0)
                    MessageBox.Show("Se modificó correctamente");
                else
                    MessageBox.Show("No se encontró ningún registro con ese ID");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizó el Estado de vehiculo, error: " + ex.ToString());
            }
        }

        // ELIMINAR (DELETE)

        public void EliminarEstadoT(int idEstadoV)
        {
            try
            {
                if (idEstadoV <= 0)
                {
                    MessageBox.Show("Debe seleccionar un Estado de vehiculo de la tabla antes de eliminar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "DELETE FROM estado_vehiculo WHERE id_estado_vehiculo = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@id", idEstadoV);

                int filasAfectadas = myComand.ExecuteNonQuery();

                if (filasAfectadas > 0)
                    MessageBox.Show("Se eliminó correctamente");
                else
                    MessageBox.Show("No se encontró ningún registro con ese ID");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el registro, error: " + ex.ToString());
            }
        }
    }
}
