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
    public partial class Tipo_Transporte : Form
    {
        // ==== AGREGADO: objeto CRUD e ID del empleado seleccionado en el grid ====
        private CTipo_Transporte objTipoT = new CTipo_Transporte();
        private int idTipoTSeleccionado = 0;

        public Tipo_Transporte()
        {
            InitializeComponent();

            // ==== AGREGADO: eventos de sincronización (no se tocó el Designer) ====

            this.Load -= TipoT_Load;
            this.Load += TipoT_Load;

            this.Dgv_Tabla_TipoT.SelectionChanged -= Tabla_TipoT_SelectionChanged;
            this.Dgv_Tabla_TipoT.SelectionChanged += Tabla_TipoT_SelectionChanged;

            this.Btn_Nuevo_TipoT.Click -= Btn_Nuevo_TipoT_Click;
            this.Btn_Nuevo_TipoT.Click += Btn_Nuevo_TipoT_Click;

            this.Btn_Guardar_TipoT.Click -= Btn_Guardar_TipoT_Click;
            this.Btn_Guardar_TipoT.Click += Btn_Guardar_TipoT_Click;

            this.Btn_Editar_TipoT.Click -= Btn_Editar_TipoT_Click;
            this.Btn_Editar_TipoT.Click += Btn_Editar_TipoT_Click;

            this.Btn_Eliminar_TipoT.Click -= Btn_Eliminar_TipoT_Click;
            this.Btn_Eliminar_TipoT.Click += Btn_Eliminar_TipoT_Click;

            this.Btn_Actualizar_TipoT.Click -= Btn_Actualizar_TipoT_Click;
            this.Btn_Actualizar_TipoT.Click += Btn_Actualizar_TipoT_Click;

            this.Btn_Limpiar_TipoT.Click -= Btn_Limpiar_TipoT_Click;
            this.Btn_Limpiar_TipoT.Click += Btn_Limpiar_TipoT_Click;
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

        private void TipoT_Load(object sender, EventArgs e)
        {

            objTipoT.mostrarTipo_Vehiculo(Dgv_Tabla_TipoT);

            // Al cargar el formulario, los campos inician bloqueados hasta seleccionar o presionar Nuevo/Editar
            BloquearCampos();
        }

        private void Tabla_TipoT_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_Tabla_TipoT.CurrentRow == null) return;

            idTipoTSeleccionado = objTipoT.SeleccionarTipoV(
                Dgv_Tabla_TipoT,
                Txt_Nombre_TipoV, Txt_Descripcion_TipoV);

            // El tipo de vehiculo seleccionado solo se puede ver, no modificar, hasta presionar Editar
            BloquearCampos();
        }

        // Btn_Nuevo_TipoT: limpia el formulario y habilita los campos para capturar un registro nuevo
        private void Btn_Nuevo_TipoT_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
        }

        // Btn_Guardar_TipoT: valida y guarda (INSERT) un nuevo empleado
        private void Btn_Guardar_TipoT_Click(object sender, EventArgs e)
        {
            objTipoT.GuardarTipoT(
                Txt_Nombre_TipoV, Txt_Descripcion_TipoV);

            objTipoT.mostrarTipo_Vehiculo(Dgv_Tabla_TipoT);
            LimpiarCampos();
            BloquearCampos();
        }

        // Btn_Editar_TipoT: habilita los campos para poder modificar el empleado seleccionado en el grid
        private void Btn_Editar_TipoT_Click(object sender, EventArgs e)
        {
            if (idTipoTSeleccionado <= 0)
            {
                MessageBox.Show("Debe seleccionar un Tipo de Vehiculo de la tabla antes de editar.");
                return;
            }

            HabilitarCampos();
        }

        // Btn_Actualizar_TipoT: valida y guarda (UPDATE) los cambios del Tipo de Vehiculo seleccionado, luego refresca el grid
        private void Btn_Actualizar_TipoT_Click(object sender, EventArgs e)
        {
            objTipoT.ModificarTipoT(
                idTipoTSeleccionado,
                Txt_Nombre_TipoV,Txt_Descripcion_TipoV);

            objTipoT.mostrarTipo_Vehiculo(Dgv_Tabla_TipoT);
            BloquearCampos();
        }

        // Btn_Eliminar_TipoT: elimina el Tipo de Vehiculo seleccionado en el grid
        private void Btn_Eliminar_TipoT_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Desea eliminar este Tipo de Vehiculo?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                objTipoT.EliminarTipoT(idTipoTSeleccionado);
                objTipoT.mostrarTipo_Vehiculo(Dgv_Tabla_TipoT);
                LimpiarCampos();
                BloquearCampos();
            }
        }

        // Btn_Limpiar_Emp: limpia el formulario para capturar un nuevo registro
        private void Btn_Limpiar_TipoT_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos();
        }

        private void LimpiarCampos()
        {
            idTipoTSeleccionado = 0;
            Txt_Nombre_TipoV.Clear();
            Txt_Descripcion_TipoV.Clear();
            
        }

        // ==== AGREGADO: bloquea todos los campos (solo lectura/visualización) ====
        private void BloquearCampos()
        {
            Txt_Nombre_TipoV.ReadOnly = true;
            Txt_Descripcion_TipoV.ReadOnly = true;
           
        }

        // ==== AGREGADO: habilita todos los campos para poder capturar/editar ====
        private void HabilitarCampos()
        {
            
            Txt_Nombre_TipoV.ReadOnly = false;
            Txt_Descripcion_TipoV.ReadOnly = false;
            
        }
    }
}