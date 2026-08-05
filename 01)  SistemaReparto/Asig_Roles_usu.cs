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
    public partial class Asig_Roles_usu : Form
    {
        UsuarioRolController controlador = new UsuarioRolController();

        // Guardan la llave original de la fila seleccionada (para editar/eliminar)
        int idUsuarioSeleccionado = 0;
        int idRolSeleccionado = 0;
        bool haySeleccion = false;

        public Asig_Roles_usu()
        {
            InitializeComponent();
            this.Load += Asig_Roles_usu_Load;
            Dgv_Tabla_UR.SelectionChanged += Dgv_Tabla_UR_SelectionChanged;
        }

        private void Asig_Roles_usu_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCombos()
        {
            // Usuarios: muestra "NombreUsuario", guarda "IdUsuario"
            cbo_Usu_Disponible.DataSource = controlador.ListarUsuariosParaCombo();
            cbo_Usu_Disponible.DisplayMember = "NombreUsuario";
            cbo_Usu_Disponible.ValueMember = "IdUsuario";
            cbo_Usu_Disponible.SelectedIndex = -1;

            // Roles: muestra "Nombre", guarda "IdRol"
            Cbo_Rol_Disponibles.DataSource = controlador.ListarRolesParaCombo();
            Cbo_Rol_Disponibles.DisplayMember = "Nombre";
            Cbo_Rol_Disponibles.ValueMember = "IdRol";
            Cbo_Rol_Disponibles.SelectedIndex = -1;
        }

        private void CargarGrid()
        {
            Dgv_Tabla_UR.DataSource = null;
            Dgv_Tabla_UR.DataSource = controlador.ListarAsignaciones();

            if (Dgv_Tabla_UR.Columns.Count > 0)
            {
                Dgv_Tabla_UR.Columns["IdUsuario"].HeaderText = "ID_Usu";
                Dgv_Tabla_UR.Columns["IdRol"].HeaderText = "ID_Rol";
                Dgv_Tabla_UR.Columns["FechaAsignacion"].HeaderText = "Fecha_Asig";
                Dgv_Tabla_UR.Columns["NombreUsuario"].HeaderText = "Usuario";
                Dgv_Tabla_UR.Columns["NombreRol"].HeaderText = "Rol";
            }
        }

        private bool ValidarCombos()
        {
            if (cbo_Usu_Disponible.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Cbo_Rol_Disponibles.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un rol", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Limpiar()
        {
            cbo_Usu_Disponible.SelectedIndex = -1;
            Cbo_Rol_Disponibles.SelectedIndex = -1;
            idUsuarioSeleccionado = 0;
            idRolSeleccionado = 0;
            haySeleccion = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




        private void Dgv_Tabla_Usu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_Tabla_UR_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_Tabla_UR.CurrentRow == null) return;

                if (Dgv_Tabla_UR.CurrentRow.DataBoundItem is CAsig_Roles_Usu seleccionado)
                {
                    idUsuarioSeleccionado = seleccionado.IdUsuario;
                    idRolSeleccionado = seleccionado.IdRol;
                    haySeleccion = true;

                    cbo_Usu_Disponible.SelectedValue = seleccionado.IdUsuario;
                    Cbo_Rol_Disponibles.SelectedValue = seleccionado.IdRol;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la asignación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Guardar_Emp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCombos()) return;

                int idUsuario = Convert.ToInt32(cbo_Usu_Disponible.SelectedValue);
                int idRol = Convert.ToInt32(Cbo_Rol_Disponibles.SelectedValue);

                CAsig_Roles_Usu nuevaAsignacion = new CAsig_Roles_Usu(idUsuario, idRol, DateTime.Now, "", "");

                if (controlador.AsignarRol(nuevaAsignacion))
                {
                    MessageBox.Show("Rol asignado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al guardar la asignación." + Environment.NewLine +
                    "Mensaje: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Actualizar_Asig_R_U_Click(object sender, EventArgs e)
        {
            try
            {
                if (!haySeleccion)
                {
                    MessageBox.Show("Selecciona una asignación de la lista primero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidarCombos()) return;

                int nuevoIdUsuario = Convert.ToInt32(cbo_Usu_Disponible.SelectedValue);
                int nuevoIdRol = Convert.ToInt32(Cbo_Rol_Disponibles.SelectedValue);

                CAsig_Roles_Usu actualizado = new CAsig_Roles_Usu(nuevoIdUsuario, nuevoIdRol, DateTime.Now, "", "");

                if (controlador.EditarAsignacion(idUsuarioSeleccionado, idRolSeleccionado, actualizado))
                {
                    MessageBox.Show("Asignación actualizada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al editar la asignación." + Environment.NewLine +
                    "Mensaje: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Eliminar_Emp_Asig_R_U_Click(object sender, EventArgs e)
        {
            try
            {
                if (!haySeleccion)
                {
                    MessageBox.Show("Selecciona una asignación de la lista primero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmacion = MessageBox.Show("¿Seguro que deseas eliminar esta asignación?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    if (controlador.EliminarAsignacion(idUsuarioSeleccionado, idRolSeleccionado))
                    {
                        MessageBox.Show("Asignación eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al eliminar la asignación." + Environment.NewLine +
                    "Mensaje: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Limpiar_Emp_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cbo_Rol_Disponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Usu_Disponible.SelectedIndex == -1) return;

                int idUsuario = Convert.ToInt32(cbo_Usu_Disponible.SelectedValue);
                

                RefrescarModulosDisponibles(idUsuario);
            
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefrescarModulosDisponibles(int idUsuario)
        {
            Cbo_Rol_Disponibles.DataSource = controlador.ListarRolessDisponibles(idUsuario);
            Cbo_Rol_Disponibles.DisplayMember = "NombreRol";
            Cbo_Rol_Disponibles.ValueMember = "IdRol";
            Cbo_Rol_Disponibles.SelectedIndex = -1;
        }
        
    }
}

