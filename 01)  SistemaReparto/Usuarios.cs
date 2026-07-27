using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReparto
{
    public partial class Usuarios : Form
    {
        private Form activeForm = null;
        public Usuarios()
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

            pnl_Usuarios.Controls.Clear();
            pnl_Usuarios.Controls.Add(childForm);
            pnl_Usuarios.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pic_Icono_Usu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Asig_Roles_usu());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Registro_usu());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Roles_usu());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Rel_Modulo_Roles());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Rel_Modulo_Usuario());

        }
    }
}
