using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaReparto.Clases
{
    internal class CEstadoEmpleado
    {
        // MOSTRAR la tabla completa en el grid

        public void mostrarEstadosEmpleado(DataGridView tablaEstados)
        {
            try
            {
                CConexion objetoConexion = new CConexion();
                string query = "SELECT id_estado_empleado AS Id_Estado_Empleado, " +
                               "nombre AS Nombre, " +
                               "descripcion AS Descripcion " +
                               "FROM estado_empleado";

                // se limpia el grid antes de llenarlo, para que no se dupliquen columnas
                // con las que ya traía diseñadas el DataGridView
                tablaEstados.DataSource = null;
                tablaEstados.Columns.Clear();

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaEstados.AutoGenerateColumns = true;
                tablaEstados.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());
            }
        }

        // BOTON GUARDAR (INSERT)
        // No se manda el id_estado_empleado porque la columna es AUTO_INCREMENT: lo genera MySQL solo,
        // y con myComand.LastInsertedId se recupera ese id recién generado para devolverlo

        public int GuardarEstadoEmpleado(TextBox nombre, TextBox descripcion)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombre.Text))
                {
                    MessageBox.Show("El nombre del estado es obligatorio.");
                    return -1;
                }

                CConexion objetoConexion = new CConexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                string query = "INSERT INTO estado_empleado (nombre, descripcion) VALUES (@nombre, @descripcion)";

                MySqlCommand myComand = new MySqlCommand(query, conexion);
                myComand.Parameters.AddWithValue("@nombre", nombre.Text);
                myComand.Parameters.AddWithValue("@descripcion", descripcion.Text);

                myComand.ExecuteNonQuery();

                int nuevoId = Convert.ToInt32(myComand.LastInsertedId);

                MessageBox.Show("Se guardó el estado de empleado correctamente");
                objetoConexion.cerrarConexion();

                return nuevoId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardó el estado de empleado, error: " + ex.ToString());
                return -1;
            }
        }

        // SELECCIONAR (cargar fila del grid a los controles)
        // Devuelve el id_estado_empleado de la fila (o -1 si no hay nada válido seleccionado)

        public int SeleccionarEstadoEmpleado(DataGridView tablaEstados, TextBox nombre, TextBox descripcion)
        {
            try
            {
                DataGridViewRow fila = tablaEstados.CurrentRow;

                // evita el error cuando el grid todavia no tiene datos, cuando esta
                // parado en la fila nueva en blanco, o cuando la celda no tiene valor
                if (fila == null || fila.IsNewRow || fila.Cells["Id_Estado_Empleado"].Value == null)
                    return -1;

                int idEstado = Convert.ToInt32(fila.Cells["Id_Estado_Empleado"].Value);

                nombre.Text = ObtenerTexto(fila, "Nombre");
                descripcion.Text = ObtenerTexto(fila, "Descripcion");

                return idEstado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No logro seleccionar el estado de empleado: " + ex.ToString());
                return -1;
            }
        }

        // metodo de apoyo: convierte el valor de una celda a texto,
        // y si viene en null o DBNull devuelve "" en vez de reventar
        private string ObtenerTexto(DataGridViewRow fila, string columna)
        {
            object valor = fila.Cells[columna].Value;
            return (valor == null || valor == DBNull.Value) ? string.Empty : valor.ToString();
        }

        // MODIFICAR (UPDATE)

        public void ModificarEstadoEmpleado(int idEstado, TextBox nombre, TextBox descripcion)
        {
            try
            {
                if (idEstado <= 0)
                {
                    MessageBox.Show("Debe seleccionar un estado de empleado de la tabla antes de editar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "UPDATE estado_empleado SET " +
                    "nombre = @nombre, " +
                    "descripcion = @descripcion " +
                    "WHERE id_estado_empleado = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@nombre", nombre.Text);
                myComand.Parameters.AddWithValue("@descripcion", descripcion.Text);
                myComand.Parameters.AddWithValue("@id", idEstado);

                int filas = myComand.ExecuteNonQuery();
                if (filas > 0)
                    MessageBox.Show("Se modificó correctamente");
                else
                    MessageBox.Show("No se encontró ningún registro con ese ID");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizó el estado de empleado, error: " + ex.ToString());
            }
        }

        // ELIMINAR (DELETE)

        public void EliminarEstadoEmpleado(int idEstado)
        {
            try
            {
                if (idEstado <= 0)
                {
                    MessageBox.Show("Debe seleccionar un estado de empleado de la tabla antes de eliminar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "DELETE FROM estado_empleado WHERE id_estado_empleado = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@id", idEstado);

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
