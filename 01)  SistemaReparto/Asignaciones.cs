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
    public partial class Asignaciones : Form
    {
        CAsignaciones objAsignaciones = new CAsignaciones();
        //Victor Omar Gómez Carrascosa 9959-23-10733
        //LLamada de las clases para la verificación de permisos
        private CPermisoModulo misPermisos;
        private ModuloRolController permisosController = new ModuloRolController();
        private ModuloUsuarioController permisosUsuarioController = new ModuloUsuarioController();

        public Asignaciones()
        {
            InitializeComponent();
        }

        private void Asignaciones_Load(object sender, EventArgs e)
        {

        }

        private void lblAsignadosTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvAsignados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblBodegaOrigenValor_Click(object sender, EventArgs e)
        {

        }

        private void dgvPedidosAsignados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvPedidosAsignados.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DataTable dtDisponibles = (DataTable)dgvPedidosDisponibles.DataSource;
                DataTable dtAsignados = (DataTable)dgvPedidosAsignados.DataSource;

                DataRow nueva = dtDisponibles.NewRow();

                foreach (DataColumn col in dtDisponibles.Columns)
                {
                    nueva[col.ColumnName] =
                        ((DataRowView)dgvPedidosAsignados.Rows[e.RowIndex].DataBoundItem)
                        .Row[col.ColumnName];
                }

                dtDisponibles.Rows.Add(nueva);

                dtAsignados.Rows.RemoveAt(e.RowIndex);
            }

            objAsignaciones.ActualizarResumen(
    dgvPedidosAsignados,
    lblTotalPedidosValor,
    lblPesoTotalValor,
    lblParadasBottomValor,
    lblTiempoEstimadoBottomValor,
    lblDistanciaTotalValor,
    Convert.ToDecimal(lblDistanciaEstimadaValor.Text.Replace(" km", "")),
    lblPedidosAsignadosValor,
    lblParadasValor,
    lblTiempoEstimadoValor);
        }

        private void lblTiempoEstimadoBottomValor_Click(object sender, EventArgs e)
        {

        }

        private void pnlBotonesAccion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Asignaciones_Load_1(object sender, EventArgs e)
        {
            try
            {

                // --- Verificación de seguridad ---
                CPermisoModulo permisosPorRol = permisosController.ObtenerPermisos(Modulos.Asignacion, Sesion.IdsRoles);
                CPermisoModulo permisosPorUsuario = permisosUsuarioController.ObtenerPermisos(Modulos.Asignacion, Sesion.IdUsuario);

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

                btnAgregar.Enabled = true;
                btnLimpiar.Enabled = true;
                btnConfirmarAsignacion.Enabled = true;
                btnCancelar.Enabled = true;


                // --- fin verificación ---

                objAsignaciones.CargarRutas(cboRuta);

                objAsignaciones.CargarRepartidores(cboRepartidor);

                objAsignaciones.CargarVehiculos(cboVehiculo);

                objAsignaciones.CargarEstados(cboEstado);

                dgvPedidosDisponibles.AutoGenerateColumns = true;
                dgvPedidosAsignados.AutoGenerateColumns = true;

                dgvPedidosAsignados.AllowUserToAddRows = false;
                dgvPedidosDisponibles.AllowUserToAddRows = false;


                if (!dgvPedidosDisponibles.Columns.Contains("Seleccionar"))
                {
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();

                    chk.Name = "Seleccionar";
                    chk.HeaderText = "";
                    chk.Width = 30;

                    dgvPedidosDisponibles.Columns.Insert(0, chk);
                }

                if (!dgvPedidosAsignados.Columns.Contains("Eliminar"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                    btn.Name = "Eliminar";
                    btn.HeaderText = "";
                    btn.Text = "X";
                    btn.UseColumnTextForButtonValue = true;
                    btn.Width = 40;

                    dgvPedidosAsignados.Columns.Add(btn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Permisos de botones según el rol del usuario

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

        private void cboRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRuta.SelectedValue == null)
                return;

            if (cboRuta.SelectedValue is DataRowView)
                return;

            int idRuta = Convert.ToInt32(cboRuta.SelectedValue);

            objAsignaciones.ObtenerInformacionRuta(
                idRuta,
                dtpFecha,
                dtpHoraInicio,
                cboEstado,
                lblBodegaOrigenValor,
                lblSucursalAreaValor,
                lblTipoRutaValor,
                lblDistanciaEstimadaValor);

            objAsignaciones.MostrarPedidosDisponibles(
                idRuta,
                dgvPedidosDisponibles);
            if (!dgvPedidosDisponibles.Columns.Contains("Seleccionar"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();

                chk.Name = "Seleccionar";
                chk.HeaderText = "";
                chk.Width = 35;

                dgvPedidosDisponibles.Columns.Insert(0, chk);
            }
        }

        private void dgvPedidosDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objAsignaciones.AsignarPedidosSeleccionados(
        dgvPedidosDisponibles,
        dgvPedidosAsignados);

            objAsignaciones.ActualizarResumen(
     dgvPedidosAsignados,
     lblTotalPedidosValor,
     lblPesoTotalValor,
     lblParadasBottomValor,
     lblTiempoEstimadoBottomValor,
     lblDistanciaTotalValor,
     Convert.ToDecimal(lblDistanciaEstimadaValor.Text.Replace(" km", "")),
     lblPedidosAsignadosValor,
     lblParadasValor,
     lblTiempoEstimadoValor);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objAsignaciones.LimpiarAsignacion(
                dgvPedidosDisponibles,
                dgvPedidosAsignados);

            objAsignaciones.ActualizarResumen(
    dgvPedidosAsignados,
    lblTotalPedidosValor,
    lblPesoTotalValor,
    lblParadasBottomValor,
    lblTiempoEstimadoBottomValor,
    lblDistanciaTotalValor,
    Convert.ToDecimal(lblDistanciaEstimadaValor.Text.Replace(" km", "")),
    lblPedidosAsignadosValor,
    lblParadasValor,
    lblTiempoEstimadoValor);
        }

        private void btnConfirmarAsignacion_Click(object sender, EventArgs e)
        {
            objAsignaciones.GuardarAsignacion(
                Convert.ToInt32(cboRuta.SelectedValue),
                Convert.ToInt32(cboVehiculo.SelectedValue),
                Convert.ToInt32(cboRepartidor.SelectedValue),
                dtpFecha.Value,
                txtObservaciones.Text,
                dgvPedidosAsignados);

            MessageBox.Show("Asignación registrada correctamente.");

            cboRuta.SelectedIndex = -1;
            cboRepartidor.SelectedIndex = -1;
            cboVehiculo.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;

            dtpFecha.Value = DateTime.Today;
            dtpHoraInicio.Value = DateTime.Now;

            txtObservaciones.Clear();

            dgvPedidosDisponibles.DataSource = null;
            dgvPedidosAsignados.DataSource = null;

            lblBodegaOrigenValor.Text = "";
            lblSucursalAreaValor.Text = "";
            lblTipoRutaValor.Text = "";
            lblDistanciaEstimadaValor.Text = "";

            lblPedidosAsignadosValor.Text = "0";
            lblParadasValor.Text = "0";
            lblDistanciaTotalValor.Text = "0.00 km";
            lblTiempoEstimadoValor.Text = "00:00";

            lblTotalPedidosValor.Text = "0";
            lblPesoTotalValor.Text = "0.00 kg";
            lblParadasBottomValor.Text = "0";
            lblTiempoEstimadoBottomValor.Text = "00:00";
        }

        private void lblDistanciaTotalValor_Click(object sender, EventArgs e)
        {

        }

        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTipoRutaValor_Click(object sender, EventArgs e)
        {

        }


        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            cboRuta.SelectedIndex = -1;
            cboRepartidor.SelectedIndex = -1;
            cboVehiculo.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;

            dtpFecha.Value = DateTime.Today;
            dtpHoraInicio.Value = DateTime.Now;

            txtObservaciones.Clear();

            dgvPedidosDisponibles.DataSource = null;
            dgvPedidosAsignados.DataSource = null;

            lblBodegaOrigenValor.Text = "";
            lblSucursalAreaValor.Text = "";
            lblTipoRutaValor.Text = "";
            lblDistanciaEstimadaValor.Text = "";

            lblPedidosAsignadosValor.Text = "0";
            lblParadasValor.Text = "0";
            lblDistanciaTotalValor.Text = "0.00 km";
            lblTiempoEstimadoValor.Text = "00:00";

            lblTotalPedidosValor.Text = "0";
            lblPesoTotalValor.Text = "0.00 kg";
            lblParadasBottomValor.Text = "0";
            lblTiempoEstimadoBottomValor.Text = "00:00";

            cboRuta.Focus();
        }

        private void txtBuscarPedido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
   
