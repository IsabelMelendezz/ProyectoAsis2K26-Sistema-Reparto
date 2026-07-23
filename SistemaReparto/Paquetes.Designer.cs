namespace SistemaReparto
{
    partial class Paquetes
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
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            cbo_Fragil_Paquete = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            ID_Paquete = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            txt_Codigo_Paquete = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Indigo;
            panel1.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 176);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 72);
            label2.Name = "label2";
            label2.Size = new Size(190, 52);
            label2.TabIndex = 6;
            label2.Text = "PAQUETES";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(659, 39);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.MaximumSize = new Size(1500, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(327, 134);
            panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.paquetes;
            pictureBox1.Location = new Point(208, 10);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(475, 232);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 28);
            comboBox1.TabIndex = 3;
            // 
            // cbo_Fragil_Paquete
            // 
            cbo_Fragil_Paquete.FormattingEnabled = true;
            cbo_Fragil_Paquete.Items.AddRange(new object[] { "Si", "No" });
            cbo_Fragil_Paquete.Location = new Point(925, 232);
            cbo_Fragil_Paquete.Name = "cbo_Fragil_Paquete";
            cbo_Fragil_Paquete.Size = new Size(130, 28);
            cbo_Fragil_Paquete.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(687, 232);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(190, 28);
            comboBox3.TabIndex = 6;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(925, 312);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(130, 28);
            comboBox4.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 233);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "⚖️ Peso (Kg)";
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 209);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 9;
            label3.Text = "Ruta Asignada:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(687, 209);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 10;
            label5.Text = "Tipo de Paquete:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(244, 203);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 11;
            label6.Text = "Descripcion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(925, 289);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 12;
            label7.Text = "Estado:";
            // 
            // button1
            // 
            button1.Location = new Point(411, 396);
            button1.Name = "button1";
            button1.Size = new Size(152, 39);
            button1.TabIndex = 13;
            button1.Text = "➕ Añadir Paquete";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(592, 396);
            button2.Name = "button2";
            button2.Size = new Size(152, 37);
            button2.TabIndex = 14;
            button2.Text = "🔄️ Actializar Datos";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(244, 226);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Descripccion";
            textBox3.Size = new Size(190, 34);
            textBox3.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(925, 203);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 16;
            label8.Text = "Fragil: ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_Paquete, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dataGridView1.Location = new Point(13, 489);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1304, 182);
            dataGridView1.TabIndex = 17;
            // 
            // ID_Paquete
            // 
            ID_Paquete.HeaderText = "ID_Paquete";
            ID_Paquete.MinimumWidth = 6;
            ID_Paquete.Name = "ID_Paquete";
            ID_Paquete.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID_Pedido";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Codigo_Rastreo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Peso";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Alto";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Ancho";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Largo";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Descripcion";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Fragil";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Valor_Declarado";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 313);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "↔️ Ancho";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(28, 315);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "↕️ Alto";
            textBox4.Size = new Size(175, 27);
            textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(475, 314);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "📏 Largo";
            textBox5.Size = new Size(190, 27);
            textBox5.TabIndex = 20;
            // 
            // txt_Codigo_Paquete
            // 
            txt_Codigo_Paquete.Location = new Point(687, 314);
            txt_Codigo_Paquete.Name = "txt_Codigo_Paquete";
            txt_Codigo_Paquete.PlaceholderText = "🚚 Codigo Rastreo";
            txt_Codigo_Paquete.ReadOnly = true;
            txt_Codigo_Paquete.Size = new Size(190, 27);
            txt_Codigo_Paquete.TabIndex = 21;
            // 
            // Paquetes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 854);
            Controls.Add(txt_Codigo_Paquete);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(cbo_Fragil_Paquete);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Paquetes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private ComboBox comboBox1;
        private ComboBox cbo_Fragil_Paquete;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private TextBox textBox2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID_Paquete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox txt_Codigo_Paquete;
    }
}