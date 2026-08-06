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
    public partial class Paquetes : Form
    {
        CPaquetes objetoPaquetes = new CPaquetes();

        private int idPaqueteSeleccionado = 0;
        //LLamada de las clases para la verificación de permisos
        private CPermisoModulo misPermisos;
        private ModuloRolController permisosController = new ModuloRolController();
        private ModuloUsuarioController permisosUsuarioController = new ModuloUsuarioController();

        public Paquetes()
        {
            InitializeComponent();

            dgvPaquetes.AutoGenerateColumns = true;
        }


        private void Paquetes_Load(object sender, EventArgs e)
        {//Victor Omar GOmez 9959-23-10733
            try
            {

                // --- Verificación de seguridad ---
                CPermisoModulo permisosPorRol = permisosController.ObtenerPermisos(Modulos.Paquetes, Sesion.IdsRoles);
                CPermisoModulo permisosPorUsuario = permisosUsuarioController.ObtenerPermisos(Modulos.Paquetes, Sesion.IdUsuario);

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

             
                objetoPaquetes.MostrarPaquetes(dgvPaquetes);

                objetoPaquetes.LlenarComboPedido(cboPedido);

                cboEstado.Items.Clear();
                cboEstado.Items.Add("Activo");
                cboEstado.Items.Add("Inactivo");
                cboEstado.SelectedIndex = 0;
                objetoPaquetes.LlenarComboTipoPaquete(cboTipoPaquete);


                cboEstadoFiltro.Items.Clear();

                cboEstadoFiltro.Items.Add("Todos");
                cboEstadoFiltro.Items.Add("Activo");
                cboEstadoFiltro.Items.Add("Inactivo");

                cboEstadoFiltro.SelectedIndex = 0;

                cboTipoFiltro.Items.Clear();

                cboTipoFiltro.Items.Add("Todos");
                cboTipoFiltro.Items.Add("Documento");
                cboTipoFiltro.Items.Add("Sobre");
                cboTipoFiltro.Items.Add("Caja");
                cboTipoFiltro.Items.Add("Paquete");
                cboTipoFiltro.Items.Add("Electrónica");
                cboTipoFiltro.Items.Add("Ropa");
                cboTipoFiltro.Items.Add("Otro");

                cboTipoFiltro.SelectedIndex = 0;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objetoPaquetes.GuardarPaquete(
                cboPedido,
                txtCodigoRastreo,
                txtPeso,
                txtAlto,
                txtAncho,
                txtLargo,
                txtDescripcion,
                cboFragil,
                cboEstado,
                txtValorDeclarado,
                cboTipoPaquete);

            objetoPaquetes.MostrarPaquetes(dgvPaquetes);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            objetoPaquetes.ModificarPaquete(
                idPaqueteSeleccionado,
                cboPedido,
                txtCodigoRastreo,
                txtPeso,
                txtAlto,
                txtAncho,
                txtLargo,
                txtDescripcion,
                cboFragil,
                cboEstado,
                txtValorDeclarado,
                cboTipoPaquete);

            objetoPaquetes.MostrarPaquetes(dgvPaquetes);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevoPaquete_Click(object sender, EventArgs e)
        {
            objetoPaquetes.LimpiarCampos(
                cboPedido,
                cboRuta,
                txtDescripcion,
                txtPeso,
                txtAlto,
                txtAncho,
                txtLargo,
                cboFragil,
                txtCodigoRastreo,
                txtValorDeclarado,
                cboTipoPaquete);

            idPaqueteSeleccionado = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objetoPaquetes.LimpiarCampos(
                cboPedido,
                cboRuta,
                txtDescripcion,
                txtPeso,
                txtAlto,
                txtAncho,
                txtLargo,
                cboFragil,
                txtCodigoRastreo,
                txtValorDeclarado,
                cboTipoPaquete);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objetoPaquetes.BuscarPaquete(
                txtBuscar.Text,
                dgvPaquetes);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            objetoPaquetes.FiltrarPaquetes(
                dgvPaquetes,
                cboEstadoFiltro,
                cboTipoFiltro);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objetoPaquetes.EliminarPaquete(idPaqueteSeleccionado);

            objetoPaquetes.MostrarPaquetes(dgvPaquetes);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPedido.SelectedIndex != -1)
            {
                objetoPaquetes.MostrarRutaPedido(
                    cboPedido,
                    cboRuta);
            }
            else
            {
                cboRuta.SelectedIndex = -1;
            }
        }

        private void dgvPaquetes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idPaqueteSeleccionado = Convert.ToInt32(
                    dgvPaquetes.CurrentRow.Cells["id_paquete"].Value);

                objetoPaquetes.SeleccionarPaquete(
                    dgvPaquetes,
                    cboPedido,
                    txtCodigoRastreo,
                    txtPeso,
                    txtAlto,
                    txtAncho,
                    txtLargo,
                    txtDescripcion,
                    cboFragil,
                    cboEstado,
                    txtValorDeclarado,
                    cboTipoPaquete);

                objetoPaquetes.MostrarRutaPedido(
                    cboPedido,
                    cboRuta);
            }
        }

        private void cboRuta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
            private void txtValorDeclarado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números
            if (char.IsDigit(e.KeyChar))
                return;

            // Permitir Backspace
            if (e.KeyChar == (char)Keys.Back)
                return;

            // Permitir un único punto decimal
            if (e.KeyChar == '.')
            {
                if (!txtValorDeclarado.Text.Contains(".") &&
                    txtValorDeclarado.Text.Length > 0)
                    return;
            }

            // Bloquear cualquier otro carácter
            e.Handled = true;
        }
    
    }
}
