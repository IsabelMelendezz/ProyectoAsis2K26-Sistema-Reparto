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

            panelcontrol.Controls.Clear();
            panelcontrol.Controls.Add(childForm);
            panelcontrol.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Registros());
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
    }
}
