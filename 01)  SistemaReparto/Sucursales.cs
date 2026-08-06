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
using static SistemaReparto.Clases.CModulo;

namespace SistemaReparto
{
    public partial class Sucursales : Form
    {
        //Victor Omar Gomez Carrascosa 9959-23-10733
        //LLamada de las clases para la verificación de permisos
        private CPermisoModulo misPermisos;
        private ModuloRolController permisosController = new ModuloRolController();
        private ModuloUsuarioController permisosUsuarioController = new ModuloUsuarioController();

        public Sucursales()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Sucursales_Load(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();
            try
            {

                // --- Verificación de seguridad ---
                CPermisoModulo permisosPorRol = permisosController.ObtenerPermisos(Modulos.Sucursales, Sesion.IdsRoles);
                CPermisoModulo permisosPorUsuario = permisosUsuarioController.ObtenerPermisos(Modulos.Sucursales, Sesion.IdUsuario);

                // Combina: si CUALQUIERA de los dos (rol o usuario específico) da el permiso, lo tiene
                misPermisos = new CPermisoModulo
                {
                    TieneAcceso = permisosPorRol.TieneAcceso || permisosPorUsuario.TieneAcceso,
                    PuedeInsertar = permisosPorRol.PuedeInsertar || permisosPorUsuario.PuedeInsertar,
                    PuedeEditar = permisosPorRol.PuedeEditar || permisosPorUsuario.PuedeEditar,
                    PuedeEliminar = permisosPorRol.PuedeEliminar || permisosPorUsuario.PuedeEliminar,
                    PuedeImprimir = permisosPorRol.PuedeImprimir || permisosPorUsuario.PuedeImprimir
                };

                if (!misPermisos.TieneAcceso)
                {
                    DeshabilitarFormularioCompleto();
                    MessageBox.Show("No tienes acceso a este módulo.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // no cierra el formulario, solo detiene la carga de datos
                }

               

                AplicarPermisosBotones();
                // --- fin verificación ---

                
                objetoSucursal.MostrarSucursales(dataGridView1);

            // Enlazamos los combos en cascada por código para no
            // depender de que el Designer ya tenga los eventos.
            comboBoxDepartamento.SelectedIndexChanged += comboBoxDepartamento_SelectedIndexChanged;
            comboBoxMunicipio.SelectedIndexChanged += comboBoxMunicipio_SelectedIndexChanged;

            objetoSucursal.CargarDepartamentos(comboBoxDepartamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Permisos de botones según el rol del usuario
        private void AplicarPermisosBotones()
        {
            btnGuardar.Enabled = misPermisos.PuedeInsertar;
            btnEditar.Enabled = misPermisos.PuedeEditar;
            btnEliminar.Enabled = misPermisos.PuedeEliminar;
            // Si tienes botón de imprimir/reportes en este form, lo controlas con PuedeImprimir
        }
        //Desabilita todos los controles del formulario, útil cuando el usuario no tiene permisos
        private void DeshabilitarFormularioCompleto()
        {
            foreach (Control control in this.Controls)
            {
                DeshabilitarControlRecursivo(control);
            }
        }
        //desabilita un control y todos sus controles hijos (si los tiene)
        private void DeshabilitarControlRecursivo(Control control)
        {
            control.Enabled = false;

            // Si el control tiene hijos (panels, group boxes, etc.), deshabilita también esos
            foreach (Control hijo in control.Controls)
            {
                DeshabilitarControlRecursivo(hijo);
            }
        }

        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            if (comboBoxDepartamento.SelectedIndex == -1)
            {
                comboBoxMunicipio.DataSource = null;
                comboBoxMunicipio.Items.Clear();
                comboBoxZona.DataSource = null;
                comboBoxZona.Items.Clear();
                return;
            }

            string departamento = comboBoxDepartamento.SelectedValue.ToString();

            objetoSucursal.CargarMunicipios(comboBoxMunicipio, departamento);
        }

        private void comboBoxMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            if (comboBoxMunicipio.SelectedIndex == -1 || comboBoxDepartamento.SelectedIndex == -1)
            {
                comboBoxZona.DataSource = null;
                comboBoxZona.Items.Clear();
                return;
            }

            string departamento = comboBoxDepartamento.SelectedValue.ToString();
            string municipio = comboBoxMunicipio.SelectedValue.ToString();

            objetoSucursal.CargarZonas(comboBoxZona, departamento, municipio);
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.SeleccionarSucursal(
                dataGridView1,
                textBoxIdSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Nuevo(
                textBoxIdSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Guardar(
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo,
                dataGridView1,
                textBoxIdSucursal);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Editar(
                textBoxIdSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo,
                dataGridView1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Eliminar(
                textBoxIdSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo,
                dataGridView1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Buscar(
                txtBuscar,
                dataGridView1);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Actualizar(
                dataGridView1,
                textBoxIdSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.SeleccionarSucursal(
                dataGridView1,
                textBoxIdSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo);
        }

        private void textBoxCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; 

            char c = e.KeyChar;

            // Caracteres permitidos
            bool esValido = char.IsLetterOrDigit(c) || c == '@' || c == '.' || c == '_' || c == '-';

            if (!esValido)
            {
                e.Handled = true;
                return;
            }

            // No permitir más de un '@'
            if (c == '@' && textBoxCorreo.Text.Contains("@"))
            {
                e.Handled = true;
                return;
            }

            // No permite '@' como primer carácter
            if (c == '@' && textBoxCorreo.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }
            if (c == '.' && textBoxCorreo.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
