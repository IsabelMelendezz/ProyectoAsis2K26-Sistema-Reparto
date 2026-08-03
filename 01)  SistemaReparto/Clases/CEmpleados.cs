//Lourdes Isabel Melendez Pineda 
//9959-23-1379

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaReparto.Clases
{
    internal class ContEmpleados
    {
        // MOSTRAR la tabla completa llamando los campos con un query especifico como hacer mineria de datos
        // y luego se crea automaticamente la tabla con codigo cada columna 
        //Victor Omar Gomez Carrascosa
        //9959-23-10733
        public List<CEmpleados> ListarEmpleadosSinUsuario()
        {
            List<CEmpleados> lista = new List<CEmpleados>();
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"SELECT e.id_empleado, CONCAT(e.nombre_empleado, ' ', e.apellido_empleado) AS nombre_completo_empleado,
                                    u.id_usuario, u.id_empleado, u.usuario_usuario, u.correo_usuario, 
                                         u.ultimo_acceso_usuario, u.fecha_creacion_usuario, u.estado_usuario
                                  FROM empleado e
                                  left JOIN usuario u ON e.id_empleado = u.id_empleado";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new CEmpleados
                    {
                        IdEmpleado = Convert.ToInt32(reader["id_empleado"]),
                        NombreCompleto = reader["nombre_completo_empleado"].ToString(),
                        NombreUsuario = reader["usuario_usuario"] != DBNull.Value ? reader["usuario_usuario"].ToString() : null,
                        Correo = reader["correo_usuario"] != DBNull.Value ? reader["correo_usuario"].ToString() : null,
                        Contrasena = null, // No se obtiene la contraseña en esta consulta
                        Estado = reader["estado_usuario"] != DBNull.Value ? reader["estado_usuario"].ToString() : null

                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.cerrarConexion();
            }
            return lista;
        }
    }
    internal class CEmpleados
    {
        // MOSTRAR la tabla completa llamando los campos con un query especifico como hacer mineria de datos
        // y luego se crea automaticamente la tabla con codigo cada columna 
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreUsuario { get; set; }     // columna "usuario"
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }
        public void mostrar_Empleados(DataGridView tablaEmpleados)
        {
            try
            {
                CConexion objetoConexion = new CConexion();
                string query = "SELECT e.id_empleado AS Id_Empleado, " +
                               "te.nombre_tipo_empleado AS Tipo_Empleado, " +
                               "ee.nombre_estado_empleado AS Estado, " +
                               "e.nombre_empleado AS Nombres, " +
                               "e.apellido_empleado AS Apellidos, " +
                               "e.dpi_empleado AS DPI, " +
                               "e.nit_empleado AS NIT, " +
                               "e.telefono_empleado AS Telefono, " +
                               "e.direccion_empleado AS Direccion, " +
                               "e.fecha_nacimiento_empleado AS Fecha_nacimiento, " +
                               "e.fecha_contratacion_empleado AS Fecha_contratacion " +
                               "FROM empleado e " +
                               "INNER JOIN tipo_empleado te ON e.id_tipo_empleado = te.id_tipo_empleado " +
                               "INNER JOIN estado_empleado ee ON e.id_estado_empleado = ee.id_estado_empleado";

                tablaEmpleados.DataSource = null;
                tablaEmpleados.Columns.Clear();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaEmpleados.AutoGenerateColumns = true;
                tablaEmpleados.DataSource = dt;

                ConfigurarEstiloTabla(tablaEmpleados);

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());
            }
        }

        
        private void ConfigurarEstiloTabla(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.FromArgb(230, 230, 230);
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
            dgv.MultiSelect = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 66, 143);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersHeight = 38;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 225, 245);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(21, 66, 143);
            dgv.DefaultCellStyle.Padding = new Padding(4);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 252);

            dgv.RowTemplate.Height = 32;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var config = new Dictionary<string, (string texto, int peso)>
            {
                { "Id_Empleado",         ("ID", 6) },
                { "Tipo_Empleado",       ("Tipo", 10) },
                { "Estado",              ("Estado", 8) },
                { "Nombres",             ("Nombres", 14) },
                { "Apellidos",           ("Apellidos", 14) },
                { "DPI",                 ("DPI", 12) },
                { "NIT",                 ("NIT", 10) },
                { "Telefono",            ("Teléfono", 10) },
                { "Direccion",           ("Dirección", 18) },
                { "Fecha_nacimiento",    ("Fecha Nacimiento", 12) },
                { "Fecha_contratacion",  ("Fecha Contratación", 12) },
            };

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (config.TryGetValue(col.Name, out var datos))
                {
                    col.HeaderText = datos.texto;
                    col.FillWeight = datos.peso;
                }
                else
                {
                    col.FillWeight = 10;
                }

                col.MinimumWidth = 60;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }

        // Llenados de combobox primero limpie los datos, estableci la conexion con la base luego se hizo el llenado 
        // y despues ya se cierra la conexion para mis dos COMBO_BOX TipoEmpleado Y EstadoEmpleado

        public void llenarComboTipoEmpleado(ComboBox cboTipoEmpleado)
        {
            try
            {
                cboTipoEmpleado.DataSource = null;
                cboTipoEmpleado.Items.Clear();
                CConexion objetoConexion = new CConexion();
                string query = "SELECT id_tipo_empleado, nombre_tipo_empleado FROM tipo_empleado";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cboTipoEmpleado.DataSource = dt;
                cboTipoEmpleado.DisplayMember = "nombre_tipo_empleado";
                cboTipoEmpleado.ValueMember = "id_tipo_empleado";
                cboTipoEmpleado.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargó el combo de Tipo Empleado, error: " + ex.ToString());
            }
        }
        // AHORA estado empleado
        public void llenarComboEstadoEmpleado(ComboBox cboEstadoEmpleado)
        {
            try
            {
                cboEstadoEmpleado.DataSource = null;
                cboEstadoEmpleado.Items.Clear();
                CConexion objetoConexion = new CConexion();
                string query = "SELECT id_estado_empleado, nombre_estado_empleado FROM estado_empleado";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cboEstadoEmpleado.DataSource = dt;
                cboEstadoEmpleado.DisplayMember = "nombre_estado_empleado";
                cboEstadoEmpleado.ValueMember = "id_estado_empleado";
                cboEstadoEmpleado.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargó el combo de Estado Empleado, error: " + ex.ToString());
            }
        }

        // BOTON GUARDAR Igual manda a llamar todos los datos ingresados en cada objeto de la interfaz 
        //manejo de errores y establece conexion 

        public int GuardarEmpleado(ComboBox cboTipoEmpleado, ComboBox cboEstadoEmpleado,
            TextBox nombres, TextBox apellidos, TextBox dpi, TextBox nit,
            TextBox telefono, TextBox direccion,
            DateTimePicker fechaNacimiento, DateTimePicker fechaContratacion)
        {
            try
            {
                if (cboTipoEmpleado.SelectedValue == null || cboEstadoEmpleado.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar Tipo de Empleado y Estado.");
                    return -1;
                }

                CConexion objetoConexion = new CConexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                string query = "INSERT INTO empleado " +
                    "(id_tipo_empleado, id_estado_empleado, nombre_empleado, apellido_empleado, dpi_empleado, nit_empleado, telefono_empleado, direccion_empleado, fecha_nacimiento_empleado, fecha_contratacion_empleado) " +
                    "VALUES (@tipo, @estado, @nombres, @apellidos, @dpi, @nit, @telefono, @direccion, @nacimiento, @contratacion)";

                MySqlCommand myComand = new MySqlCommand(query, conexion);
                myComand.Parameters.AddWithValue("@tipo", cboTipoEmpleado.SelectedValue);
                myComand.Parameters.AddWithValue("@estado", cboEstadoEmpleado.SelectedValue);
                myComand.Parameters.AddWithValue("@nombres", nombres.Text);
                myComand.Parameters.AddWithValue("@apellidos", apellidos.Text);
                myComand.Parameters.AddWithValue("@dpi", dpi.Text);
                myComand.Parameters.AddWithValue("@nit", nit.Text);
                myComand.Parameters.AddWithValue("@telefono", telefono.Text);
                myComand.Parameters.AddWithValue("@direccion", direccion.Text);
                myComand.Parameters.AddWithValue("@nacimiento", fechaNacimiento.Value.Date);
                myComand.Parameters.AddWithValue("@contratacion", fechaContratacion.Value.Date);

                myComand.ExecuteNonQuery();

                int nuevoId = Convert.ToInt32(myComand.LastInsertedId);

                MessageBox.Show("Se guardó el empleado correctamente");
                objetoConexion.cerrarConexion();

                return nuevoId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardó el empleado, error: " + ex.ToString());
                return -1;
            }
        }

        // SELECCIONAR (cargar fila tabla de controles)

        public int SeleccionarEmpleado(DataGridView tablaEmpleados,
            ComboBox cboTipoEmpleado, ComboBox cboEstadoEmpleado,
            TextBox nombres, TextBox apellidos, TextBox dpi, TextBox nit,
            TextBox telefono,TextBox direccion,
            DateTimePicker fechaNacimiento, DateTimePicker fechaContratacion)
        {
            try
            {
                DataGridViewRow fila = tablaEmpleados.CurrentRow;

                if (fila == null || fila.IsNewRow || fila.Cells["Id_Empleado"].Value == null)
                    return -1;

                int idEmpleado = Convert.ToInt32(fila.Cells["Id_Empleado"].Value);

                nombres.Text = ObtenerTexto(fila, "Nombres");
                apellidos.Text = ObtenerTexto(fila, "Apellidos");
                dpi.Text = ObtenerTexto(fila, "DPI");
                nit.Text = ObtenerTexto(fila, "NIT");
                telefono.Text = ObtenerTexto(fila, "Telefono");
                direccion.Text = ObtenerTexto(fila, "Direccion");

                object valorNacimiento = fila.Cells["Fecha_nacimiento"].Value;
                if (valorNacimiento != null && valorNacimiento != DBNull.Value)
                    fechaNacimiento.Value = Convert.ToDateTime(valorNacimiento);

                object valorContratacion = fila.Cells["Fecha_contratacion"].Value;
                if (valorContratacion != null && valorContratacion != DBNull.Value)
                    fechaContratacion.Value = Convert.ToDateTime(valorContratacion);

                cboTipoEmpleado.Text = ObtenerTexto(fila, "Tipo_Empleado");
                cboEstadoEmpleado.Text = ObtenerTexto(fila, "Estado");

                return idEmpleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No logro seleccionar el empleado: " + ex.ToString());
                return -1;
            }
        }

        private string ObtenerTexto(DataGridViewRow fila, string columna)
        {
            object valor = fila.Cells[columna].Value;
            return (valor == null || valor == DBNull.Value) ? string.Empty : valor.ToString();
        }

        // MODIFICAR (UPDATE)

        public void Modificar_Empleado(int idEmpleado, ComboBox cboTipoEmpleado, ComboBox cboEstadoEmpleado,
            TextBox nombres, TextBox apellidos, TextBox dpi, TextBox nit,
            TextBox telefono, TextBox direccion,
            DateTimePicker fechaNacimiento, DateTimePicker fechaContratacion)
        {
            try
            {
                if (idEmpleado <= 0)
                {
                    MessageBox.Show("Debe seleccionar un empleado de la tabla antes de editar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "UPDATE empleado SET " +
                    "id_tipo_empleado = @tipo, " +
                    "id_estado_empleado = @estado, " +
                    "nombre_empleado = @nombres, " +
                    "apellido_empleado = @apellidos, " +
                    "dpi_empleado = @dpi, " +
                    "nit_empleado = @nit, " +
                    "telefono_empleado = @telefono, " +
                    "direccion_empleado = @direccion, " +
                    "fecha_nacimiento_empleado = @nacimiento, " +
                    "fecha_contratacion_empleado = @contratacion " +
                    "WHERE id_empleado = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@tipo", cboTipoEmpleado.SelectedValue);
                myComand.Parameters.AddWithValue("@estado", cboEstadoEmpleado.SelectedValue);
                myComand.Parameters.AddWithValue("@nombres", nombres.Text);
                myComand.Parameters.AddWithValue("@apellidos", apellidos.Text);
                myComand.Parameters.AddWithValue("@dpi", dpi.Text);
                myComand.Parameters.AddWithValue("@nit", nit.Text);
                myComand.Parameters.AddWithValue("@telefono", telefono.Text);
                myComand.Parameters.AddWithValue("@direccion", direccion.Text);
                myComand.Parameters.AddWithValue("@nacimiento", fechaNacimiento.Value.Date);
                myComand.Parameters.AddWithValue("@contratacion", fechaContratacion.Value.Date);
                myComand.Parameters.AddWithValue("@id", idEmpleado);

                int filas = myComand.ExecuteNonQuery();
                if (filas > 0)
                    MessageBox.Show("Se modificó correctamente");
                else
                    MessageBox.Show("No se encontró ningún registro con ese ID");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizó el empleado, error: " + ex.ToString());
            }
        }

        // ELIMINAR (DELETE)

        public void EliminarEmpleado(int idEmpleado)
        {
            try
            {
                if (idEmpleado <= 0)
                {
                    MessageBox.Show("Debe seleccionar un empleado de la tabla antes de eliminar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "DELETE FROM empleado WHERE id_empleado = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@id", idEmpleado);

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