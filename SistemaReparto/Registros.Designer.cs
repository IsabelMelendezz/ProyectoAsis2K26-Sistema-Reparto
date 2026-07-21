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
            label1 = new Label();
            txtnombres = new TextBox();
            txtApellidos = new TextBox();
            txtcontraseña = new TextBox();
            txtcontrav = new TextBox();
            txtemail = new TextBox();
            txttelefono = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 46);
            label1.Name = "label1";
            label1.Size = new Size(225, 22);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE USUARIO";
            // 
            // txtnombres
            // 
            txtnombres.BackColor = SystemColors.ActiveBorder;
            txtnombres.BorderStyle = BorderStyle.FixedSingle;
            txtnombres.ForeColor = Color.Black;
            txtnombres.Location = new Point(76, 107);
            txtnombres.Name = "txtnombres";
            txtnombres.PlaceholderText = "👤​ NOMBRES";
            txtnombres.Size = new Size(313, 27);
            txtnombres.TabIndex = 1;
            txtnombres.TabStop = false;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = SystemColors.ActiveBorder;
            txtApellidos.BorderStyle = BorderStyle.FixedSingle;
            txtApellidos.ForeColor = Color.Black;
            txtApellidos.ImeMode = ImeMode.NoControl;
            txtApellidos.Location = new Point(76, 159);
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
            txtcontraseña.Location = new Point(76, 213);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PlaceholderText = "🔐 CONTRASEÑA";
            txtcontraseña.Size = new Size(313, 27);
            txtcontraseña.TabIndex = 3;
            txtcontraseña.TabStop = false;
            // 
            // txtcontrav
            // 
            txtcontrav.BackColor = SystemColors.ActiveBorder;
            txtcontrav.BorderStyle = BorderStyle.FixedSingle;
            txtcontrav.ForeColor = Color.Black;
            txtcontrav.Location = new Point(76, 261);
            txtcontrav.Name = "txtcontrav";
            txtcontrav.PlaceholderText = "🔏 CONFIRMAR CONTRASEÑA";
            txtcontrav.Size = new Size(313, 27);
            txtcontrav.TabIndex = 4;
            txtcontrav.TabStop = false;
            txtcontrav.TextChanged += textBox4_TextChanged;
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.ActiveBorder;
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.ForeColor = Color.Black;
            txtemail.Location = new Point(76, 309);
            txtemail.Name = "txtemail";
            txtemail.PlaceholderText = "📩 EMAIL";
            txtemail.Size = new Size(313, 27);
            txtemail.TabIndex = 5;
            txtemail.TabStop = false;
            // 
            // txttelefono
            // 
            txttelefono.BackColor = SystemColors.ActiveBorder;
            txttelefono.BorderStyle = BorderStyle.FixedSingle;
            txttelefono.ForeColor = Color.Black;
            txttelefono.Location = new Point(76, 358);
            txttelefono.Name = "txttelefono";
            txttelefono.PlaceholderText = "📞 TELEFONO";
            txttelefono.Size = new Size(313, 27);
            txttelefono.TabIndex = 6;
            txttelefono.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(168, 431);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 521);
            panel1.TabIndex = 8;
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(432, 521);
            Controls.Add(button1);
            Controls.Add(txttelefono);
            Controls.Add(txtemail);
            Controls.Add(txtcontrav);
            Controls.Add(txtcontraseña);
            Controls.Add(txtApellidos);
            Controls.Add(txtnombres);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Registros";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            Load += Registros_Load;
            Resize += Registros_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnombres;
        private TextBox txtApellidos;
        private TextBox txtcontraseña;
        private TextBox txtcontrav;
        private TextBox txtemail;
        private TextBox txttelefono;
        private Button button1;
        private Panel panel1;
    }
}