//Lourdes Isabel Melendez Pineda 
//9959-23-1379


using SistemaReparto.Clases;
using System;
using System.Windows.Forms;

namespace SistemaReparto
{
    public partial class Pedidos : Form
    {
        private CPedidos objetoPedidos = new CPedidos();
        private int idPedidoSeleccionado = 0;

        public Pedidos()
        {
            InitializeComponent();

            dgvPedidos.AutoGenerateColumns = true;

            this.Load -= Pedidos_Load;
            this.Load += Pedidos_Load;

            this.dgvPedidos.CellClick -= dgvPedidos_CellClick;
            this.dgvPedidos.CellClick += dgvPedidos_CellClick;

            this.btnGuardar.Click -= btnGuardar_Click;
            this.btnGuardar.Click += btnGuardar_Click;

            this.btnEditar.Click -= btnEditar_Click;
            this.btnEditar.Click += btnEditar_Click;

            this.btnEliminar.Click -= btnEliminar_Click;
            this.btnEliminar.Click += btnEliminar_Click;

            this.btnActualizar.Click -= btnActualizar_Click;
            this.btnActualizar.Click += btnActualizar_Click;

            this.btnNuevoPaquete.Click -= btnNuevoPaquete_Click;
            this.btnNuevoPaquete.Click += btnNuevoPaquete_Click;

            this.btnLimpiar.Click -= btnLimpiar_Click;
            this.btnLimpiar.Click += btnLimpiar_Click;

            this.btnBuscar.Click -= btnBuscar_Click;
            this.btnBuscar.Click += btnBuscar_Click;

            this.btnMostrarTodos.Click -= btnMostrarTodos_Click;
            this.btnMostrarTodos.Click += btnMostrarTodos_Click;

            this.comboBoxDepartamentoOrigen.SelectedIndexChanged -= comboBoxDepartamentoOrigen_SelectedIndexChanged;
            this.comboBoxDepartamentoOrigen.SelectedIndexChanged += comboBoxDepartamentoOrigen_SelectedIndexChanged;

            this.comboBoxMunicipioOrigen.SelectedIndexChanged -= comboBoxMunicipioOrigen_SelectedIndexChanged;
            this.comboBoxMunicipioOrigen.SelectedIndexChanged += comboBoxMunicipioOrigen_SelectedIndexChanged;

            this.comboBoxDepartamentoDestino.SelectedIndexChanged -= comboBoxDepartamentoDestino_SelectedIndexChanged;
            this.comboBoxDepartamentoDestino.SelectedIndexChanged += comboBoxDepartamentoDestino_SelectedIndexChanged;

            this.comboBoxMunicipioDestino.SelectedIndexChanged -= comboBoxMunicipioDestino_SelectedIndexChanged;
            this.comboBoxMunicipioDestino.SelectedIndexChanged += comboBoxMunicipioDestino_SelectedIndexChanged;
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            objetoPedidos.MostrarPedidos(dgvPedidos);

            objetoPedidos.LlenarComboCliente(cboCliente);
            objetoPedidos.LlenarComboEstadoPedido(cboEstadoPedido);

       //esto ya sale solo como un label informativo para evitar inconsistencias

            lblRuta.Text = "Sin ruta asignada";

            objetoPedidos.LlenarComboDepartamento(comboBoxDepartamentoOrigen);
            objetoPedidos.LlenarComboDepartamento(comboBoxDepartamentoDestino);

            EstablecerModoConsulta();
        }

        private void comboBoxDepartamentoOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            objetoPedidos.LlenarComboMunicipio(comboBoxMunicipioOrigen, comboBoxDepartamentoOrigen.Text);
            comboBoxZonaOrigen.Items.Clear();
            comboBoxZonaOrigen.Text = string.Empty;
        }

        private void comboBoxMunicipioOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            objetoPedidos.LlenarComboZona(comboBoxZonaOrigen, comboBoxDepartamentoOrigen.Text, comboBoxMunicipioOrigen.Text);
        }

        private void comboBoxDepartamentoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            objetoPedidos.LlenarComboMunicipio(comboBoxMunicipioDestino, comboBoxDepartamentoDestino.Text);
            comboBoxZonaDestino.Items.Clear();
            comboBoxZonaDestino.Text = string.Empty;
        }

        private void comboBoxMunicipioDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            objetoPedidos.LlenarComboZona(comboBoxZonaDestino, comboBoxDepartamentoDestino.Text, comboBoxMunicipioDestino.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
    
            objetoPedidos.GuardarPedido(
                TxtCodigoPedido,
                cboCliente,
                cboEstadoPedido,
                dateTimePedido,
                comboBoxDepartamentoOrigen,
                comboBoxMunicipioOrigen,
                comboBoxZonaOrigen,
                TextBoxDireccionOrigen,
                comboBoxDepartamentoDestino,
                comboBoxMunicipioDestino,
                comboBoxZonaDestino,
                TextBoxDireccionDestino,
                txtPesoTotal,
                TxtCantidadPaquetes,
                TxtObservaciones);

            objetoPedidos.MostrarPedidos(dgvPedidos);

            LimpiarFormulario();
            EstablecerModoConsulta();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idPedidoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un pedido de la tabla para editarlo.");
                return;
            }

            EstablecerCamposHabilitados(true);
            TxtCodigoPedido.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idPedidoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un pedido y presione Editar antes de actualizar.");
                return;
            }

            objetoPedidos.ModificarPedido(
                idPedidoSeleccionado,
                TxtCodigoPedido,
                cboCliente,
                cboEstadoPedido,
                dateTimePedido,
                comboBoxDepartamentoOrigen,
                comboBoxMunicipioOrigen,
                comboBoxZonaOrigen,
                TextBoxDireccionOrigen,
                comboBoxDepartamentoDestino,
                comboBoxMunicipioDestino,
                comboBoxZonaDestino,
                TextBoxDireccionDestino,
                txtPesoTotal,
                TxtCantidadPaquetes,
                TxtObservaciones);

            objetoPedidos.MostrarPedidos(dgvPedidos);

            EstablecerModoConsulta();
        }

        private void btnNuevoPaquete_Click(object sender, EventArgs e)
        {
            idPedidoSeleccionado = 0;

            dgvPedidos.ClearSelection();

            LimpiarFormulario();
            EstablecerCamposHabilitados(true);

            TxtCodigoPedido.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idPedidoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un pedido de la tabla para eliminarlo.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "Esta seguro que desea eliminar este pedido?",
                "Confirmar eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            objetoPedidos.EliminarPedido(idPedidoSeleccionado);

            objetoPedidos.MostrarPedidos(dgvPedidos);

            LimpiarFormulario();
            EstablecerModoConsulta();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objetoPedidos.BuscarPedido(txtBuscar.Text, dgvPedidos);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            objetoPedidos.MostrarPedidos(dgvPedidos);
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idPedidoSeleccionado = Convert.ToInt32(
                    dgvPedidos.CurrentRow.Cells["id_pedido"].Value);

                // lblRuta se llena aqui como texto informativo
                // La reasignacion de ruta se hace unicamente desde
                // "Asignacion de Pedidos a Ruta".
                objetoPedidos.SeleccionarPedido(
                    dgvPedidos,
                    TxtCodigoPedido,
                    cboCliente,
                    lblRuta,
                    cboEstadoPedido,
                    dateTimePedido,
                    comboBoxDepartamentoOrigen,
                    comboBoxMunicipioOrigen,
                    comboBoxZonaOrigen,
                    TextBoxDireccionOrigen,
                    comboBoxDepartamentoDestino,
                    comboBoxMunicipioDestino,
                    comboBoxZonaDestino,
                    TextBoxDireccionDestino,
                    txtPesoTotal,
                    TxtCantidadPaquetes,
                    TxtObservaciones);

                //Funcion para habilitar los campos al editar 
                EstablecerCamposHabilitados(false);
            }
        }


        private void EstablecerCamposHabilitados(bool habilitado)
        {
            TxtCodigoPedido.Enabled = habilitado;
            cboCliente.Enabled = habilitado;
            
            // lblRuta no se habilita/deshabilita: es un Label de solo lectura, esto para que luego 
            //no genere inconsistencias con nuestro transaccional solo va ser como un control para ver sus rutas 
            //sin asignarla porque eso ya lo ve el transaccional :) 

            cboEstadoPedido.Enabled = habilitado;
            dateTimePedido.Enabled = habilitado;
            comboBoxDepartamentoOrigen.Enabled = habilitado;
            comboBoxMunicipioOrigen.Enabled = habilitado;
            comboBoxZonaOrigen.Enabled = habilitado;
            TextBoxDireccionOrigen.Enabled = habilitado;
            comboBoxDepartamentoDestino.Enabled = habilitado;
            comboBoxMunicipioDestino.Enabled = habilitado;
            comboBoxZonaDestino.Enabled = habilitado;
            TextBoxDireccionDestino.Enabled = habilitado;
            txtPesoTotal.Enabled = habilitado;
            TxtCantidadPaquetes.Enabled = habilitado;
            TxtObservaciones.Enabled = habilitado;
        }

        //funcion para limpiar los campos 

        private void LimpiarFormulario()
        {
            objetoPedidos.LimpiarCampos(
                TxtCodigoPedido,
                cboCliente,
                lblRuta,
                cboEstadoPedido,
                dateTimePedido,
                comboBoxDepartamentoOrigen,
                comboBoxMunicipioOrigen,
                comboBoxZonaOrigen,
                TextBoxDireccionOrigen,
                comboBoxDepartamentoDestino,
                comboBoxMunicipioDestino,
                comboBoxZonaDestino,
                TextBoxDireccionDestino,
                txtPesoTotal,
                TxtCantidadPaquetes,
                TxtObservaciones);
        }

        private void EstablecerModoConsulta()
        {
            idPedidoSeleccionado = 0;
            EstablecerCamposHabilitados(false);
        }

        private void cboEstadoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}