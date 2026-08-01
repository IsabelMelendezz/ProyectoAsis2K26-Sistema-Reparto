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
    public partial class Sucursales : Form
    {
        public Sucursales()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Sucursales_Load(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.MostrarSucursales(dataGridView1);
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.SeleccionarSucursal(
                dataGridView1,
                textBoxIdSucursal,
                textBoxNombre,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Nuevo(
                textBoxIdSucursal,
                textBoxNombre,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Guardar(
                textBoxNombre,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo,
                dataGridView1,
                textBoxIdSucursal);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Editar(
                textBoxIdSucursal,
                textBoxNombre,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo,
                dataGridView1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Eliminar(
                textBoxIdSucursal,
                textBoxNombre,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo,
                dataGridView1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Buscar(
                txtBuscar,
                dataGridView1);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.Actualizar(
                dataGridView1,
                textBoxIdSucursal,
                textBoxNombre,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CSucursales objetoSucursal = new CSucursales();

            objetoSucursal.SeleccionarSucursal(
                dataGridView1,
                textBoxIdSucursal,
                textBoxNombre,
                textBoxDireccion,
                textBoxTelefono,
                textBoxCorreo);
        }
    }
}
