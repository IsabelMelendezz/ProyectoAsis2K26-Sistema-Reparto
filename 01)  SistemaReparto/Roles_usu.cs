using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaReparto.Clases;
using System.Windows.Forms;
namespace SistemaReparto
{
    public partial class Roles_usu : Form
    {
        rol_cont controlador = new rol_cont();
        int idRolSeleccionado = 0; // guarda el id del rol seleccionado en la grid

        public Roles_usu()
        {
            InitializeComponent();
        }

        private void Roles_usu_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message + Environment.NewLine + ex.StackTrace,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrid()
        {
            Dgv_Tabla_Rol.DataSource = null;
            Dgv_Tabla_Rol.DataSource = controlador.ListarRoles();

            // Opcional: renombrar encabezados de columnas para que coincidan con tu diseño
            if (Dgv_Tabla_Rol.Columns.Count > 0)
            {
                Dgv_Tabla_Rol.Columns["IdRol"].HeaderText = "ID_Rol";
                Dgv_Tabla_Rol.Columns["Nombre"].HeaderText = "Nombre";
                Dgv_Tabla_Rol.Columns["Descripcion"].HeaderText = "descripcion";
                Dgv_Tabla_Rol.Columns["Estado"].HeaderText = "estado";
            }
        }

        private void LimpiarCampos()
        {
            Txt_Nombre_Rol.Clear();
            txt_Descripcion.Clear();
            cmb_Estado.SelectedIndex = -1; // Deselecciona cualquier valor en el ComboBox

            idRolSeleccionado = 0;
        }



        // Botón "Actualizar Datos" (refresca la grid sin guardar nada)
        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            CargarGrid();
            LimpiarCampos();
        }

        // Al hacer clic en una fila de la grid, cargar los datos en los campos
        private void dgvRoles_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_Tabla_Rol.CurrentRow != null && Dgv_Tabla_Rol.CurrentRow.DataBoundItem is CRol rolSeleccionado)
            {
                idRolSeleccionado = rolSeleccionado.IdRol;
                Txt_Nombre_Rol.Text = rolSeleccionado.Nombre;
                txt_Descripcion.Text = rolSeleccionado.Descripcion;
            }
        }



        private void Btn_Update_Usu_Click(object sender, EventArgs e)
        {
            if (idRolSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un rol de la lista primero");
                return;
            }
            if (cmb_Estado.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un estado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CRol rolEditado = new CRol(idRolSeleccionado, Txt_Nombre_Rol.Text, txt_Descripcion.Text, cmb_Estado.Text);

            if (controlador.EditarRol(rolEditado))
            {
                MessageBox.Show("Rol actualizado correctamente");
                CargarGrid();
                LimpiarCampos();
            }
        }

        private void Btn_Delete_Usu_Click(object sender, EventArgs e)
        {
            if (idRolSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un rol de la lista primero");
                return;
            }

            var confirmacion = MessageBox.Show("¿Seguro que deseas eliminar este rol?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                if (controlador.BorrarRol(idRolSeleccionado))
                {
                    MessageBox.Show("Rol eliminado correctamente");
                    CargarGrid();
                    LimpiarCampos();
                }
            }
        }

        private void Dgv_Tabla_Rol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Limpiar_Emp_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Btn_Guardar_Emp_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Nombre_Rol.Text))
                {
                    MessageBox.Show("El nombre del rol es obligatorio");
                    return;
                }
                if (cmb_Estado.SelectedIndex == -1)
                {
                    MessageBox.Show("Debes seleccionar un estado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CRol nuevoRol = new CRol(Txt_Nombre_Rol.Text, txt_Descripcion.Text, cmb_Estado.Text);
                if (controlador.AnadirRol(nuevoRol))
                {
                    MessageBox.Show("Rol añadido correctamente");
                    CargarGrid();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al añadir el rol." + Environment.NewLine +
                    "Tipo: " + ex.GetType().Name + Environment.NewLine +
                    "Mensaje: " + ex.Message + Environment.NewLine +
                    "Detalle: " + ex.StackTrace,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        
    }
}