using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaReparto.Clases;

namespace SistemaReparto
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
            this.Load += Bienvenida_Load;
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            CBienvenida datos = new CBienvenida();
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

        private void btnAyuda_click(object sender, EventArgs e) { }


        private void btnAyuda_Click_1(object sender, EventArgs e)
        {
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
        }
    }
}
