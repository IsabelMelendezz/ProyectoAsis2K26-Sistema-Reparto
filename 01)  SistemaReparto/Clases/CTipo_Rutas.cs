//Cristian David Sipac Ispache
//9959-23-1567
using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReparto.Clases
{
    internal class CTipo_Rutas
    {
        public void mostrarRutas(DataGridView tablaRutas)
        {
            try
            {
                CConexion objetoConexion = new CConexion();
                String query = "select * from tipo_ruta";
                tablaRutas.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaRutas.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());

            }
        }

        public void GuardarRutas(TextBox nombre, TextBox descripcion)
        {
            try
            {
                CConexion objetoConexion = new CConexion();
                String query = "insert into tipo_ruta (nombre_tipo_ruta, descripcion_tipo_ruta)" +
                    "values ('" + nombre.Text + "', '" + descripcion.Text + "')";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se guardó los registros");
                while (reader.Read())
                {
                }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());

            }
        }


        public void SeleccionarRutas(DataGridView tablaRutas, TextBox id_tipo_ruta, TextBox nombre, TextBox descripcion)
        {
            try
            {
                id_tipo_ruta.Text = tablaRutas.CurrentRow.Cells[0].Value.ToString();
                nombre.Text = tablaRutas.CurrentRow.Cells[1].Value.ToString();
                descripcion.Text = tablaRutas.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No logro seleccionar: " + ex.ToString());

            }
        }

        public void ModificarRutas(TextBox id_tipo_ruta, TextBox nombre, TextBox descripcion)
        {
            try
            {
                CConexion objetoConexion = new CConexion();
                String query = "update tipo_ruta set id_tipo_ruta='"
                    + id_tipo_ruta.Text + "', nombre_tipo_ruta='" + nombre.Text
                    + "', descripcion_tipo_ruta='" + descripcion.Text
                    + "' where id_tipo_ruta = '" + id_tipo_ruta.Text + "';";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se modifico correctamente");
                while (reader.Read())
                {
                }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizaron de la base de datos, error: " + ex.ToString());

            }
        }


        public void EliminarRutas(TextBox id_tipo_ruta)
        {
            try
            {
                CConexion objetoConexion = new CConexion();
                string query = "DELETE FROM tipo_ruta WHERE id_tipo_ruta = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@id", id_tipo_ruta.Text);

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