namespace SistemaReparto
{
    partial class Recuperacion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recuperacion));
            panelSidebar = new Panel();
            picLogo = new PictureBox();
            lblSidebarTitle = new Label();
            lblSidebarSub = new Label();
            panelSeguridad = new Panel();
            picShield = new PictureBox();
            lblSeguridadTitulo = new Label();
            lblSeguridadTexto = new Label();
            panelContent = new Panel();
            lblTitulo = new Label();
            pnlUnderline = new Panel();
            pnlCircle1 = new Label();
            lblStep1 = new Label();
            pnlLineProgress1 = new Panel();
            pnlCircle2 = new Label();
            lblStep2 = new Label();
            pnlLineProgress2 = new Panel();
            panelStep1 = new Panel();
            picEnvelope = new PictureBox();
            lblStep1Title = new Label();
            lblStep1Desc = new Label();
            txtUsuario = new TextBox();
            txtCorreo = new TextBox();
            btnEnviarCodigo = new Button();
            picArrowCircle = new Label();
            panelStep2 = new Panel();
            picLock = new PictureBox();
            lblStep2Title = new Label();
            lblStep2Desc = new Label();
            txtCodigo = new TextBox();
            txtNuevaContraseña = new TextBox();
            lblEyeNueva = new Label();
            txtConfirmarContraseña = new TextBox();
            lblEyeConfirmar = new Label();
            btnCambiarContraseña = new Button();
            lnkRegresar = new LinkLabel();
            panelImportante = new Panel();
            picInfo = new Label();
            lblImportanteTitulo = new Label();
            lblImportanteTexto = new Label();
            picClock = new PictureBox();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelSeguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShield).BeginInit();
            panelContent.SuspendLayout();
            panelStep1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEnvelope).BeginInit();
            panelStep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLock).BeginInit();
            panelImportante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClock).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Transparent;
            panelSidebar.BackgroundImage = Properties.Resources.fondo_2;
            panelSidebar.Controls.Add(picLogo);
            panelSidebar.Controls.Add(lblSidebarTitle);
            panelSidebar.Controls.Add(lblSidebarSub);
            panelSidebar.Controls.Add(panelSeguridad);
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(340, 820);
            panelSidebar.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = (Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Location = new Point(40, 50);
            picLogo.Margin = new Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(220, 80);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblSidebarTitle
            // 
            lblSidebarTitle.AutoSize = true;
            lblSidebarTitle.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblSidebarTitle.ForeColor = Color.White;
            lblSidebarTitle.Location = new Point(40, 380);
            lblSidebarTitle.Margin = new Padding(4, 0, 4, 0);
            lblSidebarTitle.Name = "lblSidebarTitle";
            lblSidebarTitle.Size = new Size(283, 41);
            lblSidebarTitle.TabIndex = 1;
            lblSidebarTitle.Text = "Recupera tu cuenta";
            // 
            // lblSidebarSub
            // 
            lblSidebarSub.Font = new Font("Segoe UI", 10F);
            lblSidebarSub.ForeColor = Color.FromArgb(203, 213, 225);
            lblSidebarSub.Location = new Point(40, 425);
            lblSidebarSub.Margin = new Padding(4, 0, 4, 0);
            lblSidebarSub.Name = "lblSidebarSub";
            lblSidebarSub.Size = new Size(260, 70);
            lblSidebarSub.TabIndex = 2;
            lblSidebarSub.Text = "Sigue los pasos para restablecer tu contraseña de forma segura.";
            // 
            // panelSeguridad
            // 
            panelSeguridad.BackColor = Color.FromArgb(30, 55, 115);
            panelSeguridad.Controls.Add(picShield);
            panelSeguridad.Controls.Add(lblSeguridadTitulo);
            panelSeguridad.Controls.Add(lblSeguridadTexto);
            panelSeguridad.Location = new Point(30, 640);
            panelSeguridad.Margin = new Padding(4);
            panelSeguridad.Name = "panelSeguridad";
            panelSeguridad.Size = new Size(280, 150);
            panelSeguridad.TabIndex = 3;
            panelSeguridad.Paint += RoundedPanel_Paint;
            // 
            // picShield
            // 
            picShield.BackColor = Color.Transparent;
            picShield.BackgroundImage = (Image)resources.GetObject("picShield.BackgroundImage");
            picShield.BackgroundImageLayout = ImageLayout.Stretch;
            picShield.Location = new Point(20, 20);
            picShield.Margin = new Padding(4);
            picShield.Name = "picShield";
            picShield.Size = new Size(50, 50);
            picShield.SizeMode = PictureBoxSizeMode.Zoom;
            picShield.TabIndex = 0;
            picShield.TabStop = false;
            // 
            // lblSeguridadTitulo
            // 
            lblSeguridadTitulo.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblSeguridadTitulo.ForeColor = Color.White;
            lblSeguridadTitulo.Location = new Point(85, 15);
            lblSeguridadTitulo.Margin = new Padding(4, 0, 4, 0);
            lblSeguridadTitulo.Name = "lblSeguridadTitulo";
            lblSeguridadTitulo.Size = new Size(180, 45);
            lblSeguridadTitulo.TabIndex = 1;
            lblSeguridadTitulo.Text = "Tu información está protegida";
            // 
            // lblSeguridadTexto
            // 
            lblSeguridadTexto.Font = new Font("Segoe UI", 9F);
            lblSeguridadTexto.ForeColor = Color.FromArgb(203, 213, 225);
            lblSeguridadTexto.Location = new Point(20, 75);
            lblSeguridadTexto.Margin = new Padding(4, 0, 4, 0);
            lblSeguridadTexto.Name = "lblSeguridadTexto";
            lblSeguridadTexto.Size = new Size(240, 60);
            lblSeguridadTexto.TabIndex = 2;
            lblSeguridadTexto.Text = "Usamos los más altos estándares de seguridad para proteger tus datos.";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(248, 250, 252);
            panelContent.Controls.Add(lblTitulo);
            panelContent.Controls.Add(pnlUnderline);
            panelContent.Controls.Add(pnlCircle1);
            panelContent.Controls.Add(lblStep1);
            panelContent.Controls.Add(pnlLineProgress1);
            panelContent.Controls.Add(pnlCircle2);
            panelContent.Controls.Add(lblStep2);
            panelContent.Controls.Add(pnlLineProgress2);
            panelContent.Controls.Add(panelStep1);
            panelContent.Controls.Add(picArrowCircle);
            panelContent.Controls.Add(panelStep2);
            panelContent.Controls.Add(lnkRegresar);
            panelContent.Controls.Add(panelImportante);
            panelContent.Location = new Point(340, 0);
            panelContent.Margin = new Padding(4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(820, 820);
            panelContent.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitulo.Location = new Point(260, 35);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Recuperar contraseña";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlUnderline
            // 
            pnlUnderline.BackColor = Color.FromArgb(249, 115, 22);
            pnlUnderline.Location = new Point(430, 82);
            pnlUnderline.Margin = new Padding(4);
            pnlUnderline.Name = "pnlUnderline";
            pnlUnderline.Size = new Size(60, 4);
            pnlUnderline.TabIndex = 1;
            // 
            // pnlCircle1
            // 
            pnlCircle1.BackColor = Color.FromArgb(29, 78, 216);
            pnlCircle1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            pnlCircle1.ForeColor = Color.White;
            pnlCircle1.Location = new Point(140, 115);
            pnlCircle1.Margin = new Padding(4);
            pnlCircle1.Name = "pnlCircle1";
            pnlCircle1.Size = new Size(36, 36);
            pnlCircle1.TabIndex = 2;
            pnlCircle1.Text = "1";
            pnlCircle1.TextAlign = ContentAlignment.MiddleCenter;
            pnlCircle1.Paint += CircleLabel_Paint;
            // 
            // lblStep1
            // 
            lblStep1.AutoSize = true;
            lblStep1.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblStep1.ForeColor = Color.FromArgb(29, 78, 216);
            lblStep1.Location = new Point(186, 122);
            lblStep1.Margin = new Padding(4, 0, 4, 0);
            lblStep1.Name = "lblStep1";
            lblStep1.Size = new Size(144, 30);
            lblStep1.TabIndex = 3;
            lblStep1.Text = "Enviar código";
            // 
            // pnlLineProgress1
            // 
            pnlLineProgress1.BackColor = Color.FromArgb(29, 78, 216);
            pnlLineProgress1.Location = new Point(140, 160);
            pnlLineProgress1.Margin = new Padding(4);
            pnlLineProgress1.Name = "pnlLineProgress1";
            pnlLineProgress1.Size = new Size(230, 4);
            pnlLineProgress1.TabIndex = 4;
            // 
            // pnlCircle2
            // 
            pnlCircle2.BackColor = Color.FromArgb(148, 163, 184);
            pnlCircle2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            pnlCircle2.ForeColor = Color.White;
            pnlCircle2.Location = new Point(560, 115);
            pnlCircle2.Margin = new Padding(4);
            pnlCircle2.Name = "pnlCircle2";
            pnlCircle2.Size = new Size(36, 36);
            pnlCircle2.TabIndex = 5;
            pnlCircle2.Text = "2";
            pnlCircle2.TextAlign = ContentAlignment.MiddleCenter;
            pnlCircle2.Paint += CircleLabel_Paint;
            // 
            // lblStep2
            // 
            lblStep2.AutoSize = true;
            lblStep2.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblStep2.ForeColor = Color.FromArgb(100, 116, 139);
            lblStep2.Location = new Point(606, 122);
            lblStep2.Margin = new Padding(4, 0, 4, 0);
            lblStep2.Name = "lblStep2";
            lblStep2.Size = new Size(190, 30);
            lblStep2.TabIndex = 6;
            lblStep2.Text = "Verificar y cambiar";
            // 
            // pnlLineProgress2
            // 
            pnlLineProgress2.BackColor = Color.FromArgb(226, 232, 240);
            pnlLineProgress2.Location = new Point(560, 154);
            pnlLineProgress2.Margin = new Padding(4);
            pnlLineProgress2.Name = "pnlLineProgress2";
            pnlLineProgress2.Size = new Size(226, 10);
            pnlLineProgress2.TabIndex = 7;
            // 
            // panelStep1
            // 
            panelStep1.BackColor = Color.White;
            panelStep1.Controls.Add(picEnvelope);
            panelStep1.Controls.Add(lblStep1Title);
            panelStep1.Controls.Add(lblStep1Desc);
            panelStep1.Controls.Add(txtUsuario);
            panelStep1.Controls.Add(txtCorreo);
            panelStep1.Controls.Add(btnEnviarCodigo);
            panelStep1.Location = new Point(30, 190);
            panelStep1.Margin = new Padding(4);
            panelStep1.Name = "panelStep1";
            panelStep1.Size = new Size(340, 460);
            panelStep1.TabIndex = 8;
            panelStep1.Paint += RoundedPanel_Paint;
            // 
            // picEnvelope
            // 
            picEnvelope.BackColor = Color.Transparent;
            picEnvelope.BackgroundImage = (Image)resources.GetObject("picEnvelope.BackgroundImage");
            picEnvelope.BackgroundImageLayout = ImageLayout.Stretch;
            picEnvelope.Location = new Point(135, 20);
            picEnvelope.Margin = new Padding(4);
            picEnvelope.Name = "picEnvelope";
            picEnvelope.Size = new Size(70, 70);
            picEnvelope.SizeMode = PictureBoxSizeMode.Zoom;
            picEnvelope.TabIndex = 0;
            picEnvelope.TabStop = false;
            // 
            // lblStep1Title
            // 
            lblStep1Title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblStep1Title.ForeColor = Color.FromArgb(15, 23, 42);
            lblStep1Title.Location = new Point(20, 105);
            lblStep1Title.Margin = new Padding(4, 0, 4, 0);
            lblStep1Title.Name = "lblStep1Title";
            lblStep1Title.Size = new Size(300, 30);
            lblStep1Title.TabIndex = 1;
            lblStep1Title.Text = "Enviar código";
            lblStep1Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStep1Desc
            // 
            lblStep1Desc.Font = new Font("Segoe UI", 9F);
            lblStep1Desc.ForeColor = Color.FromArgb(100, 116, 139);
            lblStep1Desc.Location = new Point(20, 140);
            lblStep1Desc.Margin = new Padding(4, 0, 4, 0);
            lblStep1Desc.Name = "lblStep1Desc";
            lblStep1Desc.Size = new Size(300, 50);
            lblStep1Desc.TabIndex = 2;
            lblStep1Desc.Text = "Ingresa tu usuario y correo electrónico. Te enviaremos un código de verificación.";
            lblStep1Desc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(248, 250, 252);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(20, 210);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "👤  Usuario";
            txtUsuario.Size = new Size(300, 34);
            txtUsuario.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(248, 250, 252);
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Segoe UI", 10F);
            txtCorreo.ForeColor = Color.Black;
            txtCorreo.Location = new Point(20, 265);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "✉  Correo electrónico";
            txtCorreo.Size = new Size(300, 34);
            txtCorreo.TabIndex = 2;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.BackColor = Color.FromArgb(29, 78, 216);
            btnEnviarCodigo.FlatAppearance.BorderSize = 0;
            btnEnviarCodigo.FlatStyle = FlatStyle.Flat;
            btnEnviarCodigo.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnEnviarCodigo.ForeColor = Color.White;
            btnEnviarCodigo.Location = new Point(20, 340);
            btnEnviarCodigo.Margin = new Padding(4);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(300, 45);
            btnEnviarCodigo.TabIndex = 3;
            btnEnviarCodigo.Text = "➤   Enviar código";
            btnEnviarCodigo.UseVisualStyleBackColor = false;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click;
            // 
            // picArrowCircle
            // 
            picArrowCircle.BackColor = Color.White;
            picArrowCircle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            picArrowCircle.ForeColor = Color.FromArgb(29, 78, 216);
            picArrowCircle.Location = new Point(369, 388);
            picArrowCircle.Margin = new Padding(4);
            picArrowCircle.Name = "picArrowCircle";
            picArrowCircle.Size = new Size(59, 46);
            picArrowCircle.TabIndex = 9;
            picArrowCircle.Text = "›";
            picArrowCircle.TextAlign = ContentAlignment.MiddleCenter;
            picArrowCircle.Paint += CircleLabel_Paint;
            // 
            // panelStep2
            // 
            panelStep2.BackColor = Color.White;
            panelStep2.Controls.Add(picLock);
            panelStep2.Controls.Add(lblStep2Title);
            panelStep2.Controls.Add(lblStep2Desc);
            panelStep2.Controls.Add(txtCodigo);
            panelStep2.Controls.Add(txtNuevaContraseña);
            panelStep2.Controls.Add(lblEyeNueva);
            panelStep2.Controls.Add(txtConfirmarContraseña);
            panelStep2.Controls.Add(lblEyeConfirmar);
            panelStep2.Controls.Add(btnCambiarContraseña);
            panelStep2.Location = new Point(430, 190);
            panelStep2.Margin = new Padding(4);
            panelStep2.Name = "panelStep2";
            panelStep2.Size = new Size(370, 460);
            panelStep2.TabIndex = 10;
            panelStep2.Paint += RoundedPanel_Paint;
            // 
            // picLock
            // 
            picLock.BackColor = Color.Transparent;
            picLock.BackgroundImage = (Image)resources.GetObject("picLock.BackgroundImage");
            picLock.BackgroundImageLayout = ImageLayout.Stretch;
            picLock.Location = new Point(150, 20);
            picLock.Margin = new Padding(4);
            picLock.Name = "picLock";
            picLock.Size = new Size(70, 70);
            picLock.SizeMode = PictureBoxSizeMode.Zoom;
            picLock.TabIndex = 0;
            picLock.TabStop = false;
            // 
            // lblStep2Title
            // 
            lblStep2Title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblStep2Title.ForeColor = Color.FromArgb(15, 23, 42);
            lblStep2Title.Location = new Point(20, 105);
            lblStep2Title.Margin = new Padding(4, 0, 4, 0);
            lblStep2Title.Name = "lblStep2Title";
            lblStep2Title.Size = new Size(330, 30);
            lblStep2Title.TabIndex = 1;
            lblStep2Title.Text = "Verificar y cambiar";
            lblStep2Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStep2Desc
            // 
            lblStep2Desc.Font = new Font("Segoe UI", 9F);
            lblStep2Desc.ForeColor = Color.FromArgb(100, 116, 139);
            lblStep2Desc.Location = new Point(20, 140);
            lblStep2Desc.Margin = new Padding(4, 0, 4, 0);
            lblStep2Desc.Name = "lblStep2Desc";
            lblStep2Desc.Size = new Size(330, 50);
            lblStep2Desc.TabIndex = 2;
            lblStep2Desc.Text = "Ingresa el código que recibiste y tu nueva contraseña.";
            lblStep2Desc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(248, 250, 252);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI", 10F);
            txtCodigo.ForeColor = Color.Black;
            txtCodigo.Location = new Point(20, 210);
            txtCodigo.Margin = new Padding(4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "🛡  Código de verificación";
            txtCodigo.Size = new Size(330, 34);
            txtCodigo.TabIndex = 4;
            // 
            // txtNuevaContraseña
            // 
            txtNuevaContraseña.BackColor = Color.FromArgb(248, 250, 252);
            txtNuevaContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtNuevaContraseña.Font = new Font("Segoe UI", 10F);
            txtNuevaContraseña.ForeColor = Color.Black;
            txtNuevaContraseña.Location = new Point(20, 265);
            txtNuevaContraseña.Margin = new Padding(4);
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.PasswordChar = '●';
            txtNuevaContraseña.PlaceholderText = "🔒  Nueva contraseña";
            txtNuevaContraseña.Size = new Size(330, 34);
            txtNuevaContraseña.TabIndex = 5;
            // 
            // lblEyeNueva
            // 
            lblEyeNueva.Cursor = Cursors.Hand;
            lblEyeNueva.Font = new Font("Segoe UI", 10F);
            lblEyeNueva.ForeColor = Color.FromArgb(100, 116, 139);
            lblEyeNueva.Location = new Point(300, 271);
            lblEyeNueva.Margin = new Padding(4, 0, 4, 0);
            lblEyeNueva.Name = "lblEyeNueva";
            lblEyeNueva.Size = new Size(30, 24);
            lblEyeNueva.TabIndex = 6;
            lblEyeNueva.Text = "👁";
            lblEyeNueva.TextAlign = ContentAlignment.MiddleCenter;
            lblEyeNueva.Click += lblEyeNueva_Click;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.BackColor = Color.FromArgb(248, 250, 252);
            txtConfirmarContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarContraseña.Font = new Font("Segoe UI", 10F);
            txtConfirmarContraseña.ForeColor = Color.Black;
            txtConfirmarContraseña.Location = new Point(20, 320);
            txtConfirmarContraseña.Margin = new Padding(4);
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.PasswordChar = '●';
            txtConfirmarContraseña.PlaceholderText = "🔒  Confirmar contraseña";
            txtConfirmarContraseña.Size = new Size(330, 34);
            txtConfirmarContraseña.TabIndex = 7;
            // 
            // lblEyeConfirmar
            // 
            lblEyeConfirmar.Cursor = Cursors.Hand;
            lblEyeConfirmar.Font = new Font("Segoe UI", 10F);
            lblEyeConfirmar.ForeColor = Color.FromArgb(100, 116, 139);
            lblEyeConfirmar.Location = new Point(300, 326);
            lblEyeConfirmar.Margin = new Padding(4, 0, 4, 0);
            lblEyeConfirmar.Name = "lblEyeConfirmar";
            lblEyeConfirmar.Size = new Size(30, 24);
            lblEyeConfirmar.TabIndex = 8;
            lblEyeConfirmar.Text = "👁";
            lblEyeConfirmar.TextAlign = ContentAlignment.MiddleCenter;
            lblEyeConfirmar.Click += lblEyeConfirmar_Click;
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.BackColor = Color.FromArgb(29, 78, 216);
            btnCambiarContraseña.FlatAppearance.BorderSize = 0;
            btnCambiarContraseña.FlatStyle = FlatStyle.Flat;
            btnCambiarContraseña.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnCambiarContraseña.ForeColor = Color.White;
            btnCambiarContraseña.Location = new Point(20, 395);
            btnCambiarContraseña.Margin = new Padding(4);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(330, 45);
            btnCambiarContraseña.TabIndex = 9;
            btnCambiarContraseña.Text = "🔒   Cambiar contraseña";
            btnCambiarContraseña.UseVisualStyleBackColor = false;
            btnCambiarContraseña.Click += btnCambiarContraseña_Click;
            // 
            // lnkRegresar
            // 
            lnkRegresar.AutoSize = true;
            lnkRegresar.Font = new Font("Segoe UI", 10F);
            lnkRegresar.LinkColor = Color.FromArgb(29, 78, 216);
            lnkRegresar.Location = new Point(30, 665);
            lnkRegresar.Margin = new Padding(4, 0, 4, 0);
            lnkRegresar.Name = "lnkRegresar";
            lnkRegresar.Size = new Size(272, 28);
            lnkRegresar.TabIndex = 11;
            lnkRegresar.TabStop = true;
            lnkRegresar.Text = "←  Regresar al inicio de sesión";
            lnkRegresar.LinkClicked += lnkRegresar_LinkClicked;
            // 
            // panelImportante
            // 
            panelImportante.BackColor = Color.White;
            panelImportante.Controls.Add(picInfo);
            panelImportante.Controls.Add(lblImportanteTitulo);
            panelImportante.Controls.Add(lblImportanteTexto);
            panelImportante.Controls.Add(picClock);
            panelImportante.Location = new Point(30, 705);
            panelImportante.Margin = new Padding(4);
            panelImportante.Name = "panelImportante";
            panelImportante.Size = new Size(760, 100);
            panelImportante.TabIndex = 12;
            panelImportante.Paint += RoundedPanel_Paint;
            // 
            // picInfo
            // 
            picInfo.BackColor = Color.FromArgb(29, 78, 216);
            picInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            picInfo.ForeColor = Color.White;
            picInfo.Location = new Point(15, 15);
            picInfo.Margin = new Padding(4);
            picInfo.Name = "picInfo";
            picInfo.Size = new Size(36, 36);
            picInfo.TabIndex = 0;
            picInfo.Text = "i";
            picInfo.TextAlign = ContentAlignment.MiddleCenter;
            picInfo.Paint += CircleLabel_Paint;
            // 
            // lblImportanteTitulo
            // 
            lblImportanteTitulo.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblImportanteTitulo.ForeColor = Color.FromArgb(15, 23, 42);
            lblImportanteTitulo.Location = new Point(65, 10);
            lblImportanteTitulo.Margin = new Padding(4, 0, 4, 0);
            lblImportanteTitulo.Name = "lblImportanteTitulo";
            lblImportanteTitulo.Size = new Size(200, 25);
            lblImportanteTitulo.TabIndex = 1;
            lblImportanteTitulo.Text = "Importante";
            // 
            // lblImportanteTexto
            // 
            lblImportanteTexto.Font = new Font("Segoe UI", 9F);
            lblImportanteTexto.ForeColor = Color.FromArgb(100, 116, 139);
            lblImportanteTexto.Location = new Point(65, 38);
            lblImportanteTexto.Margin = new Padding(4, 0, 4, 0);
            lblImportanteTexto.Name = "lblImportanteTexto";
            lblImportanteTexto.Size = new Size(620, 50);
            lblImportanteTexto.TabIndex = 2;
            lblImportanteTexto.Text = "El código tiene una vigencia de 10 minutos.\nSi no lo recibes, revisa tu carpeta de spam o solicita un nuevo código.";
            // 
            // picClock
            // 
            picClock.BackColor = Color.Transparent;
            picClock.BackgroundImage = (Image)resources.GetObject("picClock.BackgroundImage");
            picClock.BackgroundImageLayout = ImageLayout.Stretch;
            picClock.Location = new Point(695, 25);
            picClock.Margin = new Padding(4);
            picClock.Name = "picClock";
            picClock.Size = new Size(50, 50);
            picClock.SizeMode = PictureBoxSizeMode.Zoom;
            picClock.TabIndex = 3;
            picClock.TabStop = false;
            // 
            // Recuperacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1160, 820);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Recuperacion";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recuperar contraseña";
            Load += Recuperacion_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelSeguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picShield).EndInit();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            panelStep1.ResumeLayout(false);
            panelStep1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEnvelope).EndInit();
            panelStep2.ResumeLayout(false);
            panelStep2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLock).EndInit();
            panelImportante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picClock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private PictureBox picLogo;
        private Label lblSidebarTitle;
        private Label lblSidebarSub;
        private Panel panelSeguridad;
        private PictureBox picShield;
        private Label lblSeguridadTitulo;
        private Label lblSeguridadTexto;

        private Panel panelContent;
        private Label lblTitulo;
        private Panel pnlUnderline;

        private Label pnlCircle1;
        private Label lblStep1;
        private Panel pnlLineProgress1;
        private Label pnlCircle2;
        private Label lblStep2;
        private Panel pnlLineProgress2;

        private Panel panelStep1;
        private PictureBox picEnvelope;
        private Label lblStep1Title;
        private Label lblStep1Desc;
        private TextBox txtUsuario;
        private TextBox txtCorreo;
        private Button btnEnviarCodigo;

        private Label picArrowCircle;

        private Panel panelStep2;
        private PictureBox picLock;
        private Label lblStep2Title;
        private Label lblStep2Desc;
        private TextBox txtCodigo;
        private TextBox txtNuevaContraseña;
        private Label lblEyeNueva;
        private TextBox txtConfirmarContraseña;
        private Label lblEyeConfirmar;
        private Button btnCambiarContraseña;

        private LinkLabel lnkRegresar;

        private Panel panelImportante;
        private Label picInfo;
        private Label lblImportanteTitulo;
        private Label lblImportanteTexto;
        private PictureBox picClock;
    }
}
