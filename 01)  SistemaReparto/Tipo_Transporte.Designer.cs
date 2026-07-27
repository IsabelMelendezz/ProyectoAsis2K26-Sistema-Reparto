namespace SistemaReparto
{
    partial class Tipo_Transporte
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
            panel3 = new Panel();
            Dgv_Tabla_TipoT = new DataGridView();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            Txt_Nombre_TipoV = new TextBox();
            Txt_Descripcion_TipoV = new TextBox();
            label5 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            Btn_Limpiar_TipoT = new Button();
            Btn_Nuevo_TipoT = new Button();
            Btn_Editar_TipoT = new Button();
            Btn_Eliminar_TipoT = new Button();
            Btn_Guardar_TipoT = new Button();
            Btn_Actualizar_TipoT = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label15 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_TipoT).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = Color.Lavender;
            panel3.Controls.Add(Dgv_Tabla_TipoT);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 177);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 456);
            panel3.TabIndex = 12;
            // 
            // Dgv_Tabla_TipoT
            // 
            Dgv_Tabla_TipoT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_Tabla_TipoT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Tabla_TipoT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Tabla_TipoT.Location = new Point(28, 227);
            Dgv_Tabla_TipoT.Margin = new Padding(5);
            Dgv_Tabla_TipoT.Name = "Dgv_Tabla_TipoT";
            Dgv_Tabla_TipoT.RowHeadersWidth = 51;
            Dgv_Tabla_TipoT.Size = new Size(1291, 191);
            Dgv_Tabla_TipoT.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(Txt_Nombre_TipoV);
            panel4.Controls.Add(Txt_Descripcion_TipoV);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(14, 27);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(854, 165);
            panel4.TabIndex = 33;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Arg_Transporte;
            pictureBox4.Location = new Point(264, 21);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 42;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(305, 24);
            label1.Name = "label1";
            label1.Size = new Size(301, 32);
            label1.TabIndex = 34;
            label1.Text = "Información del Vehiculo";
            // 
            // Txt_Nombre_TipoV
            // 
            Txt_Nombre_TipoV.Location = new Point(105, 89);
            Txt_Nombre_TipoV.Margin = new Padding(5);
            Txt_Nombre_TipoV.Name = "Txt_Nombre_TipoV";
            Txt_Nombre_TipoV.PlaceholderText = "🙋 Nombres";
            Txt_Nombre_TipoV.Size = new Size(255, 27);
            Txt_Nombre_TipoV.TabIndex = 12;
            // 
            // Txt_Descripcion_TipoV
            // 
            Txt_Descripcion_TipoV.Location = new Point(535, 93);
            Txt_Descripcion_TipoV.Margin = new Padding(5);
            Txt_Descripcion_TipoV.Multiline = true;
            Txt_Descripcion_TipoV.Name = "Txt_Descripcion_TipoV";
            Txt_Descripcion_TipoV.PlaceholderText = "📑 Descripcion";
            Txt_Descripcion_TipoV.Size = new Size(255, 23);
            Txt_Descripcion_TipoV.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AliceBlue;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(412, 93);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 18);
            label5.TabIndex = 7;
            label5.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 93);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 18);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // panel5
            // 
            panel5.BackColor = Color.AliceBlue;
            panel5.Controls.Add(Btn_Guardar_TipoT);
            panel5.Controls.Add(Btn_Nuevo_TipoT);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(Btn_Limpiar_TipoT);
            panel5.Controls.Add(Btn_Editar_TipoT);
            panel5.Controls.Add(Btn_Eliminar_TipoT);
            panel5.Controls.Add(Btn_Actualizar_TipoT);
            panel5.Location = new Point(911, 27);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(425, 169);
            panel5.TabIndex = 40;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Icon_Acciones;
            pictureBox3.Location = new Point(129, 8);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 41;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(158, 13);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 40;
            label4.Text = "Acciones";
            // 
            // Btn_Limpiar_TipoT
            // 
            Btn_Limpiar_TipoT.Image = Properties.Resources.Btn_Limpiar;
            Btn_Limpiar_TipoT.Location = new Point(282, 103);
            Btn_Limpiar_TipoT.Margin = new Padding(3, 4, 3, 4);
            Btn_Limpiar_TipoT.Name = "Btn_Limpiar_TipoT";
            Btn_Limpiar_TipoT.Size = new Size(126, 49);
            Btn_Limpiar_TipoT.TabIndex = 39;
            Btn_Limpiar_TipoT.UseVisualStyleBackColor = true;
            // 
            // Btn_Nuevo_TipoT
            // 
            Btn_Nuevo_TipoT.Image = Properties.Resources.Btn_Nuevo;
            Btn_Nuevo_TipoT.Location = new Point(17, 45);
            Btn_Nuevo_TipoT.Margin = new Padding(3, 4, 3, 4);
            Btn_Nuevo_TipoT.Name = "Btn_Nuevo_TipoT";
            Btn_Nuevo_TipoT.Size = new Size(126, 49);
            Btn_Nuevo_TipoT.TabIndex = 34;
            Btn_Nuevo_TipoT.UseVisualStyleBackColor = true;
            Btn_Nuevo_TipoT.Click += Btn_Nuevo_TipoT_Click;
            // 
            // Btn_Editar_TipoT
            // 
            Btn_Editar_TipoT.Image = Properties.Resources.Btn_Editar;
            Btn_Editar_TipoT.Location = new Point(280, 45);
            Btn_Editar_TipoT.Margin = new Padding(3, 4, 3, 4);
            Btn_Editar_TipoT.Name = "Btn_Editar_TipoT";
            Btn_Editar_TipoT.Size = new Size(126, 49);
            Btn_Editar_TipoT.TabIndex = 36;
            Btn_Editar_TipoT.UseVisualStyleBackColor = true;
            Btn_Editar_TipoT.Click += button3_Click;
            // 
            // Btn_Eliminar_TipoT
            // 
            Btn_Eliminar_TipoT.Image = Properties.Resources.Btn_ELiminar;
            Btn_Eliminar_TipoT.Location = new Point(17, 104);
            Btn_Eliminar_TipoT.Margin = new Padding(3, 4, 3, 4);
            Btn_Eliminar_TipoT.Name = "Btn_Eliminar_TipoT";
            Btn_Eliminar_TipoT.Size = new Size(126, 49);
            Btn_Eliminar_TipoT.TabIndex = 37;
            Btn_Eliminar_TipoT.UseVisualStyleBackColor = true;
            Btn_Eliminar_TipoT.Click += Btn_Eliminar_TipoT_Click;
            // 
            // Btn_Guardar_TipoT
            // 
            Btn_Guardar_TipoT.Image = Properties.Resources.Btn_guardar;
            Btn_Guardar_TipoT.Location = new Point(150, 45);
            Btn_Guardar_TipoT.Margin = new Padding(3, 4, 3, 4);
            Btn_Guardar_TipoT.Name = "Btn_Guardar_TipoT";
            Btn_Guardar_TipoT.Size = new Size(126, 49);
            Btn_Guardar_TipoT.TabIndex = 35;
            Btn_Guardar_TipoT.UseVisualStyleBackColor = true;
            Btn_Guardar_TipoT.Click += button2_Click;
            // 
            // Btn_Actualizar_TipoT
            // 
            Btn_Actualizar_TipoT.Image = Properties.Resources.Btn_Actualizar;
            Btn_Actualizar_TipoT.Location = new Point(150, 103);
            Btn_Actualizar_TipoT.Margin = new Padding(3, 4, 3, 4);
            Btn_Actualizar_TipoT.Name = "Btn_Actualizar_TipoT";
            Btn_Actualizar_TipoT.Size = new Size(126, 49);
            Btn_Actualizar_TipoT.TabIndex = 38;
            Btn_Actualizar_TipoT.UseVisualStyleBackColor = true;
            Btn_Actualizar_TipoT.Click += button5_Click;
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 177);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.patito1;
            pictureBox1.Location = new Point(1168, 11);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(183, 105);
            label15.Name = "label15";
            label15.Size = new Size(516, 28);
            label15.TabIndex = 8;
            label15.Text = "Administra los tipos de vehículos utilizados en la empresa.";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Tipo_V;
            pictureBox2.Location = new Point(32, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(183, 47);
            label2.Name = "label2";
            label2.Size = new Size(290, 52);
            label2.TabIndex = 6;
            label2.Text = "Tipos Vehiculos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            label2.Click += label2_Click;
            // 
            // Tipo_Transporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 633);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "Tipo_Transporte";
            Text = "Form6";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_TipoT).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Txt_Descripcion_TipoV;
        private System.Windows.Forms.TextBox Txt_Nombre_TipoV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dgv_Tabla_TipoT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Panel panel4;
        private Button Btn_Nuevo_TipoT;
        private Label label1;
        private Panel panel5;
        private Button Btn_Editar_TipoT;
        private Button Btn_Limpiar_TipoT;
        private Button Btn_Guardar_TipoT;
        private Button Btn_Eliminar_TipoT;
        private Button Btn_Actualizar_TipoT;
        private Label label4;
        private Label label15;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}