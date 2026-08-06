
//Lourdes Isabel Melendez Pineda 
//9959-23-1379


namespace SistemaReparto
{
    partial class Pedidos
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
            btnBuscar = new Button();
            label3 = new Label();
            btnNuevoPaquete = new Button();
            labelBuscarCampo = new Label();
            txtBuscar = new TextBox();
            btnLimpiar = new Button();
            labelIdPedido = new Label();
            labelRuta = new Label();
            cboCliente = new ComboBox();
            labelTipoPaquete = new Label();
            cboEstadoPedido = new ComboBox();
            labelFragil = new Label();
            pnlTabla = new Panel();
            label5 = new Label();
            btnMostrarTodos = new Button();
            dgvPedidos = new DataGridView();
            labelRegistros = new Label();
            btnPrimero = new Button();
            btnAnterior = new Button();
            btnPagina = new Button();
            btnSiguiente = new Button();
            btnUltimo = new Button();
            labelEstado = new Label();
            labelPeso = new Label();
            txtPesoTotal = new TextBox();
            labelAlto = new Label();
            TxtCantidadPaquetes = new TextBox();
            labelDescripcion = new Label();
            labelAncho = new Label();
            picLogo = new PictureBox();
            pnlHeader = new Panel();
            picMascota = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pnlInformacion = new Panel();
            pnlBusqueda = new Panel();
            lblRuta = new Label();
            TxtCodigoPedido = new TextBox();
            comboBoxDepartamentoDestino = new ComboBox();
            comboBoxMunicipioDestino = new ComboBox();
            comboBoxZonaDestino = new ComboBox();
            TextBoxDireccionDestino = new TextBox();
            Txt = new Label();
            comboBoxDepartamentoOrigen = new ComboBox();
            comboBoxMunicipioOrigen = new ComboBox();
            comboBoxZonaOrigen = new ComboBox();
            TextBoxDireccionOrigen = new TextBox();
            dateTimePedido = new DateTimePicker();
            TxtObservaciones = new TextBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMascota).BeginInit();
            pnlInformacion.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.FromArgb(21, 66, 143);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(1049, 60);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 28);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "🔍  Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(16, 12);
            label3.Name = "label3";
            label3.Size = new Size(221, 25);
            label3.TabIndex = 0;
            label3.Text = "Información del Pedido";
            // 
            // btnNuevoPaquete
            // 
            btnNuevoPaquete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoPaquete.BackColor = Color.White;
            btnNuevoPaquete.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnNuevoPaquete.FlatStyle = FlatStyle.Flat;
            btnNuevoPaquete.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoPaquete.ForeColor = Color.FromArgb(21, 66, 143);
            btnNuevoPaquete.Location = new Point(989, 8);
            btnNuevoPaquete.Name = "btnNuevoPaquete";
            btnNuevoPaquete.Size = new Size(150, 28);
            btnNuevoPaquete.TabIndex = 1;
            btnNuevoPaquete.Text = "➕  Nuevo Paquete";
            btnNuevoPaquete.UseVisualStyleBackColor = false;
            // 
            // labelBuscarCampo
            // 
            labelBuscarCampo.AutoSize = true;
            labelBuscarCampo.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBuscarCampo.ForeColor = Color.FromArgb(64, 64, 64);
            labelBuscarCampo.Location = new Point(16, 42);
            labelBuscarCampo.Name = "labelBuscarCampo";
            labelBuscarCampo.Size = new Size(207, 17);
            labelBuscarCampo.TabIndex = 1;
            labelBuscarCampo.Text = "Busque su pedido especifico.";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(16, 62);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese el codigo de su pedido...";
            txtBuscar.Size = new Size(663, 27);
            txtBuscar.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(21, 66, 143);
            btnLimpiar.Location = new Point(1149, 8);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 28);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "\U0001f9f9  Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // labelIdPedido
            // 
            labelIdPedido.AutoSize = true;
            labelIdPedido.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIdPedido.ForeColor = Color.FromArgb(64, 64, 64);
            labelIdPedido.Location = new Point(16, 44);
            labelIdPedido.Name = "labelIdPedido";
            labelIdPedido.Size = new Size(134, 17);
            labelIdPedido.TabIndex = 3;
            labelIdPedido.Text = "Codigo De Pedido";
            // 
            // labelRuta
            // 
            labelRuta.AutoSize = true;
            labelRuta.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRuta.ForeColor = Color.FromArgb(64, 64, 64);
            labelRuta.Location = new Point(302, 44);
            labelRuta.Name = "labelRuta";
            labelRuta.Size = new Size(116, 17);
            labelRuta.TabIndex = 5;
            labelRuta.Text = "Nombre Cliente";
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(302, 64);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(276, 28);
            cboCliente.TabIndex = 6;
            cboCliente.Text = "Seleccione el Id del cliente";
            // 
            // labelTipoPaquete
            // 
            labelTipoPaquete.AutoSize = true;
            labelTipoPaquete.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTipoPaquete.ForeColor = Color.FromArgb(64, 64, 64);
            labelTipoPaquete.Location = new Point(588, 44);
            labelTipoPaquete.Name = "labelTipoPaquete";
            labelTipoPaquete.Size = new Size(104, 17);
            labelTipoPaquete.TabIndex = 7;
            labelTipoPaquete.Text = "Estado Pedido";
            // 
            // cboEstadoPedido
            // 
            cboEstadoPedido.FormattingEnabled = true;
            cboEstadoPedido.Location = new Point(588, 64);
            cboEstadoPedido.Name = "cboEstadoPedido";
            cboEstadoPedido.Size = new Size(276, 28);
            cboEstadoPedido.TabIndex = 8;
            cboEstadoPedido.Text = "Seleccione el Estado Pedido";
            cboEstadoPedido.UseWaitCursor = true;
            cboEstadoPedido.SelectedIndexChanged += cboEstadoPedido_SelectedIndexChanged;
            // 
            // labelFragil
            // 
            labelFragil.AutoSize = true;
            labelFragil.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFragil.ForeColor = Color.FromArgb(64, 64, 64);
            labelFragil.Location = new Point(874, 44);
            labelFragil.Name = "labelFragil";
            labelFragil.Size = new Size(90, 17);
            labelFragil.TabIndex = 9;
            labelFragil.Text = "Detalle Ruta";
            // 
            // pnlTabla
            // 
            pnlTabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTabla.BackColor = Color.White;
            pnlTabla.BorderStyle = BorderStyle.FixedSingle;
            pnlTabla.Controls.Add(label5);
            pnlTabla.Controls.Add(labelBuscarCampo);
            pnlTabla.Controls.Add(txtBuscar);
            pnlTabla.Controls.Add(btnBuscar);
            pnlTabla.Controls.Add(btnMostrarTodos);
            pnlTabla.Controls.Add(dgvPedidos);
            pnlTabla.Controls.Add(labelRegistros);
            pnlTabla.Controls.Add(btnPrimero);
            pnlTabla.Controls.Add(btnAnterior);
            pnlTabla.Controls.Add(btnPagina);
            pnlTabla.Controls.Add(btnSiguiente);
            pnlTabla.Controls.Add(btnUltimo);
            pnlTabla.Location = new Point(12, 517);
            pnlTabla.Name = "pnlTabla";
            pnlTabla.Size = new Size(1305, 256);
            pnlTabla.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(16, 10);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 0;
            label5.Text = "🔍 Buscar Pedido";
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMostrarTodos.BackColor = Color.White;
            btnMostrarTodos.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnMostrarTodos.FlatStyle = FlatStyle.Flat;
            btnMostrarTodos.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarTodos.ForeColor = Color.FromArgb(21, 66, 143);
            btnMostrarTodos.Location = new Point(1149, 60);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(140, 28);
            btnMostrarTodos.TabIndex = 8;
            btnMostrarTodos.Text = "🔄  Mostrar Todos";
            btnMostrarTodos.UseVisualStyleBackColor = false;
            // 
            // dgvPedidos
            // 
            dgvPedidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(16, 94);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(1273, 118);
            dgvPedidos.TabIndex = 9;
            // 
            // labelRegistros
            // 
            labelRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelRegistros.AutoSize = true;
            labelRegistros.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRegistros.ForeColor = Color.FromArgb(90, 90, 90);
            labelRegistros.Location = new Point(16, 225);
            labelRegistros.Name = "labelRegistros";
            labelRegistros.Size = new Size(200, 19);
            labelRegistros.TabIndex = 10;
            labelRegistros.Text = "Mostrando 0 a 0 de 0 registros";
            // 
            // btnPrimero
            // 
            btnPrimero.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrimero.BackColor = Color.White;
            btnPrimero.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnPrimero.FlatStyle = FlatStyle.Flat;
            btnPrimero.ForeColor = Color.FromArgb(64, 64, 64);
            btnPrimero.Location = new Point(1103, 222);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(34, 26);
            btnPrimero.TabIndex = 11;
            btnPrimero.Text = "«";
            btnPrimero.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnterior.BackColor = Color.White;
            btnAnterior.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.ForeColor = Color.FromArgb(64, 64, 64);
            btnAnterior.Location = new Point(1141, 222);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(34, 26);
            btnAnterior.TabIndex = 12;
            btnAnterior.Text = "‹";
            btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnPagina
            // 
            btnPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPagina.BackColor = Color.FromArgb(21, 66, 143);
            btnPagina.FlatAppearance.BorderSize = 0;
            btnPagina.FlatStyle = FlatStyle.Flat;
            btnPagina.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagina.ForeColor = Color.White;
            btnPagina.Location = new Point(1179, 222);
            btnPagina.Name = "btnPagina";
            btnPagina.Size = new Size(34, 26);
            btnPagina.TabIndex = 13;
            btnPagina.Text = "1";
            btnPagina.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente.BackColor = Color.White;
            btnSiguiente.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.ForeColor = Color.FromArgb(64, 64, 64);
            btnSiguiente.Location = new Point(1217, 222);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(34, 26);
            btnSiguiente.TabIndex = 14;
            btnSiguiente.Text = "›";
            btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnUltimo
            // 
            btnUltimo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUltimo.BackColor = Color.White;
            btnUltimo.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnUltimo.FlatStyle = FlatStyle.Flat;
            btnUltimo.ForeColor = Color.FromArgb(64, 64, 64);
            btnUltimo.Location = new Point(1255, 222);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(34, 26);
            btnUltimo.TabIndex = 15;
            btnUltimo.Text = "»";
            btnUltimo.UseVisualStyleBackColor = false;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEstado.ForeColor = Color.FromArgb(64, 64, 64);
            labelEstado.Location = new Point(413, 100);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(376, 17);
            labelEstado.TabIndex = 13;
            labelEstado.Text = "Direccion de origen  (Departamento, Municipio, Zona)";
            labelEstado.Click += labelEstado_Click;
            // 
            // labelPeso
            // 
            labelPeso.AutoSize = true;
            labelPeso.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPeso.ForeColor = Color.FromArgb(64, 64, 64);
            labelPeso.Location = new Point(233, 186);
            labelPeso.Name = "labelPeso";
            labelPeso.Size = new Size(108, 17);
            labelPeso.TabIndex = 15;
            labelPeso.Text = "Peso Total (Kg)";
            // 
            // txtPesoTotal
            // 
            txtPesoTotal.Location = new Point(182, 206);
            txtPesoTotal.Name = "txtPesoTotal";
            txtPesoTotal.PlaceholderText = "0.00";
            txtPesoTotal.Size = new Size(220, 27);
            txtPesoTotal.TabIndex = 16;
            // 
            // labelAlto
            // 
            labelAlto.AutoSize = true;
            labelAlto.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAlto.ForeColor = Color.FromArgb(64, 64, 64);
            labelAlto.Location = new Point(460, 186);
            labelAlto.Name = "labelAlto";
            labelAlto.Size = new Size(163, 17);
            labelAlto.TabIndex = 17;
            labelAlto.Text = "Cantidad de Paquetes ";
            // 
            // TxtCantidadPaquetes
            // 
            TxtCantidadPaquetes.Location = new Point(450, 206);
            TxtCantidadPaquetes.Name = "TxtCantidadPaquetes";
            TxtCantidadPaquetes.PlaceholderText = "0.00";
            TxtCantidadPaquetes.Size = new Size(220, 27);
            TxtCantidadPaquetes.TabIndex = 18;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            labelDescripcion.Location = new Point(16, 100);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(115, 17);
            labelDescripcion.TabIndex = 11;
            labelDescripcion.Text = "fecha_solicitud ";
            // 
            // labelAncho
            // 
            labelAncho.AutoSize = true;
            labelAncho.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAncho.ForeColor = Color.FromArgb(64, 64, 64);
            labelAncho.Location = new Point(737, 186);
            labelAncho.Name = "labelAncho";
            labelAncho.Size = new Size(109, 17);
            labelAncho.TabIndex = 19;
            labelAncho.Text = "Observaciones";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.Icon_Pedidos1;
            picLogo.Location = new Point(16, 13);
            picLogo.Margin = new Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(180, 165);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 11;
            picLogo.TabStop = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(picLogo);
            pnlHeader.Controls.Add(picMascota);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(label2);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1337, 201);
            pnlHeader.TabIndex = 2;
            // 
            // picMascota
            // 
            picMascota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMascota.BackColor = Color.Transparent;
            picMascota.Image = Properties.Resources.patito1;
            picMascota.Location = new Point(1162, 16);
            picMascota.Margin = new Padding(4);
            picMascota.Name = "picMascota";
            picMascota.Size = new Size(155, 181);
            picMascota.SizeMode = PictureBoxSizeMode.StretchImage;
            picMascota.TabIndex = 10;
            picMascota.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(195, 76);
            label1.Name = "label1";
            label1.Size = new Size(117, 32);
            label1.TabIndex = 2;
            label1.Text = "Pedidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(195, 108);
            label2.Name = "label2";
            label2.Size = new Size(335, 20);
            label2.TabIndex = 3;
            label2.Text = "Gestiona los paquetes que se ingresan al sistema.";
            // 
            // pnlInformacion
            // 
            pnlInformacion.BackColor = Color.FromArgb(244, 246, 250);
            pnlInformacion.Controls.Add(pnlBusqueda);
            pnlInformacion.Controls.Add(pnlTabla);
            pnlInformacion.Dock = DockStyle.Fill;
            pnlInformacion.Location = new Point(0, 0);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Padding = new Padding(16);
            pnlInformacion.Size = new Size(1337, 916);
            pnlInformacion.TabIndex = 3;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlBusqueda.BackColor = Color.White;
            pnlBusqueda.BorderStyle = BorderStyle.FixedSingle;
            pnlBusqueda.Controls.Add(lblRuta);
            pnlBusqueda.Controls.Add(TxtCodigoPedido);
            pnlBusqueda.Controls.Add(comboBoxDepartamentoDestino);
            pnlBusqueda.Controls.Add(comboBoxMunicipioDestino);
            pnlBusqueda.Controls.Add(comboBoxZonaDestino);
            pnlBusqueda.Controls.Add(TextBoxDireccionDestino);
            pnlBusqueda.Controls.Add(Txt);
            pnlBusqueda.Controls.Add(comboBoxDepartamentoOrigen);
            pnlBusqueda.Controls.Add(comboBoxMunicipioOrigen);
            pnlBusqueda.Controls.Add(comboBoxZonaOrigen);
            pnlBusqueda.Controls.Add(TextBoxDireccionOrigen);
            pnlBusqueda.Controls.Add(dateTimePedido);
            pnlBusqueda.Controls.Add(label3);
            pnlBusqueda.Controls.Add(btnNuevoPaquete);
            pnlBusqueda.Controls.Add(btnLimpiar);
            pnlBusqueda.Controls.Add(labelIdPedido);
            pnlBusqueda.Controls.Add(labelRuta);
            pnlBusqueda.Controls.Add(cboCliente);
            pnlBusqueda.Controls.Add(labelTipoPaquete);
            pnlBusqueda.Controls.Add(cboEstadoPedido);
            pnlBusqueda.Controls.Add(labelFragil);
            pnlBusqueda.Controls.Add(labelDescripcion);
            pnlBusqueda.Controls.Add(labelEstado);
            pnlBusqueda.Controls.Add(labelPeso);
            pnlBusqueda.Controls.Add(txtPesoTotal);
            pnlBusqueda.Controls.Add(labelAlto);
            pnlBusqueda.Controls.Add(TxtCantidadPaquetes);
            pnlBusqueda.Controls.Add(labelAncho);
            pnlBusqueda.Controls.Add(TxtObservaciones);
            pnlBusqueda.Controls.Add(btnGuardar);
            pnlBusqueda.Controls.Add(btnEditar);
            pnlBusqueda.Controls.Add(btnEliminar);
            pnlBusqueda.Controls.Add(btnActualizar);
            pnlBusqueda.Location = new Point(12, 215);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1305, 296);
            pnlBusqueda.TabIndex = 2;
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Location = new Point(876, 64);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(0, 20);
            lblRuta.TabIndex = 36;
            // 
            // TxtCodigoPedido
            // 
            TxtCodigoPedido.Location = new Point(17, 70);
            TxtCodigoPedido.Name = "TxtCodigoPedido";
            TxtCodigoPedido.PlaceholderText = "Ej: PD-8790C";
            TxtCodigoPedido.Size = new Size(220, 27);
            TxtCodigoPedido.TabIndex = 33;
            // 
            // comboBoxDepartamentoDestino
            // 
            comboBoxDepartamentoDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDepartamentoDestino.FormattingEnabled = true;
            comboBoxDepartamentoDestino.Location = new Point(876, 121);
            comboBoxDepartamentoDestino.Name = "comboBoxDepartamentoDestino";
            comboBoxDepartamentoDestino.Size = new Size(132, 28);
            comboBoxDepartamentoDestino.TabIndex = 32;
            // 
            // comboBoxMunicipioDestino
            // 
            comboBoxMunicipioDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMunicipioDestino.FormattingEnabled = true;
            comboBoxMunicipioDestino.Location = new Point(1016, 121);
            comboBoxMunicipioDestino.Name = "comboBoxMunicipioDestino";
            comboBoxMunicipioDestino.Size = new Size(132, 28);
            comboBoxMunicipioDestino.TabIndex = 33;
            // 
            // comboBoxZonaDestino
            // 
            comboBoxZonaDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxZonaDestino.FormattingEnabled = true;
            comboBoxZonaDestino.Location = new Point(1156, 121);
            comboBoxZonaDestino.Name = "comboBoxZonaDestino";
            comboBoxZonaDestino.Size = new Size(132, 28);
            comboBoxZonaDestino.TabIndex = 34;
            // 
            // TextBoxDireccionDestino
            // 
            TextBoxDireccionDestino.Location = new Point(876, 152);
            TextBoxDireccionDestino.Name = "TextBoxDireccionDestino";
            TextBoxDireccionDestino.PlaceholderText = "Ej : 21 Av. Zona 1 comercial Capitol";
            TextBoxDireccionDestino.Size = new Size(412, 27);
            TextBoxDireccionDestino.TabIndex = 35;
            // 
            // Txt
            // 
            Txt.AutoSize = true;
            Txt.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt.ForeColor = Color.FromArgb(64, 64, 64);
            Txt.Location = new Point(874, 101);
            Txt.Name = "Txt";
            Txt.Size = new Size(380, 17);
            Txt.TabIndex = 31;
            Txt.Text = "Direccion De Destino  (Departamento, Municipio,Zona)";
            // 
            // comboBoxDepartamentoOrigen
            // 
            comboBoxDepartamentoOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDepartamentoOrigen.FormattingEnabled = true;
            comboBoxDepartamentoOrigen.Location = new Point(413, 121);
            comboBoxDepartamentoOrigen.Name = "comboBoxDepartamentoOrigen";
            comboBoxDepartamentoOrigen.Size = new Size(148, 28);
            comboBoxDepartamentoOrigen.TabIndex = 28;
            // 
            // comboBoxMunicipioOrigen
            // 
            comboBoxMunicipioOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMunicipioOrigen.FormattingEnabled = true;
            comboBoxMunicipioOrigen.Location = new Point(569, 121);
            comboBoxMunicipioOrigen.Name = "comboBoxMunicipioOrigen";
            comboBoxMunicipioOrigen.Size = new Size(148, 28);
            comboBoxMunicipioOrigen.TabIndex = 29;
            // 
            // comboBoxZonaOrigen
            // 
            comboBoxZonaOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxZonaOrigen.FormattingEnabled = true;
            comboBoxZonaOrigen.Location = new Point(725, 121);
            comboBoxZonaOrigen.Name = "comboBoxZonaOrigen";
            comboBoxZonaOrigen.Size = new Size(148, 28);
            comboBoxZonaOrigen.TabIndex = 30;
            // 
            // TextBoxDireccionOrigen
            // 
            TextBoxDireccionOrigen.Location = new Point(413, 152);
            TextBoxDireccionOrigen.Name = "TextBoxDireccionOrigen";
            TextBoxDireccionOrigen.PlaceholderText = "Ej : 15 Av. 22-27 Alameda 3";
            TextBoxDireccionOrigen.Size = new Size(460, 27);
            TextBoxDireccionOrigen.TabIndex = 31;
            // 
            // dateTimePedido
            // 
            dateTimePedido.Location = new Point(16, 120);
            dateTimePedido.Name = "dateTimePedido";
            dateTimePedido.Size = new Size(377, 27);
            dateTimePedido.TabIndex = 29;
            // 
            // TxtObservaciones
            // 
            TxtObservaciones.Location = new Point(737, 206);
            TxtObservaciones.Name = "TxtObservaciones";
            TxtObservaciones.PlaceholderText = "0.00";
            TxtObservaciones.Size = new Size(220, 27);
            TxtObservaciones.TabIndex = 20;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(31, 145, 62);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(16, 242);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(276, 32);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "💾  Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(230, 129, 26);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(302, 242);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(276, 32);
            btnEditar.TabIndex = 26;
            btnEditar.Text = "✏️  Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(205, 32, 32);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(588, 242);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(276, 32);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "🗑️  Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(111, 66, 193);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(874, 242);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(276, 32);
            btnActualizar.TabIndex = 28;
            btnActualizar.Text = "🔄  Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // Pedidos
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1337, 916);
            Controls.Add(pnlHeader);
            Controls.Add(pnlInformacion);
            MinimumSize = new Size(1100, 750);
            Name = "Pedidos";
            Text = "Pedidos";
            Load += Pedidos_Load_1;
            pnlTabla.ResumeLayout(false);
            pnlTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMascota).EndInit();
            pnlInformacion.ResumeLayout(false);
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscar;
        private Label label3;
        private Button btnNuevoPaquete;
        private Label labelBuscarCampo;
        private TextBox txtBuscar;
        private Button btnLimpiar;
        private Label labelIdPedido;
        private Label labelRuta;
        private ComboBox cboCliente;
        private Label labelTipoPaquete;
        private ComboBox cboEstadoPedido;
        private Label labelFragil;
        private Panel pnlTabla;
        private Label label5;
        private Button btnMostrarTodos;
        private DataGridView dgvPedidos;
        private Label labelRegistros;
        private Button btnPrimero;
        private Button btnAnterior;
        private Button btnPagina;
        private Button btnSiguiente;
        private Button btnUltimo;
        private Label labelEstado;
        private Label labelPeso;
        private TextBox txtPesoTotal;
        private Label labelAlto;
        private TextBox TxtCantidadPaquetes;
        private Label labelDescripcion;
        private Label labelAncho;
        private PictureBox picLogo;
        private Panel pnlHeader;
        private PictureBox picMascota;
        private Label label1;
        private Label label2;
        private Panel pnlInformacion;
        private Panel pnlBusqueda;
        private TextBox TxtObservaciones;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnActualizar;
        private ComboBox comboBoxDepartamentoOrigen;
        private ComboBox comboBoxMunicipioOrigen;
        private ComboBox comboBoxZonaOrigen;
        private TextBox TextBoxDireccionOrigen;
        private DateTimePicker dateTimePedido;
        private Label Txt;
        private ComboBox comboBoxDepartamentoDestino;
        private ComboBox comboBoxMunicipioDestino;
        private ComboBox comboBoxZonaDestino;
        private TextBox TextBoxDireccionDestino;
        private TextBox TxtCodigoPedido;
        private Label lblRuta;
    }
}