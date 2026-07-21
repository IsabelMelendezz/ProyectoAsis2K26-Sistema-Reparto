namespace SistemaReparto
{
using System.Drawing.Drawing2D;

    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            panel1.Region = new Region(GetRoundedRect(panel1.ClientRectangle, 20));
        }

        private void pictureLog3_Click(object sender, EventArgs e)
        {

        }
    }
}
