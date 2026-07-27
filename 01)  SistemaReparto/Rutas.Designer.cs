namespace SistemaReparto
{
    partial class Rutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rutas));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label15 = new Label();
            label2 = new Label();
            Total_Rutas = new DataGridView();
            panel3 = new Panel();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            Btn_Limpiar_Emp = new Button();
            Btn_Nueva_Ruta = new Button();
            Btn_Editar_Ruta = new Button();
            Btn_Eliminar_Ruta = new Button();
            Btn_Guardar_Ruta = new Button();
            Btn_Actualizar_Ruta = new Button();
            panel4 = new Panel();
            Text_Id_Ruta = new TextBox();
            label3 = new Label();
            label1 = new Label();
            Text_Nombre_Ruta = new TextBox();
            Text_Descripcion_Ruta = new TextBox();
            label5 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Total_Rutas).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 133);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.patito1;
            pictureBox2.Location = new Point(1029, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 20);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 90);
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
            label15.Location = new Point(156, 77);
            label15.Name = "label15";
            label15.Size = new Size(371, 21);
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
            label2.Location = new Point(156, 28);
            label2.Name = "label2";
            label2.Size = new Size(97, 42);
            label2.TabIndex = 6;
            label2.Text = "RUTAS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            label2.Click += label2_Click;
            // 
            // Total_Rutas
            // 
            Total_Rutas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Total_Rutas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Total_Rutas.Location = new Point(74, 286);
            Total_Rutas.Margin = new Padding(4, 4, 4, 4);
            Total_Rutas.Name = "Total_Rutas";
            Total_Rutas.RowHeadersWidth = 51;
            Total_Rutas.Size = new Size(1102, 277);
            Total_Rutas.TabIndex = 3;
            Total_Rutas.CellContentClick += dataGridView1_CellContentClick;
            Total_Rutas.CellMouseDoubleClick += Total_Rutas_CellMouseDoubleClick;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoScroll = true;
            panel3.BackColor = Color.Lavender;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(Total_Rutas);
            panel3.Location = new Point(0, 129);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1242, 590);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.AliceBlue;
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(Btn_Limpiar_Emp);
            panel5.Controls.Add(Btn_Nueva_Ruta);
            panel5.Controls.Add(Btn_Editar_Ruta);
            panel5.Controls.Add(Btn_Eliminar_Ruta);
            panel5.Controls.Add(Btn_Guardar_Ruta);
            panel5.Controls.Add(Btn_Actualizar_Ruta);
            panel5.Location = new Point(851, 50);
            panel5.Name = "panel5";
            panel5.Size = new Size(372, 127);
            panel5.TabIndex = 41;
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
            // Btn_Limpiar_Emp
            // 
            Btn_Limpiar_Emp.Image = Properties.Resources.Btn_Limpiar;
            Btn_Limpiar_Emp.Location = new Point(247, 77);
            Btn_Limpiar_Emp.Name = "Btn_Limpiar_Emp";
            Btn_Limpiar_Emp.Size = new Size(110, 37);
            Btn_Limpiar_Emp.TabIndex = 39;
            Btn_Limpiar_Emp.UseVisualStyleBackColor = true;
            Btn_Limpiar_Emp.Click += Btn_Limpiar_Emp_Click;
            // 
            // Btn_Nueva_Ruta
            // 
            Btn_Nueva_Ruta.Image = Properties.Resources.Btn_Nuevo;
            Btn_Nueva_Ruta.Location = new Point(15, 34);
            Btn_Nueva_Ruta.Name = "Btn_Nueva_Ruta";
            Btn_Nueva_Ruta.Size = new Size(110, 37);
            Btn_Nueva_Ruta.TabIndex = 34;
            Btn_Nueva_Ruta.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar_Ruta
            // 
            Btn_Editar_Ruta.Image = Properties.Resources.Btn_Editar;
            Btn_Editar_Ruta.Location = new Point(245, 34);
            Btn_Editar_Ruta.Name = "Btn_Editar_Ruta";
            Btn_Editar_Ruta.Size = new Size(110, 37);
            Btn_Editar_Ruta.TabIndex = 36;
            Btn_Editar_Ruta.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar_Ruta
            // 
            Btn_Eliminar_Ruta.Image = Properties.Resources.Btn_ELiminar;
            Btn_Eliminar_Ruta.Location = new Point(15, 78);
            Btn_Eliminar_Ruta.Name = "Btn_Eliminar_Ruta";
            Btn_Eliminar_Ruta.Size = new Size(110, 37);
            Btn_Eliminar_Ruta.TabIndex = 37;
            Btn_Eliminar_Ruta.UseVisualStyleBackColor = true;
            Btn_Eliminar_Ruta.Click += Btn_Eliminar_Ruta_Click;
            // 
            // Btn_Guardar_Ruta
            // 
            Btn_Guardar_Ruta.Image = Properties.Resources.Btn_guardar;
            Btn_Guardar_Ruta.Location = new Point(131, 34);
            Btn_Guardar_Ruta.Name = "Btn_Guardar_Ruta";
            Btn_Guardar_Ruta.Size = new Size(110, 37);
            Btn_Guardar_Ruta.TabIndex = 35;
            Btn_Guardar_Ruta.UseVisualStyleBackColor = true;
            Btn_Guardar_Ruta.Click += Btn_Guardar_Ruta_Click;
            // 
            // Btn_Actualizar_Ruta
            // 
            Btn_Actualizar_Ruta.Image = Properties.Resources.Btn_Actualizar;
            Btn_Actualizar_Ruta.Location = new Point(131, 77);
            Btn_Actualizar_Ruta.Name = "Btn_Actualizar_Ruta";
            Btn_Actualizar_Ruta.Size = new Size(110, 37);
            Btn_Actualizar_Ruta.TabIndex = 38;
            Btn_Actualizar_Ruta.UseVisualStyleBackColor = true;
            Btn_Actualizar_Ruta.Click += Btn_Actualizar_Ruta_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(Text_Id_Ruta);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(Text_Nombre_Ruta);
            panel4.Controls.Add(Text_Descripcion_Ruta);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(74, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(747, 221);
            panel4.TabIndex = 34;
            // 
            // Text_Id_Ruta
            // 
            Text_Id_Ruta.Location = new Point(306, 82);
            Text_Id_Ruta.Margin = new Padding(4, 4, 4, 4);
            Text_Id_Ruta.Name = "Text_Id_Ruta";
            Text_Id_Ruta.PlaceholderText = "ID_Tipo_Ruta";
            Text_Id_Ruta.ReadOnly = true;
            Text_Id_Ruta.Size = new Size(224, 23);
            Text_Id_Ruta.TabIndex = 36;
            Text_Id_Ruta.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(260, 85);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(19, 16);
            label3.TabIndex = 35;
            label3.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(243, 18);
            label1.Name = "label1";
            label1.Size = new Size(247, 25);
            label1.TabIndex = 34;
            label1.Text = "Información del Empleado";
            // 
            // Text_Nombre_Ruta
            // 
            Text_Nombre_Ruta.Location = new Point(126, 138);
            Text_Nombre_Ruta.Margin = new Padding(4, 4, 4, 4);
            Text_Nombre_Ruta.Name = "Text_Nombre_Ruta";
            Text_Nombre_Ruta.PlaceholderText = " Nombre";
            Text_Nombre_Ruta.Size = new Size(224, 23);
            Text_Nombre_Ruta.TabIndex = 12;
            // 
            // Text_Descripcion_Ruta
            // 
            Text_Descripcion_Ruta.Location = new Point(483, 138);
            Text_Descripcion_Ruta.Margin = new Padding(4, 4, 4, 4);
            Text_Descripcion_Ruta.Name = "Text_Descripcion_Ruta";
            Text_Descripcion_Ruta.PlaceholderText = "Descripcion";
            Text_Descripcion_Ruta.Size = new Size(224, 23);
            Text_Descripcion_Ruta.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AliceBlue;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 141);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 16);
            label5.TabIndex = 7;
            label5.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AliceBlue;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(371, 145);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(62, 16);
            label7.TabIndex = 11;
            label7.Text = "Apellidos";
            // 
            // Rutas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 562);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Rutas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Rutas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Total_Rutas).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Total_Rutas;
        private System.Windows.Forms.Panel panel3;
        private Label label15;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Label label1;
        private TextBox Text_Nombre_Ruta;
        private TextBox Text_Descripcion_Ruta;
        private Label label5;
        private Label label7;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label label4;
        private Button Btn_Limpiar_Emp;
        private Button Btn_Nueva_Ruta;
        private Button Btn_Editar_Ruta;
        private Button Btn_Eliminar_Ruta;
        private Button Btn_Guardar_Ruta;
        private Button Btn_Actualizar_Ruta;
        private TextBox Text_Id_Ruta;
        private Label label3;
    }
}