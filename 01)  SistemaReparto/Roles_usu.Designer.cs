namespace SistemaReparto
{
    partial class Roles_usu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roles_usu));
            Dgv_Tabla_Rol = new DataGridView();
            Txt_Nombre_Rol = new TextBox();
            txt_Descripcion = new RichTextBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label15 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            cmb_Estado = new ComboBox();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            Btn_Limpiar_Emp = new Button();
            Btn_Update_Usu = new Button();
            Btn_Delete_Usu = new Button();
            Btn_Guardar_Emp = new Button();
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_Rol).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Dgv_Tabla_Rol
            // 
            Dgv_Tabla_Rol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_Tabla_Rol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Tabla_Rol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Tabla_Rol.Location = new Point(104, 568);
            Dgv_Tabla_Rol.Name = "Dgv_Tabla_Rol";
            Dgv_Tabla_Rol.RowHeadersWidth = 51;
            Dgv_Tabla_Rol.Size = new Size(992, 136);
            Dgv_Tabla_Rol.TabIndex = 44;
            Dgv_Tabla_Rol.CellContentClick += Dgv_Tabla_Rol_CellContentClick;
            Dgv_Tabla_Rol.SelectionChanged += dgvRoles_SelectionChanged;
            // 
            // Txt_Nombre_Rol
            // 
            Txt_Nombre_Rol.Location = new Point(56, 96);
            Txt_Nombre_Rol.Name = "Txt_Nombre_Rol";
            Txt_Nombre_Rol.PlaceholderText = "👤Nombre Rol";
            Txt_Nombre_Rol.Size = new Size(173, 27);
            Txt_Nombre_Rol.TabIndex = 41;
            // 
            // txt_Descripcion
            // 
            txt_Descripcion.Location = new Point(56, 176);
            txt_Descripcion.Name = "txt_Descripcion";
            txt_Descripcion.Size = new Size(280, 88);
            txt_Descripcion.TabIndex = 53;
            txt_Descripcion.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 152);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 54;
            label1.Text = "Descripcion";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Indigo;
            panel1.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 177);
            panel1.TabIndex = 55;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.patito1;
            pictureBox2.Location = new Point(1213, 8);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 56;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(178, 103);
            label15.Name = "label15";
            label15.Size = new Size(465, 28);
            label15.TabIndex = 9;
            label15.Text = "Gestiona la información del personal de la empresa.";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(178, 52);
            label2.Name = "label2";
            label2.Size = new Size(121, 52);
            label2.TabIndex = 6;
            label2.Text = "ROLES";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(cmb_Estado);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txt_Descripcion);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(Txt_Nombre_Rol);
            panel4.Location = new Point(48, 216);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(648, 304);
            panel4.TabIndex = 56;
            // 
            // cmb_Estado
            // 
            cmb_Estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Estado.FormattingEnabled = true;
            cmb_Estado.Items.AddRange(new object[] { "1", "0" });
            cmb_Estado.Location = new Point(472, 216);
            cmb_Estado.Margin = new Padding(5);
            cmb_Estado.Name = "cmb_Estado";
            cmb_Estado.Size = new Size(128, 28);
            cmb_Estado.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.AliceBlue;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(384, 224);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(56, 18);
            label8.TabIndex = 48;
            label8.Text = "Estado";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Usu_ico1;
            pictureBox4.Location = new Point(168, 13);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 42;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(209, 16);
            label4.Name = "label4";
            label4.Size = new Size(244, 32);
            label4.TabIndex = 34;
            label4.Text = "Informacíon Del Rol";
            // 
            // panel5
            // 
            panel5.BackColor = Color.AliceBlue;
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(Btn_Limpiar_Emp);
            panel5.Controls.Add(Btn_Update_Usu);
            panel5.Controls.Add(Btn_Delete_Usu);
            panel5.Controls.Add(Btn_Guardar_Emp);
            panel5.Location = new Point(800, 296);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(425, 149);
            panel5.TabIndex = 57;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Icon_Acciones;
            pictureBox3.Location = new Point(130, 1);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 41;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(166, 1);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 40;
            label3.Text = "Acciones";
            // 
            // Btn_Limpiar_Emp
            // 
            Btn_Limpiar_Emp.Image = Properties.Resources.Btn_Limpiar;
            Btn_Limpiar_Emp.Location = new Point(192, 88);
            Btn_Limpiar_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Limpiar_Emp.Name = "Btn_Limpiar_Emp";
            Btn_Limpiar_Emp.Size = new Size(114, 47);
            Btn_Limpiar_Emp.TabIndex = 39;
            Btn_Limpiar_Emp.UseVisualStyleBackColor = true;
            Btn_Limpiar_Emp.Click += Btn_Limpiar_Emp_Click;
            // 
            // Btn_Update_Usu
            // 
            Btn_Update_Usu.Image = Properties.Resources.Btn_Editar;
            Btn_Update_Usu.Location = new Point(184, 40);
            Btn_Update_Usu.Margin = new Padding(3, 4, 3, 4);
            Btn_Update_Usu.Name = "Btn_Update_Usu";
            Btn_Update_Usu.Size = new Size(114, 47);
            Btn_Update_Usu.TabIndex = 36;
            Btn_Update_Usu.UseVisualStyleBackColor = true;
            Btn_Update_Usu.Click += Btn_Update_Usu_Click;
            // 
            // Btn_Delete_Usu
            // 
            Btn_Delete_Usu.Image = Properties.Resources.Btn_ELiminar;
            Btn_Delete_Usu.Location = new Point(42, 91);
            Btn_Delete_Usu.Margin = new Padding(3, 4, 3, 4);
            Btn_Delete_Usu.Name = "Btn_Delete_Usu";
            Btn_Delete_Usu.Size = new Size(114, 47);
            Btn_Delete_Usu.TabIndex = 37;
            Btn_Delete_Usu.UseVisualStyleBackColor = true;
            Btn_Delete_Usu.Click += Btn_Delete_Usu_Click;
            // 
            // Btn_Guardar_Emp
            // 
            Btn_Guardar_Emp.Image = Properties.Resources.Btn_guardar;
            Btn_Guardar_Emp.Location = new Point(48, 40);
            Btn_Guardar_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Guardar_Emp.Name = "Btn_Guardar_Emp";
            Btn_Guardar_Emp.Size = new Size(114, 47);
            Btn_Guardar_Emp.TabIndex = 35;
            Btn_Guardar_Emp.UseVisualStyleBackColor = true;
            Btn_Guardar_Emp.Click += Btn_Guardar_Emp_Click;
            // 
            // Roles_usu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(Dgv_Tabla_Rol);
            Name = "Roles_usu";
            Text = "Roles_usu";
            Load += Roles_usu_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_Rol).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView Dgv_Tabla_Rol;
        private TextBox Txt_Nombre_Rol;
        private RichTextBox txt_Descripcion;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label15;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel4;
        private ComboBox cmb_Estado;
        private Label label8;
        private PictureBox pictureBox4;
        private Label label4;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label label3;
        private Button Btn_Limpiar_Emp;
        private Button Btn_Update_Usu;
        private Button Btn_Delete_Usu;
        private Button Btn_Guardar_Emp;
    }
}