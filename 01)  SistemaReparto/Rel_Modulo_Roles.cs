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
    public partial class Rel_Modulo_Roles : Form
    {
        CRelRolMod_cont controlador = new CRelRolMod_cont();
        rol_cont rolController = new rol_cont(); // ya lo tienes de antes

        int idModuloSeleccionadoEnGrid = 0;
        bool haySeleccionEnAsignados = false;

        public Rel_Modulo_Roles()
        {
            InitializeComponent();
            this.Load += Rel_Modulo_Rol_Load;
            Cbo_Rol_Disponibles.SelectedIndexChanged += Cbo_Rol_Disponibles_SelectedIndexChanged;
            lst_Mod_Asignados.SelectedIndexChanged += lst_Mod_Asignados_SelectedIndexChanged;


        }
        private void Rel_Modulo_Rol_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarComboRoles()
        {
            Cbo_Rol_Disponibles.DisplayMember = "Nombre";
            Cbo_Rol_Disponibles.ValueMember = "IdRol";
            Cbo_Rol_Disponibles.DataSource = rolController.ListarRoles();
            Cbo_Rol_Disponibles.SelectedIndex = -1;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Rel_Modulo_Roles_Load(object sender, EventArgs e)
        {

        }

        private void Cbo_Rol_Disponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Rol_Disponibles.SelectedIndex == -1) return;

                int idRol = Convert.ToInt32(Cbo_Rol_Disponibles.SelectedValue);
                txt_Rol.Text = Cbo_Rol_Disponibles.Text;

                RefrescarModulosDisponibles(idRol);
                RefrescarModulosAsignados(idRol);
                LimpiarPermisos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefrescarModulosDisponibles(int idRol)
        {
            cbo_Mod_Disponibles.DataSource = controlador.ListarModulosDisponibles(idRol);
            cbo_Mod_Disponibles.DisplayMember = "NombreModulo";
            cbo_Mod_Disponibles.ValueMember = "IdModulo";
            cbo_Mod_Disponibles.SelectedIndex = -1;
        }

        private void RefrescarModulosAsignados(int idRol)
        {
            lst_Mod_Asignados.DataSource = null;
            lst_Mod_Asignados.DataSource = controlador.ListarModulosAsignados(idRol);
            lst_Mod_Asignados.DisplayMember = "NombreModulo";
        }

        private void LimpiarPermisos()
        {
            chk_Insertar.Checked = false;
            chk_Editar.Checked = false;
            chk_Eliminar.Checked = false;
            idModuloSeleccionadoEnGrid = 0;
            haySeleccionEnAsignados = false;
        }

        private void lst_Mod_Asignados_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lst_Mod_Asignados.SelectedItem is CRelRolModulo seleccionado)
                {
                    idModuloSeleccionadoEnGrid = seleccionado.IdModulo;
                    haySeleccionEnAsignados = true;
                    Cbo_Rol_Disponibles.SelectedValue = seleccionado.IdRol;
                    chk_Insertar.Checked = seleccionado.DerInsertar;
                    chk_Editar.Checked = seleccionado.DerEditar;
                    chk_Eliminar.Checked = seleccionado.DerEliminar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el módulo asignado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Guardar_Emp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Rol_Disponibles.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un rol", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbo_Mod_Disponibles.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un módulo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idRol = Convert.ToInt32(Cbo_Rol_Disponibles.SelectedValue);
                int idModulo = Convert.ToInt32(cbo_Mod_Disponibles.SelectedValue);

                CRelRolModulo nuevo = new CRelRolModulo(
                    idModulo, idRol,
                    chk_Insertar.Checked, chk_Editar.Checked, chk_Eliminar.Checked, false // false = Imprimir, aún no está en tu diseño
                );

                if (controlador.AsignarModulo(nuevo))
                {
                    MessageBox.Show("Módulo asignado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarModulosDisponibles(idRol);
                    RefrescarModulosAsignados(idRol);
                    LimpiarPermisos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al guardar." + Environment.NewLine + "Mensaje: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Editar_Emp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!haySeleccionEnAsignados)
                {
                    MessageBox.Show("Selecciona un módulo de la lista de Asignados primero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idRol = Convert.ToInt32(Cbo_Rol_Disponibles.SelectedValue);

                CRelRolModulo actualizado = new CRelRolModulo(
                    idModuloSeleccionadoEnGrid, idRol,
                    chk_Insertar.Checked, chk_Editar.Checked, chk_Eliminar.Checked, false
                );

                if (controlador.ActualizarPermisos(actualizado))
                {
                    MessageBox.Show("Permisos actualizados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarModulosAsignados(idRol);
                    LimpiarPermisos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al editar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Eliminar_Emp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!haySeleccionEnAsignados)
                {
                    MessageBox.Show("Selecciona un módulo de la lista de Asignados primero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmacion = MessageBox.Show("¿Quitar este módulo del rol?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    int idRol = Convert.ToInt32(Cbo_Rol_Disponibles.SelectedValue);

                    if (controlador.EliminarAsignacion(idModuloSeleccionadoEnGrid, idRol))
                    {
                        MessageBox.Show("Módulo removido del rol correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescarModulosDisponibles(idRol);
                        RefrescarModulosAsignados(idRol);
                        LimpiarPermisos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Limpiar_Emp_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarPermisos();
                cbo_Mod_Disponibles.SelectedIndex = -1;
                txt_Rol.Clear();
                lst_Mod_Asignados.ClearSelected();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
