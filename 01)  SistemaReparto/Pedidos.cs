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
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            objetoPedidos.MostrarPedidos(dgvPedidos);

            objetoPedidos.LlenarComboCliente(cboCliente);
            objetoPedidos.LlenarComboRuta(cboRuta);
            objetoPedidos.LlenarComboEstadoPedido(cboEstadoPedido);
            EstablecerModoConsulta();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objetoPedidos.GuardarPedido(
                TxtCodigoPedido,
                cboCliente,
                cboRuta,
                cboEstadoPedido,
                dateTimePedido,
                textDireccionOrigen,
                TxtDireccionDestino,
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
                cboRuta,
                cboEstadoPedido,
                dateTimePedido,
                textDireccionOrigen,
                TxtDireccionDestino,
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
                "¿Está seguro que desea eliminar este pedido?",
                "Confirmar eliminación",
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

                objetoPedidos.SeleccionarPedido(
                    dgvPedidos,
                    TxtCodigoPedido,
                    cboCliente,
                    cboRuta,
                    cboEstadoPedido,
                    dateTimePedido,
                    textDireccionOrigen,
                    TxtDireccionDestino,
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
            cboRuta.Enabled = habilitado;
            cboEstadoPedido.Enabled = habilitado;
            dateTimePedido.Enabled = habilitado;
            textDireccionOrigen.Enabled = habilitado;
            TxtDireccionDestino.Enabled = habilitado;
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
                cboRuta,
                cboEstadoPedido,
                dateTimePedido,
                textDireccionOrigen,
                TxtDireccionDestino,
                txtPesoTotal,
                TxtCantidadPaquetes,
                TxtObservaciones);
        }

        /// al seleccionar una columna de la tabla se mantienen los campos bloqueados 
        /// Con el fin de evitar acciones erroneas o accidentales
        private void EstablecerModoConsulta()
        {
            idPedidoSeleccionado = 0;
            EstablecerCamposHabilitados(false);
        }
    }
}