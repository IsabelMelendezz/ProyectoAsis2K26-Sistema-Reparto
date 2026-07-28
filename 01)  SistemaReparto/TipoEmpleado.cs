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
    public partial class TipoEmpleado : Form
    {
        // ==== AGREGADO: objeto CRUD e ID del tipo de empleado seleccionado en el grid ====
        private CTipoEmpleado objTipoEmp = new CTipoEmpleado();
        private int idTipoEmpSeleccionado = 0;

        public TipoEmpleado()
        {
            InitializeComponent();

            // ==== AGREGADO: eventos de sincronización (no se tocó el Designer) ====

            this.Load -= TipoEmp_Load;
            this.Load += TipoEmp_Load;

            this.Dgv_Tabla_TipoE.SelectionChanged -= Tabla_TipoE_SelectionChanged;
            this.Dgv_Tabla_TipoE.SelectionChanged += Tabla_TipoE_SelectionChanged;

            this.Btn_Nuevo_TipoE.Click -= Btn_Nuevo_TipoE_Click;
            this.Btn_Nuevo_TipoE.Click += Btn_Nuevo_TipoE_Click;

            this.Btn_Guardar_TipoE.Click -= Btn_Guardar_TipoE_Click;
            this.Btn_Guardar_TipoE.Click += Btn_Guardar_TipoE_Click;

            this.Btn_Editar_TipoE.Click -= Btn_Editar_TipoE_Click;
            this.Btn_Editar_TipoE.Click += Btn_Editar_TipoE_Click;

            this.Btn_Eliminar_TipoE.Click -= Btn_Eliminar_TipoE_Click;
            this.Btn_Eliminar_TipoE.Click += Btn_Eliminar_TipoE_Click;

            this.Btn_Actualizar_TipoE.Click -= Btn_Actualizar_TipoE_Click;
            this.Btn_Actualizar_TipoE.Click += Btn_Actualizar_TipoE_Click;

            this.Btn_Limpiar_TipoE.Click -= Btn_Limpiar_TipoE_Click;
            this.Btn_Limpiar_TipoE.Click += Btn_Limpiar_TipoE_Click;
        }

        // sincronización con la base de datos

        private void TipoEmp_Load(object sender, EventArgs e)
        {

            objTipoEmp.mostrarTipoEmpleado(Dgv_Tabla_TipoE);

            // Al cargar el formulario, los campos inician bloqueados hasta seleccionar o presionar Nuevo/Editar
            BloquearCampos();
        }

        private void Tabla_TipoE_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_Tabla_TipoE.CurrentRow == null) return;

            idTipoEmpSeleccionado = objTipoEmp.SeleccionarTipoEmp(
                Dgv_Tabla_TipoE,
                Txt_Nombre_TipoEmp, Txt_Descripcion_TipoE);

            // El tipo de empleado seleccionado solo se puede ver, no modificar, hasta presionar Editar
            BloquearCampos();
        }

        // Btn_Nuevo_TipoE: limpia el formulario y habilita los campos para capturar un registro nuevo
        private void Btn_Nuevo_TipoE_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
        }

        // Btn_Guardar_TipoE: valida y guarda (INSERT) un nuevo tipo de empleado
        private void Btn_Guardar_TipoE_Click(object sender, EventArgs e)
        {
            objTipoEmp.GuardarTipoEmp(
                Txt_Nombre_TipoEmp, Txt_Descripcion_TipoE);

            objTipoEmp.mostrarTipoEmpleado(Dgv_Tabla_TipoE);
            LimpiarCampos();
            BloquearCampos();
        }

        // Btn_Editar_TipoE: habilita los campos para poder modificar el tipo de empleado seleccionado en el grid
        private void Btn_Editar_TipoE_Click(object sender, EventArgs e)
        {
            if (idTipoEmpSeleccionado <= 0)
            {
                MessageBox.Show("Debe seleccionar un Tipo de Empleado de la tabla antes de editar.");
                return;
            }

            HabilitarCampos();
        }

        // Btn_Actualizar_TipoE: valida y guarda (UPDATE) los cambios del Tipo de Empleado seleccionado, luego refresca el grid
        private void Btn_Actualizar_TipoE_Click(object sender, EventArgs e)
        {
            objTipoEmp.ModificarTipoEmp(
                idTipoEmpSeleccionado,
                Txt_Nombre_TipoEmp, Txt_Descripcion_TipoE);

            objTipoEmp.mostrarTipoEmpleado(Dgv_Tabla_TipoE);
            BloquearCampos();
        }

        // Btn_Eliminar_TipoE: elimina el Tipo de Empleado seleccionado en el grid
        private void Btn_Eliminar_TipoE_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Desea eliminar este Tipo de Empleado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                objTipoEmp.EliminarTipoEmp(idTipoEmpSeleccionado);
                objTipoEmp.mostrarTipoEmpleado(Dgv_Tabla_TipoE);
                LimpiarCampos();
                BloquearCampos();
            }
        }

        // Btn_Limpiar_TipoE: limpia el formulario para capturar un nuevo registro
        private void Btn_Limpiar_TipoE_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos();
        }

        private void LimpiarCampos()
        {
            idTipoEmpSeleccionado = 0;
            Txt_Nombre_TipoEmp.Clear();
            Txt_Descripcion_TipoE.Clear();

        }

        // ==== AGREGADO: bloquea todos los campos (solo lectura/visualización) ====
        private void BloquearCampos()
        {
            Txt_Nombre_TipoEmp.ReadOnly = true;
            Txt_Descripcion_TipoE.ReadOnly = true;

        }

        // ==== AGREGADO: habilita todos los campos para poder capturar/editar ====
        private void HabilitarCampos()
        {

            Txt_Nombre_TipoEmp.ReadOnly = false;
            Txt_Descripcion_TipoE.ReadOnly = false;

        }
    }
}
