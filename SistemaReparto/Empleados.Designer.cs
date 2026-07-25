namespace SistemaReparto
{
    partial class Empleados
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
            dateTimePicker2 = new DateTimePicker();
            label13 = new Label();
            dataGridView1 = new DataGridView();
            Id_Empleado = new DataGridViewTextBoxColumn();
            Tipo_Empleado = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            DPI = new DataGridViewTextBoxColumn();
            NIT = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Fecha_nacimiento = new DataGridViewTextBoxColumn();
            Fecha_contratacion = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            dateTimePicker3 = new DateTimePicker();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label14 = new Label();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label12 = new Label();
            textBox1 = new TextBox();
            label11 = new Label();
            textBox3 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            button3 = new Button();
            button6 = new Button();
            button2 = new Button();
            button4 = new Button();
            button1 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label15 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel3.Controls.Add(dateTimePicker2);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 177);
            panel3.Margin = new Padding(5, 5, 5, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 572);
            panel3.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(1048, 56);
            dateTimePicker2.Margin = new Padding(5, 5, 5, 5);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(265, 27);
            dateTimePicker2.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(888, 63);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(155, 18);
            label13.TabIndex = 27;
            label13.Text = "Fecha Contratacion";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id_Empleado, Tipo_Empleado, Estado, Nombres, Apellidos, DPI, NIT, Correo, Direccion, Fecha_nacimiento, Fecha_contratacion });
            dataGridView1.Location = new Point(15, 385);
            dataGridView1.Margin = new Padding(5, 5, 5, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1291, 155);
            dataGridView1.TabIndex = 3;
            // 
            // Id_Empleado
            // 
            Id_Empleado.HeaderText = "Id_Empleado";
            Id_Empleado.MinimumWidth = 6;
            Id_Empleado.Name = "Id_Empleado";
            // 
            // Tipo_Empleado
            // 
            Tipo_Empleado.HeaderText = "Tipo_Empleado";
            Tipo_Empleado.MinimumWidth = 10;
            Tipo_Empleado.Name = "Tipo_Empleado";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            // 
            // Nombres
            // 
            Nombres.HeaderText = "Nombres";
            Nombres.MinimumWidth = 6;
            Nombres.Name = "Nombres";
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.MinimumWidth = 6;
            Apellidos.Name = "Apellidos";
            // 
            // DPI
            // 
            DPI.HeaderText = "DPI";
            DPI.MinimumWidth = 6;
            DPI.Name = "DPI";
            // 
            // NIT
            // 
            NIT.HeaderText = "NIT";
            NIT.MinimumWidth = 6;
            NIT.Name = "NIT";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            // 
            // Fecha_nacimiento
            // 
            Fecha_nacimiento.HeaderText = "Fecha_nacimiento";
            Fecha_nacimiento.MinimumWidth = 6;
            Fecha_nacimiento.Name = "Fecha_nacimiento";
            // 
            // Fecha_contratacion
            // 
            Fecha_contratacion.HeaderText = "Fecha_contratacion";
            Fecha_contratacion.MinimumWidth = 6;
            Fecha_contratacion.Name = "Fecha_contratacion";
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(dateTimePicker3);
            panel4.Controls.Add(comboBox3);
            panel4.Controls.Add(comboBox4);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(textBox6);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(14, 27);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(854, 324);
            panel4.TabIndex = 33;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.agregar_usuario__3_;
            pictureBox4.Location = new Point(264, 21);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 36);
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
            label1.Size = new Size(317, 32);
            label1.TabIndex = 34;
            label1.Text = "Información del Empleado";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(574, 253);
            dateTimePicker3.Margin = new Padding(5, 5, 5, 5);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(265, 27);
            dateTimePicker3.TabIndex = 33;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(146, 88);
            comboBox3.Margin = new Padding(5, 5, 5, 5);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(255, 28);
            comboBox3.TabIndex = 30;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(146, 253);
            comboBox4.Margin = new Padding(5, 5, 5, 5);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(255, 28);
            comboBox4.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(14, 253);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(136, 18);
            label14.TabIndex = 31;
            label14.Text = "Estado Empleado";
            label14.Click += label14_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(574, 72);
            textBox4.Margin = new Padding(5, 5, 5, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(265, 27);
            textBox4.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(574, 120);
            comboBox1.Margin = new Padding(5, 5, 5, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 28);
            comboBox1.TabIndex = 19;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(574, 161);
            comboBox2.Margin = new Padding(5, 5, 5, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(265, 28);
            comboBox2.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(430, 253);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(144, 18);
            label12.TabIndex = 25;
            label12.Text = "Fecha Nacimiento";
            label12.Click += label12_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 129);
            textBox1.Margin = new Padding(5, 5, 5, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 27);
            textBox1.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.AliceBlue;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(430, 209);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(81, 18);
            label11.TabIndex = 22;
            label11.Text = "Direccion";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(574, 200);
            textBox3.Margin = new Padding(5, 5, 5, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 27);
            textBox3.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.AliceBlue;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(430, 171);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(60, 18);
            label10.TabIndex = 20;
            label10.Text = "Correo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.AliceBlue;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(430, 129);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(71, 18);
            label9.TabIndex = 18;
            label9.Text = "Telefono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.AliceBlue;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(430, 81);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(29, 18);
            label8.TabIndex = 15;
            label8.Text = "NIT";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(146, 212);
            textBox6.Margin = new Padding(5, 5, 5, 5);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(255, 27);
            textBox6.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 171);
            textBox2.Margin = new Padding(5, 5, 5, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 27);
            textBox2.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AliceBlue;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 139);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 18);
            label5.TabIndex = 7;
            label5.Text = "Nombres";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AliceBlue;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 180);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 18);
            label7.TabIndex = 11;
            label7.Text = "Apellidos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AliceBlue;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 215);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(31, 18);
            label6.TabIndex = 9;
            label6.Text = "DPI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 93);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 18);
            label3.TabIndex = 5;
            label3.Text = "Tipo Empleado";
            // 
            // panel5
            // 
            panel5.BackColor = Color.AliceBlue;
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(button6);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(button5);
            panel5.Location = new Point(888, 147);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(425, 204);
            panel5.TabIndex = 40;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Icon_Acciones;
            pictureBox3.Location = new Point(119, 19);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 41;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(160, 19);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 40;
            label4.Text = "Acciones";
            // 
            // button3
            // 
            button3.Image = Properties.Resources.Btn_Editar;
            button3.Location = new Point(280, 76);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(126, 49);
            button3.TabIndex = 36;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Image = Properties.Resources.Btn_Limpiar;
            button6.Location = new Point(280, 133);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(126, 49);
            button6.TabIndex = 39;
            button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.Btn_guardar;
            button2.Location = new Point(147, 76);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(126, 49);
            button2.TabIndex = 35;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.Btn_ELiminar;
            button4.Location = new Point(15, 133);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(126, 49);
            button4.TabIndex = 37;
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Btn_Nuevo;
            button1.Location = new Point(15, 76);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(126, 49);
            button1.TabIndex = 34;
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.Btn_Actualizar;
            button5.Location = new Point(147, 133);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(126, 49);
            button5.TabIndex = 38;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
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
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.patito1;
            pictureBox1.Location = new Point(1126, 11);
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
            label15.Size = new Size(465, 28);
            label15.TabIndex = 8;
            label15.Text = "Gestiona la información del personal de la empresa.";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Repa_ico;
            pictureBox2.Location = new Point(59, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 132);
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
            label2.Size = new Size(214, 52);
            label2.TabIndex = 6;
            label2.Text = "Empleados";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            label2.Click += label2_Click;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Empleados";
            Text = "Form5";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox3;
        private Panel panel4;
        private Button button1;
        private Label label1;
        private DateTimePicker dateTimePicker3;
        private Panel panel5;
        private Button button3;
        private Button button6;
        private Button button2;
        private Button button4;
        private Button button5;
        private Label label4;
        private Label label15;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private DataGridViewTextBoxColumn Id_Empleado;
        private DataGridViewTextBoxColumn Tipo_Empleado;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn DPI;
        private DataGridViewTextBoxColumn NIT;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Fecha_nacimiento;
        private DataGridViewTextBoxColumn Fecha_contratacion;
        private PictureBox pictureBox4;
    }
}