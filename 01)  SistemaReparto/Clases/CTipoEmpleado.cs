using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReparto.Clases
{
    internal class CTipoEmpleado
    {
        public void mostrarTipoEmpleado(DataGridView Tabla_TipoEmp)
        {
            try
            {
                CConexion objetoConexion = new CConexion();
                String query = "SELECT te.id_tipo_empleado AS Id_Tipo_Empleado, " +
                               "te.nombre AS Nombre, " +
                               "te.descripcion AS Descripcion " +
                               "FROM tipo_empleado te ";

                Tabla_TipoEmp.DataSource = null;
                Tabla_TipoEmp.Columns.Clear();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Tabla_TipoEmp.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());

            }
        }



        public int GuardarTipoEmp(TextBox nombre, TextBox descrip)
        {
            try
            {

                CConexion objetoConexion = new CConexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                string query = "INSERT INTO tipo_empleado " +
                    "(nombre, descripcion) " +
                    "VALUES (@nombre, @descripcion)";

                MySqlCommand myComand = new MySqlCommand(query, conexion);
                myComand.Parameters.AddWithValue("@nombre", nombre.Text);
                myComand.Parameters.AddWithValue("@descripcion", descrip.Text);


                myComand.ExecuteNonQuery();

                int nuevoId = Convert.ToInt32(myComand.LastInsertedId);

                MessageBox.Show("Se guardó el Tipo de Empleado correctamente");
                objetoConexion.cerrarConexion();

                return nuevoId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardó el Tipo de Empleado, error: " + ex.ToString());
                return -1;
            }
        }


        // SELECCIONAR (cargar fila tabla de controles)
        // 
        public int SeleccionarTipoEmp(DataGridView Tabla_TipoEmp,
            TextBox nombre, TextBox descrip)
        {
            try
            {
                DataGridViewRow fila = Tabla_TipoEmp.CurrentRow;

                if (fila == null || fila.IsNewRow || fila.Cells["Id_Tipo_Empleado"].Value == null)
                    return -1;

                int idTipoEmp = Convert.ToInt32(fila.Cells["Id_Tipo_Empleado"].Value);

                nombre.Text = ObtenerTexto(fila, "nombre");
                descrip.Text = ObtenerTexto(fila, "descripcion");

                return idTipoEmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No logro seleccionar el Tipo de Empleado: " + ex.ToString());
                return -1;
            }
        }

        private string ObtenerTexto(DataGridViewRow fila, string columna)
        {
            object valor = fila.Cells[columna].Value;
            return (valor == null || valor == DBNull.Value) ? string.Empty : valor.ToString();
        }

        // MODIFICAR (UPDATE)

        public void ModificarTipoEmp(int idTipoEmp, TextBox nombre, TextBox descrip)
        {
            try
            {
                if (idTipoEmp <= 0)
                {
                    MessageBox.Show("Debe seleccionar un Tipo de Empleado de la tabla antes de editar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "UPDATE tipo_empleado SET " +
                    "nombre = @nombre, " +
                    "descripcion = @descripcion " +
                    "WHERE id_tipo_empleado = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@nombre", nombre.Text);
                myComand.Parameters.AddWithValue("@descripcion", descrip.Text);
                myComand.Parameters.AddWithValue("@id", idTipoEmp);

                int filas = myComand.ExecuteNonQuery();
                if (filas > 0)
                    MessageBox.Show("Se modificó correctamente");
                else
                    MessageBox.Show("No se encontró ningún registro con ese ID");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizó el Tipo de Empleado, error: " + ex.ToString());
            }
        }

        // ELIMINAR (DELETE)

        public void EliminarTipoEmp(int idTipoEmp)
        {
            try
            {
                if (idTipoEmp <= 0)
                {
                    MessageBox.Show("Debe seleccionar un Tipo de Empleado de la tabla antes de eliminar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "DELETE FROM tipo_empleado WHERE id_tipo_empleado = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@id", idTipoEmp);

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