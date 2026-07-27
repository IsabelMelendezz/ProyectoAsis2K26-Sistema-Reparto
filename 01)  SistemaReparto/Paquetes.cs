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


            cboTipoPaquete.Enabled = false;
            cboEstado.Enabled = false;
            cboTipoFiltro.Enabled = false;
            cboEstadoFiltro.Enabled = false;
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
                cboFragil);

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
                    cboFragil);

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
            txtCodigoRastreo);

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
            txtCodigoRastreo);
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
            objetoPaquetes.MostrarRutaPedido(
                cboPedido,
                cboRuta);
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
                    cboFragil);

                objetoPaquetes.MostrarRutaPedido(
                    cboPedido,
                    cboRuta);
            }
        }
    }
}
