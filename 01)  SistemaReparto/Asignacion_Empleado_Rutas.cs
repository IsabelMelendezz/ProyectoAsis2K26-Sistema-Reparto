//Cristian David Sipac Ispache
//9959-23-1567
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
    public partial class Asignacion_Empleado_Rutas : Form
    {
        private CAsignacionArea objAsignacion = new CAsignacionArea();
        private int idAsignacionSeleccionada = 0;

        public Asignacion_Empleado_Rutas()
        {
            InitializeComponent();

            this.Load += Asignacion_Area_Load;
            Cbo_Empleado.SelectedIndexChanged += Cbo_Empleado_SelectedIndexChanged;
            List_Asignacion_Area.SelectedIndexChanged += List_Asignacion_Area_SelectedIndexChanged;

            this.Btn_Nueva_Asignacion_Area.Click += Btn_Nueva_Asignacion_Area_Click;
            this.Btn_Guardar_Asignacion_Area.Click += Btn_Guardar_Asignacion_Area_Click;
            this.Btn_Editar_Asignacion_Area.Click += Btn_Editar_Asignacion_Area_Click;
            this.Btn_Actualizar_Asignacion_Area.Click += Btn_Actualizar_Asignacion_Area_Click;
            this.Btn_Eliminar_Asignacion_Area.Click += Btn_Eliminar_Asignacion_Area_Click;
            this.Btn_Limpiar_Asignacion_Area.Click += Btn_Limpiar_Asignacion_Area_Click;
        }

        private void Asignacion_Area_Load(object sender, EventArgs e)
        {
            try
            {
                Cbo_Empleado.SelectedIndexChanged -= Cbo_Empleado_SelectedIndexChanged;
                objAsignacion.llenarComboEmpleado(Cbo_Empleado);
                Cbo_Empleado.SelectedIndexChanged += Cbo_Empleado_SelectedIndexChanged;

                BloquearCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cbo_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Empleado.SelectedIndex == -1) return;

                int idEmpleado = Convert.ToInt32(Cbo_Empleado.SelectedValue);

                objAsignacion.RefrescarAreasDisponibles(Cbo_Area, idEmpleado);
                objAsignacion.RefrescarAreasAsignadas(List_Asignacion_Area, idEmpleado);
                LimpiarFechas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFechas()
        {
            idAsignacionSeleccionada = 0;
            Date_Inicio_Asignacion.Value = DateTime.Now;
            Date_Fin_Asignacion.Value = DateTime.Now;
        }

        private void List_Asignacion_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idAsignacionSeleccionada = objAsignacion.SeleccionarAsignacion(
                    List_Asignacion_Area,
                    Date_Inicio_Asignacion, Date_Fin_Asignacion);

                BloquearCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la asignación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Nueva_Asignacion_Area_Click(object sender, EventArgs e)
        {
            if (Cbo_Empleado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un empleado primero.");
                return;
            }

            LimpiarFechas();
            Cbo_Area.Enabled = true;
            Date_Inicio_Asignacion.Enabled = true;
            Date_Fin_Asignacion.Enabled = true;
        }

        private void Btn_Editar_Asignacion_Area_Click(object sender, EventArgs e)
        {
            if (idAsignacionSeleccionada <= 0)
            {
                MessageBox.Show("Debe seleccionar una asignación de la lista antes de editar.");
                return;
            }

            Date_Inicio_Asignacion.Enabled = true;
            Date_Fin_Asignacion.Enabled = true;
            // Cbo_Area se queda deshabilitado a propósito: el área de una asignación existente no se edita
        }


        private void Btn_Guardar_Asignacion_Area_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Empleado.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un empleado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Cbo_Area.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un área", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idEmpleado = Convert.ToInt32(Cbo_Empleado.SelectedValue);

                int nuevoId = objAsignacion.GuardarAsignacion(Cbo_Empleado, Cbo_Area, Date_Inicio_Asignacion, Date_Fin_Asignacion);

                if (nuevoId > 0)
                {
                    objAsignacion.RefrescarAreasDisponibles(Cbo_Area, idEmpleado);
                    objAsignacion.RefrescarAreasAsignadas(List_Asignacion_Area, idEmpleado);
                    LimpiarFechas();
                    BloquearCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar." + Environment.NewLine + "Mensaje: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Actualizar_Asignacion_Area_Click(object sender, EventArgs e)
        {
            try
            {
                if (idAsignacionSeleccionada <= 0)
                {
                    MessageBox.Show("Selecciona una asignación de la lista primero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idEmpleado = Convert.ToInt32(Cbo_Empleado.SelectedValue);

                objAsignacion.ModificarAsignacion(idAsignacionSeleccionada, Date_Inicio_Asignacion, Date_Fin_Asignacion);

                objAsignacion.RefrescarAreasAsignadas(List_Asignacion_Area, idEmpleado);
                LimpiarFechas();
                BloquearCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Btn_Eliminar_Asignacion_Area_Click(object sender, EventArgs e)
        {
            try
            {
                if (idAsignacionSeleccionada <= 0)
                {
                    MessageBox.Show("Selecciona una asignación de la lista primero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmacion = MessageBox.Show("¿Quitar esta área asignada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    int idEmpleado = Convert.ToInt32(Cbo_Empleado.SelectedValue);

                    objAsignacion.EliminarAsignacion(idAsignacionSeleccionada);

                    objAsignacion.RefrescarAreasDisponibles(Cbo_Area, idEmpleado);
                    objAsignacion.RefrescarAreasAsignadas(List_Asignacion_Area, idEmpleado);
                    LimpiarFechas();
                    BloquearCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Limpiar_Asignacion_Area_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarFechas();
                Cbo_Area.SelectedIndex = -1;
                List_Asignacion_Area.ClearSelected();
                BloquearCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BloquearCampos()
        {
            Cbo_Area.Enabled = false;
            Date_Inicio_Asignacion.Enabled = false;
            Date_Fin_Asignacion.Enabled = false;
        }

        private void Asignacion_Empleado_Rutas_Load(object sender, EventArgs e)
        {

        }
    }

}
