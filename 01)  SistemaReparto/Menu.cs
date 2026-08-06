using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SistemaReparto.Clases;

namespace SistemaReparto
{
    public partial class Menu : Form
    {
        private Form activeForm = null;

        public Menu()
        {
            InitializeComponent();
            this.Load += Menu_Load;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            CMenu datos = new CMenu();
            try
            {
                label_paquetes.Text = datos.ContarPaquetesRegistrados().ToString();
                label_rutas.Text = datos.ContarRutasActivas().ToString();
                label_bodegas.Text = datos.ContarBodegasOperativas().ToString();
                label_repartidores.Text = datos.ContarRepartidoresEnServicio().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el resumen: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OpenFormInPanel(new Pedidos());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Area_Cubierta());
        }

        private void btnAsignacion_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Asignaciones());
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAyuda_Click_Click(object sender, EventArgs e)
        {
            string rutaPdf = Path.Combine(Application.StartupPath, "Manual", "Manual-Nortek.pdf");

            if (File.Exists(rutaPdf))
            {
                Process.Start(new ProcessStartInfo(rutaPdf) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("No se encontró el manual de ayuda en: " + rutaPdf,
                    "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que deseas cerrar sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Logs formLogin = new Logs();
                formLogin.Show();
                this.Hide();
            }
        }
        private void ActualizarInformacionUsuario()
        {
            lbl_usu_con.Text = $"Usuario: {Sesion.NombreEmpleado}";
            lbl_rol_con.Text = $"Rol: {Sesion.RolesComoTexto()}";
        }
        private void menu_Load(object sender, EventArgs e)
        {
            ActualizarInformacionUsuario();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
