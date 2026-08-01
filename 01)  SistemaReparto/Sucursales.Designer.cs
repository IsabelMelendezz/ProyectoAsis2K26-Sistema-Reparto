namespace SistemaReparto
{
    partial class Sucursales
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
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pic_Sucur = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            labelIdSucursal = new Label();
            textBoxIdSucursal = new TextBox();
            labelNombre = new Label();
            textBoxNombre = new TextBox();
            labelDireccion = new Label();
            textBoxDireccion = new TextBox();
            labelTelefono = new Label();
            textBoxTelefono = new TextBox();
            labelCorreo = new Label();
            textBoxCorreo = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            panel5 = new Panel();
            label5 = new Label();
            labelBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dataGridView1 = new DataGridView();
            labelRegistros = new Label();
            btnAnterior = new Button();
            btnPag1 = new Button();
            btnSiguiente = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Sucur).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Indigo;
            panel1.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pic_Sucur);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1538, 220);
            panel1.TabIndex = 2;
            // 
            // pic_Sucur
            // 
            pic_Sucur.BackColor = Color.Transparent;
            pic_Sucur.Image = Properties.Resources.Sucu_ico;
            pic_Sucur.Location = new Point(47, 26);
            pic_Sucur.Name = "pic_Sucur";
            pic_Sucur.Size = new Size(166, 154);
            pic_Sucur.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Sucur.TabIndex = 20;
            pic_Sucur.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(220, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(244, 62);
            label2.TabIndex = 6;
            label2.Text = "Sucursales";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1133, 17);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.MaximumSize = new Size(1875, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 174);
            panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.patito1;
            pictureBox1.Location = new Point(82, -5);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(labelIdSucursal);
            panel3.Controls.Add(textBoxIdSucursal);
            panel3.Controls.Add(labelNombre);
            panel3.Controls.Add(textBoxNombre);
            panel3.Controls.Add(labelDireccion);
            panel3.Controls.Add(textBoxDireccion);
            panel3.Controls.Add(labelTelefono);
            panel3.Controls.Add(textBoxTelefono);
            panel3.Controls.Add(labelCorreo);
            panel3.Controls.Add(textBoxCorreo);
            panel3.Location = new Point(27, 250);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1088, 355);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(25, 22);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(432, 40);
            label3.TabIndex = 0;
            label3.Text = "🏢 Información de la Sucursal";
            // 
            // labelIdSucursal
            // 
            labelIdSucursal.AutoSize = true;
            labelIdSucursal.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIdSucursal.ForeColor = Color.FromArgb(64, 64, 64);
            labelIdSucursal.Location = new Point(30, 88);
            labelIdSucursal.Margin = new Padding(4, 0, 4, 0);
            labelIdSucursal.Name = "labelIdSucursal";
            labelIdSucursal.Size = new Size(116, 23);
            labelIdSucursal.TabIndex = 1;
            labelIdSucursal.Text = "ID Sucursal";
            // 
            // textBoxIdSucursal
            // 
            textBoxIdSucursal.BackColor = Color.FromArgb(237, 237, 237);
            textBoxIdSucursal.Location = new Point(30, 118);
            textBoxIdSucursal.Margin = new Padding(4);
            textBoxIdSucursal.Name = "textBoxIdSucursal";
            textBoxIdSucursal.PlaceholderText = "🔒 Autogenerado";
            textBoxIdSucursal.ReadOnly = true;
            textBoxIdSucursal.Size = new Size(237, 31);
            textBoxIdSucursal.TabIndex = 2;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = Color.FromArgb(64, 64, 64);
            labelNombre.Location = new Point(340, 91);
            labelNombre.Margin = new Padding(4, 0, 4, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(246, 23);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre de la Sucursal *";
            labelNombre.Click += labelNombre_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(326, 118);
            textBoxNombre.Margin = new Padding(4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Ingrese el nombre de la sucursal";
            textBoxNombre.Size = new Size(347, 31);
            textBoxNombre.TabIndex = 4;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            labelDireccion.Location = new Point(739, 88);
            labelDireccion.Margin = new Padding(4, 0, 4, 0);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(119, 23);
            labelDireccion.TabIndex = 5;
            labelDireccion.Text = "Dirección *";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDireccion.Location = new Point(704, 118);
            textBoxDireccion.Margin = new Padding(4);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.PlaceholderText = "Ingrese la dirección de la sucursal";
            textBoxDireccion.Size = new Size(323, 31);
            textBoxDireccion.TabIndex = 6;
            textBoxDireccion.TextChanged += textBoxDireccion_TextChanged;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTelefono.ForeColor = Color.FromArgb(64, 64, 64);
            labelTelefono.Location = new Point(30, 215);
            labelTelefono.Margin = new Padding(4, 0, 4, 0);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(93, 23);
            labelTelefono.TabIndex = 7;
            labelTelefono.Text = "Teléfono";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(30, 245);
            textBoxTelefono.Margin = new Padding(4);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.PlaceholderText = "☎  Ingrese el teléfono de la sucursal";
            textBoxTelefono.Size = new Size(394, 31);
            textBoxTelefono.TabIndex = 8;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCorreo.ForeColor = Color.FromArgb(64, 64, 64);
            labelCorreo.Location = new Point(511, 215);
            labelCorreo.Margin = new Padding(4, 0, 4, 0);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(192, 23);
            labelCorreo.TabIndex = 9;
            labelCorreo.Text = "Correo Electrónico";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCorreo.Location = new Point(511, 245);
            textBoxCorreo.Margin = new Padding(4);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.PlaceholderText = "✉  Ingrese el correo electrónico";
            textBoxCorreo.Size = new Size(465, 31);
            textBoxCorreo.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(btnNuevo);
            panel4.Controls.Add(btnGuardar);
            panel4.Controls.Add(btnEditar);
            panel4.Controls.Add(btnEliminar);
            panel4.Controls.Add(btnLimpiar);
            panel4.Location = new Point(1123, 250);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(402, 355);
            panel4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(118, 0);
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
            btnNuevo.Location = new Point(30, 43);
            btnNuevo.Margin = new Padding(4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(354, 53);
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
            btnGuardar.Location = new Point(30, 107);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(354, 53);
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
            btnEditar.Location = new Point(30, 171);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(354, 53);
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
            btnEliminar.Location = new Point(30, 233);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(354, 53);
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
            btnLimpiar.Location = new Point(30, 297);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(354, 37);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "\U0001f9f9  Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(labelBuscar);
            panel5.Controls.Add(txtBuscar);
            panel5.Controls.Add(btnBuscar);
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(labelRegistros);
            panel5.Controls.Add(btnAnterior);
            panel5.Controls.Add(btnPag1);
            panel5.Controls.Add(btnSiguiente);
            panel5.Location = new Point(27, 613);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1498, 285);
            panel5.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(25, 5);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(359, 40);
            label5.TabIndex = 0;
            label5.Text = "📋 Listado de Sucursales";
            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBuscar.ForeColor = Color.FromArgb(64, 64, 64);
            labelBuscar.Location = new Point(30, 51);
            labelBuscar.Margin = new Padding(4, 0, 4, 0);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(81, 23);
            labelBuscar.TabIndex = 1;
            labelBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(112, 46);
            txtBuscar.Margin = new Padding(4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese nombre, dirección o teléfono...";
            txtBuscar.Size = new Size(524, 31);
            txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(21, 66, 143);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(1277, 32);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(188, 45);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "🔍  Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(13, 33, 82);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(30, 98);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 20;
            dataGridView1.RowTemplate.Height = 34;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1435, 170);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelRegistros
            // 
            labelRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelRegistros.AutoSize = true;
            labelRegistros.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRegistros.ForeColor = Color.FromArgb(90, 90, 90);
            labelRegistros.Location = new Point(25, 795);
            labelRegistros.Margin = new Padding(4, 0, 4, 0);
            labelRegistros.Name = "labelRegistros";
            labelRegistros.Size = new Size(328, 28);
            labelRegistros.TabIndex = 6;
            labelRegistros.Text = "📊  Mostrando 1 a 5 de 5 sucursales";
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnterior.BackColor = Color.White;
            btnAnterior.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.ForeColor = Color.FromArgb(64, 64, 64);
            btnAnterior.Location = new Point(2746, 785);
            btnAnterior.Margin = new Padding(4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(48, 42);
            btnAnterior.TabIndex = 7;
            btnAnterior.Text = "‹";
            btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnPag1
            // 
            btnPag1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPag1.BackColor = Color.FromArgb(21, 66, 143);
            btnPag1.FlatAppearance.BorderSize = 0;
            btnPag1.FlatStyle = FlatStyle.Flat;
            btnPag1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPag1.ForeColor = Color.White;
            btnPag1.Location = new Point(2801, 785);
            btnPag1.Margin = new Padding(4);
            btnPag1.Name = "btnPag1";
            btnPag1.Size = new Size(48, 42);
            btnPag1.TabIndex = 8;
            btnPag1.Text = "1";
            btnPag1.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente.BackColor = Color.White;
            btnSiguiente.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.ForeColor = Color.FromArgb(64, 64, 64);
            btnSiguiente.Location = new Point(2856, 785);
            btnSiguiente.Margin = new Padding(4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(48, 42);
            btnSiguiente.TabIndex = 9;
            btnSiguiente.Text = "›";
            btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // Sucursales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1538, 904);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Sucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Sucursales_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Sucur).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Panel panel3;
        private Label label3;
        private Label labelIdSucursal;
        private TextBox textBoxIdSucursal;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private Label labelDireccion;
        private TextBox textBoxDireccion;
        private Label labelTelefono;
        private TextBox textBoxTelefono;
        private Label labelCorreo;
        private TextBox textBoxCorreo;
        private Panel panel4;
        private Label label4;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Panel panel5;
        private Label label5;
        private Label labelBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private Label labelRegistros;
        private Button btnAnterior;
        private Button btnPag1;
        private Button btnSiguiente;
        private PictureBox pic_Sucur;
        private PictureBox pictureBox1;
    }
}