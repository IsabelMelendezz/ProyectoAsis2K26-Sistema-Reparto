using SistemaReparto.Clases;
using System;
using System.Windows.Forms;

namespace SistemaReparto
{
    public partial class Estado_Empleado : Form
    {
        private CEstadoEmpleado objEstadoEmpleado = new CEstadoEmpleado();
        private int idEstadoSeleccionado = 0;

        public Estado_Empleado()
        {
            InitializeComponent();

            // "-=" antes de "+=" para blindar contra suscripciones duplicadas
            // (por si el Designer tambien quedo enganchando el mismo evento
            // por un doble clic accidental en el boton dentro del disenador)
            this.Load -= EstadoEmpleado_Load;
            this.Load += EstadoEmpleado_Load;

            this.Dgv_Tabla_EstadoE.SelectionChanged -= Dgv_Tabla_EstadoE_SelectionChanged;
            this.Dgv_Tabla_EstadoE.SelectionChanged += Dgv_Tabla_EstadoE_SelectionChanged;

            this.Btn_Nuevo_EstadoE.Click -= Btn_Nuevo_EstadoE_Click;
            this.Btn_Nuevo_EstadoE.Click += Btn_Nuevo_EstadoE_Click;

            this.Btn_Guardar_EstadoE.Click -= Btn_Guardar_EstadoE_Click;
            this.Btn_Guardar_EstadoE.Click += Btn_Guardar_EstadoE_Click;

            this.Btn_Editar_EstadoE.Click -= Btn_Editar_EstadoE_Click;
            this.Btn_Editar_EstadoE.Click += Btn_Editar_EstadoE_Click;

            this.Btn_Eliminar_EstadoE.Click -= Btn_Eliminar_EstadoE_Click;
            this.Btn_Eliminar_EstadoE.Click += Btn_Eliminar_EstadoE_Click;

            this.Btn_Actualizar_EstadoE.Click -= Btn_Actualizar_EstadoE_Click;
            this.Btn_Actualizar_EstadoE.Click += Btn_Actualizar_EstadoE_Click;

            this.Btn_Limpiar_EstadoE.Click -= Btn_Limpiar_EstadoE_Click;
            this.Btn_Limpiar_EstadoE.Click += Btn_Limpiar_EstadoE_Click;
        }

        // sincronización con la base de datos

        private void EstadoEmpleado_Load(object sender, EventArgs e)
        {
            objEstadoEmpleado.mostrarEstadosEmpleado(Dgv_Tabla_EstadoE);

            // Al cargar el formulario, los campos inician bloqueados hasta seleccionar o presionar Nuevo/Editar
            BloquearCampos();
        }

        private void Dgv_Tabla_EstadoE_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_Tabla_EstadoE.CurrentRow == null) return;

            idEstadoSeleccionado = objEstadoEmpleado.SeleccionarEstadoEmpleado(
                Dgv_Tabla_EstadoE, Txt_Nombre_EstadoEmp, Txt_Descripcion_EstadoE);

            // El estado seleccionado solo se puede ver, no modificar, hasta presionar Editar
            BloquearCampos();
        }

        // Btn_Nuevo_EstadoE: limpia el formulario y habilita los campos para capturar un registro nuevo
        private void Btn_Nuevo_EstadoE_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
        }

        // Btn_Guardar_EstadoE: valida y guarda (INSERT) un nuevo estado de empleado
        private void Btn_Guardar_EstadoE_Click(object sender, EventArgs e)
        {
            objEstadoEmpleado.GuardarEstadoEmpleado(Txt_Nombre_EstadoEmp, Txt_Descripcion_EstadoE);

            objEstadoEmpleado.mostrarEstadosEmpleado(Dgv_Tabla_EstadoE);
            LimpiarCampos();
            BloquearCampos();
        }

        // Btn_Editar_EstadoE: habilita los campos para poder modificar el estado seleccionado en el grid
        private void Btn_Editar_EstadoE_Click(object sender, EventArgs e)
        {
            if (idEstadoSeleccionado <= 0)
            {
                MessageBox.Show("Debe seleccionar un Estado de Empleado de la tabla antes de editar.");
                return;
            }

            HabilitarCampos();
        }

        // Btn_Actualizar_EstadoE: valida y guarda (UPDATE) los cambios del estado seleccionado, luego refresca el grid
        private void Btn_Actualizar_EstadoE_Click(object sender, EventArgs e)
        {
            objEstadoEmpleado.ModificarEstadoEmpleado(idEstadoSeleccionado, Txt_Nombre_EstadoEmp, Txt_Descripcion_EstadoE);

            objEstadoEmpleado.mostrarEstadosEmpleado(Dgv_Tabla_EstadoE);
            BloquearCampos();
        }

        // Btn_Eliminar_EstadoE: elimina el estado seleccionado en el grid
        private void Btn_Eliminar_EstadoE_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Desea eliminar este estado de empleado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                objEstadoEmpleado.EliminarEstadoEmpleado(idEstadoSeleccionado);
                objEstadoEmpleado.mostrarEstadosEmpleado(Dgv_Tabla_EstadoE);
                LimpiarCampos();
                BloquearCampos();
            }
        }

        // Btn_Limpiar_EstadoE: limpia el formulario
        private void Btn_Limpiar_EstadoE_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos();
        }

        private void LimpiarCampos()
        {
            idEstadoSeleccionado = 0;
            Txt_Nombre_EstadoEmp.Clear();
            Txt_Descripcion_EstadoE.Clear();
        }

        // bloquea todos los campos (solo lectura/visualización)
        private void BloquearCampos()
        {
            Txt_Nombre_EstadoEmp.ReadOnly = true;
            Txt_Descripcion_EstadoE.ReadOnly = true;
        }

        // habilita todos los campos para poder capturar/editar
        private void HabilitarCampos()
        {
            Txt_Nombre_EstadoEmp.ReadOnly = false;
            Txt_Descripcion_EstadoE.ReadOnly = false;
        }
    }
}