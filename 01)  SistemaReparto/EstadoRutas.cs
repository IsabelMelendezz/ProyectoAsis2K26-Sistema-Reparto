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
    public partial class EstadoRutas : Form
    {
        public EstadoRutas()
        {
            InitializeComponent();
            Clases.CEstadoRutas objetoRutas = new Clases.CEstadoRutas();
            objetoRutas.mostrarRutas(Total_Estado_Rutas);
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
            Clases.CEstadoRutas objetoRutas = new Clases.CEstadoRutas();
            objetoRutas.GuardarRutas(Text_Nombre_Ruta, Text_Descripcion_Ruta);
            objetoRutas.mostrarRutas(Total_Estado_Rutas);
        }

        private void Total_Rutas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CEstadoRutas objetoRutas = new Clases.CEstadoRutas();
            objetoRutas.SeleccionarRutas(Total_Estado_Rutas, Text_Id_Tipo_Ruta, Text_Nombre_Ruta, Text_Descripcion_Ruta);
        }

        private void Btn_Actualizar_Ruta_Click(object sender, EventArgs e)
        {
            Clases.CEstadoRutas objetoRutas = new Clases.CEstadoRutas();
            objetoRutas.ModificarRutas(Text_Id_Tipo_Ruta, Text_Nombre_Ruta, Text_Descripcion_Ruta);
            objetoRutas.mostrarRutas(Total_Estado_Rutas);
        }

        private void Btn_Eliminar_Ruta_Click(object sender, EventArgs e)
        {
            Clases.CEstadoRutas objetoRutas = new Clases.CEstadoRutas();
            objetoRutas.EliminarRutas(Text_Id_Tipo_Ruta);
            objetoRutas.mostrarRutas(Total_Estado_Rutas);
        }

        private void Btn_Limpiar_Emp_Click(object sender, EventArgs e)
        {
            Text_Id_Tipo_Ruta.Clear();
            Text_Nombre_Ruta.Clear();
            Text_Descripcion_Ruta.Clear();
        }
    }
}
