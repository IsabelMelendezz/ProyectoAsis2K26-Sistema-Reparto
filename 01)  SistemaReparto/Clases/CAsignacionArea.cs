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
    internal class CAsignacionArea
    {
        // COMBO EMPLEADO (todos los empleados, no se filtran)

        public void llenarComboEmpleado(ComboBox Cbo_Empleado)
        {
            try
            {
                Cbo_Empleado.DataSource = null;
                Cbo_Empleado.Items.Clear();
                CConexion objetoConexion = new CConexion();
                string query = "SELECT e.id_empleado, CONCAT(e.nombre_empleado, ' ', e.apellido_empleado) AS nombre_completo " +
               "FROM empleado e " +
               "INNER JOIN tipo_empleado te ON e.id_tipo_empleado = te.id_tipo_empleado " +
               "INNER JOIN estado_empleado ee ON e.id_estado_empleado = ee.id_estado_empleado " +
               "WHERE te.nombre_tipo_empleado = 'Repartidor' " +
               "AND ee.nombre_estado_empleado = 'Activo';";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Cbo_Empleado.DataSource = dt;
                Cbo_Empleado.DisplayMember = "nombre_completo";
                Cbo_Empleado.ValueMember = "id_empleado";
                Cbo_Empleado.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargó el combo de Empleado, error: " + ex.ToString());
            }
        }


        // COMBO ÁREA (solo las áreas que el empleado seleccionado AÚN NO tiene asignadas)

        public void RefrescarAreasDisponibles(ComboBox Cbo_Area, int idEmpleado)
        {
            try
            {
                Cbo_Area.DataSource = null;
                Cbo_Area.Items.Clear();
                CConexion objetoConexion = new CConexion();

                string query = "SELECT id_area, zona_area_cubierta FROM area_cubierta " +
                               "WHERE id_area NOT IN " +
                               "(SELECT id_area FROM asignacion_area WHERE id_empleado = @idEmpleado)";

                MySqlCommand cmd = new MySqlCommand(query, objetoConexion.establecerConexion());
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Cbo_Area.DataSource = dt;
                Cbo_Area.DisplayMember = "zona_area_cubierta";
                Cbo_Area.ValueMember = "id_area";
                Cbo_Area.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargó el combo de Área, error: " + ex.ToString());
            }
        }


        // LISTBOX (las áreas que el empleado seleccionado YA tiene asignadas)

        public void RefrescarAreasAsignadas(ListBox List_Asignacion_Area, int idEmpleado)
        {
            try
            {
                List_Asignacion_Area.DataSource = null;
                List_Asignacion_Area.Items.Clear();
                CConexion objetoConexion = new CConexion();

                string query = "SELECT aa.id_asignacion_area, " +
                               "ac.zona_area_cubierta, " +
                               "aa.fecha_inicio_asignacion_area, " +
                               "aa.fecha_fin_asignacion_area, " +
                               "CONCAT(ac.zona_area_cubierta, ' (', " +
                               "IFNULL(DATE_FORMAT(aa.fecha_inicio_asignacion_area, '%d/%m/%Y'), 'Sin inicio'), " +
                               "' - ', " +
                               "IFNULL(DATE_FORMAT(aa.fecha_fin_asignacion_area, '%d/%m/%Y'), 'Sin fin'), ')') AS texto " +
                               "FROM asignacion_area aa " +
                               "INNER JOIN area_cubierta ac ON aa.id_area = ac.id_area " +
                               "WHERE aa.id_empleado = @idEmpleado";

                MySqlCommand cmd = new MySqlCommand(query, objetoConexion.establecerConexion());
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                List_Asignacion_Area.DataSource = dt;
                List_Asignacion_Area.DisplayMember = "texto";
                List_Asignacion_Area.ValueMember = "id_asignacion_area";

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargaron las áreas asignadas, error: " + ex.ToString());
            }
        }


        // GUARDAR (INSERT) - asigna una nueva área al empleado

        public int GuardarAsignacion(ComboBox Cbo_Empleado, ComboBox Cbo_Area,
            DateTimePicker Date_Inicio_Asignacion, DateTimePicker Date_Fin_Asignacion)
        {
            try
            {
                if (Cbo_Empleado.SelectedValue == null || Cbo_Area.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar Empleado y Área.");
                    return -1;
                }

                CConexion objetoConexion = new CConexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                string query = "INSERT INTO asignacion_area " +
                    "(id_empleado, id_area, fecha_inicio_asignacion_area, fecha_fin_asignacion_area) " +
                    "VALUES (@idEmpleado, @idArea, @fechaInicio, @fechaFin)";

                MySqlCommand myComand = new MySqlCommand(query, conexion);
                myComand.Parameters.AddWithValue("@idEmpleado", Cbo_Empleado.SelectedValue);
                myComand.Parameters.AddWithValue("@idArea", Cbo_Area.SelectedValue);
                myComand.Parameters.AddWithValue("@fechaInicio", Date_Inicio_Asignacion.Value.Date);
                myComand.Parameters.AddWithValue("@fechaFin", Date_Fin_Asignacion.Value.Date);

                myComand.ExecuteNonQuery();

                int nuevoId = Convert.ToInt32(myComand.LastInsertedId);

                MessageBox.Show("Se guardó la asignación correctamente");
                objetoConexion.cerrarConexion();

                return nuevoId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardó la asignación, error: " + ex.ToString());
                return -1;
            }
        }


        // SELECCIONAR (al hacer clic en una asignación del ListBox, carga solo las fechas)

        public int SeleccionarAsignacion(ListBox List_Asignacion_Area,
            DateTimePicker Date_Inicio_Asignacion, DateTimePicker Date_Fin_Asignacion)
        {
            try
            {
                if (List_Asignacion_Area.SelectedValue == null)
                    return -1;

                DataRowView fila = (DataRowView)List_Asignacion_Area.SelectedItem;

                int idAsignacion = Convert.ToInt32(fila["id_asignacion_area"]);

                if (fila["fecha_inicio_asignacion_area"] != DBNull.Value)
                    Date_Inicio_Asignacion.Value = Convert.ToDateTime(fila["fecha_inicio_asignacion_area"]);

                if (fila["fecha_fin_asignacion_area"] != DBNull.Value)
                    Date_Fin_Asignacion.Value = Convert.ToDateTime(fila["fecha_fin_asignacion_area"]);

                return idAsignacion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No logro seleccionar la asignación: " + ex.ToString());
                return -1;
            }
        }


        // MODIFICAR (UPDATE) - solo se editan las fechas, el empleado y el área no cambian

        public void ModificarAsignacion(int idAsignacion,
            DateTimePicker Date_Inicio_Asignacion, DateTimePicker Date_Fin_Asignacion)
        {
            try
            {
                if (idAsignacion <= 0)
                {
                    MessageBox.Show("Debe seleccionar una asignación de la lista antes de editar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "UPDATE asignacion_area SET " +
                    "fecha_inicio_asignacion_area = @fechaInicio, " +
                    "fecha_fin_asignacion_area = @fechaFin " +
                    "WHERE id_asignacion_area = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@fechaInicio", Date_Inicio_Asignacion.Value.Date);
                myComand.Parameters.AddWithValue("@fechaFin", Date_Fin_Asignacion.Value.Date);
                myComand.Parameters.AddWithValue("@id", idAsignacion);

                int filas = myComand.ExecuteNonQuery();
                if (filas > 0)
                    MessageBox.Show("Se modificó correctamente");
                else
                    MessageBox.Show("No se encontró ningún registro con ese ID");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizó la asignación, error: " + ex.ToString());
            }
        }


        // ELIMINAR (DELETE) - quita el área asignada al empleado

        public void EliminarAsignacion(int idAsignacion)
        {
            try
            {
                if (idAsignacion <= 0)
                {
                    MessageBox.Show("Debe seleccionar una asignación de la lista antes de eliminar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "DELETE FROM asignacion_area WHERE id_asignacion_area = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@id", idAsignacion);

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
