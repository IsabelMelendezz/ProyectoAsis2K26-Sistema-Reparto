//Carlos David Calderón Ramirez
//9959-23-848

using ScottPlot;
using ScottPlot.WinForms;
using SistemaReparto.Clases;
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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private CReportes objReportes = new CReportes();
        private void button1_Click(object sender, EventArgs e)
        {
            switch (cbo_Selecciona_Reportes.Text)
            {
                case "Pedido":
                    objReportes.ReportePedidos(dataGridView1, Dt_Desde_Reporte.Value, Dt_Hasta_Reporte.Value);
                    objReportes.GraficaPedido(formsPlot1, Dt_Desde_Reporte.Value, Dt_Hasta_Reporte.Value);
                    break;
                case "Ruta":
                    objReportes.ReporteRutas(dataGridView1, Dt_Desde_Reporte.Value, Dt_Hasta_Reporte.Value);
                    objReportes.GraficaRuta(formsPlot1, Dt_Desde_Reporte.Value, Dt_Hasta_Reporte.Value);
                    break;
                case "Empleado":
                    objReportes.ReporteEmpleados(dataGridView1, Dt_Desde_Reporte.Value, Dt_Hasta_Reporte.Value);
                    objReportes.GraficaEmpleado(formsPlot1, Dt_Desde_Reporte.Value, Dt_Hasta_Reporte.Value);
                    break;
                case "Vehiculo":
                    objReportes.ReporteVehiculos(dataGridView1, Dt_Desde_Reporte.Value, Dt_Hasta_Reporte.Value);
                    objReportes.GraficaVehiculo(formsPlot1, Dt_Desde_Reporte.Value, Dt_Hasta_Reporte.Value);
                    break;
            }
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }
    }
}
