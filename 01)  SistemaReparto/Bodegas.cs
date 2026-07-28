using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaReparto.Clases;

namespace SistemaReparto
{
    public partial class Bodegas : Form
    {
        public Bodegas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            objetoBodega.MostrarBodegas(dataGridView1);

            objetoBodega.LlenarComboSucursal(comboBoxSucursal);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            objetoBodega.SeleccionarBodega(
                dataGridView1,
                textBoxIdBodega,
                comboBoxSucursal,
                textBoxNombre,
                textBoxDireccion,
                numericUpDownCapacidad,
                textBoxTelefono);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            CBodegas objetoBodega = new CBodegas();

            objetoBodega.Nuevo(
                textBoxIdBodega,
                comboBoxSucursal,
                textBoxNombre,
                textBoxDireccion,
                numericUpDownCapacidad,
                textBoxTelefono);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            objetoBodega.Guardar(
                comboBoxSucursal,
                textBoxNombre,
                textBoxDireccion,
                numericUpDownCapacidad,
                textBoxTelefono,
                dataGridView1,
                textBoxIdBodega);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            objetoBodega.Editar(
                textBoxIdBodega,
                comboBoxSucursal,
                textBoxNombre,
                textBoxDireccion,
                numericUpDownCapacidad,
                textBoxTelefono,
                dataGridView1);


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            objetoBodega.Eliminar(
                textBoxIdBodega,
                comboBoxSucursal,
                textBoxNombre,
                textBoxDireccion,
                numericUpDownCapacidad,
                textBoxTelefono,
                dataGridView1);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            objetoBodega.Buscar(
                txtBuscar,
                dataGridView1);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CBodegas objetoBodega = new CBodegas();

            objetoBodega.Actualizar(
                dataGridView1,
                textBoxIdBodega,
                comboBoxSucursal,
                textBoxNombre,
                textBoxDireccion,
                numericUpDownCapacidad,
                textBoxTelefono);
        }
    }
}
