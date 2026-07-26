namespace SistemaReparto
{
    partial class Repartidores
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
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbo_Zona_Reparto = new ComboBox();
            cbo_Entrega_Reparto = new ComboBox();
            cbo_Queja_Reparto = new ComboBox();
            nud_Edad_Reparto = new DomainUpDown();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(540, 39);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.MaximumSize = new Size(1500, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 134);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 69);
            label2.Name = "label2";
            label2.Size = new Size(268, 52);
            label2.TabIndex = 6;
            label2.Text = "REPARTIDORES";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.repartidores;
            pictureBox1.Location = new Point(371, 10);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 219);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 3;
            label3.Text = "Zona Asignada:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 219);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 4;
            label5.Text = "Rango de Edad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(534, 221);
            label6.Name = "label6";
            label6.Size = new Size(179, 20);
            label6.TabIndex = 5;
            label6.Text = "Rendimiento de Entregas:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(804, 224);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 6;
            label7.Text = "Tipo de Quejas:";
            // 
            // cbo_Zona_Reparto
            // 
            cbo_Zona_Reparto.FormattingEnabled = true;
            cbo_Zona_Reparto.Location = new Point(34, 255);
            cbo_Zona_Reparto.Name = "cbo_Zona_Reparto";
            cbo_Zona_Reparto.Size = new Size(177, 28);
            cbo_Zona_Reparto.TabIndex = 7;
            // 
            // cbo_Entrega_Reparto
            // 
            cbo_Entrega_Reparto.FormattingEnabled = true;
            cbo_Entrega_Reparto.Location = new Point(534, 255);
            cbo_Entrega_Reparto.Name = "cbo_Entrega_Reparto";
            cbo_Entrega_Reparto.Size = new Size(179, 28);
            cbo_Entrega_Reparto.TabIndex = 8;
            // 
            // cbo_Queja_Reparto
            // 
            cbo_Queja_Reparto.FormattingEnabled = true;
            cbo_Queja_Reparto.Items.AddRange(new object[] { "Negativa" });
            cbo_Queja_Reparto.Location = new Point(804, 255);
            cbo_Queja_Reparto.Name = "cbo_Queja_Reparto";
            cbo_Queja_Reparto.Size = new Size(163, 28);
            cbo_Queja_Reparto.TabIndex = 9;
            // 
            // nud_Edad_Reparto
            // 
            nud_Edad_Reparto.Items.Add("41-50");
            nud_Edad_Reparto.Items.Add("31-40");
            nud_Edad_Reparto.Items.Add("20-30");
            nud_Edad_Reparto.Location = new Point(311, 256);
            nud_Edad_Reparto.Name = "nud_Edad_Reparto";
            nud_Edad_Reparto.Size = new Size(169, 27);
            nud_Edad_Reparto.TabIndex = 10;
            // 
            // Repartidores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 854);
            Controls.Add(nud_Edad_Reparto);
            Controls.Add(cbo_Queja_Reparto);
            Controls.Add(cbo_Entrega_Reparto);
            Controls.Add(cbo_Zona_Reparto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Repartidores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Repartidores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbo_Zona_Reparto;
        private ComboBox cbo_Entrega_Reparto;
        private ComboBox cbo_Queja_Reparto;
        private DomainUpDown nud_Edad_Reparto;
    }
}