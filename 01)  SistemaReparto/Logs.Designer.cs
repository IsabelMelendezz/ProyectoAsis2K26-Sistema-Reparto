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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logs));
            btn_Log = new Button();
            txt_Usu_Log = new TextBox();
            txt_Contra_Log = new TextBox();
            lbl_no_Cuenta = new Label();
            pictureLog1 = new PictureBox();
            lbl_Inicio = new Label();
            pnl_log = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            lnkrecuperacion = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureLog1).BeginInit();
            pnl_log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Log
            // 
            btn_Log.FlatStyle = FlatStyle.Popup;
            btn_Log.Location = new Point(151, 374);
            btn_Log.Margin = new Padding(4);
            btn_Log.Name = "btn_Log";
            btn_Log.Size = new Size(118, 36);
            btn_Log.TabIndex = 0;
            btn_Log.Text = "LOGIN";
            btn_Log.UseVisualStyleBackColor = true;
            btn_Log.Click += button1_Click;
            // 
            // txt_Usu_Log
            // 
            txt_Usu_Log.BackColor = SystemColors.Menu;
            txt_Usu_Log.ForeColor = SystemColors.InfoText;
            txt_Usu_Log.Location = new Point(61, 226);
            txt_Usu_Log.Margin = new Padding(4);
            txt_Usu_Log.Name = "txt_Usu_Log";
            txt_Usu_Log.PlaceholderText = "👤 Usuario";
            txt_Usu_Log.Size = new Size(325, 31);
            txt_Usu_Log.TabIndex = 1;
            // 
            // txt_Contra_Log
            // 
            txt_Contra_Log.Location = new Point(65, 300);
            txt_Contra_Log.Margin = new Padding(4);
            txt_Contra_Log.Name = "txt_Contra_Log";
            txt_Contra_Log.PasswordChar = '*';
            txt_Contra_Log.PlaceholderText = "🔐 Contraseña";
            txt_Contra_Log.Size = new Size(325, 31);
            txt_Contra_Log.TabIndex = 2;
            // 
            // lbl_no_Cuenta
            // 
            lbl_no_Cuenta.AutoSize = true;
            lbl_no_Cuenta.BackColor = SystemColors.ButtonFace;
            lbl_no_Cuenta.Location = new Point(30, 445);
            lbl_no_Cuenta.Margin = new Padding(4, 0, 4, 0);
            lbl_no_Cuenta.Name = "lbl_no_Cuenta";
            lbl_no_Cuenta.Size = new Size(0, 25);
            lbl_no_Cuenta.TabIndex = 6;
            lbl_no_Cuenta.Click += lbl_no_Cuenta_Click;
            // 
            // pictureLog1
            // 
            pictureLog1.ErrorImage = null;
            pictureLog1.Image = Properties.Resources.patito;
            pictureLog1.Location = new Point(138, 19);
            pictureLog1.Margin = new Padding(4);
            pictureLog1.Name = "pictureLog1";
            pictureLog1.Size = new Size(142, 139);
            pictureLog1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLog1.TabIndex = 7;
            pictureLog1.TabStop = false;
            // 
            // lbl_Inicio
            // 
            lbl_Inicio.AutoSize = true;
            lbl_Inicio.BackColor = SystemColors.ButtonFace;
            lbl_Inicio.Location = new Point(138, 175);
            lbl_Inicio.Margin = new Padding(4, 0, 4, 0);
            lbl_Inicio.Name = "lbl_Inicio";
            lbl_Inicio.Size = new Size(140, 25);
            lbl_Inicio.TabIndex = 8;
            lbl_Inicio.Text = "INICIAR SESIÓN";
            // 
            // pnl_log
            // 
            pnl_log.BackColor = SystemColors.ButtonFace;
            pnl_log.Controls.Add(lnkrecuperacion);
            pnl_log.Controls.Add(txt_Contra_Log);
            pnl_log.Controls.Add(txt_Usu_Log);
            pnl_log.Controls.Add(lbl_no_Cuenta);
            pnl_log.Controls.Add(btn_Log);
            pnl_log.Controls.Add(pictureLog1);
            pnl_log.Controls.Add(lbl_Inicio);
            pnl_log.Controls.Add(panel2);
            pnl_log.Controls.Add(panel3);
            pnl_log.Location = new Point(656, 166);
            pnl_log.Margin = new Padding(4);
            pnl_log.Name = "pnl_log";
            pnl_log.Size = new Size(439, 500);
            pnl_log.TabIndex = 11;
            pnl_log.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Location = new Point(56, 220);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 44);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SkyBlue;
            panel3.Location = new Point(60, 292);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(335, 45);
            panel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Fondo_1;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1122, 749);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lnkrecuperacion
            // 
            lnkrecuperacion.AutoSize = true;
            lnkrecuperacion.Location = new Point(49, 437);
            lnkrecuperacion.Name = "lnkrecuperacion";
            lnkrecuperacion.Size = new Size(214, 25);
            lnkrecuperacion.TabIndex = 13;
            lnkrecuperacion.TabStop = true;
            lnkrecuperacion.Text = "¿Olvidaste tu contraseña?";
            lnkrecuperacion.LinkClicked += lnkrecuperacion_LinkClicked;
            // 
            // Logs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1122, 749);
            Controls.Add(pnl_log);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Logs";
            Text = "Inicio de sesión";
            Load += Logs_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLog1).EndInit();
            pnl_log.ResumeLayout(false);
            pnl_log.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Log;
        private TextBox txt_Usu_Log;
        private TextBox txt_Contra_Log;
        private Label lbl_no_Cuenta;
        private PictureBox pictureLog1;
        private Label lbl_Inicio;
        private Panel pnl_log;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private LinkLabel lnkrecuperacion;
    }
}
