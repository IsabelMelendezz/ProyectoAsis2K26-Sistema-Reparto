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
    public partial class Estado_Transporte : Form
    {
        // ==== AGREGADO: objeto CRUD e ID del empleado seleccionado en el grid ====
        private CEstado_Transporte objEstadoT = new CEstado_Transporte();
        private int idEstadoTSeleccionado = 0;

        public Estado_Transporte()
        {
            InitializeComponent();

            // ==== AGREGADO: eventos de sincronización (no se tocó el Designer) ====

            this.Load -= EstadoT_Load;
            this.Load += EstadoT_Load;

            this.Dgv_Tabla_EstadoT.SelectionChanged -= Tabla_EstadoT_SelectionChanged;
            this.Dgv_Tabla_EstadoT.SelectionChanged += Tabla_EstadoT_SelectionChanged;

            this.Btn_Nuevo_EstadoT.Click -= Btn_Nuevo_EstadoT_Click;
            this.Btn_Nuevo_EstadoT.Click += Btn_Nuevo_EstadoT_Click;

            this.Btn_Guardar_EstadoT.Click -= Btn_Guardar_EstadoT_Click;
            this.Btn_Guardar_EstadoT.Click += Btn_Guardar_EstadoT_Click;

            this.Btn_Editar_EstadoT.Click -= Btn_Editar_EstadoT_Click;
            this.Btn_Editar_EstadoT.Click += Btn_Editar_EstadoT_Click;

            this.Btn_Eliminar_EstadoT.Click -= Btn_Eliminar_EstadoT_Click;
            this.Btn_Eliminar_EstadoT.Click += Btn_Eliminar_EstadoT_Click;

            this.Btn_Actualizar_EstadoT.Click -= Btn_Actualizar_EstadoT_Click;
            this.Btn_Actualizar_EstadoT.Click += Btn_Actualizar_EstadoT_Click;

            this.Btn_Limpiar_EstadoT.Click -= Btn_Limpiar_EstadoT_Click;
            this.Btn_Limpiar_EstadoT.Click += Btn_Limpiar_EstadoT_Click;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnProbarConexion_Click_Click(object sender, EventArgs e)
        {
            CConexion cn = new CConexion();
            var conexion = cn.establecerConexion();
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("¡Conexión exitosa!");
                cn.cerrarConexion();
            }
            else
            {
                MessageBox.Show("No se pudo conectar. Estado: " + conexion.State);
            }
        }

        // sincronización con la base de datos

        private void EstadoT_Load(object sender, EventArgs e)
        {

            objEstadoT.mostrarEstado_Vehiculo(Dgv_Tabla_EstadoT);

            // Al cargar el formulario, los campos inician bloqueados hasta seleccionar o presionar Nuevo/Editar
            BloquearCampos();
        }

        private void Tabla_EstadoT_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_Tabla_EstadoT.CurrentRow == null) return;

            idEstadoTSeleccionado = objEstadoT.SeleccionarEstadoV(
                Dgv_Tabla_EstadoT,
                Txt_Nombre_EstadoV, Txt_Descripcion_EstadoV);

            // El tipo de vehiculo seleccionado solo se puede ver, no modificar, hasta presionar Editar
            BloquearCampos();
        }

        // Btn_Nuevo_TipoT: limpia el formulario y habilita los campos para capturar un registro nuevo
        private void Btn_Nuevo_EstadoT_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
        }

        // Btn_Guardar_TipoT: valida y guarda (INSERT) un nuevo empleado
        private void Btn_Guardar_EstadoT_Click(object sender, EventArgs e)
        {
            objEstadoT.GuardarEstadoT(
                Txt_Nombre_EstadoV, Txt_Descripcion_EstadoV);

            objEstadoT.mostrarEstado_Vehiculo(Dgv_Tabla_EstadoT);
            LimpiarCampos();
            BloquearCampos();
        }

        // Btn_Editar_TipoT: habilita los campos para poder modificar el empleado seleccionado en el grid
        private void Btn_Editar_EstadoT_Click(object sender, EventArgs e)
        {
            if (idEstadoTSeleccionado <= 0)
            {
                MessageBox.Show("Debe seleccionar un Estado de Vehiculo de la tabla antes de editar.");
                return;
            }

            HabilitarCampos();
        }

        // Btn_Actualizar_TipoT: valida y guarda (UPDATE) los cambios del Tipo de Vehiculo seleccionado, luego refresca el grid
        private void Btn_Actualizar_EstadoT_Click(object sender, EventArgs e)
        {
            objEstadoT.ModificarEstadoT(
                idEstadoTSeleccionado,
                Txt_Nombre_EstadoV, Txt_Descripcion_EstadoV);

            objEstadoT.mostrarEstado_Vehiculo(Dgv_Tabla_EstadoT);
            BloquearCampos();
        }

        // Btn_Eliminar_TipoT: elimina el Tipo de Vehiculo seleccionado en el grid
        private void Btn_Eliminar_EstadoT_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Desea eliminar este Estado de Vehiculo?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                objEstadoT.EliminarEstadoT(idEstadoTSeleccionado);
                objEstadoT.mostrarEstado_Vehiculo(Dgv_Tabla_EstadoT);
                LimpiarCampos();
                BloquearCampos();
            }
        }

        // Btn_Limpiar_Emp: limpia el formulario para capturar un nuevo registro
        private void Btn_Limpiar_EstadoT_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos();
        }

        private void LimpiarCampos()
        {
            idEstadoTSeleccionado = 0;
            Txt_Nombre_EstadoV.Clear();
            Txt_Descripcion_EstadoV.Clear();

        }

        // ==== AGREGADO: bloquea todos los campos (solo lectura/visualización) ====
        private void BloquearCampos()
        {
            Txt_Nombre_EstadoV.ReadOnly = true;
            Txt_Descripcion_EstadoV.ReadOnly = true;

        }

        // ==== AGREGADO: habilita todos los campos para poder capturar/editar ====
        private void HabilitarCampos()
        {

            Txt_Nombre_EstadoV.ReadOnly = false;
            Txt_Descripcion_EstadoV.ReadOnly = false;

        }

        private void Estado_Transporte_Load(object sender, EventArgs e)
        {

        }
    }
}