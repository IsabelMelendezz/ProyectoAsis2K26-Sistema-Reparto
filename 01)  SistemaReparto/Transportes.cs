//Carlos David Calderón Ramirez
//9959-23-848


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
    public partial class Transportes : Form
    {
        // ==== AGREGANDO: objeto CRUD e ID del vehiculo seleccionado en la tabla ====
        private CTransporte objTransporte = new CTransporte();
        private int idVehiculoSeleccionado = 0;
        public Transportes()
        {
            InitializeComponent();

            // ==== AGREGADO: eventos de sincronizació ====
            this.Load += Transportes_Load;
            this.Dgv_Tabla_Transporte.SelectionChanged += Dgv_Tabla_Transporte_SelectionChanged;

            this.Btn_Nuevo_Transporte.Click += button1_Click;
            this.Btn_Editar_Transporte.Click += Btn_Editar_Transporte_Click;
            this.Btn_Eliminar_Transporte.Click += Btn_Eliminar_Transporte_Click;
            this.Btn_Actualizar_Transporte.Click += Btn_Actualizar_Transporte_Click;
            this.Btn_Limpiar_Transporte.Click += Btn_Limpiar_Transporte_Click;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            CConexion cn = new CConexion();
            var conexion = cn.establecerConexion();
            if (conexion.State == System.Data.ConnectionState.Open)
            {

                Tipo_Transporte formTipos = new Tipo_Transporte();
                formTipos.ShowDialog(); // se abre encima, pausa Transportes hasta cerrarla

            }
            else
            {
                MessageBox.Show("No se pudo conectar. Estado: " + conexion.State);
            }
        }
        // Btn_Nuevo_Emp: guarda un nuevo empleado con lo que hay en el formulario
        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
        }

        private void Transportes_Load(object sender, EventArgs e)
        {
            objTransporte.llenarComboTipoVehiculo(Cbo_Tipo_Transporte);
            objTransporte.llenarComboEstadoVehiculo(Cbo_Estado_Transporte);
            objTransporte.mostrarVehiculo(Dgv_Tabla_Transporte);

            // Al cargar el formulario, los campos inician bloqueados hasta seleccionar o presionar Nuevo/Editar
            BloquearCampos();
        }

        private void Dgv_Tabla_Transporte_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_Tabla_Transporte.CurrentRow == null) return;

            idVehiculoSeleccionado = objTransporte.SeleccionarVehiculo(
            Dgv_Tabla_Transporte,
            Cbo_Tipo_Transporte, Cbo_Estado_Transporte,
            Txt_Placa_Transporte, Txt_Año_Transporte, Txt_Modelo_Transporte, Txt_Marca_Transporte,
            Txt_Peso_Transporte);

            BloquearCampos();
        }

        private void Btn_Editar_Transporte_Click(object sender, EventArgs e)
        {
            if (idVehiculoSeleccionado <= 0)
            {
                MessageBox.Show("Debe seleccionar un empleado de la tabla antes de editar.");
                return;
            }

            HabilitarCampos();
        }
        // Btn_Eliminar_Emp: elimina el empleado seleccionado en la tabla 
        private void Btn_Eliminar_Transporte_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Desea eliminar este vehiculo?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                objTransporte.EliminarVehiculo(idVehiculoSeleccionado);
                objTransporte.mostrarVehiculo(Dgv_Tabla_Transporte);
                LimpiarCampos();
                BloquearCampos();
            }
        }

        // Btn_Actualizar_Emp: actualiza los datos de los textbox y componentes 
        private void Btn_Actualizar_Transporte_Click(object sender, EventArgs e)
        {
            objTransporte.ModificarVehiculo(
                idVehiculoSeleccionado,
                Cbo_Tipo_Transporte, Cbo_Estado_Transporte,
                Txt_Placa_Transporte, Txt_Año_Transporte, Txt_Modelo_Transporte, Txt_Marca_Transporte,
                Txt_Peso_Transporte);

            objTransporte.mostrarVehiculo(Dgv_Tabla_Transporte);
            BloquearCampos();
        }

        // Btn_Limpiar_Emp: limpia el formulario para capturar un nuevo registro
        private void Btn_Limpiar_Transporte_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos();
        }
        private void LimpiarCampos()
        {
            idVehiculoSeleccionado = 0;
            Cbo_Tipo_Transporte.SelectedIndex = -1;
            Cbo_Estado_Transporte.SelectedIndex = -1;
            Txt_Placa_Transporte.Clear();
            Txt_Año_Transporte.Clear();
            Txt_Modelo_Transporte.Clear();
            Txt_Marca_Transporte.Clear();
            Txt_Peso_Transporte.Clear();
        }

        private void Btn_Guardar_Transporte_Click(object sender, EventArgs e)
        {
            objTransporte.GuardarVehiculo(
               Cbo_Tipo_Transporte, Cbo_Estado_Transporte,
               Txt_Placa_Transporte, Txt_Año_Transporte, Txt_Modelo_Transporte, Txt_Marca_Transporte,
               Txt_Peso_Transporte);

            objTransporte.mostrarVehiculo(Dgv_Tabla_Transporte);
            LimpiarCampos();
            BloquearCampos();
        }

        // ==== AGREGADO: bloquea todos los campos (solo lectura/visualización) ====
        private void BloquearCampos()
        {
            Cbo_Tipo_Transporte.Enabled = false;
            Cbo_Estado_Transporte.Enabled = false;
            Txt_Placa_Transporte.ReadOnly = true;
            Txt_Año_Transporte.ReadOnly = true;
            Txt_Modelo_Transporte.ReadOnly = true;
            Txt_Marca_Transporte.ReadOnly = true;
            Txt_Peso_Transporte.ReadOnly = true;

        }
        // ==== AGREGADO: habilita todos los campos para poder capturar/editar ====
        private void HabilitarCampos()
        {
            Cbo_Tipo_Transporte.Enabled = true;
            Cbo_Estado_Transporte.Enabled = true;
            Txt_Placa_Transporte.ReadOnly = false;
            Txt_Año_Transporte.ReadOnly = false;
            Txt_Modelo_Transporte.ReadOnly = false;
            Txt_Marca_Transporte.ReadOnly = false;
            Txt_Peso_Transporte.ReadOnly = false;

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnProbarConexion_Click_Click(object sender, EventArgs e)
        {
            Tipo_Transporte formTipos = new Tipo_Transporte();
            formTipos.ShowDialog(); // se abre encima, pausa Transportes hasta cerrarla

        }

        private void Btn_Estado_Transporte_Click(object sender, EventArgs e)
        {
            Estado_Transporte formTipos = new Estado_Transporte();
            formTipos.ShowDialog(); // se abre encima, pausa Transportes hasta cerrarla

        }

        private void Txt_Placa_Transporte_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Placa_Transporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; 

            int pos = Txt_Placa_Transporte.SelectionStart;

            bool esLetra = pos < 1 || pos >= 4;    // posiciones 0,1 y 5,6,7 letras
            bool esNumero = pos >= 1 && pos < 4;   // posiciones 2,3,4 números

            if (esLetra && !char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (esNumero && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
