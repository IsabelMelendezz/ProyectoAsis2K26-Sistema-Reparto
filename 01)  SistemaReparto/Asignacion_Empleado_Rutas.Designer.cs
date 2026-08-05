namespace SistemaReparto
{
    partial class Asignacion_Empleado_Rutas
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
            List_Asignacion_Area = new ListBox();
            txt_Usuario = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            Date_Fin_Asignacion = new DateTimePicker();
            Date_Inicio_Asignacion = new DateTimePicker();
            label7 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            Btn_Actualizar_Asignacion_Area = new Button();
            Btn_Nueva_Asignacion_Area = new Button();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            Btn_Limpiar_Asignacion_Area = new Button();
            Btn_Editar_Asignacion_Area = new Button();
            Btn_Eliminar_Asignacion_Area = new Button();
            Btn_Guardar_Asignacion_Area = new Button();
            Cbo_Area = new ComboBox();
            label3 = new Label();
            Cbo_Empleado = new ComboBox();
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
            label15.Location = new Point(192, 103);
            label15.Name = "label15";
            label15.Size = new Size(489, 28);
            label15.TabIndex = 9;
            label15.Text = "Gestiona las rutas que se le asignaran a los empelados";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoEllipsis = true;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(179, 51);
            label10.Name = "label10";
            label10.Size = new Size(570, 52);
            label10.TabIndex = 6;
            label10.Text = "Asignación Rutas a Empleados";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.AliceBlue;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(606, 321);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(151, 18);
            label8.TabIndex = 53;
            label8.Text = "Modulos Asignados";
            // 
            // List_Asignacion_Area
            // 
            List_Asignacion_Area.FormattingEnabled = true;
            List_Asignacion_Area.Location = new Point(606, 354);
            List_Asignacion_Area.Name = "List_Asignacion_Area";
            List_Asignacion_Area.Size = new Size(264, 304);
            List_Asignacion_Area.TabIndex = 52;
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(692, 253);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(136, 27);
            txt_Usuario.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AliceBlue;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(606, 258);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 18);
            label6.TabIndex = 49;
            label6.Text = "Usuario";
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(Date_Fin_Asignacion);
            panel4.Controls.Add(Date_Inicio_Asignacion);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(Cbo_Area);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(Cbo_Empleado);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(40, 232);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(510, 488);
            panel4.TabIndex = 48;
            // 
            // Date_Fin_Asignacion
            // 
            Date_Fin_Asignacion.Location = new Point(176, 171);
            Date_Fin_Asignacion.Name = "Date_Fin_Asignacion";
            Date_Fin_Asignacion.Size = new Size(250, 27);
            Date_Fin_Asignacion.TabIndex = 62;
            // 
            // Date_Inicio_Asignacion
            // 
            Date_Inicio_Asignacion.Location = new Point(176, 122);
            Date_Inicio_Asignacion.Name = "Date_Inicio_Asignacion";
            Date_Inicio_Asignacion.Size = new Size(250, 27);
            Date_Inicio_Asignacion.TabIndex = 61;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AliceBlue;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 171);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 18);
            label7.TabIndex = 60;
            label7.Text = "Fecha Fin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AliceBlue;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 122);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 18);
            label5.TabIndex = 59;
            label5.Text = "Fecha Inicio";
            // 
            // panel5
            // 
            panel5.BackColor = Color.AliceBlue;
            panel5.Controls.Add(Btn_Actualizar_Asignacion_Area);
            panel5.Controls.Add(Btn_Nueva_Asignacion_Area);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(Btn_Limpiar_Asignacion_Area);
            panel5.Controls.Add(Btn_Editar_Asignacion_Area);
            panel5.Controls.Add(Btn_Eliminar_Asignacion_Area);
            panel5.Controls.Add(Btn_Guardar_Asignacion_Area);
            panel5.Location = new Point(16, 288);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(454, 149);
            panel5.TabIndex = 58;
            // 
            // Btn_Actualizar_Asignacion_Area
            // 
            Btn_Actualizar_Asignacion_Area.Image = Properties.Resources.Btn_Actualizar;
            Btn_Actualizar_Asignacion_Area.Location = new Point(51, 95);
            Btn_Actualizar_Asignacion_Area.Name = "Btn_Actualizar_Asignacion_Area";
            Btn_Actualizar_Asignacion_Area.Size = new Size(106, 38);
            Btn_Actualizar_Asignacion_Area.TabIndex = 43;
            Btn_Actualizar_Asignacion_Area.UseVisualStyleBackColor = true;
            // 
            // Btn_Nueva_Asignacion_Area
            // 
            Btn_Nueva_Asignacion_Area.Image = Properties.Resources.Btn_Nuevo;
            Btn_Nueva_Asignacion_Area.Location = new Point(51, 44);
            Btn_Nueva_Asignacion_Area.Name = "Btn_Nueva_Asignacion_Area";
            Btn_Nueva_Asignacion_Area.Size = new Size(106, 38);
            Btn_Nueva_Asignacion_Area.TabIndex = 42;
            Btn_Nueva_Asignacion_Area.UseVisualStyleBackColor = true;
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
            // Btn_Limpiar_Asignacion_Area
            // 
            Btn_Limpiar_Asignacion_Area.Image = Properties.Resources.Btn_Limpiar;
            Btn_Limpiar_Asignacion_Area.Location = new Point(305, 88);
            Btn_Limpiar_Asignacion_Area.Margin = new Padding(3, 4, 3, 4);
            Btn_Limpiar_Asignacion_Area.Name = "Btn_Limpiar_Asignacion_Area";
            Btn_Limpiar_Asignacion_Area.Size = new Size(114, 47);
            Btn_Limpiar_Asignacion_Area.TabIndex = 39;
            Btn_Limpiar_Asignacion_Area.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar_Asignacion_Area
            // 
            Btn_Editar_Asignacion_Area.Image = Properties.Resources.Btn_Editar;
            Btn_Editar_Asignacion_Area.Location = new Point(305, 40);
            Btn_Editar_Asignacion_Area.Margin = new Padding(3, 4, 3, 4);
            Btn_Editar_Asignacion_Area.Name = "Btn_Editar_Asignacion_Area";
            Btn_Editar_Asignacion_Area.Size = new Size(114, 47);
            Btn_Editar_Asignacion_Area.TabIndex = 36;
            Btn_Editar_Asignacion_Area.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar_Asignacion_Area
            // 
            Btn_Eliminar_Asignacion_Area.Image = Properties.Resources.Btn_ELiminar;
            Btn_Eliminar_Asignacion_Area.Location = new Point(168, 91);
            Btn_Eliminar_Asignacion_Area.Margin = new Padding(3, 4, 3, 4);
            Btn_Eliminar_Asignacion_Area.Name = "Btn_Eliminar_Asignacion_Area";
            Btn_Eliminar_Asignacion_Area.Size = new Size(114, 47);
            Btn_Eliminar_Asignacion_Area.TabIndex = 37;
            Btn_Eliminar_Asignacion_Area.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar_Asignacion_Area
            // 
            Btn_Guardar_Asignacion_Area.BackColor = Color.Transparent;
            Btn_Guardar_Asignacion_Area.Image = Properties.Resources.Btn_guardar;
            Btn_Guardar_Asignacion_Area.Location = new Point(169, 40);
            Btn_Guardar_Asignacion_Area.Margin = new Padding(3, 4, 3, 4);
            Btn_Guardar_Asignacion_Area.Name = "Btn_Guardar_Asignacion_Area";
            Btn_Guardar_Asignacion_Area.Size = new Size(114, 47);
            Btn_Guardar_Asignacion_Area.TabIndex = 35;
            Btn_Guardar_Asignacion_Area.UseVisualStyleBackColor = false;
            // 
            // Cbo_Area
            // 
            Cbo_Area.FormattingEnabled = true;
            Cbo_Area.Location = new Point(176, 64);
            Cbo_Area.Margin = new Padding(5);
            Cbo_Area.Name = "Cbo_Area";
            Cbo_Area.Size = new Size(294, 28);
            Cbo_Area.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 24);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 18);
            label3.TabIndex = 31;
            label3.Text = "Empleado";
            // 
            // Cbo_Empleado
            // 
            Cbo_Empleado.FormattingEnabled = true;
            Cbo_Empleado.Location = new Point(176, 16);
            Cbo_Empleado.Margin = new Padding(5);
            Cbo_Empleado.Name = "Cbo_Empleado";
            Cbo_Empleado.Size = new Size(294, 28);
            Cbo_Empleado.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 72);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 18);
            label2.TabIndex = 33;
            label2.Text = "Area Disponible";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AliceBlue;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(606, 223);
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
            // Asignacion_Empleado_Rutas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 795);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(List_Asignacion_Area);
            Controls.Add(txt_Usuario);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Asignacion_Empleado_Rutas";
            Text = "Rel_Modulo_Usuario";
            Load += Asignacion_Empleado_Rutas_Load;
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
        private ListBox List_Asignacion_Area;
        private TextBox txt_Usuario;
        private Label label6;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label label9;
        private Button Btn_Limpiar_Asignacion_Area;
        private Button Btn_Editar_Asignacion_Area;
        private Button Btn_Eliminar_Asignacion_Area;
        private Button Btn_Guardar_Asignacion_Area;
        private ComboBox Cbo_Area;
        private Label label3;
        private ComboBox Cbo_Empleado;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label label7;
        private Label label5;
        private Button Btn_Nueva_Asignacion_Area;
        private DateTimePicker Date_Fin_Asignacion;
        private DateTimePicker Date_Inicio_Asignacion;
        private Button Btn_Actualizar_Asignacion_Area;
    }
}