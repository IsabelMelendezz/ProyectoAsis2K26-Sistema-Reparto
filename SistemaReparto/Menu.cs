using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaReparto
{
    public partial class Menu : Form
    {
        private Form activeForm = null;

        public Menu()
        {
            InitializeComponent();
        }

        private void OpenFormInPanel(Form childForm)
        {
            // Cerrar formulario activo si existe
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnl_Control.Controls.Clear();
            pnl_Control.Controls.Add(childForm);
            pnl_Control.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Usuarios());
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Rutas());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Bodegas());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ;
        }

        private void panelcontrol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Transportes());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Paquetes());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Reportes());
        }

        private void btnRepartidores_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Empleados());
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Sucursales());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            OpenFormInPanel(new Bienvenida());
        }
    }
}
