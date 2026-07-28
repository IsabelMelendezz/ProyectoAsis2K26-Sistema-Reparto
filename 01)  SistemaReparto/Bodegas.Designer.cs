namespace SistemaReparto
{
    partial class Bodegas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pic_Bode = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            labelIdBodega = new Label();
            textBoxIdBodega = new TextBox();
            labelCapacidad = new Label();
            numericUpDownCapacidad = new NumericUpDown();
            labelIdSucursal = new Label();
            comboBoxSucursal = new ComboBox();
            labelTelefono = new Label();
            textBoxTelefono = new TextBox();
            labelNombre = new Label();
            textBoxNombre = new TextBox();
            labelDireccion = new Label();
            textBoxDireccion = new TextBox();
            labelObligatorios = new Label();
            panel4 = new Panel();
            label4 = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            panel5 = new Panel();
            label5 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnActualizar = new Button();
            dataGridView1 = new DataGridView();
            labelRegistros = new Label();
            btnPrimero = new Button();
            btnAnterior = new Button();
            btnPagina = new Button();
            btnSiguiente = new Button();
            btnUltimo = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Bode).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacidad).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pic_Bode);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1774, 221);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.patito1;
            pictureBox1.Location = new Point(1397, 13);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pic_Bode
            // 
            pic_Bode.Image = Properties.Resources.Bode_ico;
            pic_Bode.Location = new Point(60, 33);
            pic_Bode.Name = "pic_Bode";
            pic_Bode.Size = new Size(172, 152);
            pic_Bode.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Bode.TabIndex = 16;
            pic_Bode.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(237, 45);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(264, 78);
            label2.TabIndex = 6;
            label2.Text = "Bodegas";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(labelIdBodega);
            panel3.Controls.Add(textBoxIdBodega);
            panel3.Controls.Add(labelCapacidad);
            panel3.Controls.Add(numericUpDownCapacidad);
            panel3.Controls.Add(labelIdSucursal);
            panel3.Controls.Add(comboBoxSucursal);
            panel3.Controls.Add(labelTelefono);
            panel3.Controls.Add(textBoxTelefono);
            panel3.Controls.Add(labelNombre);
            panel3.Controls.Add(textBoxNombre);
            panel3.Controls.Add(labelDireccion);
            panel3.Controls.Add(textBoxDireccion);
            panel3.Controls.Add(labelObligatorios);
            panel3.Location = new Point(29, 229);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1171, 474);
            panel3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(25, 22);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(390, 40);
            label3.TabIndex = 0;
            label3.Text = "📋 Información de Bodega";
            // 
            // labelIdBodega
            // 
            labelIdBodega.AutoSize = true;
            labelIdBodega.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIdBodega.ForeColor = Color.FromArgb(64, 64, 64);
            labelIdBodega.Location = new Point(30, 95);
            labelIdBodega.Margin = new Padding(4, 0, 4, 0);
            labelIdBodega.Name = "labelIdBodega";
            labelIdBodega.Size = new Size(93, 23);
            labelIdBodega.TabIndex = 1;
            labelIdBodega.Text = "Bodega:";
            // 
            // textBoxIdBodega
            // 
            textBoxIdBodega.BackColor = Color.FromArgb(237, 237, 237);
            textBoxIdBodega.Location = new Point(238, 90);
            textBoxIdBodega.Margin = new Padding(4);
            textBoxIdBodega.Name = "textBoxIdBodega";
            textBoxIdBodega.PlaceholderText = "(Autogenerado)";
            textBoxIdBodega.ReadOnly = true;
            textBoxIdBodega.Size = new Size(299, 31);
            textBoxIdBodega.TabIndex = 2;
            // 
            // labelCapacidad
            // 
            labelCapacidad.AutoSize = true;
            labelCapacidad.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCapacidad.ForeColor = Color.FromArgb(64, 64, 64);
            labelCapacidad.Location = new Point(600, 95);
            labelCapacidad.Margin = new Padding(4, 0, 4, 0);
            labelCapacidad.Name = "labelCapacidad";
            labelCapacidad.Size = new Size(143, 23);
            labelCapacidad.TabIndex = 3;
            labelCapacidad.Text = "Capacidad: *";
            // 
            // numericUpDownCapacidad
            // 
            numericUpDownCapacidad.Location = new Point(812, 90);
            numericUpDownCapacidad.Margin = new Padding(4);
            numericUpDownCapacidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownCapacidad.Name = "numericUpDownCapacidad";
            numericUpDownCapacidad.Size = new Size(288, 31);
            numericUpDownCapacidad.TabIndex = 4;
            // 
            // labelIdSucursal
            // 
            labelIdSucursal.AutoSize = true;
            labelIdSucursal.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIdSucursal.ForeColor = Color.FromArgb(64, 64, 64);
            labelIdSucursal.Location = new Point(30, 152);
            labelIdSucursal.Margin = new Padding(4, 0, 4, 0);
            labelIdSucursal.Name = "labelIdSucursal";
            labelIdSucursal.Size = new Size(111, 23);
            labelIdSucursal.TabIndex = 5;
            labelIdSucursal.Text = "Sucursal: *";
            // 
            // comboBoxSucursal
            // 
            comboBoxSucursal.FormattingEnabled = true;
            comboBoxSucursal.Location = new Point(238, 148);
            comboBoxSucursal.Margin = new Padding(4);
            comboBoxSucursal.Name = "comboBoxSucursal";
            comboBoxSucursal.Size = new Size(299, 33);
            comboBoxSucursal.TabIndex = 6;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTelefono.ForeColor = Color.FromArgb(64, 64, 64);
            labelTelefono.Location = new Point(600, 152);
            labelTelefono.Margin = new Padding(4, 0, 4, 0);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(114, 23);
            labelTelefono.TabIndex = 7;
            labelTelefono.Text = "Teléfono: *";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(812, 148);
            textBoxTelefono.Margin = new Padding(4);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.PlaceholderText = "Ingrese el teléfono";
            textBoxTelefono.Size = new Size(286, 31);
            textBoxTelefono.TabIndex = 8;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = Color.FromArgb(64, 64, 64);
            labelNombre.Location = new Point(30, 210);
            labelNombre.Margin = new Padding(4, 0, 4, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(110, 23);
            labelNombre.TabIndex = 9;
            labelNombre.Text = "Nombre: *";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(238, 205);
            textBoxNombre.Margin = new Padding(4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Ingrese el nombre de la bodega";
            textBoxNombre.Size = new Size(862, 31);
            textBoxNombre.TabIndex = 10;
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            labelDireccion.Location = new Point(30, 268);
            labelDireccion.Margin = new Padding(4, 0, 4, 0);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(125, 23);
            labelDireccion.TabIndex = 11;
            labelDireccion.Text = "Dirección: *";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(238, 262);
            textBoxDireccion.Margin = new Padding(4);
            textBoxDireccion.Multiline = true;
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.PlaceholderText = "Ingrese la dirección completa";
            textBoxDireccion.ScrollBars = ScrollBars.Vertical;
            textBoxDireccion.Size = new Size(862, 99);
            textBoxDireccion.TabIndex = 12;
            // 
            // labelObligatorios
            // 
            labelObligatorios.AutoSize = true;
            labelObligatorios.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelObligatorios.ForeColor = Color.Red;
            labelObligatorios.Location = new Point(30, 425);
            labelObligatorios.Margin = new Padding(4, 0, 4, 0);
            labelObligatorios.Name = "labelObligatorios";
            labelObligatorios.Size = new Size(172, 23);
            labelObligatorios.TabIndex = 13;
            labelObligatorios.Text = "* Campos obligatorios";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(btnNuevo);
            panel4.Controls.Add(btnGuardar);
            panel4.Controls.Add(btnEditar);
            panel4.Controls.Add(btnEliminar);
            panel4.Controls.Add(btnLimpiar);
            panel4.Location = new Point(1220, 229);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(521, 474);
            panel4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(25, 22);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(187, 40);
            label4.TabIndex = 0;
            label4.Text = "⚙️ Acciones";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(21, 66, 143);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(30, 85);
            btnNuevo.Margin = new Padding(4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(452, 62);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "➕  Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(31, 145, 62);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(30, 160);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(452, 62);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "💾  Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(230, 129, 26);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(30, 235);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(452, 62);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "✏️  Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(205, 32, 32);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(30, 310);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(452, 62);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "🗑️  Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.Location = new Point(30, 385);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(452, 62);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "\U0001f9f9  Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(txtBuscar);
            panel5.Controls.Add(btnBuscar);
            panel5.Controls.Add(btnActualizar);
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(labelRegistros);
            panel5.Controls.Add(btnPrimero);
            panel5.Controls.Add(btnAnterior);
            panel5.Controls.Add(btnPagina);
            panel5.Controls.Add(btnSiguiente);
            panel5.Controls.Add(btnUltimo);
            panel5.Location = new Point(29, 725);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1712, 476);
            panel5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(25, 22);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(333, 40);
            label5.TabIndex = 0;
            label5.Text = "📋 Listado de Bodegas";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(30, 85);
            txtBuscar.Margin = new Padding(4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre, dirección o teléfono...";
            txtBuscar.Size = new Size(649, 31);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(21, 66, 143);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(690, 82);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(62, 39);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "🔍";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.White;
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.FromArgb(21, 66, 143);
            btnActualizar.Location = new Point(1475, 80);
            btnActualizar.Margin = new Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(188, 44);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "🔄  Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 132);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1633, 284);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // labelRegistros
            // 
            labelRegistros.AutoSize = true;
            labelRegistros.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRegistros.ForeColor = Color.FromArgb(90, 90, 90);
            labelRegistros.Location = new Point(30, 555);
            labelRegistros.Margin = new Padding(4, 0, 4, 0);
            labelRegistros.Name = "labelRegistros";
            labelRegistros.Size = new Size(280, 28);
            labelRegistros.TabIndex = 6;
            labelRegistros.Text = "Mostrando 1 a 5 de 5 registros";
            // 
            // btnPrimero
            // 
            btnPrimero.BackColor = Color.White;
            btnPrimero.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnPrimero.FlatStyle = FlatStyle.Flat;
            btnPrimero.ForeColor = Color.FromArgb(64, 64, 64);
            btnPrimero.Location = new Point(1250, 548);
            btnPrimero.Margin = new Padding(4);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(50, 40);
            btnPrimero.TabIndex = 7;
            btnPrimero.Text = "«";
            btnPrimero.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.White;
            btnAnterior.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.ForeColor = Color.FromArgb(64, 64, 64);
            btnAnterior.Location = new Point(1308, 548);
            btnAnterior.Margin = new Padding(4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(50, 40);
            btnAnterior.TabIndex = 8;
            btnAnterior.Text = "‹";
            btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnPagina
            // 
            btnPagina.BackColor = Color.FromArgb(21, 66, 143);
            btnPagina.FlatAppearance.BorderSize = 0;
            btnPagina.FlatStyle = FlatStyle.Flat;
            btnPagina.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagina.ForeColor = Color.White;
            btnPagina.Location = new Point(1365, 548);
            btnPagina.Margin = new Padding(4);
            btnPagina.Name = "btnPagina";
            btnPagina.Size = new Size(50, 40);
            btnPagina.TabIndex = 9;
            btnPagina.Text = "1";
            btnPagina.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.White;
            btnSiguiente.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.ForeColor = Color.FromArgb(64, 64, 64);
            btnSiguiente.Location = new Point(1422, 548);
            btnSiguiente.Margin = new Padding(4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(50, 40);
            btnSiguiente.TabIndex = 10;
            btnSiguiente.Text = "›";
            btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnUltimo
            // 
            btnUltimo.BackColor = Color.White;
            btnUltimo.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnUltimo.FlatStyle = FlatStyle.Flat;
            btnUltimo.ForeColor = Color.FromArgb(64, 64, 64);
            btnUltimo.Location = new Point(1480, 548);
            btnUltimo.Margin = new Padding(4);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(50, 40);
            btnUltimo.TabIndex = 11;
            btnUltimo.Text = "»";
            btnUltimo.UseVisualStyleBackColor = false;
            // 
            // Bodegas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1774, 1214);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Bodegas";
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Bode).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacidad).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label3;
        private Label labelIdBodega;
        private TextBox textBoxIdBodega;
        private Label labelCapacidad;
        private NumericUpDown numericUpDownCapacidad;
        private Label labelIdSucursal;
        private ComboBox comboBoxSucursal;
        private Label labelTelefono;
        private TextBox textBoxTelefono;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private Label labelDireccion;
        private TextBox textBoxDireccion;
        private Label labelObligatorios;
        private Panel panel4;
        private Label label4;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Panel panel5;
        private Label label5;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnActualizar;
        private DataGridView dataGridView1;
        private Label labelRegistros;
        private Button btnPrimero;
        private Button btnAnterior;
        private Button btnPagina;
        private Button btnSiguiente;
        private Button btnUltimo;
        private PictureBox pic_Bode;
        private PictureBox pictureBox1;
    }
}