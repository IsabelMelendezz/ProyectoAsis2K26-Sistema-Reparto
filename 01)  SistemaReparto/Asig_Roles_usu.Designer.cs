namespace SistemaReparto
{
    partial class Asig_Roles_usu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asig_Roles_usu));
            label1 = new Label();
            label2 = new Label();
            Dgv_Tabla_UR = new DataGridView();
            cbo_Usu_Disponible = new ComboBox();
            Cbo_Rol_Disponibles = new ComboBox();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            Btn_Limpiar_Emp = new Button();
            Btn_Nuevo_Emp = new Button();
            Btn_Editar_Emp = new Button();
            Btn_Eliminar_Emp_Asig_R_U = new Button();
            Btn_Guardar_Asig_R_U = new Button();
            Btn_Actualizar_Asig_R_U = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label15 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_UR).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 104);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 55;
            label1.Text = "Usuarios Disponibles";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 208);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 56;
            label2.Text = "Roles Disponibles";
            label2.Click += label2_Click;
            // 
            // Dgv_Tabla_UR
            // 
            Dgv_Tabla_UR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_Tabla_UR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Tabla_UR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Tabla_UR.Location = new Point(20, 544);
            Dgv_Tabla_UR.Name = "Dgv_Tabla_UR";
            Dgv_Tabla_UR.RowHeadersWidth = 51;
            Dgv_Tabla_UR.Size = new Size(1034, 162);
            Dgv_Tabla_UR.TabIndex = 59;
            Dgv_Tabla_UR.CellContentClick += Dgv_Tabla_Usu_CellContentClick;
            Dgv_Tabla_UR.SelectionChanged += Dgv_Tabla_UR_SelectionChanged;
            // 
            // cbo_Usu_Disponible
            // 
            cbo_Usu_Disponible.FormattingEnabled = true;
            cbo_Usu_Disponible.Location = new Point(160, 104);
            cbo_Usu_Disponible.Name = "cbo_Usu_Disponible";
            cbo_Usu_Disponible.Size = new Size(160, 28);
            cbo_Usu_Disponible.TabIndex = 62;
            // 
            // Cbo_Rol_Disponibles
            // 
            Cbo_Rol_Disponibles.FormattingEnabled = true;
            Cbo_Rol_Disponibles.Location = new Point(160, 200);
            Cbo_Rol_Disponibles.Name = "Cbo_Rol_Disponibles";
            Cbo_Rol_Disponibles.Size = new Size(160, 28);
            Cbo_Rol_Disponibles.TabIndex = 63;
            Cbo_Rol_Disponibles.SelectedIndexChanged += Cbo_Rol_Disponibles_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(Cbo_Rol_Disponibles);
            panel4.Controls.Add(cbo_Usu_Disponible);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(72, 208);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(448, 304);
            panel4.TabIndex = 64;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Usu_ico1;
            pictureBox4.Location = new Point(87, 13);
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
            label4.Location = new Point(128, 16);
            label4.Name = "label4";
            label4.Size = new Size(247, 32);
            label4.TabIndex = 34;
            label4.Text = "Asignacion De Roles";
            // 
            // panel5
            // 
            panel5.BackColor = Color.AliceBlue;
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(Btn_Limpiar_Emp);
            panel5.Controls.Add(Btn_Nuevo_Emp);
            panel5.Controls.Add(Btn_Editar_Emp);
            panel5.Controls.Add(Btn_Eliminar_Emp_Asig_R_U);
            panel5.Controls.Add(Btn_Guardar_Asig_R_U);
            panel5.Controls.Add(Btn_Actualizar_Asig_R_U);
            panel5.Location = new Point(592, 272);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(425, 149);
            panel5.TabIndex = 64;
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
            Btn_Limpiar_Emp.Location = new Point(287, 85);
            Btn_Limpiar_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Limpiar_Emp.Name = "Btn_Limpiar_Emp";
            Btn_Limpiar_Emp.Size = new Size(114, 47);
            Btn_Limpiar_Emp.TabIndex = 39;
            Btn_Limpiar_Emp.UseVisualStyleBackColor = true;
            Btn_Limpiar_Emp.Click += Btn_Limpiar_Emp_Click;
            // 
            // Btn_Nuevo_Emp
            // 
            Btn_Nuevo_Emp.Image = Properties.Resources.Btn_Nuevo;
            Btn_Nuevo_Emp.Location = new Point(42, 39);
            Btn_Nuevo_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Nuevo_Emp.Name = "Btn_Nuevo_Emp";
            Btn_Nuevo_Emp.Size = new Size(114, 47);
            Btn_Nuevo_Emp.TabIndex = 34;
            Btn_Nuevo_Emp.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar_Emp
            // 
            Btn_Editar_Emp.Image = Properties.Resources.Btn_Editar;
            Btn_Editar_Emp.Location = new Point(287, 33);
            Btn_Editar_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Editar_Emp.Name = "Btn_Editar_Emp";
            Btn_Editar_Emp.Size = new Size(114, 47);
            Btn_Editar_Emp.TabIndex = 36;
            Btn_Editar_Emp.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar_Emp_Asig_R_U
            // 
            Btn_Eliminar_Emp_Asig_R_U.Image = Properties.Resources.Btn_ELiminar;
            Btn_Eliminar_Emp_Asig_R_U.Location = new Point(42, 91);
            Btn_Eliminar_Emp_Asig_R_U.Margin = new Padding(3, 4, 3, 4);
            Btn_Eliminar_Emp_Asig_R_U.Name = "Btn_Eliminar_Emp_Asig_R_U";
            Btn_Eliminar_Emp_Asig_R_U.Size = new Size(114, 47);
            Btn_Eliminar_Emp_Asig_R_U.TabIndex = 37;
            Btn_Eliminar_Emp_Asig_R_U.UseVisualStyleBackColor = true;
            Btn_Eliminar_Emp_Asig_R_U.Click += Btn_Eliminar_Emp_Asig_R_U_Click;
            // 
            // Btn_Guardar_Asig_R_U
            // 
            Btn_Guardar_Asig_R_U.Image = Properties.Resources.Btn_guardar;
            Btn_Guardar_Asig_R_U.Location = new Point(166, 39);
            Btn_Guardar_Asig_R_U.Margin = new Padding(3, 4, 3, 4);
            Btn_Guardar_Asig_R_U.Name = "Btn_Guardar_Asig_R_U";
            Btn_Guardar_Asig_R_U.Size = new Size(114, 47);
            Btn_Guardar_Asig_R_U.TabIndex = 35;
            Btn_Guardar_Asig_R_U.UseVisualStyleBackColor = true;
            Btn_Guardar_Asig_R_U.Click += Btn_Guardar_Emp_Click;
            // 
            // Btn_Actualizar_Asig_R_U
            // 
            Btn_Actualizar_Asig_R_U.Image = Properties.Resources.Btn_Actualizar;
            Btn_Actualizar_Asig_R_U.Location = new Point(166, 85);
            Btn_Actualizar_Asig_R_U.Margin = new Padding(3, 4, 3, 4);
            Btn_Actualizar_Asig_R_U.Name = "Btn_Actualizar_Asig_R_U";
            Btn_Actualizar_Asig_R_U.Size = new Size(114, 47);
            Btn_Actualizar_Asig_R_U.TabIndex = 38;
            Btn_Actualizar_Asig_R_U.UseVisualStyleBackColor = true;
            Btn_Actualizar_Asig_R_U.Click += Btn_Actualizar_Asig_R_U_Click;
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
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 177);
            panel1.TabIndex = 65;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.patito1;
            pictureBox2.Location = new Point(933, 8);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 66;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Usu_ico;
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
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(178, 52);
            label5.Name = "label5";
            label5.Size = new Size(206, 52);
            label5.TabIndex = 6;
            label5.Text = "Asig. Roles";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.UseCompatibleTextRendering = true;
            // 
            // Asig_Roles_usu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 749);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(Dgv_Tabla_UR);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Asig_Roles_usu";
            Text = "Asig_Roles_usu";
            Load += Asig_Roles_usu_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_UR).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private DataGridView Dgv_Tabla_UR;
        private ComboBox cbo_Usu_Disponible;
        private ComboBox Cbo_Rol_Disponibles;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label label4;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label label3;
        private Button Btn_Limpiar_Emp;
        private Button Btn_Nuevo_Emp;
        private Button Btn_Editar_Emp;
        private Button Btn_Eliminar_Emp_Asig_R_U;
        private Button Btn_Guardar_Asig_R_U;
        private Button Btn_Actualizar_Asig_R_U;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label15;
        private Label label5;
        private PictureBox pictureBox2;
    }
}