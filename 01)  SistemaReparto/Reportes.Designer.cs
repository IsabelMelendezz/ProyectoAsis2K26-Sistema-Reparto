namespace SistemaReparto
{
    partial class Reportes
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
            Lbl_Enca_Repo = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            cbo_Selecciona_Reportes = new ComboBox();
            dataGridView1 = new DataGridView();
            Dt_Desde_Reporte = new DateTimePicker();
            Dt_Hasta_Reporte = new DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            Btn_Generar_Reporte = new Button();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Controls.Add(Lbl_Enca_Repo);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1492, 176);
            panel1.TabIndex = 2;
            // 
            // Lbl_Enca_Repo
            // 
            Lbl_Enca_Repo.AutoSize = true;
            Lbl_Enca_Repo.BackColor = Color.Transparent;
            Lbl_Enca_Repo.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            Lbl_Enca_Repo.ForeColor = SystemColors.ButtonHighlight;
            Lbl_Enca_Repo.Location = new Point(172, 94);
            Lbl_Enca_Repo.Name = "Lbl_Enca_Repo";
            Lbl_Enca_Repo.Size = new Size(354, 28);
            Lbl_Enca_Repo.TabIndex = 11;
            Lbl_Enca_Repo.Text = "Consulta y Genera reportes del Sistema";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.patito1;
            pictureBox2.Location = new Point(1306, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Repo_ico;
            pictureBox1.Location = new Point(34, 23);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(172, 42);
            label2.Name = "label2";
            label2.Size = new Size(182, 52);
            label2.TabIndex = 6;
            label2.Text = "REPORTES";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 191);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 3;
            label3.Text = "Seleccione Reporte:";
            // 
            // cbo_Selecciona_Reportes
            // 
            cbo_Selecciona_Reportes.FormattingEnabled = true;
            cbo_Selecciona_Reportes.Items.AddRange(new object[] { "Pedido", "Ruta", "Empleado", "Vehiculo" });
            cbo_Selecciona_Reportes.Location = new Point(34, 225);
            cbo_Selecciona_Reportes.Name = "cbo_Selecciona_Reportes";
            cbo_Selecciona_Reportes.Size = new Size(170, 28);
            cbo_Selecciona_Reportes.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 309);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1030, 496);
            dataGridView1.TabIndex = 11;
            // 
            // Dt_Desde_Reporte
            // 
            Dt_Desde_Reporte.Format = DateTimePickerFormat.Short;
            Dt_Desde_Reporte.Location = new Point(259, 226);
            Dt_Desde_Reporte.Name = "Dt_Desde_Reporte";
            Dt_Desde_Reporte.Size = new Size(134, 27);
            Dt_Desde_Reporte.TabIndex = 12;
            // 
            // Dt_Hasta_Reporte
            // 
            Dt_Hasta_Reporte.Format = DateTimePickerFormat.Short;
            Dt_Hasta_Reporte.Location = new Point(435, 226);
            Dt_Hasta_Reporte.Name = "Dt_Hasta_Reporte";
            Dt_Hasta_Reporte.Size = new Size(133, 27);
            Dt_Hasta_Reporte.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 193);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 14;
            label1.Text = "Desde que fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(435, 193);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 15;
            label4.Text = "Hasta que fecha:";
            // 
            // Btn_Generar_Reporte
            // 
            Btn_Generar_Reporte.BackColor = Color.FromArgb(31, 145, 62);
            Btn_Generar_Reporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Btn_Generar_Reporte.ForeColor = Color.White;
            Btn_Generar_Reporte.Location = new Point(605, 206);
            Btn_Generar_Reporte.Name = "Btn_Generar_Reporte";
            Btn_Generar_Reporte.Size = new Size(115, 32);
            Btn_Generar_Reporte.TabIndex = 16;
            Btn_Generar_Reporte.Text = "\U0001fa84 Generar";
            Btn_Generar_Reporte.UseVisualStyleBackColor = false;
            Btn_Generar_Reporte.Click += button1_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(1075, 309);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(405, 496);
            formsPlot1.TabIndex = 17;
            formsPlot1.Load += formsPlot1_Load;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 854);
            Controls.Add(formsPlot1);
            Controls.Add(Btn_Generar_Reporte);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(Dt_Hasta_Reporte);
            Controls.Add(Dt_Desde_Reporte);
            Controls.Add(dataGridView1);
            Controls.Add(cbo_Selecciona_Reportes);
            Controls.Add(label3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Reportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Reportes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Label label3;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private ComboBox cbo_Selecciona_Reportes;
        private ComboBox cbo_Repartidor_Reportes;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID_Pedido;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private PictureBox pictureBox2;
        private Label Lbl_Enca_Repo;
        private DateTimePicker Dt_Desde_Reporte;
        private DateTimePicker Dt_Hasta_Reporte;
        private Label label1;
        private Label label4;
        private Button Btn_Generar_Reporte;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}