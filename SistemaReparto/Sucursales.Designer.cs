namespace SistemaReparto
{
    partial class Sucursales
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
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox3 = new ComboBox();
            label7 = new Label();
            comboBox4 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ID_Sucursal = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1079, 176);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(683, 39);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.MaximumSize = new Size(1500, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 134);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 43);
            label2.Name = "label2";
            label2.Size = new Size(203, 52);
            label2.TabIndex = 6;
            label2.Text = "Sucursales";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bodega;
            pictureBox1.Location = new Point(225, 10);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 105);
            label1.Name = "label1";
            label1.Size = new Size(176, 23);
            label1.TabIndex = 4;
            label1.Text = "Sistema de paqueteria";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(90, 70);
            label4.Name = "label4";
            label4.Size = new Size(121, 34);
            label4.TabIndex = 5;
            label4.Text = "UI DESING";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseCompatibleTextRendering = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_envios_2;
            pictureBox2.Location = new Point(11, 39);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 220);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 3;
            label3.Text = "Sucursales:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(58, 261);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 28);
            comboBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(370, 220);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 5;
            label5.Text = "Departamentos:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(370, 261);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(177, 28);
            comboBox2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 336);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 7;
            label6.Text = "Encargado:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(58, 373);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 336);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 9;
            label7.Text = "Estado Bodega:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(370, 373);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(626, 313);
            button1.Name = "button1";
            button1.Size = new Size(164, 29);
            button1.TabIndex = 11;
            button1.Text = "Añadir Sucursal";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_Sucursal, Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(11, 446);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1055, 188);
            dataGridView1.TabIndex = 12;
            // 
            // ID_Sucursal
            // 
            ID_Sucursal.HeaderText = "ID_Sucursal";
            ID_Sucursal.MinimumWidth = 6;
            ID_Sucursal.Name = "ID_Sucursal";
            ID_Sucursal.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Direccion";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Departamento";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Encargado";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total_Paquetes";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Estado_Bodega";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Personal";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Sucursales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 854);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(comboBox4);
            Controls.Add(label7);
            Controls.Add(comboBox3);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Sucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Sucursales_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox3;
        private Label label7;
        private ComboBox comboBox4;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID_Sucursal;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}