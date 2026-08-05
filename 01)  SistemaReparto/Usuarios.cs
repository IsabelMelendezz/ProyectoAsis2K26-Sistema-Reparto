using SistemaReparto.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReparto
{
    public partial class Usuarios : Form
    {
        CUsuarios_cont controlador = new CUsuarios_cont();
        ContEmpleados empleadoController = new ContEmpleados();

        int idUsuarioSeleccionado = 0;
        bool haySeleccion = false;
        bool cambiandoContrasena = false;

        public Usuarios()
        {
            InitializeComponent();
            Dgv_Tabla_Usu.SelectionChanged += dgvUsuarios_SelectionChanged;
            cbo_Id_Empleados.SelectedIndexChanged += cmbIdEmpleado_SelectedIndexChanged;
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboEmpleados();
                CargarComboEstado();
                CargarGrid();
                btn_cambiar_contra.Text = "Cambio de Contraseña";
                // Fecha de creación: automática y no editable
                dtp_Fecha_Creacion.Value = DateTime.Now;
                dtp_Fecha_Creacion.Enabled = false;
                txt_Contraseña.PasswordChar = '*';

                DeshabilitarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeshabilitarCampos()
        {
            cbo_Id_Empleados.Enabled = false;
            txt_Nombre_Usuario.Enabled = false;
            txt_Correo.Enabled = false;
            cbo_Estado_Usuario.Enabled = false;
            txt_Contraseña.Enabled = false;

        }
        private void HabilitarCamposParaEditar()
        {
            cbo_Id_Empleados.Enabled = true;
            txt_Nombre_Usuario.Enabled = true;
            txt_Correo.Enabled = true;
            cbo_Estado_Usuario.Enabled = true;
            txt_Contraseña.Enabled = false;
        }
        private void HabilitarCamposParaNuevo()
        {
            cbo_Id_Empleados.Enabled = true;
            txt_Nombre_Usuario.Enabled = true;
            txt_Correo.Enabled = true;
            cbo_Estado_Usuario.Enabled = true;
            txt_Contraseña.Enabled = true;
        }
        private void CargarComboEmpleados()
        {
            cbo_Id_Empleados.DataSource = empleadoController.ListarEmpleadosSinUsuario();
            cbo_Id_Empleados.DisplayMember = "NombreCompleto";     // el combo "Id Empleado" muestra el ID
            cbo_Id_Empleados.ValueMember = "IdEmpleado";
            cbo_Id_Empleados.SelectedIndex = -1;
            txt_Nombre_Empleado.Clear();
        }

        private void CargarComboEstado()
        {
            cbo_Estado_Usuario.Items.Clear();
            cbo_Estado_Usuario.Items.Add("Activo");
            cbo_Estado_Usuario.Items.Add("Inactivo");
            cbo_Estado_Usuario.SelectedIndex = -1;
        }

        private void CargarGrid()
        {
            Dgv_Tabla_Usu.DataSource = null;
            Dgv_Tabla_Usu.DataSource = controlador.ListarUsuarios();

            if (Dgv_Tabla_Usu.Columns.Count > 0)
            {
                Dgv_Tabla_Usu.Columns["IdUsuario"].HeaderText = "ID_Usuario";
                Dgv_Tabla_Usu.Columns["IdEmpleado"].HeaderText = "ID_Empleado";
                Dgv_Tabla_Usu.Columns["NombreEmpleado"].HeaderText = "Empleado";
                Dgv_Tabla_Usu.Columns["NombreUsuario"].HeaderText = "Usuario";
                Dgv_Tabla_Usu.Columns["Correo"].HeaderText = "Correo";
                Dgv_Tabla_Usu.Columns["contrasena"].HeaderText = "Contraseña";
                Dgv_Tabla_Usu.Columns["UltimoAcceso"].HeaderText = "Último Acceso";
                Dgv_Tabla_Usu.Columns["FechaCreacion"].HeaderText = "Fecha Creación";
                Dgv_Tabla_Usu.Columns["Estado"].HeaderText = "Estado";


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pic_Icono_Usu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }



        private void btnProbarConexion_Click_Click(object sender, EventArgs e)
        {
            Roles_usu roles = new Roles_usu();
            roles.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Asig_Roles_usu asigR_Usu = new Asig_Roles_usu();
            asigR_Usu.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Rel_Modulo_Roles relMod_Roles = new Rel_Modulo_Roles();
            relMod_Roles.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Rel_Modulo_Usuario relMod_Usu = new Rel_Modulo_Usuario();
            relMod_Usu.Show();
        }

        private void Btn_Nuevo_Emp_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                HabilitarCamposParaNuevo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dgv_Usuar(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            try
            {
                if (Dgv_Tabla_Usu.CurrentRow == null) return;

                if (Dgv_Tabla_Usu.CurrentRow.DataBoundItem is CUsuarios seleccionado)
                {
                    idUsuarioSeleccionado = seleccionado.IdUsuario;
                    haySeleccion = true;
                    // Recargar el combo incluyendo también el empleado actual de este usuario
                    var listaEmpleados = empleadoController.ListarEmpleadosSinUsuario();
                    listaEmpleados.Add(new CEmpleados
                    {
                        IdEmpleado = seleccionado.IdEmpleado
                    });

                    cbo_Id_Empleados.DataSource = listaEmpleados;
                    cbo_Id_Empleados.DisplayMember = "NombreCompleto";
                    cbo_Id_Empleados.ValueMember = "IdEmpleado";
                    cbo_Id_Empleados.SelectedValue = seleccionado.IdEmpleado;

                    txt_Nombre_Usuario.Text = seleccionado.NombreUsuario;
                    txt_Correo.Text = seleccionado.Correo;
                    txt_Contraseña.Text = seleccionado.Contrasena;
                    txt_Nombre_Empleado.Text = seleccionado.IdEmpleado.ToString();
                    cbo_Estado_Usuario.SelectedItem = seleccionado.Estado;
                    dtp_Fecha_Creacion.Value = seleccionado.FechaCreacion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbIdEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Id_Empleados.SelectedItem is CEmpleados empleadoSeleccionado)
            {
                txt_Nombre_Empleado.Text = empleadoSeleccionado.IdEmpleado.ToString();
                txt_Nombre_Usuario.Text = empleadoSeleccionado.NombreUsuario;
                txt_Contraseña.Text = empleadoSeleccionado.Contrasena;

                cbo_Estado_Usuario.SelectedItem = empleadoSeleccionado.Estado;

            }
        }
        private bool Validar()
        {
            if (cbo_Id_Empleados.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un empleado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Nombre_Empleado.Text))
            {
                MessageBox.Show("El nombre de usuario es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Contraseña.Text))
            {
                MessageBox.Show("La contraseña es obligatoria", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbo_Estado_Usuario.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un estado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Limpiar()
        {
            cbo_Id_Empleados.SelectedIndex = -1;
            txt_Nombre_Empleado.Clear();
            txt_Nombre_Usuario.Clear();
            txt_Contraseña.Clear();
            txt_Correo.Clear();
            cbo_Estado_Usuario.SelectedIndex = -1;
            dtp_Fecha_Creacion.Value = DateTime.Now;
            idUsuarioSeleccionado = 0;
            haySeleccion = false;
        }

        private void Dgv_Tabla_Usu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Editar_Emp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!haySeleccion)
                {
                    MessageBox.Show("Selecciona un usuario de la lista primero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                HabilitarCamposParaEditar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Actualizar_Usu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!haySeleccion)
                {
                    MessageBox.Show("Selecciona un usuario de la lista primero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Validar()) return;

                int idEmpleado = Convert.ToInt32(cbo_Id_Empleados.SelectedValue);
                string estado = cbo_Estado_Usuario.SelectedItem.ToString();

                CUsuarios usuarioEditado = new CUsuarios
                {
                    IdUsuario = idUsuarioSeleccionado,
                    IdEmpleado = idEmpleado,
                    NombreUsuario = txt_Nombre_Usuario.Text,
                    Correo = txt_Correo.Text,
                    Estado = estado
                };

                if (controlador.EditarUsuario(usuarioEditado))
                {
                    MessageBox.Show("Usuario actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al editar el usuario." + Environment.NewLine + "Mensaje: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Eliminar_Emp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!haySeleccion)
                {
                    MessageBox.Show("Selecciona un usuario de la lista primero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmacion = MessageBox.Show("¿Seguro que deseas eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    if (controlador.BorrarUsuario(idUsuarioSeleccionado))
                    {
                        MessageBox.Show("Usuario eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarComboEmpleados();
                        CargarGrid();
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el usuario." + Environment.NewLine + "Mensaje: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Guardar_Emp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;

                int idEmpleado = Convert.ToInt32(cbo_Id_Empleados.SelectedValue);
                string estado = cbo_Estado_Usuario.SelectedItem.ToString();

                CUsuarios nuevoUsuario = new CUsuarios(idEmpleado, txt_Nombre_Usuario.Text, txt_Correo.Text, txt_Contraseña.Text, estado);

                if (controlador.AnadirUsuario(nuevoUsuario))
                {
                    MessageBox.Show("Usuario creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarComboEmpleados();
                    CargarGrid();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el usuario." + Environment.NewLine + "Mensaje: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!haySeleccion)
                {
                    MessageBox.Show("Selecciona un usuario de la lista primero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!cambiandoContrasena)
                {
                    // Paso 1: pedir confirmación antes de habilitar el campo
                    var confirmacion = MessageBox.Show(
                        "¿Estás seguro que deseas cambiar la contraseña de este usuario?",
                        "Confirmar cambio de contraseña",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    btn_cambiar_contra.Text = "Cambio de Contraseña";

                    if (confirmacion != DialogResult.Yes)
                        return; // el usuario canceló, no se habilita nada

                    // Habilita el campo vacío para escribir la nueva contraseña
                    txt_Contraseña.Clear();
                    txt_Contraseña.Enabled = true;
                    txt_Contraseña.Focus();
                    cambiandoContrasena = true;
                    btn_cambiar_contra.Text = "Confirmar Nueva Contraseña";
                }
                else
                {
                    // Paso 2: valida y guarda la nueva contraseña
                    if (string.IsNullOrWhiteSpace(txt_Contraseña.Text))
                    {
                        MessageBox.Show("Ingresa la nueva contraseña", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (controlador.CambiarContrasena(idUsuarioSeleccionado, txt_Contraseña.Text))
                    {
                        MessageBox.Show("Contraseña actualizada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Contraseña.Enabled = false;
                        cambiandoContrasena = false;
                        btn_cambiar_contra.Text = "Cambio de Contraseña";
                        CargarGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar la contraseña: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // permite backspace, etc.

            char c = e.KeyChar;

            // Caracteres permitidos en un correo: letras, números, @ . _ -
            bool esValido = char.IsLetterOrDigit(c) || c == '@' || c == '.' || c == '_' || c == '-';

            if (!esValido)
            {
                e.Handled = true;
                return;
            }

            // No permitir más de un '@'
            if (c == '@' && txt_Correo.Text.Contains("@"))
            {
                e.Handled = true;
                return;
            }

            // No permitir '@' como primer carácter
            if (c == '@' && txt_Correo.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }
            if (c == '.' && txt_Correo.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }
        }
    }
}


