namespace SistemaReparto
{
    partial class Asignaciones
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpInfoRuta = new GroupBox();
            lblRuta = new Label();
            cboRuta = new ComboBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblRepartidor = new Label();
            cboRepartidor = new ComboBox();
            lblHoraInicio = new Label();
            dtpHoraInicio = new DateTimePicker();
            lblVehiculo = new Label();
            cboVehiculo = new ComboBox();
            lblEstado = new Label();
            cboEstado = new ComboBox();
            grpInfoOrigen = new GroupBox();
            lblBodegaOrigenTitulo = new Label();
            lblBodegaOrigenValor = new Label();
            lblSucursalAreaTitulo = new Label();
            lblSucursalAreaValor = new Label();
            lblTipoRutaTitulo = new Label();
            lblTipoRutaValor = new Label();
            lblDistanciaEstimadaTitulo = new Label();
            lblDistanciaEstimadaValor = new Label();
            grpResumenRuta = new GroupBox();
            lblIconPedidos = new Label();
            lblPedidosAsignadosTitulo = new Label();
            lblPedidosAsignadosValor = new Label();
            lblIconParadas = new Label();
            lblParadasTitulo = new Label();
            lblParadasValor = new Label();
            lblIconDistancia = new Label();
            lblDistanciaTotalTitulo = new Label();
            lblDistanciaTotalValor = new Label();
            lblIconTiempo = new Label();
            lblTiempoEstimadoTitulo = new Label();
            lblTiempoEstimadoValor = new Label();
            grpPedidosDisponibles = new GroupBox();
            txtBuscarPedido = new TextBox();
            btnBuscarPedido = new Button();
            dgvPedidosDisponibles = new DataGridView();
            colDispCheck = new DataGridViewCheckBoxColumn();
            colDispPedido = new DataGridViewTextBoxColumn();
            colDispCliente = new DataGridViewTextBoxColumn();
            colDispDireccion = new DataGridViewTextBoxColumn();
            colDispArea = new DataGridViewTextBoxColumn();
            colDispPeso = new DataGridViewTextBoxColumn();
            pnlBotonesAccion = new Panel();
            btnAgregar = new Button();
            btnQuitar = new Button();
            btnLimpiar = new Button();
            grpPedidosAsignados = new GroupBox();
            dgvPedidosAsignados = new DataGridView();
            colAsigOrden = new DataGridViewTextBoxColumn();
            colAsigPedido = new DataGridViewTextBoxColumn();
            colAsigCliente = new DataGridViewTextBoxColumn();
            colAsigDireccion = new DataGridViewTextBoxColumn();
            colAsigEstado = new DataGridViewTextBoxColumn();
            colAsigPeso = new DataGridViewTextBoxColumn();
            colAsigAcciones = new DataGridViewButtonColumn();
            lblTotalPedidosTitulo = new Label();
            lblTotalPedidosValor = new Label();
            lblPesoTotalTitulo = new Label();
            lblPesoTotalValor = new Label();
            lblParadasBottomTitulo = new Label();
            lblParadasBottomValor = new Label();
            lblTiempoEstimadoBottomTitulo = new Label();
            lblTiempoEstimadoBottomValor = new Label();
            grpObservaciones = new GroupBox();
            txtObservaciones = new TextBox();
            grpAcciones = new GroupBox();
            btnConfirmarAsignacion = new Button();
            btnGuardarComoPlan = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            picLogo = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            grpInfoRuta.SuspendLayout();
            grpInfoOrigen.SuspendLayout();
            grpResumenRuta.SuspendLayout();
            grpPedidosDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosDisponibles).BeginInit();
            pnlBotonesAccion.SuspendLayout();
            grpPedidosAsignados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosAsignados).BeginInit();
            grpObservaciones.SuspendLayout();
            grpAcciones.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // grpInfoRuta
            // 
            grpInfoRuta.Controls.Add(lblRuta);
            grpInfoRuta.Controls.Add(cboRuta);
            grpInfoRuta.Controls.Add(lblFecha);
            grpInfoRuta.Controls.Add(dtpFecha);
            grpInfoRuta.Controls.Add(lblRepartidor);
            grpInfoRuta.Controls.Add(cboRepartidor);
            grpInfoRuta.Controls.Add(lblHoraInicio);
            grpInfoRuta.Controls.Add(dtpHoraInicio);
            grpInfoRuta.Controls.Add(lblVehiculo);
            grpInfoRuta.Controls.Add(cboVehiculo);
            grpInfoRuta.Controls.Add(lblEstado);
            grpInfoRuta.Controls.Add(cboEstado);
            grpInfoRuta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpInfoRuta.ForeColor = Color.FromArgb(30, 41, 59);
            grpInfoRuta.Location = new Point(17, 174);
            grpInfoRuta.Margin = new Padding(3, 4, 3, 4);
            grpInfoRuta.Name = "grpInfoRuta";
            grpInfoRuta.Padding = new Padding(3, 4, 3, 4);
            grpInfoRuta.Size = new Size(418, 198);
            grpInfoRuta.TabIndex = 0;
            grpInfoRuta.TabStop = false;
            grpInfoRuta.Text = "📍 Información de la Ruta";
            // 
            // lblRuta
            // 
            lblRuta.Font = new Font("Segoe UI", 9F);
            lblRuta.Location = new Point(29, 31);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(98, 24);
            lblRuta.TabIndex = 0;
            lblRuta.Text = "Ruta";
            // 
            // cboRuta
            // 
            cboRuta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRuta.Font = new Font("Segoe UI", 9F);
            cboRuta.Location = new Point(29, 50);
            cboRuta.Margin = new Padding(3, 4, 3, 4);
            cboRuta.Name = "cboRuta";
            cboRuta.Size = new Size(170, 28);
            cboRuta.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI", 9F);
            lblFecha.Location = new Point(217, 30);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(112, 24);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 9F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(217, 50);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(184, 27);
            dtpFecha.TabIndex = 3;
            // 
            // lblRepartidor
            // 
            lblRepartidor.Font = new Font("Segoe UI", 9F);
            lblRepartidor.Location = new Point(29, 75);
            lblRepartidor.Name = "lblRepartidor";
            lblRepartidor.Size = new Size(98, 24);
            lblRepartidor.TabIndex = 4;
            lblRepartidor.Text = "Repartidor";
            // 
            // cboRepartidor
            // 
            cboRepartidor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRepartidor.Font = new Font("Segoe UI", 9F);
            cboRepartidor.Location = new Point(29, 94);
            cboRepartidor.Margin = new Padding(3, 4, 3, 4);
            cboRepartidor.Name = "cboRepartidor";
            cboRepartidor.Size = new Size(170, 28);
            cboRepartidor.TabIndex = 5;
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.Font = new Font("Segoe UI", 9F);
            lblHoraInicio.Location = new Point(217, 74);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(129, 24);
            lblHoraInicio.TabIndex = 6;
            lblHoraInicio.Text = "Hora inicio";
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.Font = new Font("Segoe UI", 9F);
            dtpHoraInicio.Format = DateTimePickerFormat.Time;
            dtpHoraInicio.Location = new Point(217, 93);
            dtpHoraInicio.Margin = new Padding(3, 4, 3, 4);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Size = new Size(184, 27);
            dtpHoraInicio.TabIndex = 7;
            // 
            // lblVehiculo
            // 
            lblVehiculo.Font = new Font("Segoe UI", 9F);
            lblVehiculo.Location = new Point(29, 118);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new Size(114, 24);
            lblVehiculo.TabIndex = 8;
            lblVehiculo.Text = "Vehículo";
            // 
            // cboVehiculo
            // 
            cboVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVehiculo.Font = new Font("Segoe UI", 9F);
            cboVehiculo.Location = new Point(29, 136);
            cboVehiculo.Margin = new Padding(3, 4, 3, 4);
            cboVehiculo.Name = "cboVehiculo";
            cboVehiculo.Size = new Size(170, 28);
            cboVehiculo.TabIndex = 9;
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Segoe UI", 9F);
            lblEstado.Location = new Point(217, 117);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(112, 24);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Font = new Font("Segoe UI", 9F);
            cboEstado.ForeColor = Color.FromArgb(37, 99, 235);
            cboEstado.Location = new Point(217, 135);
            cboEstado.Margin = new Padding(3, 4, 3, 4);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(184, 28);
            cboEstado.TabIndex = 11;
            // 
            // grpInfoOrigen
            // 
            grpInfoOrigen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpInfoOrigen.Controls.Add(lblBodegaOrigenTitulo);
            grpInfoOrigen.Controls.Add(lblBodegaOrigenValor);
            grpInfoOrigen.Controls.Add(lblSucursalAreaTitulo);
            grpInfoOrigen.Controls.Add(lblSucursalAreaValor);
            grpInfoOrigen.Controls.Add(lblTipoRutaTitulo);
            grpInfoOrigen.Controls.Add(lblTipoRutaValor);
            grpInfoOrigen.Controls.Add(lblDistanciaEstimadaTitulo);
            grpInfoOrigen.Controls.Add(lblDistanciaEstimadaValor);
            grpInfoOrigen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpInfoOrigen.ForeColor = Color.FromArgb(30, 41, 59);
            grpInfoOrigen.Location = new Point(442, 175);
            grpInfoOrigen.Margin = new Padding(3, 4, 3, 4);
            grpInfoOrigen.Name = "grpInfoOrigen";
            grpInfoOrigen.Padding = new Padding(3, 4, 3, 4);
            grpInfoOrigen.Size = new Size(419, 198);
            grpInfoOrigen.TabIndex = 1;
            grpInfoOrigen.TabStop = false;
            grpInfoOrigen.Text = "🏢 Información de Origen";
            // 
            // lblBodegaOrigenTitulo
            // 
            lblBodegaOrigenTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBodegaOrigenTitulo.Location = new Point(17, 46);
            lblBodegaOrigenTitulo.Name = "lblBodegaOrigenTitulo";
            lblBodegaOrigenTitulo.Size = new Size(194, 26);
            lblBodegaOrigenTitulo.TabIndex = 0;
            lblBodegaOrigenTitulo.Text = "Bodega de Origen";
            // 
            // lblBodegaOrigenValor
            // 
            lblBodegaOrigenValor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBodegaOrigenValor.Font = new Font("Segoe UI", 9F);
            lblBodegaOrigenValor.Location = new Point(207, 46);
            lblBodegaOrigenValor.Name = "lblBodegaOrigenValor";
            lblBodegaOrigenValor.Size = new Size(174, 26);
            lblBodegaOrigenValor.TabIndex = 1;
            lblBodegaOrigenValor.Text = "Bodega Central";
            lblBodegaOrigenValor.Click += lblBodegaOrigenValor_Click;
            // 
            // lblSucursalAreaTitulo
            // 
            lblSucursalAreaTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSucursalAreaTitulo.Location = new Point(17, 71);
            lblSucursalAreaTitulo.Name = "lblSucursalAreaTitulo";
            lblSucursalAreaTitulo.Size = new Size(194, 26);
            lblSucursalAreaTitulo.TabIndex = 2;
            lblSucursalAreaTitulo.Text = "Sucursal / Área";
            // 
            // lblSucursalAreaValor
            // 
            lblSucursalAreaValor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSucursalAreaValor.Font = new Font("Segoe UI", 9F);
            lblSucursalAreaValor.Location = new Point(207, 71);
            lblSucursalAreaValor.Name = "lblSucursalAreaValor";
            lblSucursalAreaValor.Size = new Size(174, 26);
            lblSucursalAreaValor.TabIndex = 3;
            lblSucursalAreaValor.Text = "Zona 1 Centro";
            // 
            // lblTipoRutaTitulo
            // 
            lblTipoRutaTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTipoRutaTitulo.Location = new Point(17, 106);
            lblTipoRutaTitulo.Name = "lblTipoRutaTitulo";
            lblTipoRutaTitulo.Size = new Size(194, 26);
            lblTipoRutaTitulo.TabIndex = 4;
            lblTipoRutaTitulo.Text = "Tipo de Ruta";
            // 
            // lblTipoRutaValor
            // 
            lblTipoRutaValor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTipoRutaValor.Font = new Font("Segoe UI", 9F);
            lblTipoRutaValor.Location = new Point(207, 106);
            lblTipoRutaValor.Name = "lblTipoRutaValor";
            lblTipoRutaValor.Size = new Size(174, 26);
            lblTipoRutaValor.TabIndex = 5;
            lblTipoRutaValor.Text = "Urbana";
            // 
            // lblDistanciaEstimadaTitulo
            // 
            lblDistanciaEstimadaTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDistanciaEstimadaTitulo.Location = new Point(17, 138);
            lblDistanciaEstimadaTitulo.Name = "lblDistanciaEstimadaTitulo";
            lblDistanciaEstimadaTitulo.Size = new Size(194, 26);
            lblDistanciaEstimadaTitulo.TabIndex = 6;
            lblDistanciaEstimadaTitulo.Text = "Distancia Total Estimada";
            // 
            // lblDistanciaEstimadaValor
            // 
            lblDistanciaEstimadaValor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDistanciaEstimadaValor.Font = new Font("Segoe UI", 9F);
            lblDistanciaEstimadaValor.Location = new Point(207, 138);
            lblDistanciaEstimadaValor.Name = "lblDistanciaEstimadaValor";
            lblDistanciaEstimadaValor.Size = new Size(174, 26);
            lblDistanciaEstimadaValor.TabIndex = 7;
            lblDistanciaEstimadaValor.Text = "15.50 km";
            // 
            // grpResumenRuta
            // 
            grpResumenRuta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpResumenRuta.Controls.Add(lblIconPedidos);
            grpResumenRuta.Controls.Add(lblPedidosAsignadosTitulo);
            grpResumenRuta.Controls.Add(lblPedidosAsignadosValor);
            grpResumenRuta.Controls.Add(lblIconParadas);
            grpResumenRuta.Controls.Add(lblParadasTitulo);
            grpResumenRuta.Controls.Add(lblParadasValor);
            grpResumenRuta.Controls.Add(lblIconDistancia);
            grpResumenRuta.Controls.Add(lblDistanciaTotalTitulo);
            grpResumenRuta.Controls.Add(lblDistanciaTotalValor);
            grpResumenRuta.Controls.Add(lblIconTiempo);
            grpResumenRuta.Controls.Add(lblTiempoEstimadoTitulo);
            grpResumenRuta.Controls.Add(lblTiempoEstimadoValor);
            grpResumenRuta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpResumenRuta.ForeColor = Color.FromArgb(30, 41, 59);
            grpResumenRuta.Location = new Point(867, 174);
            grpResumenRuta.Margin = new Padding(3, 4, 3, 4);
            grpResumenRuta.Name = "grpResumenRuta";
            grpResumenRuta.Padding = new Padding(3, 4, 3, 4);
            grpResumenRuta.Size = new Size(304, 199);
            grpResumenRuta.TabIndex = 2;
            grpResumenRuta.TabStop = false;
            grpResumenRuta.Text = "🔀 Resumen de la Ruta";
            // 
            // lblIconPedidos
            // 
            lblIconPedidos.Font = new Font("Segoe UI", 14F);
            lblIconPedidos.Location = new Point(17, 38);
            lblIconPedidos.Name = "lblIconPedidos";
            lblIconPedidos.Size = new Size(34, 40);
            lblIconPedidos.TabIndex = 0;
            lblIconPedidos.Text = "📋";
            // 
            // lblPedidosAsignadosTitulo
            // 
            lblPedidosAsignadosTitulo.Font = new Font("Segoe UI", 9F);
            lblPedidosAsignadosTitulo.Location = new Point(57, 38);
            lblPedidosAsignadosTitulo.Name = "lblPedidosAsignadosTitulo";
            lblPedidosAsignadosTitulo.Size = new Size(135, 24);
            lblPedidosAsignadosTitulo.TabIndex = 1;
            lblPedidosAsignadosTitulo.Text = "Pedidos Asignados";
            // 
            // lblPedidosAsignadosValor
            // 
            lblPedidosAsignadosValor.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPedidosAsignadosValor.ForeColor = Color.FromArgb(37, 99, 235);
            lblPedidosAsignadosValor.Location = new Point(198, 34);
            lblPedidosAsignadosValor.Name = "lblPedidosAsignadosValor";
            lblPedidosAsignadosValor.Size = new Size(72, 34);
            lblPedidosAsignadosValor.TabIndex = 2;
            lblPedidosAsignadosValor.Text = "4";
            // 
            // lblIconParadas
            // 
            lblIconParadas.Font = new Font("Segoe UI", 14F);
            lblIconParadas.Location = new Point(17, 75);
            lblIconParadas.Name = "lblIconParadas";
            lblIconParadas.Size = new Size(34, 40);
            lblIconParadas.TabIndex = 3;
            lblIconParadas.Text = "📍";
            // 
            // lblParadasTitulo
            // 
            lblParadasTitulo.Font = new Font("Segoe UI", 9F);
            lblParadasTitulo.Location = new Point(58, 80);
            lblParadasTitulo.Name = "lblParadasTitulo";
            lblParadasTitulo.Size = new Size(70, 24);
            lblParadasTitulo.TabIndex = 4;
            lblParadasTitulo.Text = "Paradas";
            // 
            // lblParadasValor
            // 
            lblParadasValor.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblParadasValor.ForeColor = Color.FromArgb(37, 99, 235);
            lblParadasValor.Location = new Point(198, 73);
            lblParadasValor.Name = "lblParadasValor";
            lblParadasValor.Size = new Size(92, 34);
            lblParadasValor.TabIndex = 5;
            lblParadasValor.Text = "4";
            // 
            // lblIconDistancia
            // 
            lblIconDistancia.Font = new Font("Segoe UI", 14F);
            lblIconDistancia.Location = new Point(15, 118);
            lblIconDistancia.Name = "lblIconDistancia";
            lblIconDistancia.Size = new Size(34, 40);
            lblIconDistancia.TabIndex = 6;
            lblIconDistancia.Text = "🛣";
            // 
            // lblDistanciaTotalTitulo
            // 
            lblDistanciaTotalTitulo.Font = new Font("Segoe UI", 9F);
            lblDistanciaTotalTitulo.Location = new Point(55, 122);
            lblDistanciaTotalTitulo.Name = "lblDistanciaTotalTitulo";
            lblDistanciaTotalTitulo.Size = new Size(107, 24);
            lblDistanciaTotalTitulo.TabIndex = 7;
            lblDistanciaTotalTitulo.Text = "Distancia Total";
            // 
            // lblDistanciaTotalValor
            // 
            lblDistanciaTotalValor.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDistanciaTotalValor.ForeColor = Color.FromArgb(37, 99, 235);
            lblDistanciaTotalValor.Location = new Point(186, 114);
            lblDistanciaTotalValor.Name = "lblDistanciaTotalValor";
            lblDistanciaTotalValor.Size = new Size(121, 34);
            lblDistanciaTotalValor.TabIndex = 8;
            lblDistanciaTotalValor.Text = "15.50 km";
            // 
            // lblIconTiempo
            // 
            lblIconTiempo.Font = new Font("Segoe UI", 14F);
            lblIconTiempo.Location = new Point(18, 158);
            lblIconTiempo.Name = "lblIconTiempo";
            lblIconTiempo.Size = new Size(34, 40);
            lblIconTiempo.TabIndex = 9;
            lblIconTiempo.Text = "🕒";
            // 
            // lblTiempoEstimadoTitulo
            // 
            lblTiempoEstimadoTitulo.Font = new Font("Segoe UI", 9F);
            lblTiempoEstimadoTitulo.Location = new Point(55, 165);
            lblTiempoEstimadoTitulo.Name = "lblTiempoEstimadoTitulo";
            lblTiempoEstimadoTitulo.Size = new Size(124, 24);
            lblTiempoEstimadoTitulo.TabIndex = 10;
            lblTiempoEstimadoTitulo.Text = "Tiempo Estimado";
            // 
            // lblTiempoEstimadoValor
            // 
            lblTiempoEstimadoValor.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTiempoEstimadoValor.ForeColor = Color.FromArgb(37, 99, 235);
            lblTiempoEstimadoValor.Location = new Point(186, 159);
            lblTiempoEstimadoValor.Name = "lblTiempoEstimadoValor";
            lblTiempoEstimadoValor.Size = new Size(121, 34);
            lblTiempoEstimadoValor.TabIndex = 11;
            lblTiempoEstimadoValor.Text = "3h 20m";
            // 
            // grpPedidosDisponibles
            // 
            grpPedidosDisponibles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpPedidosDisponibles.Controls.Add(txtBuscarPedido);
            grpPedidosDisponibles.Controls.Add(btnBuscarPedido);
            grpPedidosDisponibles.Controls.Add(dgvPedidosDisponibles);
            grpPedidosDisponibles.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPedidosDisponibles.ForeColor = Color.FromArgb(30, 41, 59);
            grpPedidosDisponibles.Location = new Point(13, 374);
            grpPedidosDisponibles.Margin = new Padding(3, 4, 3, 4);
            grpPedidosDisponibles.Name = "grpPedidosDisponibles";
            grpPedidosDisponibles.Padding = new Padding(3, 4, 3, 4);
            grpPedidosDisponibles.Size = new Size(466, 254);
            grpPedidosDisponibles.TabIndex = 3;
            grpPedidosDisponibles.TabStop = false;
            grpPedidosDisponibles.Text = "🚚 Pedidos Disponibles";
            // 
            // txtBuscarPedido
            // 
            txtBuscarPedido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarPedido.Font = new Font("Segoe UI", 9F);
            txtBuscarPedido.Location = new Point(17, 40);
            txtBuscarPedido.Margin = new Padding(3, 4, 3, 4);
            txtBuscarPedido.Name = "txtBuscarPedido";
            txtBuscarPedido.PlaceholderText = "Buscar pedido o cliente...";
            txtBuscarPedido.Size = new Size(385, 27);
            txtBuscarPedido.TabIndex = 0;
            // 
            // btnBuscarPedido
            // 
            btnBuscarPedido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarPedido.Font = new Font("Segoe UI", 9F);
            btnBuscarPedido.Location = new Point(408, 40);
            btnBuscarPedido.Margin = new Padding(3, 4, 3, 4);
            btnBuscarPedido.Name = "btnBuscarPedido";
            btnBuscarPedido.Size = new Size(34, 34);
            btnBuscarPedido.TabIndex = 1;
            btnBuscarPedido.Text = "🔍";
            btnBuscarPedido.UseVisualStyleBackColor = true;
            // 
            // dgvPedidosDisponibles
            // 
            dgvPedidosDisponibles.AllowUserToAddRows = false;
            dgvPedidosDisponibles.AllowUserToDeleteRows = false;
            dgvPedidosDisponibles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPedidosDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidosDisponibles.BackgroundColor = Color.White;
            dgvPedidosDisponibles.ColumnHeadersHeight = 34;
            dgvPedidosDisponibles.Columns.AddRange(new DataGridViewColumn[] { colDispCheck, colDispPedido, colDispCliente, colDispDireccion, colDispArea, colDispPeso });
            dgvPedidosDisponibles.Location = new Point(13, 83);
            dgvPedidosDisponibles.Margin = new Padding(3, 4, 3, 4);
            dgvPedidosDisponibles.MultiSelect = false;
            dgvPedidosDisponibles.Name = "dgvPedidosDisponibles";
            dgvPedidosDisponibles.RowHeadersVisible = false;
            dgvPedidosDisponibles.RowHeadersWidth = 62;
            dgvPedidosDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidosDisponibles.Size = new Size(430, 147);
            dgvPedidosDisponibles.TabIndex = 2;
            // 
            // colDispCheck
            // 
            colDispCheck.HeaderText = "";
            colDispCheck.MinimumWidth = 8;
            colDispCheck.Name = "colDispCheck";
            // 
            // colDispPedido
            // 
            colDispPedido.HeaderText = "Pedido";
            colDispPedido.MinimumWidth = 8;
            colDispPedido.Name = "colDispPedido";
            colDispPedido.ReadOnly = true;
            // 
            // colDispCliente
            // 
            colDispCliente.HeaderText = "Cliente";
            colDispCliente.MinimumWidth = 8;
            colDispCliente.Name = "colDispCliente";
            colDispCliente.ReadOnly = true;
            // 
            // colDispDireccion
            // 
            colDispDireccion.HeaderText = "Dirección";
            colDispDireccion.MinimumWidth = 8;
            colDispDireccion.Name = "colDispDireccion";
            colDispDireccion.ReadOnly = true;
            // 
            // colDispArea
            // 
            colDispArea.HeaderText = "Área";
            colDispArea.MinimumWidth = 8;
            colDispArea.Name = "colDispArea";
            colDispArea.ReadOnly = true;
            // 
            // colDispPeso
            // 
            colDispPeso.HeaderText = "Peso (kg)";
            colDispPeso.MinimumWidth = 8;
            colDispPeso.Name = "colDispPeso";
            colDispPeso.ReadOnly = true;
            // 
            // pnlBotonesAccion
            // 
            pnlBotonesAccion.Controls.Add(btnAgregar);
            pnlBotonesAccion.Controls.Add(btnQuitar);
            pnlBotonesAccion.Controls.Add(btnLimpiar);
            pnlBotonesAccion.Location = new Point(485, 386);
            pnlBotonesAccion.Margin = new Padding(3, 4, 3, 4);
            pnlBotonesAccion.Name = "pnlBotonesAccion";
            pnlBotonesAccion.Size = new Size(103, 213);
            pnlBotonesAccion.TabIndex = 4;
            pnlBotonesAccion.Paint += pnlBotonesAccion_Paint;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(37, 99, 235);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(0, 7);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 60);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "»» Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnQuitar
            // 
            btnQuitar.Font = new Font("Segoe UI", 9F);
            btnQuitar.Location = new Point(0, 70);
            btnQuitar.Margin = new Padding(3, 4, 3, 4);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(103, 60);
            btnQuitar.TabIndex = 1;
            btnQuitar.Text = "«« Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9F);
            btnLimpiar.Location = new Point(0, 134);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(103, 60);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "🔄 Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // grpPedidosAsignados
            // 
            grpPedidosAsignados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpPedidosAsignados.Controls.Add(dgvPedidosAsignados);
            grpPedidosAsignados.Controls.Add(lblTotalPedidosTitulo);
            grpPedidosAsignados.Controls.Add(lblTotalPedidosValor);
            grpPedidosAsignados.Controls.Add(lblPesoTotalTitulo);
            grpPedidosAsignados.Controls.Add(lblPesoTotalValor);
            grpPedidosAsignados.Controls.Add(lblParadasBottomTitulo);
            grpPedidosAsignados.Controls.Add(lblParadasBottomValor);
            grpPedidosAsignados.Controls.Add(lblTiempoEstimadoBottomTitulo);
            grpPedidosAsignados.Controls.Add(lblTiempoEstimadoBottomValor);
            grpPedidosAsignados.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPedidosAsignados.ForeColor = Color.FromArgb(30, 41, 59);
            grpPedidosAsignados.Location = new Point(594, 371);
            grpPedidosAsignados.Margin = new Padding(3, 4, 3, 4);
            grpPedidosAsignados.Name = "grpPedidosAsignados";
            grpPedidosAsignados.Padding = new Padding(3, 4, 3, 4);
            grpPedidosAsignados.Size = new Size(580, 256);
            grpPedidosAsignados.TabIndex = 5;
            grpPedidosAsignados.TabStop = false;
            grpPedidosAsignados.Text = "\U0001f9fe Pedidos Asignados a la Ruta";
            // 
            // dgvPedidosAsignados
            // 
            dgvPedidosAsignados.AllowDrop = true;
            dgvPedidosAsignados.AllowUserToAddRows = false;
            dgvPedidosAsignados.AllowUserToDeleteRows = false;
            dgvPedidosAsignados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPedidosAsignados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidosAsignados.BackgroundColor = Color.White;
            dgvPedidosAsignados.ColumnHeadersHeight = 34;
            dgvPedidosAsignados.Columns.AddRange(new DataGridViewColumn[] { colAsigOrden, colAsigPedido, colAsigCliente, colAsigDireccion, colAsigEstado, colAsigPeso, colAsigAcciones });
            dgvPedidosAsignados.Location = new Point(10, 32);
            dgvPedidosAsignados.Margin = new Padding(3, 4, 3, 4);
            dgvPedidosAsignados.MultiSelect = false;
            dgvPedidosAsignados.Name = "dgvPedidosAsignados";
            dgvPedidosAsignados.RowHeadersVisible = false;
            dgvPedidosAsignados.RowHeadersWidth = 62;
            dgvPedidosAsignados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidosAsignados.Size = new Size(556, 164);
            dgvPedidosAsignados.TabIndex = 0;
            dgvPedidosAsignados.CellContentClick += dgvPedidosAsignados_CellContentClick;
            // 
            // colAsigOrden
            // 
            colAsigOrden.FillWeight = 60F;
            colAsigOrden.HeaderText = "Orden";
            colAsigOrden.MinimumWidth = 8;
            colAsigOrden.Name = "colAsigOrden";
            colAsigOrden.ReadOnly = true;
            // 
            // colAsigPedido
            // 
            colAsigPedido.HeaderText = "Pedido";
            colAsigPedido.MinimumWidth = 8;
            colAsigPedido.Name = "colAsigPedido";
            colAsigPedido.ReadOnly = true;
            // 
            // colAsigCliente
            // 
            colAsigCliente.HeaderText = "Cliente";
            colAsigCliente.MinimumWidth = 8;
            colAsigCliente.Name = "colAsigCliente";
            colAsigCliente.ReadOnly = true;
            // 
            // colAsigDireccion
            // 
            colAsigDireccion.HeaderText = "Dirección";
            colAsigDireccion.MinimumWidth = 8;
            colAsigDireccion.Name = "colAsigDireccion";
            colAsigDireccion.ReadOnly = true;
            // 
            // colAsigEstado
            // 
            colAsigEstado.HeaderText = "Estado";
            colAsigEstado.MinimumWidth = 8;
            colAsigEstado.Name = "colAsigEstado";
            colAsigEstado.ReadOnly = true;
            // 
            // colAsigPeso
            // 
            colAsigPeso.HeaderText = "Peso (kg)";
            colAsigPeso.MinimumWidth = 8;
            colAsigPeso.Name = "colAsigPeso";
            colAsigPeso.ReadOnly = true;
            // 
            // colAsigAcciones
            // 
            colAsigAcciones.FillWeight = 60F;
            colAsigAcciones.HeaderText = "Acciones";
            colAsigAcciones.MinimumWidth = 8;
            colAsigAcciones.Name = "colAsigAcciones";
            colAsigAcciones.Text = "🗑";
            colAsigAcciones.UseColumnTextForButtonValue = true;
            // 
            // lblTotalPedidosTitulo
            // 
            lblTotalPedidosTitulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalPedidosTitulo.Font = new Font("Segoe UI", 9F);
            lblTotalPedidosTitulo.Location = new Point(17, 204);
            lblTotalPedidosTitulo.Name = "lblTotalPedidosTitulo";
            lblTotalPedidosTitulo.Size = new Size(109, 26);
            lblTotalPedidosTitulo.TabIndex = 1;
            lblTotalPedidosTitulo.Text = "Total Pedidos:";
            // 
            // lblTotalPedidosValor
            // 
            lblTotalPedidosValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalPedidosValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalPedidosValor.Location = new Point(32, 224);
            lblTotalPedidosValor.Name = "lblTotalPedidosValor";
            lblTotalPedidosValor.Size = new Size(46, 26);
            lblTotalPedidosValor.TabIndex = 2;
            lblTotalPedidosValor.Text = "4";
            // 
            // lblPesoTotalTitulo
            // 
            lblPesoTotalTitulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPesoTotalTitulo.Font = new Font("Segoe UI", 9F);
            lblPesoTotalTitulo.Location = new Point(146, 204);
            lblPesoTotalTitulo.Name = "lblPesoTotalTitulo";
            lblPesoTotalTitulo.Size = new Size(97, 25);
            lblPesoTotalTitulo.TabIndex = 3;
            lblPesoTotalTitulo.Text = "Peso Total:";
            // 
            // lblPesoTotalValor
            // 
            lblPesoTotalValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPesoTotalValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPesoTotalValor.Location = new Point(152, 224);
            lblPesoTotalValor.Name = "lblPesoTotalValor";
            lblPesoTotalValor.Size = new Size(91, 26);
            lblPesoTotalValor.TabIndex = 4;
            lblPesoTotalValor.Text = "33.80 kg";
            // 
            // lblParadasBottomTitulo
            // 
            lblParadasBottomTitulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblParadasBottomTitulo.Font = new Font("Segoe UI", 9F);
            lblParadasBottomTitulo.Location = new Point(269, 204);
            lblParadasBottomTitulo.Name = "lblParadasBottomTitulo";
            lblParadasBottomTitulo.Size = new Size(80, 26);
            lblParadasBottomTitulo.TabIndex = 5;
            lblParadasBottomTitulo.Text = "Paradas:";
            // 
            // lblParadasBottomValor
            // 
            lblParadasBottomValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblParadasBottomValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblParadasBottomValor.Location = new Point(283, 224);
            lblParadasBottomValor.Name = "lblParadasBottomValor";
            lblParadasBottomValor.Size = new Size(34, 26);
            lblParadasBottomValor.TabIndex = 6;
            lblParadasBottomValor.Text = "4";
            // 
            // lblTiempoEstimadoBottomTitulo
            // 
            lblTiempoEstimadoBottomTitulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTiempoEstimadoBottomTitulo.Font = new Font("Segoe UI", 9F);
            lblTiempoEstimadoBottomTitulo.Location = new Point(340, 203);
            lblTiempoEstimadoBottomTitulo.Name = "lblTiempoEstimadoBottomTitulo";
            lblTiempoEstimadoBottomTitulo.Size = new Size(137, 26);
            lblTiempoEstimadoBottomTitulo.TabIndex = 7;
            lblTiempoEstimadoBottomTitulo.Text = "Tiempo Estimado:";
            // 
            // lblTiempoEstimadoBottomValor
            // 
            lblTiempoEstimadoBottomValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTiempoEstimadoBottomValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTiempoEstimadoBottomValor.Location = new Point(376, 224);
            lblTiempoEstimadoBottomValor.Name = "lblTiempoEstimadoBottomValor";
            lblTiempoEstimadoBottomValor.Size = new Size(69, 26);
            lblTiempoEstimadoBottomValor.TabIndex = 8;
            lblTiempoEstimadoBottomValor.Text = "3h 20m";
            lblTiempoEstimadoBottomValor.Click += lblTiempoEstimadoBottomValor_Click;
            // 
            // grpObservaciones
            // 
            grpObservaciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            grpObservaciones.Controls.Add(txtObservaciones);
            grpObservaciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpObservaciones.ForeColor = Color.FromArgb(30, 41, 59);
            grpObservaciones.Location = new Point(17, 647);
            grpObservaciones.Margin = new Padding(3, 4, 3, 4);
            grpObservaciones.Name = "grpObservaciones";
            grpObservaciones.Padding = new Padding(3, 4, 3, 4);
            grpObservaciones.Size = new Size(666, 187);
            grpObservaciones.TabIndex = 6;
            grpObservaciones.TabStop = false;
            grpObservaciones.Text = "💬 Observaciones de la Asignación";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtObservaciones.Font = new Font("Segoe UI", 9F);
            txtObservaciones.Location = new Point(17, 40);
            txtObservaciones.Margin = new Padding(3, 4, 3, 4);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "Escribe alguna observación adicional (opcional)...";
            txtObservaciones.ScrollBars = ScrollBars.Vertical;
            txtObservaciones.Size = new Size(630, 126);
            txtObservaciones.TabIndex = 0;
            // 
            // grpAcciones
            // 
            grpAcciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpAcciones.Controls.Add(btnConfirmarAsignacion);
            grpAcciones.Controls.Add(btnGuardarComoPlan);
            grpAcciones.Controls.Add(btnCancelar);
            grpAcciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpAcciones.ForeColor = Color.FromArgb(30, 41, 59);
            grpAcciones.Location = new Point(689, 636);
            grpAcciones.Margin = new Padding(3, 4, 3, 4);
            grpAcciones.Name = "grpAcciones";
            grpAcciones.Padding = new Padding(3, 4, 3, 4);
            grpAcciones.Size = new Size(486, 198);
            grpAcciones.TabIndex = 7;
            grpAcciones.TabStop = false;
            grpAcciones.Text = "⚙ Acciones";
            // 
            // btnConfirmarAsignacion
            // 
            btnConfirmarAsignacion.BackColor = Color.FromArgb(37, 99, 235);
            btnConfirmarAsignacion.FlatAppearance.BorderSize = 0;
            btnConfirmarAsignacion.FlatStyle = FlatStyle.Flat;
            btnConfirmarAsignacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfirmarAsignacion.ForeColor = Color.White;
            btnConfirmarAsignacion.Location = new Point(24, 46);
            btnConfirmarAsignacion.Margin = new Padding(3, 4, 3, 4);
            btnConfirmarAsignacion.Name = "btnConfirmarAsignacion";
            btnConfirmarAsignacion.Size = new Size(164, 60);
            btnConfirmarAsignacion.TabIndex = 0;
            btnConfirmarAsignacion.Text = "✔ Confirmar Asignación";
            btnConfirmarAsignacion.UseVisualStyleBackColor = false;
            // 
            // btnGuardarComoPlan
            // 
            btnGuardarComoPlan.BackColor = Color.FromArgb(22, 163, 74);
            btnGuardarComoPlan.FlatAppearance.BorderSize = 0;
            btnGuardarComoPlan.FlatStyle = FlatStyle.Flat;
            btnGuardarComoPlan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardarComoPlan.ForeColor = Color.White;
            btnGuardarComoPlan.Location = new Point(210, 46);
            btnGuardarComoPlan.Margin = new Padding(3, 4, 3, 4);
            btnGuardarComoPlan.Name = "btnGuardarComoPlan";
            btnGuardarComoPlan.Size = new Size(149, 60);
            btnGuardarComoPlan.TabIndex = 1;
            btnGuardarComoPlan.Text = "💾 Guardar como Plan";
            btnGuardarComoPlan.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.Location = new Point(120, 114);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(171, 60);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "✕ Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Indigo;
            panel1.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(picLogo);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 166);
            panel1.TabIndex = 8;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.Asig_ico;
            picLogo.Location = new Point(24, 13);
            picLogo.Margin = new Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(157, 139);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 12;
            picLogo.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.AutoSize = true;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(793, 13);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.MaximumSize = new Size(1500, 139);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 139);
            panel3.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.patito1;
            pictureBox2.Location = new Point(68, -1);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(168, 146);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(202, 64);
            label2.Name = "label2";
            label2.Size = new Size(571, 52);
            label2.TabIndex = 6;
            label2.Text = "Asignacion de Pedidos a Rutas";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            // 
            // Asignaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 249);
            ClientSize = new Size(1185, 868);
            Controls.Add(panel1);
            Controls.Add(grpInfoRuta);
            Controls.Add(grpInfoOrigen);
            Controls.Add(grpResumenRuta);
            Controls.Add(grpPedidosDisponibles);
            Controls.Add(pnlBotonesAccion);
            Controls.Add(grpPedidosAsignados);
            Controls.Add(grpObservaciones);
            Controls.Add(grpAcciones);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1139, 913);
            Name = "Asignaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asignaciones de Ruta";
            Load += Asignaciones_Load_1;
            grpInfoRuta.ResumeLayout(false);
            grpInfoOrigen.ResumeLayout(false);
            grpResumenRuta.ResumeLayout(false);
            grpPedidosDisponibles.ResumeLayout(false);
            grpPedidosDisponibles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosDisponibles).EndInit();
            pnlBotonesAccion.ResumeLayout(false);
            grpPedidosAsignados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidosAsignados).EndInit();
            grpObservaciones.ResumeLayout(false);
            grpObservaciones.PerformLayout();
            grpAcciones.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // ===== Grupos principales =====
        private System.Windows.Forms.GroupBox grpInfoRuta;
        private System.Windows.Forms.GroupBox grpInfoOrigen;
        private System.Windows.Forms.GroupBox grpResumenRuta;
        private System.Windows.Forms.GroupBox grpPedidosDisponibles;
        private System.Windows.Forms.Panel pnlBotonesAccion;
        private System.Windows.Forms.GroupBox grpPedidosAsignados;
        private System.Windows.Forms.GroupBox grpObservaciones;
        private System.Windows.Forms.GroupBox grpAcciones;

        // ===== Información de la Ruta =====
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.ComboBox cboRuta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblRepartidor;
        private System.Windows.Forms.ComboBox cboRepartidor;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.ComboBox cboVehiculo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;

        // ===== Información de Origen =====
        private System.Windows.Forms.Label lblBodegaOrigenTitulo;
        private System.Windows.Forms.Label lblBodegaOrigenValor;
        private System.Windows.Forms.Label lblSucursalAreaTitulo;
        private System.Windows.Forms.Label lblSucursalAreaValor;
        private System.Windows.Forms.Label lblTipoRutaTitulo;
        private System.Windows.Forms.Label lblTipoRutaValor;
        private System.Windows.Forms.Label lblDistanciaEstimadaTitulo;
        private System.Windows.Forms.Label lblDistanciaEstimadaValor;

        // ===== Resumen de la Ruta =====
        private System.Windows.Forms.Label lblIconPedidos;
        private System.Windows.Forms.Label lblPedidosAsignadosTitulo;
        private System.Windows.Forms.Label lblPedidosAsignadosValor;
        private System.Windows.Forms.Label lblIconParadas;
        private System.Windows.Forms.Label lblParadasTitulo;
        private System.Windows.Forms.Label lblParadasValor;
        private System.Windows.Forms.Label lblIconDistancia;
        private System.Windows.Forms.Label lblDistanciaTotalTitulo;
        private System.Windows.Forms.Label lblDistanciaTotalValor;
        private System.Windows.Forms.Label lblIconTiempo;
        private System.Windows.Forms.Label lblTiempoEstimadoTitulo;
        private System.Windows.Forms.Label lblTiempoEstimadoValor;

        // ===== Pedidos Disponibles =====
        private System.Windows.Forms.TextBox txtBuscarPedido;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.DataGridView dgvPedidosDisponibles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDispCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDispPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDispCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDispDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDispArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDispPeso;

        // ===== Botones de transferencia =====
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnLimpiar;

        // ===== Pedidos Asignados a la Ruta =====
        private System.Windows.Forms.DataGridView dgvPedidosAsignados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsigOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsigPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsigCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsigDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsigEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsigPeso;
        private System.Windows.Forms.DataGridViewButtonColumn colAsigAcciones;
        private System.Windows.Forms.Label lblTotalPedidosTitulo;
        private System.Windows.Forms.Label lblTotalPedidosValor;
        private System.Windows.Forms.Label lblPesoTotalTitulo;
        private System.Windows.Forms.Label lblPesoTotalValor;
        private System.Windows.Forms.Label lblParadasBottomTitulo;
        private System.Windows.Forms.Label lblParadasBottomValor;
        private System.Windows.Forms.Label lblTiempoEstimadoBottomTitulo;
        private System.Windows.Forms.Label lblTiempoEstimadoBottomValor;

        // ===== Observaciones =====
        private System.Windows.Forms.TextBox txtObservaciones;

        // ===== Acciones =====
        private System.Windows.Forms.Button btnConfirmarAsignacion;
        private System.Windows.Forms.Button btnGuardarComoPlan;
        private System.Windows.Forms.Button btnCancelar;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox picLogo;
    }
}