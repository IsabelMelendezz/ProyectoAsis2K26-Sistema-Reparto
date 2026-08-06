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
using static SistemaReparto.Clases.CModulo;

namespace SistemaReparto
{
    public partial class Bodegas : Form
    {//LLamada de las clases para la verificación de permisos
        private CPermisoModulo misPermisos;
        private ModuloRolController permisosController = new ModuloRolController();
        private ModuloUsuarioController permisosUsuarioController = new ModuloUsuarioController();

        public Bodegas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            objetoBodega.LlenarComboSucursal(comboBoxSucursal);

            objetoBodega.LlenarComboDepartamento(comboBoxDepartamento);

            objetoBodega.MostrarBodegas(dataGridView1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            objetoBodega.SeleccionarBodega(
                dataGridView1,
                textBoxIdBodega,
                comboBoxSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                numericUpDownCapacidad,
                textBoxTelefono);
        }

        // Al cambiar el departamento se recarga el combo de municipios
        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            string departamento = comboBoxDepartamento.SelectedValue?.ToString();

            objetoBodega.LlenarComboMunicipio(comboBoxMunicipio, departamento);

            // Al cambiar el departamento ya no aplica la zona previamente cargada
            comboBoxZona.DataSource = null;
            comboBoxZona.Items.Clear();
        }

        // Al cambiar el municipio se recarga el combo de zonas/áreas
        private void comboBoxMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            string municipio = comboBoxMunicipio.SelectedValue?.ToString();
            string departamento = comboBoxDepartamento.SelectedValue?.ToString();

            objetoBodega.LlenarComboZona(comboBoxZona, municipio, departamento);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            CBodegas objetoBodega = new CBodegas();

            objetoBodega.Nuevo(
                textBoxIdBodega,
                comboBoxSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                numericUpDownCapacidad,
                textBoxTelefono);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            objetoBodega.Guardar(
                comboBoxSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                numericUpDownCapacidad,
                textBoxTelefono,
                dataGridView1,
                textBoxIdBodega);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            objetoBodega.Editar(
                textBoxIdBodega,
                comboBoxSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                numericUpDownCapacidad,
                textBoxTelefono,
                dataGridView1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            objetoBodega.Eliminar(
                textBoxIdBodega,
                comboBoxSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                numericUpDownCapacidad,
                textBoxTelefono,
                dataGridView1);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            objetoBodega.Buscar(
                txtBuscar,
                dataGridView1);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            objetoBodega.Actualizar(
                dataGridView1,
                textBoxIdBodega,
                comboBoxSucursal,
                textBoxNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                textBoxDireccion,
                numericUpDownCapacidad,
                textBoxTelefono);
        }

        private void Bodega_Load(object sender, EventArgs e)
        {
            try
            {

                // --- Verificación de seguridad ---
                CPermisoModulo permisosPorRol = permisosController.ObtenerPermisos(Modulos.Bodegas, Sesion.IdsRoles);
                CPermisoModulo permisosPorUsuario = permisosUsuarioController.ObtenerPermisos(Modulos.Bodegas, Sesion.IdUsuario);

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
            btnActualizar.Enabled = misPermisos.PuedeEditar;
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
    }
}
