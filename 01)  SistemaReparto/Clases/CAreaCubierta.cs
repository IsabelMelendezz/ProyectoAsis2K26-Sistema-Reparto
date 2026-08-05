//Cristian David Sipac Ispache
//9959-23-1567
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReparto.Clases
{
    internal class CAreaCubierta
    {
        

        public void mostrarAreas(DataGridView Dgv_Tabla_Area)
        {
            try
            {
                CConexion objetoConexion = new CConexion();
                String query = "SELECT * FROM area_cubierta";

                Dgv_Tabla_Area.DataSource = null;
                Dgv_Tabla_Area.Columns.Clear();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Dgv_Tabla_Area.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());
            }
        }

        public int GuardarArea(TextBox Txt_Zona_Area_Cubierta, TextBox Txt_Municipio_Area_Cubierta,
            TextBox Txt_Departamento_Area_Cubierta, TextBox Txt_Descripcion_Area_Cubierta)
        {
            try
            {
                CConexion objetoConexion = new CConexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                string query = "INSERT INTO area_cubierta " +
                    "(zona_area_cubierta, municipio_area_cubierta, departamento_area_cubierta, descripcion_area_cubierta) " +
                    "VALUES (@zona, @municipio, @departamento, @descripcion)";

                MySqlCommand myComand = new MySqlCommand(query, conexion);
                myComand.Parameters.AddWithValue("@zona", Txt_Zona_Area_Cubierta.Text);
                myComand.Parameters.AddWithValue("@municipio", Txt_Municipio_Area_Cubierta.Text);
                myComand.Parameters.AddWithValue("@departamento", Txt_Departamento_Area_Cubierta.Text);
                myComand.Parameters.AddWithValue("@descripcion", Txt_Descripcion_Area_Cubierta.Text);

                myComand.ExecuteNonQuery();

                int nuevoId = Convert.ToInt32(myComand.LastInsertedId);

                MessageBox.Show("Se guardó el área correctamente");
                objetoConexion.cerrarConexion();

                return nuevoId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardó el área, error: " + ex.ToString());
                return -1;
            }
        }


        public int SeleccionarArea(DataGridView Dgv_Tabla_Area,
            TextBox Txt_Zona_Area_Cubierta, TextBox Txt_Municipio_Area_Cubierta,
            TextBox Txt_Departamento_Area_Cubierta, TextBox Txt_Descripcion_Area_Cubierta)
        {
            try
            {
                DataGridViewRow fila = Dgv_Tabla_Area.CurrentRow;

                if (fila == null || fila.IsNewRow || fila.Cells["id_area"].Value == null)
                    return -1;

                int idArea = Convert.ToInt32(fila.Cells["id_area"].Value);

                Txt_Zona_Area_Cubierta.Text = ObtenerTexto(fila, "zona_area_cubierta");
                Txt_Municipio_Area_Cubierta.Text = ObtenerTexto(fila, "municipio_area_cubierta");
                Txt_Departamento_Area_Cubierta.Text = ObtenerTexto(fila, "departamento_area_cubierta");
                Txt_Descripcion_Area_Cubierta.Text = ObtenerTexto(fila, "descripcion_area_cubierta");

                return idArea;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No logro seleccionar el área: " + ex.ToString());
                return -1;
            }
        }

        private string ObtenerTexto(DataGridViewRow fila, string columna)
        {
            object valor = fila.Cells[columna].Value;
            return (valor == null || valor == DBNull.Value) ? string.Empty : valor.ToString();
        }


        public void ModificarArea(int idArea, TextBox Txt_Zona_Area_Cubierta, TextBox Txt_Municipio_Area_Cubierta,
            TextBox Txt_Departamento_Area_Cubierta, TextBox Txt_Descripcion_Area_Cubierta)
        {
            try
            {
                if (idArea <= 0)
                {
                    MessageBox.Show("Debe seleccionar un área de la tabla antes de editar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "UPDATE area_cubierta SET " +
                    "zona_area_cubierta = @zona, " +
                    "municipio_area_cubierta = @municipio, " +
                    "departamento_area_cubierta = @departamento, " +
                    "descripcion_area_cubierta = @descripcion " +
                    "WHERE id_area = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@zona", Txt_Zona_Area_Cubierta.Text);
                myComand.Parameters.AddWithValue("@municipio", Txt_Municipio_Area_Cubierta.Text);
                myComand.Parameters.AddWithValue("@departamento", Txt_Departamento_Area_Cubierta.Text);
                myComand.Parameters.AddWithValue("@descripcion", Txt_Descripcion_Area_Cubierta.Text);
                myComand.Parameters.AddWithValue("@id", idArea);

                int filas = myComand.ExecuteNonQuery();
                if (filas > 0)
                    MessageBox.Show("Se modificó correctamente");
                else
                    MessageBox.Show("No se encontró ningún registro con ese ID");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizó el área, error: " + ex.ToString());
            }
        }

        public void EliminarArea(int idArea)
        {
            try
            {
                if (idArea <= 0)
                {
                    MessageBox.Show("Debe seleccionar un área de la tabla antes de eliminar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "DELETE FROM area_cubierta WHERE id_area = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@id", idArea);

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
