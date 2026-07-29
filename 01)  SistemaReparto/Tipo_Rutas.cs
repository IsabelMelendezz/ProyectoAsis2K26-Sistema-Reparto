//Cristian David Sipac Ispache
//9959-23-1567
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
    public partial class Tipo_Rutas : Form
    {
        public Tipo_Rutas()
        {
            InitializeComponent();
            Clases.CTipo_Rutas objetoRutas = new Clases.CTipo_Rutas();
            objetoRutas.mostrarRutas(Total_Rutas);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rutas_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Nuevo_Emp_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Ruta_Click(object sender, EventArgs e)
        {
            Clases.CTipo_Rutas objetoRutas = new Clases.CTipo_Rutas();
            objetoRutas.GuardarRutas(Text_Nombre_Ruta, Text_Descripcion_Ruta);
            objetoRutas.mostrarRutas(Total_Rutas);
        }

        private void Total_Rutas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CTipo_Rutas objetoRutas = new Clases.CTipo_Rutas();
            objetoRutas.SeleccionarRutas(Total_Rutas, Text_Id_Ruta, Text_Nombre_Ruta, Text_Descripcion_Ruta);
        }

        private void Btn_Actualizar_Ruta_Click(object sender, EventArgs e)
        {
            Clases.CTipo_Rutas objetoRutas = new Clases.CTipo_Rutas();
            objetoRutas.ModificarRutas(Text_Id_Ruta, Text_Nombre_Ruta, Text_Descripcion_Ruta);
            objetoRutas.mostrarRutas(Total_Rutas);
        }

        private void Btn_Eliminar_Ruta_Click(object sender, EventArgs e)
        {
            Clases.CTipo_Rutas objetoRutas = new Clases.CTipo_Rutas();
            objetoRutas.EliminarRutas(Text_Id_Ruta);
            objetoRutas.mostrarRutas(Total_Rutas);
        }

        private void Btn_Limpiar_Emp_Click(object sender, EventArgs e)
        {
            Text_Id_Ruta.Clear();
            Text_Nombre_Ruta.Clear();
            Text_Descripcion_Ruta.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
