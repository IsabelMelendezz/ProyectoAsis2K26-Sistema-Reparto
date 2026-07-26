namespace SistemaReparto
{
    partial class Registros
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
            txtApellidos = new TextBox();
            txtcontraseña = new TextBox();
            txtnombres = new TextBox();
            txtcontrav = new TextBox();
            label1 = new Label();
            txtemail = new TextBox();
            button1 = new Button();
            txttelefono = new TextBox();
            pictureBox2 = new PictureBox();
            pnl_Registro = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnl_Registro.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = SystemColors.ActiveBorder;
            txtApellidos.BorderStyle = BorderStyle.FixedSingle;
            txtApellidos.ForeColor = Color.Black;
            txtApellidos.ImeMode = ImeMode.NoControl;
            txtApellidos.Location = new Point(17, 160);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.PlaceholderText = "👥 APELLIDOS";
            txtApellidos.Size = new Size(313, 27);
            txtApellidos.TabIndex = 2;
            txtApellidos.TabStop = false;
            // 
            // txtcontraseña
            // 
            txtcontraseña.BackColor = SystemColors.ActiveBorder;
            txtcontraseña.BorderStyle = BorderStyle.FixedSingle;
            txtcontraseña.ForeColor = Color.Black;
            txtcontraseña.Location = new Point(17, 221);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PlaceholderText = "🔐 CONTRASEÑA";
            txtcontraseña.Size = new Size(313, 27);
            txtcontraseña.TabIndex = 3;
            txtcontraseña.TabStop = false;
            // 
            // txtnombres
            // 
            txtnombres.BackColor = SystemColors.ActiveBorder;
            txtnombres.BorderStyle = BorderStyle.FixedSingle;
            txtnombres.ForeColor = Color.Black;
            txtnombres.Location = new Point(17, 104);
            txtnombres.Name = "txtnombres";
            txtnombres.PlaceholderText = "👤​ NOMBRES";
            txtnombres.Size = new Size(313, 27);
            txtnombres.TabIndex = 1;
            txtnombres.TabStop = false;
            // 
            // txtcontrav
            // 
            txtcontrav.BackColor = SystemColors.ActiveBorder;
            txtcontrav.BorderStyle = BorderStyle.FixedSingle;
            txtcontrav.ForeColor = Color.Black;
            txtcontrav.Location = new Point(17, 280);
            txtcontrav.Name = "txtcontrav";
            txtcontrav.PlaceholderText = "🔏 CONFIRMAR CONTRASEÑA";
            txtcontrav.Size = new Size(313, 27);
            txtcontrav.TabIndex = 4;
            txtcontrav.TabStop = false;
            txtcontrav.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(64, 36);
            label1.Name = "label1";
            label1.Size = new Size(219, 28);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE USUARIO";
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.ActiveBorder;
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.ForeColor = Color.Black;
            txtemail.Location = new Point(17, 339);
            txtemail.Name = "txtemail";
            txtemail.PlaceholderText = "📩 EMAIL";
            txtemail.Size = new Size(313, 27);
            txtemail.TabIndex = 5;
            txtemail.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Window;
            button1.Image = Properties.Resources.boton_RE;
            button1.Location = new Point(88, 456);
            button1.Name = "button1";
            button1.Size = new Size(188, 37);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txttelefono
            // 
            txttelefono.BackColor = SystemColors.ActiveBorder;
            txttelefono.BorderStyle = BorderStyle.FixedSingle;
            txttelefono.ForeColor = Color.Black;
            txttelefono.Location = new Point(17, 394);
            txttelefono.Name = "txttelefono";
            txttelefono.PlaceholderText = "📞 TELEFONO";
            txttelefono.Size = new Size(313, 27);
            txttelefono.TabIndex = 6;
            txttelefono.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(-17, -82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(293, 70);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pnl_Registro
            // 
            pnl_Registro.AutoSize = true;
            pnl_Registro.BackColor = SystemColors.ButtonFace;
            pnl_Registro.Controls.Add(pictureBox2);
            pnl_Registro.Controls.Add(button1);
            pnl_Registro.Controls.Add(label1);
            pnl_Registro.Controls.Add(txtnombres);
            pnl_Registro.Controls.Add(txtApellidos);
            pnl_Registro.Controls.Add(txtcontraseña);
            pnl_Registro.Controls.Add(txtcontrav);
            pnl_Registro.Controls.Add(txtemail);
            pnl_Registro.Controls.Add(txttelefono);
            pnl_Registro.Location = new Point(224, 120);
            pnl_Registro.Name = "pnl_Registro";
            pnl_Registro.Size = new Size(358, 526);
            pnl_Registro.TabIndex = 8;
            pnl_Registro.Paint += pnl_Registro_Paint;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fondo_2;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnl_Registro);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 752);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.norton_Letras_logo;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(32, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 75);
            panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.norteklogo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(771, 762);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Registros";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            Load += Registros_Load;
            Resize += Registros_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnl_Registro.ResumeLayout(false);
            pnl_Registro.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtApellidos;
        private TextBox txtcontraseña;
        private TextBox txtnombres;
        private TextBox txtcontrav;
        private Label label1;
        private TextBox txtemail;
        private Button button1;
        private TextBox txttelefono;
        private PictureBox pictureBox2;
        private Panel pnl_Registro;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}