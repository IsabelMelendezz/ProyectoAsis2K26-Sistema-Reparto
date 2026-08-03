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
    internal class CTipo_Transporte
    {
        public void mostrarTipo_Vehiculo(DataGridView Tabla_T_Transporte)
        {
            try
            {
                CConexion objetoConexion = new CConexion();
                String query = "SELECT tv.id_tipo_vehiculo AS Id_Tipo_Vehiculo, " +
                               "tv.nombre_tipo_vehiculo AS Nombre, " +
                               "tv.descripcion_tipo_vehiculo AS Descripcion " +
                               "FROM tipo_vehiculo tv ";

                Tabla_T_Transporte.DataSource = null;
                Tabla_T_Transporte.Columns.Clear();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Tabla_T_Transporte.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());

            }
        }



        public int GuardarTipoT(TextBox nombre,TextBox descrip)
        {
            try
            {
                
                CConexion objetoConexion = new CConexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                string query = "INSERT INTO tipo_vehiculo " +
                    "(nombre_tipo_vehiculo, descripcion_tipo_vehiculo) " +
                    "VALUES (@nombre, @descripcion)";

                MySqlCommand myComand = new MySqlCommand(query, conexion);
                myComand.Parameters.AddWithValue("@nombre", nombre.Text);
                myComand.Parameters.AddWithValue("@descripcion", descrip.Text);


                myComand.ExecuteNonQuery();

                int nuevoId = Convert.ToInt32(myComand.LastInsertedId);

                MessageBox.Show("Se guardó el Tipo de Vehiculo correctamente");
                objetoConexion.cerrarConexion();

                return nuevoId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardó el Tipo de Vehiculo, error: " + ex.ToString());
                return -1;
            }
        }


        // SELECCIONAR (cargar fila tabla de controles)
        // 
        public int SeleccionarTipoV(DataGridView Tabla_T_Transporte,
            TextBox nombre, TextBox descrip)
        {
            try
            {
                DataGridViewRow fila = Tabla_T_Transporte.CurrentRow;

                if (fila == null || fila.IsNewRow || fila.Cells["Id_Tipo_Vehiculo"].Value == null)
                    return -1;

                int idTipoV = Convert.ToInt32(fila.Cells["Id_Tipo_Vehiculo"].Value);

                nombre.Text = ObtenerTexto(fila, "nombre");
                descrip.Text = ObtenerTexto(fila, "descripcion");

                return idTipoV;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No logro seleccionar el Tipo de vehiculo: " + ex.ToString());
                return -1;
            }
        }

        private string ObtenerTexto(DataGridViewRow fila, string columna)
        {
            object valor = fila.Cells[columna].Value;
            return (valor == null || valor == DBNull.Value) ? string.Empty : valor.ToString();
        }

        // MODIFICAR (UPDATE)

        public void ModificarTipoT(int idTipoV, TextBox nombre, TextBox descrip)
        {
            try
            {
                if (idTipoV <= 0)
                {
                    MessageBox.Show("Debe seleccionar un Tipo de vehiculo de la tabla antes de editar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "UPDATE tipo_vehiculo SET " +
                    "nombre_tipo_vehiculo = @nombre, " +
                    "descripcion_tipo_vehiculo = @descrip, ";

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
                MessageBox.Show("No se actualizó el Tipo de vehiculo, error: " + ex.ToString());
            }
        }

        // ELIMINAR (DELETE)

        public void EliminarTipoT(int idTipoV)
        {
            try
            {
                if (idTipoV <= 0)
                {
                    MessageBox.Show("Debe seleccionar un Tipo de vehiculo de la tabla antes de eliminar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "DELETE FROM tipo_vehiculo WHERE id_tipo_vehiculo = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@id", idTipoV);

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
