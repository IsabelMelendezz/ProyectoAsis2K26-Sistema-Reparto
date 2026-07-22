namespace SistemaReparto
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnSucursales = new Button();
            btnRepartidores = new Button();
            btnTransportes = new Button();
            btnReportes = new Button();
            btnBodegas = new Button();
            btnPaquetes = new Button();
            btnRutas = new Button();
            btnUsuarios = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panelcontrol = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.barra_menu;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.CausesValidation = false;
            panel1.Controls.Add(btnSucursales);
            panel1.Controls.Add(btnRepartidores);
            panel1.Controls.Add(btnTransportes);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnBodegas);
            panel1.Controls.Add(btnPaquetes);
            panel1.Controls.Add(btnRutas);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 1500);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnSucursales
            // 
            btnSucursales.Cursor = Cursors.Hand;
            btnSucursales.Dock = DockStyle.Top;
            btnSucursales.FlatAppearance.BorderSize = 0;
            btnSucursales.FlatStyle = FlatStyle.Flat;
            btnSucursales.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSucursales.ForeColor = Color.White;
            btnSucursales.Image = Properties.Resources.bodega__1_;
            btnSucursales.ImageAlign = ContentAlignment.MiddleLeft;
            btnSucursales.Location = new Point(27, 748);
            btnSucursales.Margin = new Padding(3, 4, 3, 4);
            btnSucursales.Name = "btnSucursales";
            btnSucursales.RightToLeft = RightToLeft.No;
            btnSucursales.Size = new Size(216, 87);
            btnSucursales.TabIndex = 12;
            btnSucursales.Text = "  Sucursales";
            btnSucursales.UseMnemonic = false;
            btnSucursales.UseVisualStyleBackColor = false;
            btnSucursales.Click += btnSucursales_Click;
            // 
            // btnRepartidores
            // 
            btnRepartidores.Cursor = Cursors.Hand;
            btnRepartidores.Dock = DockStyle.Top;
            btnRepartidores.FlatAppearance.BorderSize = 0;
            btnRepartidores.FlatStyle = FlatStyle.Flat;
            btnRepartidores.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRepartidores.ForeColor = Color.White;
            btnRepartidores.Image = Properties.Resources.repartidores__3_;
            btnRepartidores.ImageAlign = ContentAlignment.MiddleLeft;
            btnRepartidores.Location = new Point(27, 661);
            btnRepartidores.Margin = new Padding(3, 4, 3, 4);
            btnRepartidores.Name = "btnRepartidores";
            btnRepartidores.RightToLeft = RightToLeft.No;
            btnRepartidores.Size = new Size(216, 87);
            btnRepartidores.TabIndex = 10;
            btnRepartidores.Text = " Repartidores";
            btnRepartidores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRepartidores.UseMnemonic = false;
            btnRepartidores.UseVisualStyleBackColor = false;
            btnRepartidores.Click += btnRepartidores_Click;
            // 
            // btnTransportes
            // 
            btnTransportes.Cursor = Cursors.Hand;
            btnTransportes.Dock = DockStyle.Top;
            btnTransportes.FlatAppearance.BorderSize = 0;
            btnTransportes.FlatStyle = FlatStyle.Flat;
            btnTransportes.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransportes.ForeColor = Color.White;
            btnTransportes.Image = Properties.Resources.descarga__1_;
            btnTransportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransportes.Location = new Point(27, 574);
            btnTransportes.Margin = new Padding(3, 4, 3, 4);
            btnTransportes.Name = "btnTransportes";
            btnTransportes.Size = new Size(216, 87);
            btnTransportes.TabIndex = 9;
            btnTransportes.Text = " Transportes";
            btnTransportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransportes.UseMnemonic = false;
            btnTransportes.UseVisualStyleBackColor = false;
            btnTransportes.Click += button7_Click;
            // 
            // btnReportes
            // 
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.White;
            btnReportes.Image = Properties.Resources.reportes__1_;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(27, 487);
            btnReportes.Margin = new Padding(3, 4, 3, 4);
            btnReportes.Name = "btnReportes";
            btnReportes.RightToLeft = RightToLeft.No;
            btnReportes.Size = new Size(216, 87);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.UseMnemonic = false;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnBodegas
            // 
            btnBodegas.Cursor = Cursors.Hand;
            btnBodegas.Dock = DockStyle.Top;
            btnBodegas.FlatAppearance.BorderSize = 0;
            btnBodegas.FlatStyle = FlatStyle.Flat;
            btnBodegas.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBodegas.ForeColor = Color.White;
            btnBodegas.Image = Properties.Resources.bodegas__1_;
            btnBodegas.ImageAlign = ContentAlignment.MiddleLeft;
            btnBodegas.Location = new Point(27, 400);
            btnBodegas.Margin = new Padding(3, 4, 3, 4);
            btnBodegas.Name = "btnBodegas";
            btnBodegas.RightToLeft = RightToLeft.No;
            btnBodegas.Size = new Size(216, 87);
            btnBodegas.TabIndex = 6;
            btnBodegas.Text = "Bodegas";
            btnBodegas.UseMnemonic = false;
            btnBodegas.UseVisualStyleBackColor = false;
            btnBodegas.Click += button4_Click;
            // 
            // btnPaquetes
            // 
            btnPaquetes.Cursor = Cursors.Hand;
            btnPaquetes.Dock = DockStyle.Top;
            btnPaquetes.FlatAppearance.BorderSize = 0;
            btnPaquetes.FlatStyle = FlatStyle.Flat;
            btnPaquetes.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaquetes.ForeColor = Color.White;
            btnPaquetes.Image = Properties.Resources.paquetes_1_;
            btnPaquetes.ImageAlign = ContentAlignment.MiddleLeft;
            btnPaquetes.Location = new Point(27, 313);
            btnPaquetes.Margin = new Padding(3, 4, 3, 4);
            btnPaquetes.Name = "btnPaquetes";
            btnPaquetes.RightToLeft = RightToLeft.No;
            btnPaquetes.Size = new Size(216, 87);
            btnPaquetes.TabIndex = 5;
            btnPaquetes.Text = " Paquetes";
            btnPaquetes.UseMnemonic = false;
            btnPaquetes.UseVisualStyleBackColor = false;
            btnPaquetes.Click += button3_Click;
            // 
            // btnRutas
            // 
            btnRutas.Cursor = Cursors.Hand;
            btnRutas.Dock = DockStyle.Top;
            btnRutas.FlatAppearance.BorderSize = 0;
            btnRutas.FlatStyle = FlatStyle.Flat;
            btnRutas.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRutas.ForeColor = Color.White;
            btnRutas.Image = Properties.Resources.Ubicacion;
            btnRutas.ImageAlign = ContentAlignment.MiddleLeft;
            btnRutas.Location = new Point(27, 226);
            btnRutas.Margin = new Padding(3, 4, 3, 4);
            btnRutas.Name = "btnRutas";
            btnRutas.RightToLeft = RightToLeft.No;
            btnRutas.Size = new Size(216, 87);
            btnRutas.TabIndex = 4;
            btnRutas.Text = "Rutas       ";
            btnRutas.UseMnemonic = false;
            btnRutas.UseVisualStyleBackColor = false;
            btnRutas.Click += button2_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Image = Properties.Resources.agregar_usuario__3_;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(27, 139);
            btnUsuarios.Margin = new Padding(3, 4, 3, 4);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.RightToLeft = RightToLeft.No;
            btnUsuarios.Size = new Size(216, 87);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios  ";
            btnUsuarios.UseMnemonic = false;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(243, 139);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(27, 1361);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 139);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(27, 1361);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(pictureBox3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 139);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.norteklogo1;
            pictureBox3.Location = new Point(18, 43);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(222, 77);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // panelcontrol
            // 
            panelcontrol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelcontrol.AutoSize = true;
            panelcontrol.Location = new Point(273, 4);
            panelcontrol.Margin = new Padding(3, 4, 3, 4);
            panelcontrol.Name = "panelcontrol";
            panelcontrol.Size = new Size(1192, 940);
            panelcontrol.TabIndex = 1;
            panelcontrol.Paint += panelcontrol_Paint;
            // 
            // Menu
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(1465, 991);
            Controls.Add(panelcontrol);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Menu";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnBodegas;
        private System.Windows.Forms.Button btnPaquetes;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Button btnSucursales;
        private System.Windows.Forms.Button btnRepartidores;
        private System.Windows.Forms.Button btnTransportes;
        private System.Windows.Forms.Panel panelcontrol;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}

