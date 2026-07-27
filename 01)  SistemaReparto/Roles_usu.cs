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
        RolController controlador = new RolController();
        int idRolSeleccionado = 0; // guarda el id del rol seleccionado en la grid

        public Roles_usu()
        {
            InitializeComponent();
        }

        private void Roles_usu_Load(object sender, EventArgs e)
        {
            CargarGrid();
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
            }
        }

        private void LimpiarCampos()
        {
            Txt_Nombre_Rol.Clear();
            txtDescripcion.Clear();
            idRolSeleccionado = 0;
        }

        // Botón "Añadir Rol"


        // Botón "Editar Rol"


        // Botón "Borrar Rol"
        

        // Botón "Actualizar Datos" (refresca la grid sin guardar nada)
        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            CargarGrid();
            LimpiarCampos();
        }

        // Al hacer clic en una fila de la grid, cargar los datos en los campos
        private void dgvRoles_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_Tabla_Rol.CurrentRow != null && Dgv_Tabla_Rol.CurrentRow.DataBoundItem is Rol rolSeleccionado)
            {
                idRolSeleccionado = rolSeleccionado.IdRol;
                Txt_Nombre_Rol.Text = rolSeleccionado.Nombre;
                txtDescripcion.Text = rolSeleccionado.Descripcion;
            }
        }

        private void Btn_Insert_Usu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Nombre_Rol.Text))
            {
                MessageBox.Show("El nombre del rol es obligatorio");
                return;
            }

            Rol nuevoRol = new Rol(Txt_Nombre_Rol.Text, txtDescripcion.Text);

            if (controlador.AnadirRol(nuevoRol))
            {
                MessageBox.Show("Rol añadido correctamente");
                CargarGrid();
                LimpiarCampos();
            }
        }

        private void Btn_Update_Usu_Click(object sender, EventArgs e)
        {
            if (idRolSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un rol de la lista primero");
                return;
            }

            Rol rolEditado = new Rol(idRolSeleccionado, Txt_Nombre_Rol.Text, txtDescripcion.Text);

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
    }
}