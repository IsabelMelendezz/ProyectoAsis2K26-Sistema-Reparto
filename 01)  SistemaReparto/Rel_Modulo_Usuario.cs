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
    public partial class Rel_Modulo_Usuario : Form
    {
        CRelUsuMod_cont controlador = new CRelUsuMod_cont();
        CUsuarios_cont rolController = new CUsuarios_cont(); // ya lo tienes de antes

        int idModuloSeleccionadoEnGrid = 0;
        bool haySeleccionEnAsignados = false;
        public Rel_Modulo_Usuario()
        {
            InitializeComponent();
            this.Load += Rel_Modulo_Usuario_Load;
            cbo_Usu_Disponibles.SelectedIndexChanged += cbo_Usu_Disponibles_SelectedIndexChanged;
            lst_Mod_Asignados.SelectedIndexChanged += lst_Mod_Asignados_SelectedIndexChanged;
        }

        private void Rel_Modulo_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboUsu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CargarComboUsu()
        {
            cbo_Usu_Disponibles.SelectedIndexChanged -= cbo_Usu_Disponibles_SelectedIndexChanged;

            cbo_Usu_Disponibles.DisplayMember = "NombreUsuario";
            cbo_Usu_Disponibles.ValueMember = "IdUsuario";
            cbo_Usu_Disponibles.DataSource = rolController.ListarUsuarios(); // usando ListarUsuariosParaCombo() ver nota abajo
            cbo_Usu_Disponibles.SelectedIndex = -1;

            cbo_Usu_Disponibles.SelectedIndexChanged += cbo_Usu_Disponibles_SelectedIndexChanged;

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbo_Usu_Disponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Usu_Disponibles.SelectedIndex == -1) return;

                int idUsuario = Convert.ToInt32(cbo_Usu_Disponibles.SelectedValue);
                txt_Usuario.Text = cbo_Usu_Disponibles.Text;

                RefrescarModulosDisponibles(idUsuario);
                RefrescarModulosAsignados(idUsuario);
                LimpiarPermisos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefrescarModulosDisponibles(int idUsuario)
        {
            cbo_Modulos_Disponibles.DataSource = controlador.ListarModulosDisponibles(idUsuario);
            cbo_Modulos_Disponibles.DisplayMember = "NombreModulo";
            cbo_Modulos_Disponibles.ValueMember = "IdModulo";
            cbo_Modulos_Disponibles.SelectedIndex = -1;
        }
        private void RefrescarModulosAsignados(int idUsuario)
        {
            lst_Mod_Asignados.DataSource = null;
            lst_Mod_Asignados.DataSource = controlador.ListarModulosAsignados(idUsuario);
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
                if (lst_Mod_Asignados.SelectedItem is CRelUsuModulo seleccionado)
                {
                    idModuloSeleccionadoEnGrid = seleccionado.IdModulo;
                    haySeleccionEnAsignados = true;
                    cbo_Usu_Disponibles.SelectedValue = seleccionado.IdUsuario;
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
                if (cbo_Usu_Disponibles.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un rol", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbo_Modulos_Disponibles.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un módulo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idUsuario = Convert.ToInt32(cbo_Usu_Disponibles.SelectedValue);
                int idModulo = Convert.ToInt32(cbo_Modulos_Disponibles.SelectedValue);

                CRelUsuModulo nuevo = new CRelUsuModulo(
                    idModulo, idUsuario,
                    chk_Insertar.Checked, chk_Editar.Checked, chk_Eliminar.Checked, false // false = Imprimir, aún no está en tu diseño
                );

                if (controlador.AsignarModulo(nuevo))
                {
                    MessageBox.Show("Módulo asignado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarModulosDisponibles(idUsuario);
                    RefrescarModulosAsignados(idUsuario);
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

                int idUsuario = Convert.ToInt32(cbo_Usu_Disponibles.SelectedValue);

                CRelUsuModulo actualizado = new CRelUsuModulo(
                    idModuloSeleccionadoEnGrid, idUsuario,
                    chk_Insertar.Checked, chk_Editar.Checked, chk_Eliminar.Checked, false
                );

                if (controlador.ActualizarPermisos(actualizado))
                {
                    MessageBox.Show("Permisos actualizados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarModulosAsignados(idUsuario);
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

                var confirmacion = MessageBox.Show("¿Quitar este módulo del Usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    int idUsuario = Convert.ToInt32(cbo_Usu_Disponibles.SelectedValue);

                    if (controlador.EliminarAsignacion(idModuloSeleccionadoEnGrid, idUsuario))
                    {
                        MessageBox.Show("Módulo removido del Usuario correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescarModulosDisponibles(idUsuario);
                        RefrescarModulosAsignados(idUsuario);
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
                cbo_Modulos_Disponibles.SelectedIndex = -1;
                txt_Usuario.Clear();
                lst_Mod_Asignados.ClearSelected();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbo_Modulos_Disponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
