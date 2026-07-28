namespace SistemaReparto
{
    partial class Estado_Empleado
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
            label2 = new Label();
            panel3 = new Panel();
            Dgv_Tabla_EstadoE = new DataGridView();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            Txt_Nombre_EstadoEmp = new TextBox();
            Txt_Descripcion_EstadoE = new TextBox();
            label5 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            Btn_Guardar_EstadoE = new Button();
            Btn_Nuevo_EstadoE = new Button();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            Btn_Limpiar_EstadoE = new Button();
            Btn_Editar_EstadoE = new Button();
            Btn_Eliminar_EstadoE = new Button();
            Btn_Actualizar_EstadoE = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label15 = new Label();
            pictureBox2 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_EstadoE).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
           // SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(160, 36);
            label2.Name = "label2";
            label2.Size = new Size(263, 42);
            label2.TabIndex = 6;
            label2.Text = "Estado Empleado";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = Color.Lavender;
            panel3.Controls.Add(Dgv_Tabla_EstadoE);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 133);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1087, 472);
            panel3.TabIndex = 14;
            // 
            // Dgv_Tabla_EstadoE
            // 
            Dgv_Tabla_EstadoE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_Tabla_EstadoE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Tabla_EstadoE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Tabla_EstadoE.Location = new Point(38, 173);
            Dgv_Tabla_EstadoE.Margin = new Padding(4);
            Dgv_Tabla_EstadoE.Name = "Dgv_Tabla_EstadoE";
            Dgv_Tabla_EstadoE.RowHeadersWidth = 51;
            Dgv_Tabla_EstadoE.Size = new Size(1000, 256);
            Dgv_Tabla_EstadoE.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(Txt_Nombre_EstadoEmp);
            panel4.Controls.Add(Txt_Descripcion_EstadoE);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(12, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(747, 124);
            panel4.TabIndex = 33;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Arg_Transporte;
            pictureBox4.Location = new Point(231, 16);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 42;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(267, 18);
            label1.Name = "label1";
            label1.Size = new Size(343, 25);
            label1.TabIndex = 34;
            label1.Text = "Información del estado del Empleado";
            // 
            // Txt_Nombre_EstadoEmp
            // 
            Txt_Nombre_EstadoEmp.Location = new Point(92, 67);
            Txt_Nombre_EstadoEmp.Margin = new Padding(4);
            Txt_Nombre_EstadoEmp.Name = "Txt_Nombre_EstadoEmp";
            Txt_Nombre_EstadoEmp.PlaceholderText = "🙋 Nombres";
            Txt_Nombre_EstadoEmp.Size = new Size(224, 23);
            Txt_Nombre_EstadoEmp.TabIndex = 12;
            // 
            // Txt_Descripcion_EstadoE
            // 
            Txt_Descripcion_EstadoE.Location = new Point(468, 70);
            Txt_Descripcion_EstadoE.Margin = new Padding(4);
            Txt_Descripcion_EstadoE.Multiline = true;
            Txt_Descripcion_EstadoE.Name = "Txt_Descripcion_EstadoE";
            Txt_Descripcion_EstadoE.PlaceholderText = "📑 Descripcion";
            Txt_Descripcion_EstadoE.Size = new Size(224, 18);
            Txt_Descripcion_EstadoE.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AliceBlue;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(360, 70);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 16);
            label5.TabIndex = 7;
            label5.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 70);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 16);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // panel5
            // 
            panel5.BackColor = Color.AliceBlue;
            panel5.Controls.Add(Btn_Guardar_EstadoE);
            panel5.Controls.Add(Btn_Nuevo_EstadoE);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(Btn_Limpiar_EstadoE);
            panel5.Controls.Add(Btn_Editar_EstadoE);
            panel5.Controls.Add(Btn_Eliminar_EstadoE);
            panel5.Controls.Add(Btn_Actualizar_EstadoE);
            panel5.Location = new Point(797, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(372, 127);
            panel5.TabIndex = 40;
            // 
            // Btn_Guardar_EstadoE
            // 
            Btn_Guardar_EstadoE.Image = Properties.Resources.Btn_guardar;
            Btn_Guardar_EstadoE.Location = new Point(131, 34);
            Btn_Guardar_EstadoE.Name = "Btn_Guardar_EstadoE";
            Btn_Guardar_EstadoE.Size = new Size(110, 37);
            Btn_Guardar_EstadoE.TabIndex = 35;
            Btn_Guardar_EstadoE.UseVisualStyleBackColor = true;
            // 
            // Btn_Nuevo_EstadoE
            // 
            Btn_Nuevo_EstadoE.Image = Properties.Resources.Btn_Nuevo;
            Btn_Nuevo_EstadoE.Location = new Point(15, 34);
            Btn_Nuevo_EstadoE.Name = "Btn_Nuevo_EstadoE";
            Btn_Nuevo_EstadoE.Size = new Size(110, 37);
            Btn_Nuevo_EstadoE.TabIndex = 34;
            Btn_Nuevo_EstadoE.UseVisualStyleBackColor = true;
            Btn_Nuevo_EstadoE.Click += Btn_Nuevo_EstadoE_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Icon_Acciones;
            pictureBox3.Location = new Point(113, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 41;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(138, 10);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 40;
            label4.Text = "Acciones";
            // 
            // Btn_Limpiar_EstadoE
            // 
            Btn_Limpiar_EstadoE.Image = Properties.Resources.Btn_Limpiar;
            Btn_Limpiar_EstadoE.Location = new Point(247, 77);
            Btn_Limpiar_EstadoE.Name = "Btn_Limpiar_EstadoE";
            Btn_Limpiar_EstadoE.Size = new Size(110, 37);
            Btn_Limpiar_EstadoE.TabIndex = 39;
            Btn_Limpiar_EstadoE.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar_EstadoE
            // 
            Btn_Editar_EstadoE.Image = Properties.Resources.Btn_Editar;
            Btn_Editar_EstadoE.Location = new Point(245, 34);
            Btn_Editar_EstadoE.Name = "Btn_Editar_EstadoE";
            Btn_Editar_EstadoE.Size = new Size(110, 37);
            Btn_Editar_EstadoE.TabIndex = 36;
            Btn_Editar_EstadoE.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar_EstadoE
            // 
            Btn_Eliminar_EstadoE.Image = Properties.Resources.Btn_ELiminar;
            Btn_Eliminar_EstadoE.Location = new Point(15, 78);
            Btn_Eliminar_EstadoE.Name = "Btn_Eliminar_EstadoE";
            Btn_Eliminar_EstadoE.Size = new Size(110, 37);
            Btn_Eliminar_EstadoE.TabIndex = 37;
            Btn_Eliminar_EstadoE.UseVisualStyleBackColor = true;
            // 
            // Btn_Actualizar_EstadoE
            // 
            Btn_Actualizar_EstadoE.Image = Properties.Resources.Btn_Actualizar;
            Btn_Actualizar_EstadoE.Location = new Point(131, 77);
            Btn_Actualizar_EstadoE.Name = "Btn_Actualizar_EstadoE";
            Btn_Actualizar_EstadoE.Size = new Size(110, 37);
            Btn_Actualizar_EstadoE.TabIndex = 38;
            Btn_Actualizar_EstadoE.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.patito1;
            pictureBox1.Location = new Point(1909, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Indigo;
            panel1.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 133);
            panel1.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(160, 79);
            label15.Name = "label15";
            label15.Size = new Size(343, 21);
            label15.TabIndex = 8;
            label15.Text = "Registre la actividad del empleado actualmente.";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Tipo_V;
            pictureBox2.Location = new Point(28, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Estado_Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 605);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Estado_Empleado";
            Text = "Form1";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_EstadoE).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Panel panel3;
        private DataGridView Dgv_Tabla_EstadoE;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label label1;
        private TextBox Txt_Nombre_EstadoEmp;
        private TextBox Txt_Descripcion_EstadoE;
        private Label label5;
        private Label label3;
        private Panel panel5;
        private Button Btn_Guardar_EstadoE;
        private Button Btn_Nuevo_EstadoE;
        private PictureBox pictureBox3;
        private Label label4;
        private Button Btn_Limpiar_EstadoE;
        private Button Btn_Editar_EstadoE;
        private Button Btn_Eliminar_EstadoE;
        private Button Btn_Actualizar_EstadoE;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label15;
        private PictureBox pictureBox2;
    }
}