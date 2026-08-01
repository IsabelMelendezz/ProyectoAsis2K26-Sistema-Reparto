namespace SistemaReparto
{
    partial class Rel_Modulo_Usuario
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
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label15 = new Label();
            label10 = new Label();
            label8 = new Label();
            lst_Mod_Asignados = new ListBox();
            txt_Usuario = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            Btn_Limpiar_Emp = new Button();
            Btn_Editar_Emp = new Button();
            Btn_Eliminar_Emp = new Button();
            Btn_Guardar_Emp = new Button();
            label5 = new Label();
            chk_Eliminar = new CheckBox();
            chk_Editar = new CheckBox();
            chk_Insertar = new CheckBox();
            cbo_Modulos_Disponibles = new ComboBox();
            label3 = new Label();
            cbo_Usu_Disponibles = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.patito1;
            pictureBox2.Location = new Point(863, 8);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
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
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 177);
            panel1.TabIndex = 54;
            panel1.Paint += panel1_Paint;
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
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoEllipsis = true;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(192, 56);
            label10.Name = "label10";
            label10.Size = new Size(358, 52);
            label10.TabIndex = 6;
            label10.Text = "Rel.Modulo Usuario";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.AliceBlue;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(440, 304);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(151, 18);
            label8.TabIndex = 53;
            label8.Text = "Modulos Asignados";
            // 
            // lst_Mod_Asignados
            // 
            lst_Mod_Asignados.FormattingEnabled = true;
            lst_Mod_Asignados.Location = new Point(544, 336);
            lst_Mod_Asignados.Name = "lst_Mod_Asignados";
            lst_Mod_Asignados.Size = new Size(264, 304);
            lst_Mod_Asignados.TabIndex = 52;
            lst_Mod_Asignados.SelectedIndexChanged += lst_Mod_Asignados_SelectedIndexChanged;
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(632, 216);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(136, 27);
            txt_Usuario.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AliceBlue;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(560, 224);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 18);
            label6.TabIndex = 49;
            label6.Text = "Usuario";
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(chk_Eliminar);
            panel4.Controls.Add(chk_Editar);
            panel4.Controls.Add(chk_Insertar);
            panel4.Controls.Add(cbo_Modulos_Disponibles);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(cbo_Usu_Disponibles);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(40, 232);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(368, 488);
            panel4.TabIndex = 48;
            // 
            // panel5
            // 
            panel5.BackColor = Color.AliceBlue;
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(Btn_Limpiar_Emp);
            panel5.Controls.Add(Btn_Editar_Emp);
            panel5.Controls.Add(Btn_Eliminar_Emp);
            panel5.Controls.Add(Btn_Guardar_Emp);
            panel5.Location = new Point(16, 288);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(340, 149);
            panel5.TabIndex = 58;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Icon_Acciones;
            pictureBox3.Location = new Point(72, 1);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 41;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(108, 1);
            label9.Name = "label9";
            label9.Size = new Size(116, 32);
            label9.TabIndex = 40;
            label9.Text = "Acciones";
            // 
            // Btn_Limpiar_Emp
            // 
            Btn_Limpiar_Emp.Image = Properties.Resources.Btn_Limpiar;
            Btn_Limpiar_Emp.Location = new Point(184, 88);
            Btn_Limpiar_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Limpiar_Emp.Name = "Btn_Limpiar_Emp";
            Btn_Limpiar_Emp.Size = new Size(114, 47);
            Btn_Limpiar_Emp.TabIndex = 39;
            Btn_Limpiar_Emp.UseVisualStyleBackColor = true;
            Btn_Limpiar_Emp.Click += Btn_Limpiar_Emp_Click;
            // 
            // Btn_Editar_Emp
            // 
            Btn_Editar_Emp.Image = Properties.Resources.Btn_Editar;
            Btn_Editar_Emp.Location = new Point(184, 40);
            Btn_Editar_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Editar_Emp.Name = "Btn_Editar_Emp";
            Btn_Editar_Emp.Size = new Size(114, 47);
            Btn_Editar_Emp.TabIndex = 36;
            Btn_Editar_Emp.UseVisualStyleBackColor = true;
            Btn_Editar_Emp.Click += Btn_Editar_Emp_Click;
            // 
            // Btn_Eliminar_Emp
            // 
            Btn_Eliminar_Emp.Image = Properties.Resources.Btn_ELiminar;
            Btn_Eliminar_Emp.Location = new Point(42, 91);
            Btn_Eliminar_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Eliminar_Emp.Name = "Btn_Eliminar_Emp";
            Btn_Eliminar_Emp.Size = new Size(114, 47);
            Btn_Eliminar_Emp.TabIndex = 37;
            Btn_Eliminar_Emp.UseVisualStyleBackColor = true;
            Btn_Eliminar_Emp.Click += Btn_Eliminar_Emp_Click;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AliceBlue;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 112);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 18);
            label5.TabIndex = 39;
            label5.Text = "Permisos";
            // 
            // chk_Eliminar
            // 
            chk_Eliminar.AutoSize = true;
            chk_Eliminar.Location = new Point(144, 144);
            chk_Eliminar.Name = "chk_Eliminar";
            chk_Eliminar.Size = new Size(85, 24);
            chk_Eliminar.TabIndex = 38;
            chk_Eliminar.Text = "Eliminar";
            chk_Eliminar.UseVisualStyleBackColor = true;
            // 
            // chk_Editar
            // 
            chk_Editar.AutoSize = true;
            chk_Editar.Location = new Point(32, 200);
            chk_Editar.Name = "chk_Editar";
            chk_Editar.Size = new Size(70, 24);
            chk_Editar.TabIndex = 37;
            chk_Editar.Text = "Editar";
            chk_Editar.UseVisualStyleBackColor = true;
            // 
            // chk_Insertar
            // 
            chk_Insertar.AutoSize = true;
            chk_Insertar.Location = new Point(32, 144);
            chk_Insertar.Name = "chk_Insertar";
            chk_Insertar.Size = new Size(80, 24);
            chk_Insertar.TabIndex = 35;
            chk_Insertar.Text = "Insertar";
            chk_Insertar.UseVisualStyleBackColor = true;
            // 
            // cbo_Modulos_Disponibles
            // 
            cbo_Modulos_Disponibles.FormattingEnabled = true;
            cbo_Modulos_Disponibles.Location = new Point(176, 64);
            cbo_Modulos_Disponibles.Margin = new Padding(5);
            cbo_Modulos_Disponibles.Name = "cbo_Modulos_Disponibles";
            cbo_Modulos_Disponibles.Size = new Size(160, 28);
            cbo_Modulos_Disponibles.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 24);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(156, 18);
            label3.TabIndex = 31;
            label3.Text = "Usuarios Disponibles";
            // 
            // cbo_Usu_Disponibles
            // 
            cbo_Usu_Disponibles.FormattingEnabled = true;
            cbo_Usu_Disponibles.Location = new Point(176, 16);
            cbo_Usu_Disponibles.Margin = new Padding(5);
            cbo_Usu_Disponibles.Name = "cbo_Usu_Disponibles";
            cbo_Usu_Disponibles.Size = new Size(160, 28);
            cbo_Usu_Disponibles.TabIndex = 32;
            cbo_Usu_Disponibles.SelectedIndexChanged += cbo_Usu_Disponibles_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 72);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 18);
            label2.TabIndex = 33;
            label2.Text = "Modulos Disponibles";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AliceBlue;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(440, 216);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 18);
            label4.TabIndex = 47;
            label4.Text = "Resumen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 256);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 44;
            // 
            // Rel_Modulo_Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 795);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(lst_Mod_Asignados);
            Controls.Add(txt_Usuario);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Rel_Modulo_Usuario";
            Text = "Rel_Modulo_Usuario";
            Load += Rel_Modulo_Usuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label15;
        private Label label10;
        private Label label8;
        private ListBox lst_Mod_Asignados;
        private TextBox txt_Usuario;
        private Label label6;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label label9;
        private Button Btn_Limpiar_Emp;
        private Button Btn_Editar_Emp;
        private Button Btn_Eliminar_Emp;
        private Button Btn_Guardar_Emp;
        private Label label5;
        private CheckBox chk_Eliminar;
        private CheckBox chk_Editar;
        private CheckBox chk_Insertar;
        private ComboBox cbo_Modulos_Disponibles;
        private Label label3;
        private ComboBox cbo_Usu_Disponibles;
        private Label label2;
        private Label label4;
        private Label label1;
    }
}