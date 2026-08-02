namespace SistemaReparto
{
    partial class Paquetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paquetes));
            pnlHeader = new Panel();
            picLogo = new PictureBox();
            picMascota = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pnlInformacion = new Panel();
            pnlBusqueda = new Panel();
            label3 = new Label();
            btnNuevoPaquete = new Button();
            btnLimpiar = new Button();
            labelIdPedido = new Label();
            cboPedido = new ComboBox();
            labelRuta = new Label();
            cboRuta = new ComboBox();
            labelTipoPaquete = new Label();
            cboTipoPaquete = new ComboBox();
            labelFragil = new Label();
            cboFragil = new ComboBox();
            labelDescripcion = new Label();
            txtDescripcion = new TextBox();
            labelEstado = new Label();
            cboEstado = new ComboBox();
            labelPeso = new Label();
            txtPeso = new TextBox();
            labelAlto = new Label();
            txtAlto = new TextBox();
            labelAncho = new Label();
            txtAncho = new TextBox();
            labelLargo = new Label();
            txtLargo = new TextBox();
            labelCodigoRastreo = new Label();
            txtCodigoRastreo = new TextBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            pnlTabla = new Panel();
            label5 = new Label();
            labelBuscarCampo = new Label();
            txtBuscar = new TextBox();
            labelEstadoFiltro = new Label();
            cboEstadoFiltro = new ComboBox();
            labelTipoFiltro = new Label();
            cboTipoFiltro = new ComboBox();
            btnBuscar = new Button();
            btnMostrarTodos = new Button();
            dgvPaquetes = new DataGridView();
            labelRegistros = new Label();
            btnPrimero = new Button();
            btnAnterior = new Button();
            btnPagina = new Button();
            btnSiguiente = new Button();
            btnUltimo = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMascota).BeginInit();
            pnlInformacion.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaquetes).BeginInit();
            SuspendLayout();
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
            pnlHeader.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(16, 13);
            picLogo.Margin = new Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(180, 165);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 11;
            picLogo.TabStop = false;
            // 
            // picMascota
            // 
            picMascota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMascota.BackColor = Color.Transparent;
            picMascota.Image = Properties.Resources.patito1;
            picMascota.Location = new Point(1133, 16);
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
            label1.Location = new Point(195, 66);
            label1.Name = "label1";
            label1.Size = new Size(160, 38);
            label1.TabIndex = 2;
            label1.Text = "Paquetes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(195, 108);
            label2.Name = "label2";
            label2.Size = new Size(428, 25);
            label2.TabIndex = 3;
            label2.Text = "Gestiona la información de los paquetes del sistema.";
            // 
            // pnlInformacion
            // 
            pnlInformacion.BackColor = Color.FromArgb(244, 246, 250);
            pnlInformacion.Controls.Add(pnlBusqueda);
            pnlInformacion.Controls.Add(pnlTabla);
            pnlInformacion.Dock = DockStyle.Fill;
            pnlInformacion.Location = new Point(0, 201);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Padding = new Padding(16);
            pnlInformacion.Size = new Size(1337, 715);
            pnlInformacion.TabIndex = 1;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlBusqueda.BackColor = Color.White;
            pnlBusqueda.BorderStyle = BorderStyle.FixedSingle;
            pnlBusqueda.Controls.Add(label3);
            pnlBusqueda.Controls.Add(btnNuevoPaquete);
            pnlBusqueda.Controls.Add(btnLimpiar);
            pnlBusqueda.Controls.Add(labelIdPedido);
            pnlBusqueda.Controls.Add(cboPedido);
            pnlBusqueda.Controls.Add(labelRuta);
            pnlBusqueda.Controls.Add(cboRuta);
            pnlBusqueda.Controls.Add(labelTipoPaquete);
            pnlBusqueda.Controls.Add(cboTipoPaquete);
            pnlBusqueda.Controls.Add(labelFragil);
            pnlBusqueda.Controls.Add(cboFragil);
            pnlBusqueda.Controls.Add(labelDescripcion);
            pnlBusqueda.Controls.Add(txtDescripcion);
            pnlBusqueda.Controls.Add(labelEstado);
            pnlBusqueda.Controls.Add(cboEstado);
            pnlBusqueda.Controls.Add(labelPeso);
            pnlBusqueda.Controls.Add(txtPeso);
            pnlBusqueda.Controls.Add(labelAlto);
            pnlBusqueda.Controls.Add(txtAlto);
            pnlBusqueda.Controls.Add(labelAncho);
            pnlBusqueda.Controls.Add(txtAncho);
            pnlBusqueda.Controls.Add(labelLargo);
            pnlBusqueda.Controls.Add(txtLargo);
            pnlBusqueda.Controls.Add(labelCodigoRastreo);
            pnlBusqueda.Controls.Add(txtCodigoRastreo);
            pnlBusqueda.Controls.Add(btnGuardar);
            pnlBusqueda.Controls.Add(btnEditar);
            pnlBusqueda.Controls.Add(btnEliminar);
            pnlBusqueda.Controls.Add(btnActualizar);
            pnlBusqueda.Location = new Point(16, 16);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1305, 256);
            pnlBusqueda.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(16, 12);
            label3.Name = "label3";
            label3.Size = new Size(304, 30);
            label3.TabIndex = 0;
            label3.Text = "📦 Información del Paquete";
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
            btnNuevoPaquete.Click += btnNuevoPaquete_Click;
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
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // labelIdPedido
            // 
            labelIdPedido.AutoSize = true;
            labelIdPedido.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIdPedido.ForeColor = Color.FromArgb(64, 64, 64);
            labelIdPedido.Location = new Point(16, 44);
            labelIdPedido.Name = "labelIdPedido";
            labelIdPedido.Size = new Size(83, 19);
            labelIdPedido.TabIndex = 3;
            labelIdPedido.Text = "ID Pedido";
            // 
            // cboPedido
            // 
            cboPedido.FormattingEnabled = true;
            cboPedido.Location = new Point(16, 64);
            cboPedido.Name = "cboPedido";
            cboPedido.Size = new Size(276, 33);
            cboPedido.TabIndex = 4;
            cboPedido.Text = "Seleccionar pedido";
            cboPedido.SelectedIndexChanged += cboPedido_SelectedIndexChanged;
            // 
            // labelRuta
            // 
            labelRuta.AutoSize = true;
            labelRuta.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRuta.ForeColor = Color.FromArgb(64, 64, 64);
            labelRuta.Location = new Point(302, 44);
            labelRuta.Name = "labelRuta";
            labelRuta.Size = new Size(123, 19);
            labelRuta.TabIndex = 5;
            labelRuta.Text = "Ruta Asignada";
            // 
            // cboRuta
            // 
            cboRuta.FormattingEnabled = true;
            cboRuta.Location = new Point(302, 64);
            cboRuta.Name = "cboRuta";
            cboRuta.Size = new Size(325, 33);
            cboRuta.TabIndex = 6;
            cboRuta.Text = "Seleccionar ruta";
            cboRuta.SelectedIndexChanged += cboRuta_SelectedIndexChanged;
            // 
            // labelTipoPaquete
            // 
            labelTipoPaquete.AutoSize = true;
            labelTipoPaquete.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTipoPaquete.ForeColor = Color.FromArgb(64, 64, 64);
            labelTipoPaquete.Location = new Point(633, 44);
            labelTipoPaquete.Name = "labelTipoPaquete";
            labelTipoPaquete.Size = new Size(135, 19);
            labelTipoPaquete.TabIndex = 7;
            labelTipoPaquete.Text = "Tipo de Paquete";
            // 
            // cboTipoPaquete
            // 
            cboTipoPaquete.FormattingEnabled = true;
            cboTipoPaquete.Location = new Point(633, 64);
            cboTipoPaquete.Name = "cboTipoPaquete";
            cboTipoPaquete.Size = new Size(276, 33);
            cboTipoPaquete.TabIndex = 8;
            cboTipoPaquete.Text = "Seleccionar tipo";
            // 
            // labelFragil
            // 
            labelFragil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelFragil.AutoSize = true;
            labelFragil.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFragil.ForeColor = Color.FromArgb(64, 64, 64);
            labelFragil.Location = new Point(1011, 44);
            labelFragil.Name = "labelFragil";
            labelFragil.Size = new Size(52, 19);
            labelFragil.TabIndex = 9;
            labelFragil.Text = "Frágil";
            // 
            // cboFragil
            // 
            cboFragil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboFragil.FormattingEnabled = true;
            cboFragil.Items.AddRange(new object[] { "Sí", "No" });
            cboFragil.Location = new Point(1011, 64);
            cboFragil.Name = "cboFragil";
            cboFragil.Size = new Size(278, 33);
            cboFragil.TabIndex = 10;
            cboFragil.Text = "No";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            labelDescripcion.Location = new Point(16, 100);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(100, 19);
            labelDescripcion.TabIndex = 11;
            labelDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.Location = new Point(16, 120);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción del paquete";
            txtDescripcion.Size = new Size(985, 31);
            txtDescripcion.TabIndex = 12;
            // 
            // labelEstado
            // 
            labelEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelEstado.AutoSize = true;
            labelEstado.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEstado.ForeColor = Color.FromArgb(64, 64, 64);
            labelEstado.Location = new Point(1011, 100);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(59, 19);
            labelEstado.TabIndex = 13;
            labelEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            cboEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cboEstado.Location = new Point(1011, 120);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(278, 33);
            cboEstado.TabIndex = 14;
            cboEstado.Text = "Activo";
            // 
            // labelPeso
            // 
            labelPeso.AutoSize = true;
            labelPeso.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPeso.ForeColor = Color.FromArgb(64, 64, 64);
            labelPeso.Location = new Point(16, 156);
            labelPeso.Name = "labelPeso";
            labelPeso.Size = new Size(81, 19);
            labelPeso.TabIndex = 15;
            labelPeso.Text = "Peso (Kg)";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(16, 176);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "0.00";
            txtPeso.Size = new Size(220, 31);
            txtPeso.TabIndex = 16;
            // 
            // labelAlto
            // 
            labelAlto.AutoSize = true;
            labelAlto.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAlto.ForeColor = Color.FromArgb(64, 64, 64);
            labelAlto.Location = new Point(244, 156);
            labelAlto.Name = "labelAlto";
            labelAlto.Size = new Size(81, 19);
            labelAlto.TabIndex = 17;
            labelAlto.Text = "Alto (cm)";
            // 
            // txtAlto
            // 
            txtAlto.Location = new Point(244, 176);
            txtAlto.Name = "txtAlto";
            txtAlto.PlaceholderText = "0.00";
            txtAlto.Size = new Size(220, 31);
            txtAlto.TabIndex = 18;
            // 
            // labelAncho
            // 
            labelAncho.AutoSize = true;
            labelAncho.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAncho.ForeColor = Color.FromArgb(64, 64, 64);
            labelAncho.Location = new Point(472, 156);
            labelAncho.Name = "labelAncho";
            labelAncho.Size = new Size(103, 19);
            labelAncho.TabIndex = 19;
            labelAncho.Text = "Ancho (cm)";
            // 
            // txtAncho
            // 
            txtAncho.Location = new Point(472, 176);
            txtAncho.Name = "txtAncho";
            txtAncho.PlaceholderText = "0.00";
            txtAncho.Size = new Size(220, 31);
            txtAncho.TabIndex = 20;
            // 
            // labelLargo
            // 
            labelLargo.AutoSize = true;
            labelLargo.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLargo.ForeColor = Color.FromArgb(64, 64, 64);
            labelLargo.Location = new Point(700, 156);
            labelLargo.Name = "labelLargo";
            labelLargo.Size = new Size(95, 19);
            labelLargo.TabIndex = 21;
            labelLargo.Text = "Largo (cm)";
            // 
            // txtLargo
            // 
            txtLargo.Location = new Point(700, 176);
            txtLargo.Name = "txtLargo";
            txtLargo.PlaceholderText = "0.00";
            txtLargo.Size = new Size(220, 31);
            txtLargo.TabIndex = 22;
            // 
            // labelCodigoRastreo
            // 
            labelCodigoRastreo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCodigoRastreo.AutoSize = true;
            labelCodigoRastreo.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCodigoRastreo.ForeColor = Color.FromArgb(64, 64, 64);
            labelCodigoRastreo.Location = new Point(1065, 156);
            labelCodigoRastreo.Name = "labelCodigoRastreo";
            labelCodigoRastreo.Size = new Size(126, 19);
            labelCodigoRastreo.TabIndex = 23;
            labelCodigoRastreo.Text = "Código Rastreo";
            // 
            // txtCodigoRastreo
            // 
            txtCodigoRastreo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCodigoRastreo.Location = new Point(1065, 176);
            txtCodigoRastreo.Name = "txtCodigoRastreo";
            txtCodigoRastreo.PlaceholderText = "Ingrese código de rastreo";
            txtCodigoRastreo.Size = new Size(224, 31);
            txtCodigoRastreo.TabIndex = 24;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(31, 145, 62);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(16, 212);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(276, 32);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "💾  Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(230, 129, 26);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(302, 212);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(276, 32);
            btnEditar.TabIndex = 26;
            btnEditar.Text = "✏️  Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(205, 32, 32);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(588, 212);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(276, 32);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "🗑️  Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.BackColor = Color.FromArgb(111, 66, 193);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(1011, 212);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(278, 32);
            btnActualizar.TabIndex = 28;
            btnActualizar.Text = "🔄  Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // pnlTabla
            // 
            pnlTabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTabla.BackColor = Color.White;
            pnlTabla.BorderStyle = BorderStyle.FixedSingle;
            pnlTabla.Controls.Add(label5);
            pnlTabla.Controls.Add(labelBuscarCampo);
            pnlTabla.Controls.Add(txtBuscar);
            pnlTabla.Controls.Add(labelEstadoFiltro);
            pnlTabla.Controls.Add(cboEstadoFiltro);
            pnlTabla.Controls.Add(labelTipoFiltro);
            pnlTabla.Controls.Add(cboTipoFiltro);
            pnlTabla.Controls.Add(btnBuscar);
            pnlTabla.Controls.Add(btnMostrarTodos);
            pnlTabla.Controls.Add(dgvPaquetes);
            pnlTabla.Controls.Add(labelRegistros);
            pnlTabla.Controls.Add(btnPrimero);
            pnlTabla.Controls.Add(btnAnterior);
            pnlTabla.Controls.Add(btnPagina);
            pnlTabla.Controls.Add(btnSiguiente);
            pnlTabla.Controls.Add(btnUltimo);
            pnlTabla.Location = new Point(16, 288);
            pnlTabla.Name = "pnlTabla";
            pnlTabla.Size = new Size(1305, 411);
            pnlTabla.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(16, 10);
            label5.Name = "label5";
            label5.Size = new Size(211, 30);
            label5.TabIndex = 0;
            label5.Text = "🔍 Buscar paquete";
            // 
            // labelBuscarCampo
            // 
            labelBuscarCampo.AutoSize = true;
            labelBuscarCampo.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBuscarCampo.ForeColor = Color.FromArgb(64, 64, 64);
            labelBuscarCampo.Location = new Point(16, 42);
            labelBuscarCampo.Name = "labelBuscarCampo";
            labelBuscarCampo.Size = new Size(131, 19);
            labelBuscarCampo.TabIndex = 1;
            labelBuscarCampo.Text = "Buscar paquete";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(16, 62);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese código de rastreo, descripción o ID pedido...";
            txtBuscar.Size = new Size(669, 31);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // labelEstadoFiltro
            // 
            labelEstadoFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelEstadoFiltro.AutoSize = true;
            labelEstadoFiltro.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEstadoFiltro.ForeColor = Color.FromArgb(64, 64, 64);
            labelEstadoFiltro.Location = new Point(695, 42);
            labelEstadoFiltro.Name = "labelEstadoFiltro";
            labelEstadoFiltro.Size = new Size(59, 19);
            labelEstadoFiltro.TabIndex = 3;
            labelEstadoFiltro.Text = "Estado";
            // 
            // cboEstadoFiltro
            // 
            cboEstadoFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboEstadoFiltro.FormattingEnabled = true;
            cboEstadoFiltro.Items.AddRange(new object[] { "Todos", "Activo", "Inactivo" });
            cboEstadoFiltro.Location = new Point(695, 62);
            cboEstadoFiltro.Name = "cboEstadoFiltro";
            cboEstadoFiltro.Size = new Size(160, 33);
            cboEstadoFiltro.TabIndex = 4;
            cboEstadoFiltro.Text = "Todos";
            // 
            // labelTipoFiltro
            // 
            labelTipoFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTipoFiltro.AutoSize = true;
            labelTipoFiltro.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTipoFiltro.ForeColor = Color.FromArgb(64, 64, 64);
            labelTipoFiltro.Location = new Point(863, 42);
            labelTipoFiltro.Name = "labelTipoFiltro";
            labelTipoFiltro.Size = new Size(135, 19);
            labelTipoFiltro.TabIndex = 5;
            labelTipoFiltro.Text = "Tipo de Paquete";
            // 
            // cboTipoFiltro
            // 
            cboTipoFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboTipoFiltro.FormattingEnabled = true;
            cboTipoFiltro.Items.AddRange(new object[] { "Todos" });
            cboTipoFiltro.Location = new Point(863, 62);
            cboTipoFiltro.Name = "cboTipoFiltro";
            cboTipoFiltro.Size = new Size(180, 33);
            cboTipoFiltro.TabIndex = 6;
            cboTipoFiltro.Text = "Todos";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.FromArgb(21, 66, 143);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(1051, 60);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 28);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "🔍  Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
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
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // dgvPaquetes
            // 
            dgvPaquetes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPaquetes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaquetes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaquetes.Location = new Point(16, 94);
            dgvPaquetes.Name = "dgvPaquetes";
            dgvPaquetes.ReadOnly = true;
            dgvPaquetes.RowHeadersWidth = 51;
            dgvPaquetes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaquetes.Size = new Size(1273, 267);
            dgvPaquetes.TabIndex = 9;
            dgvPaquetes.CellClick += dgvPaquetes_CellClick;
            dgvPaquetes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelRegistros
            // 
            labelRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelRegistros.AutoSize = true;
            labelRegistros.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRegistros.ForeColor = Color.FromArgb(90, 90, 90);
            labelRegistros.Location = new Point(16, 377);
            labelRegistros.Name = "labelRegistros";
            labelRegistros.Size = new Size(223, 21);
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
            btnPrimero.Location = new Point(1095, 369);
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
            btnAnterior.Location = new Point(1135, 369);
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
            btnPagina.Location = new Point(1175, 369);
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
            btnSiguiente.Location = new Point(1215, 369);
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
            btnUltimo.Location = new Point(1255, 369);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(34, 26);
            btnUltimo.TabIndex = 15;
            btnUltimo.Text = "»";
            btnUltimo.UseVisualStyleBackColor = false;
            // 
            // Paquetes
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1337, 916);
            Controls.Add(pnlInformacion);
            Controls.Add(pnlHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 650);
            Name = "Paquetes";
            Text = "Paquetes";
            Load += Paquetes_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMascota).EndInit();
            pnlInformacion.ResumeLayout(false);
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlTabla.ResumeLayout(false);
            pnlTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaquetes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevoPaquete;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label labelIdPedido;
        private System.Windows.Forms.ComboBox cboPedido;
        private System.Windows.Forms.Label labelRuta;
        private System.Windows.Forms.ComboBox cboRuta;
        private System.Windows.Forms.Label labelTipoPaquete;
        private System.Windows.Forms.ComboBox cboTipoPaquete;
        private System.Windows.Forms.Label labelFragil;
        private System.Windows.Forms.ComboBox cboFragil;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label labelAlto;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.Label labelAncho;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label labelLargo;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.Label labelCodigoRastreo;
        private System.Windows.Forms.TextBox txtCodigoRastreo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelBuscarCampo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label labelEstadoFiltro;
        private System.Windows.Forms.ComboBox cboEstadoFiltro;
        private System.Windows.Forms.Label labelTipoFiltro;
        private System.Windows.Forms.ComboBox cboTipoFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.DataGridView dgvPaquetes;
        private System.Windows.Forms.Label labelRegistros;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPagina;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private PictureBox picMascota;
        private PictureBox picLogo;
    }
}
