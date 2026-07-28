namespace SistemaReparto
{
    partial class TipoEmpleado
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
            label2 = new Label();
            panel5 = new Panel();
            Btn_Guardar_TipoE = new Button();
            Btn_Nuevo_TipoE = new Button();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            Btn_Limpiar_TipoE = new Button();
            Btn_Editar_TipoE = new Button();
            Btn_Eliminar_TipoE = new Button();
            Btn_Actualizar_TipoE = new Button();
            label5 = new Label();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            Txt_Nombre_TipoEmp = new TextBox();
            panel4 = new Panel();
            Txt_Descripcion_TipoE = new TextBox();
            Dgv_Tabla_TipoE = new DataGridView();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_TipoE).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(1190, 133);
            panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.patito1;
            pictureBox1.Location = new Point(2899, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 122);
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
            label15.Location = new Point(160, 79);
            label15.Name = "label15";
            label15.Size = new Size(415, 21);
            label15.TabIndex = 8;
            label15.Text = "Registre los tipos de cargos que se manejan en la empresa.";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(160, 37);
            label2.Name = "label2";
            label2.Size = new Size(225, 42);
            label2.TabIndex = 6;
            label2.Text = "Tipo Empleado";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.AliceBlue;
            panel5.Controls.Add(Btn_Guardar_TipoE);
            panel5.Controls.Add(Btn_Nuevo_TipoE);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(Btn_Limpiar_TipoE);
            panel5.Controls.Add(Btn_Editar_TipoE);
            panel5.Controls.Add(Btn_Eliminar_TipoE);
            panel5.Controls.Add(Btn_Actualizar_TipoE);
            panel5.Location = new Point(788, 185);
            panel5.Name = "panel5";
            panel5.Size = new Size(372, 127);
            panel5.TabIndex = 40;
            // 
            // Btn_Guardar_TipoE
            // 
            Btn_Guardar_TipoE.Image = Properties.Resources.Btn_guardar;
            Btn_Guardar_TipoE.Location = new Point(131, 34);
            Btn_Guardar_TipoE.Name = "Btn_Guardar_TipoE";
            Btn_Guardar_TipoE.Size = new Size(110, 37);
            Btn_Guardar_TipoE.TabIndex = 35;
            Btn_Guardar_TipoE.UseVisualStyleBackColor = true;
            // 
            // Btn_Nuevo_TipoE
            // 
            Btn_Nuevo_TipoE.Image = Properties.Resources.Btn_Nuevo;
            Btn_Nuevo_TipoE.Location = new Point(15, 34);
            Btn_Nuevo_TipoE.Name = "Btn_Nuevo_TipoE";
            Btn_Nuevo_TipoE.Size = new Size(110, 37);
            Btn_Nuevo_TipoE.TabIndex = 34;
            Btn_Nuevo_TipoE.UseVisualStyleBackColor = true;
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
            // Btn_Limpiar_TipoE
            // 
            Btn_Limpiar_TipoE.Image = Properties.Resources.Btn_Limpiar;
            Btn_Limpiar_TipoE.Location = new Point(247, 77);
            Btn_Limpiar_TipoE.Name = "Btn_Limpiar_TipoE";
            Btn_Limpiar_TipoE.Size = new Size(110, 37);
            Btn_Limpiar_TipoE.TabIndex = 39;
            Btn_Limpiar_TipoE.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar_TipoE
            // 
            Btn_Editar_TipoE.Image = Properties.Resources.Btn_Editar;
            Btn_Editar_TipoE.Location = new Point(245, 34);
            Btn_Editar_TipoE.Name = "Btn_Editar_TipoE";
            Btn_Editar_TipoE.Size = new Size(110, 37);
            Btn_Editar_TipoE.TabIndex = 36;
            Btn_Editar_TipoE.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar_TipoE
            // 
            Btn_Eliminar_TipoE.Image = Properties.Resources.Btn_ELiminar;
            Btn_Eliminar_TipoE.Location = new Point(15, 78);
            Btn_Eliminar_TipoE.Name = "Btn_Eliminar_TipoE";
            Btn_Eliminar_TipoE.Size = new Size(110, 37);
            Btn_Eliminar_TipoE.TabIndex = 37;
            Btn_Eliminar_TipoE.UseVisualStyleBackColor = true;
            // 
            // Btn_Actualizar_TipoE
            // 
            Btn_Actualizar_TipoE.Image = Properties.Resources.Btn_Actualizar;
            Btn_Actualizar_TipoE.Location = new Point(131, 77);
            Btn_Actualizar_TipoE.Name = "Btn_Actualizar_TipoE";
            Btn_Actualizar_TipoE.Size = new Size(110, 37);
            Btn_Actualizar_TipoE.TabIndex = 38;
            Btn_Actualizar_TipoE.UseVisualStyleBackColor = true;
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
            // Txt_Nombre_TipoEmp
            // 
            Txt_Nombre_TipoEmp.Location = new Point(92, 67);
            Txt_Nombre_TipoEmp.Margin = new Padding(4);
            Txt_Nombre_TipoEmp.Name = "Txt_Nombre_TipoEmp";
            Txt_Nombre_TipoEmp.PlaceholderText = "🙋 Nombres";
            Txt_Nombre_TipoEmp.Size = new Size(224, 23);
            Txt_Nombre_TipoEmp.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(Txt_Nombre_TipoEmp);
            panel4.Controls.Add(Txt_Descripcion_TipoE);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(28, 188);
            panel4.Name = "panel4";
            panel4.Size = new Size(747, 124);
            panel4.TabIndex = 33;
            // 
            // Txt_Descripcion_TipoE
            // 
            Txt_Descripcion_TipoE.Location = new Point(468, 70);
            Txt_Descripcion_TipoE.Margin = new Padding(4);
            Txt_Descripcion_TipoE.Multiline = true;
            Txt_Descripcion_TipoE.Name = "Txt_Descripcion_TipoE";
            Txt_Descripcion_TipoE.PlaceholderText = "📑 Descripcion";
            Txt_Descripcion_TipoE.Size = new Size(224, 18);
            Txt_Descripcion_TipoE.TabIndex = 13;
            // 
            // Dgv_Tabla_TipoE
            // 
            Dgv_Tabla_TipoE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_Tabla_TipoE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Tabla_TipoE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Tabla_TipoE.Location = new Point(28, 328);
            Dgv_Tabla_TipoE.Margin = new Padding(4);
            Dgv_Tabla_TipoE.Name = "Dgv_Tabla_TipoE";
            Dgv_Tabla_TipoE.RowHeadersWidth = 51;
            Dgv_Tabla_TipoE.Size = new Size(2072, 791);
            Dgv_Tabla_TipoE.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = Color.Lavender;
            panel3.Controls.Add(Dgv_Tabla_TipoE);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1190, 635);
            panel3.TabIndex = 16;
            //panel3.Paint += this.panel3_Paint;
            // 
            // TipoEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 635);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "TipoEmpleado";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_TipoE).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label15;
        private Label label2;
        private Panel panel5;
        private Button Btn_Guardar_TipoE;
        private Button Btn_Nuevo_TipoE;
        private PictureBox pictureBox3;
        private Label label4;
        private Button Btn_Limpiar_TipoE;
        private Button Btn_Editar_TipoE;
        private Button Btn_Eliminar_TipoE;
        private Button Btn_Actualizar_TipoE;
        private Label label5;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label1;
        private TextBox Txt_Nombre_TipoEmp;
        private Panel panel4;
        private TextBox Txt_Descripcion_TipoE;
        private DataGridView Dgv_Tabla_TipoE;
        private Panel panel3;
    }
}