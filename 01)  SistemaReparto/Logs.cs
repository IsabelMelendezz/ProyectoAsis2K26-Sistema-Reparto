namespace SistemaReparto
{
    using SistemaReparto.Clases;
    using System.Drawing.Drawing2D;

    public partial class Logs : Form
    {
        CLogin controladorLogin = new CLogin();
        public Logs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_Usu_Log.Text) || string.IsNullOrWhiteSpace(txt_Contra_Log.Text))
                {
                    MessageBox.Show("Ingresa usuario y contraseña", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool acceso = controladorLogin.ValidarLogin(txt_Usu_Log.Text, txt_Contra_Log.Text);

                if (acceso)
                {
                    MessageBox.Show($"Bienvenido, {Sesion.NombreEmpleado}\nRoles: {Sesion.RolesComoTexto()}",
                        "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Menu_Repartidor menuPrincipal = new Menu_Repartidor();
                    menuPrincipal.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registros formRegistros = new Registros();
            formRegistros.Show();
            this.Hide();
        }

        private void Logs_Load(object sender, EventArgs e)
        {

        }
        private GraphicsPath GetRoundedRect(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            pnl_log.Region = new Region(GetRoundedRect(pnl_log.ClientRectangle, 20));
        }

        private void pictureLog3_Click(object sender, EventArgs e)
        {

        }
    }
}
