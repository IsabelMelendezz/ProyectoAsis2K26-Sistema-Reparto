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

namespace SistemaReparto
{
    public partial class Paquetes : Form
    {
        CPaquetes objetoPaquetes = new CPaquetes();

        private int idPaqueteSeleccionado = 0;

        public Paquetes()
        {
            InitializeComponent();

            dgvPaquetes.AutoGenerateColumns = true;
        }


        private void Paquetes_Load(object sender, EventArgs e)
        {
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
