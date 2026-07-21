namespace SistemaReparto
{
    partial class Logs
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Log = new Button();
            txt_Usu_Log = new TextBox();
            txt_Contra_Log = new TextBox();
            btn_Registrar_Log = new Button();
            lbl_no_Cuenta = new Label();
            pictureLog1 = new PictureBox();
            lbl_Inicio = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureLog1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Log
            // 
            btn_Log.FlatStyle = FlatStyle.Popup;
            btn_Log.Location = new Point(121, 299);
            btn_Log.Name = "btn_Log";
            btn_Log.Size = new Size(94, 29);
            btn_Log.TabIndex = 0;
            btn_Log.Text = "LOGIN";
            btn_Log.UseVisualStyleBackColor = true;
            btn_Log.Click += button1_Click;
            // 
            // txt_Usu_Log
            // 
            txt_Usu_Log.BackColor = SystemColors.Menu;
            txt_Usu_Log.ForeColor = SystemColors.InfoText;
            txt_Usu_Log.Location = new Point(49, 181);
            txt_Usu_Log.Name = "txt_Usu_Log";
            txt_Usu_Log.PlaceholderText = "👤 Usuario";
            txt_Usu_Log.Size = new Size(261, 27);
            txt_Usu_Log.TabIndex = 1;
            // 
            // txt_Contra_Log
            // 
            txt_Contra_Log.Location = new Point(52, 240);
            txt_Contra_Log.Name = "txt_Contra_Log";
            txt_Contra_Log.PasswordChar = '*';
            txt_Contra_Log.PlaceholderText = "🔐 Contraseña";
            txt_Contra_Log.Size = new Size(261, 27);
            txt_Contra_Log.TabIndex = 2;
            // 
            // btn_Registrar_Log
            // 
            btn_Registrar_Log.BackColor = SystemColors.ButtonFace;
            btn_Registrar_Log.FlatStyle = FlatStyle.Flat;
            btn_Registrar_Log.ForeColor = Color.Black;
            btn_Registrar_Log.Location = new Point(215, 346);
            btn_Registrar_Log.Name = "btn_Registrar_Log";
            btn_Registrar_Log.Size = new Size(95, 30);
            btn_Registrar_Log.TabIndex = 4;
            btn_Registrar_Log.Text = "Registrate";
            btn_Registrar_Log.UseVisualStyleBackColor = false;
            btn_Registrar_Log.Click += button2_Click;
            // 
            // lbl_no_Cuenta
            // 
            lbl_no_Cuenta.AutoSize = true;
            lbl_no_Cuenta.BackColor = SystemColors.ButtonFace;
            lbl_no_Cuenta.Location = new Point(24, 356);
            lbl_no_Cuenta.Name = "lbl_no_Cuenta";
            lbl_no_Cuenta.Size = new Size(162, 20);
            lbl_no_Cuenta.TabIndex = 6;
            lbl_no_Cuenta.Text = "¿No tienes una cuenta?";
            // 
            // pictureLog1
            // 
            pictureLog1.ErrorImage = null;
            pictureLog1.Image = Properties.Resources.patito;
            pictureLog1.Location = new Point(110, 15);
            pictureLog1.Name = "pictureLog1";
            pictureLog1.Size = new Size(114, 111);
            pictureLog1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLog1.TabIndex = 7;
            pictureLog1.TabStop = false;
            // 
            // lbl_Inicio
            // 
            lbl_Inicio.AutoSize = true;
            lbl_Inicio.BackColor = SystemColors.ButtonFace;
            lbl_Inicio.Location = new Point(110, 140);
            lbl_Inicio.Name = "lbl_Inicio";
            lbl_Inicio.Size = new Size(114, 20);
            lbl_Inicio.TabIndex = 8;
            lbl_Inicio.Text = "INICIAR SESIÓN";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(txt_Contra_Log);
            panel1.Controls.Add(txt_Usu_Log);
            panel1.Controls.Add(lbl_no_Cuenta);
            panel1.Controls.Add(btn_Log);
            panel1.Controls.Add(pictureLog1);
            panel1.Controls.Add(lbl_Inicio);
            panel1.Controls.Add(btn_Registrar_Log);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(525, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 400);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Location = new Point(45, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 35);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SkyBlue;
            panel3.Location = new Point(48, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 36);
            panel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Fondo_1;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(898, 599);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Logs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(898, 599);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Logs";
            Text = "Form1";
            Load += Logs_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLog1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Log;
        private TextBox txt_Usu_Log;
        private TextBox txt_Contra_Log;
        private Button btn_Registrar_Log;
        private Label lbl_no_Cuenta;
        private PictureBox pictureLog1;
        private Label lbl_Inicio;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
    }
}
