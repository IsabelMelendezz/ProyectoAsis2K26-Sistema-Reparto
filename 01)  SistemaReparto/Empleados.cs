//Lourdes Isabel Melendez Pineda 
//9959-23-1379

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
using static SistemaReparto.Clases.CModulo;
namespace SistemaReparto
{
    public partial class Empleados : Form
    {
        // ==== AGREGADO: objeto CRUD e ID del empleado seleccionado en el grid ====
        private CEmpleados objEmpleados = new CEmpleados();
        private int idEmpleadoSeleccionado = 0;
        //Victor Omar GOmez Carrascosa 9959-23-10733
        //LLamada de las clases para la verificación de permisos
        private CPermisoModulo misPermisos;
        private ModuloRolController permisosController = new ModuloRolController();
        private ModuloUsuarioController permisosUsuarioController = new ModuloUsuarioController();

        public Empleados()
        {
            InitializeComponent();

            // ==== AGREGADO: eventos de sincronización (no se tocó el Designer) ====

            this.Load -= Empleados_Load;
            this.Load += Empleados_Load;

            this.Tabla_Empleados.SelectionChanged -= Tabla_Empleados_SelectionChanged;
            this.Tabla_Empleados.SelectionChanged += Tabla_Empleados_SelectionChanged;

            this.Btn_Nuevo_Emp.Click -= Btn_Nuevo_Emp_Click;
            this.Btn_Nuevo_Emp.Click += Btn_Nuevo_Emp_Click;

            this.Btn_Guardar_Emp.Click -= Btn_Guardar_Emp_Click;
            this.Btn_Guardar_Emp.Click += Btn_Guardar_Emp_Click;

            this.Btn_Editar_Emp.Click -= Btn_Editar_Emp_Click;
            this.Btn_Editar_Emp.Click += Btn_Editar_Emp_Click;

            this.Btn_Eliminar_Emp.Click -= Btn_Eliminar_Emp_Click;
            this.Btn_Eliminar_Emp.Click += Btn_Eliminar_Emp_Click;

            this.Btn_Actualizar_Emp.Click -= Btn_Actualizar_Emp_Click;
            this.Btn_Actualizar_Emp.Click += Btn_Actualizar_Emp_Click;

            this.Btn_Limpiar_Emp.Click -= Btn_Limpiar_Emp_Click;
            this.Btn_Limpiar_Emp.Click += Btn_Limpiar_Emp_Click;
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
            TipoEmpleado formTipos = new TipoEmpleado();
            formTipos.ShowDialog(); // se abre encima, pausa Transportes hasta cerrarla
        }

        // sincronización con la base de datos

        private void Empleados_Load(object sender, EventArgs e)
        {
            objEmpleados.llenarComboTipoEmpleado(Tipo_Empleado1);
            objEmpleados.llenarComboEstadoEmpleado(Estado_Empleado);
            objEmpleados.mostrar_Empleados(Tabla_Empleados);

            // Al cargar el formulario, los campos inician bloqueados hasta seleccionar o presionar Nuevo/Editar
            BloquearCampos();
        }

        private void Tabla_Empleados_SelectionChanged(object sender, EventArgs e)
        {
            if (Tabla_Empleados.CurrentRow == null) return;

            idEmpleadoSeleccionado = objEmpleados.SeleccionarEmpleado(
                Tabla_Empleados,
                Tipo_Empleado1, Estado_Empleado,
                Nombre_Empleado, Apellidos_Empleado, Dpi_Empleado, Nit_Empleado,
                Telefono_Empleado, Direccion_Empleado,
                Nacimiento_Empleado, Contratacion_Empleado);

            // El empleado seleccionado solo se puede ver, no modificar, hasta presionar Editar
            BloquearCampos();
        }

        // Btn_Nuevo_Emp: limpia el formulario y habilita los campos para capturar un registro nuevo
        private void Btn_Nuevo_Emp_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
        }

        // Btn_Guardar_Emp: valida y guarda (INSERT) un nuevo empleado
        private void Btn_Guardar_Emp_Click(object sender, EventArgs e)
        {
            objEmpleados.GuardarEmpleado(
                Tipo_Empleado1, Estado_Empleado,
                Nombre_Empleado, Apellidos_Empleado, Dpi_Empleado, Nit_Empleado,
                Telefono_Empleado, Direccion_Empleado,
                Nacimiento_Empleado, Contratacion_Empleado);

            objEmpleados.mostrar_Empleados(Tabla_Empleados);
            LimpiarCampos();
            BloquearCampos();
        }

        // Btn_Editar_Emp: habilita los campos para poder modificar el empleado seleccionado en el grid
        private void Btn_Editar_Emp_Click(object sender, EventArgs e)
        {
            if (idEmpleadoSeleccionado <= 0)
            {
                MessageBox.Show("Debe seleccionar un empleado de la tabla antes de editar.");
                return;
            }

            HabilitarCampos();
        }

        // Btn_Actualizar_Emp: valida y guarda (UPDATE) los cambios del empleado seleccionado, luego refresca el grid
        private void Btn_Actualizar_Emp_Click(object sender, EventArgs e)
        {
            objEmpleados.Modificar_Empleado(
                idEmpleadoSeleccionado,
                Tipo_Empleado1, Estado_Empleado,
                Nombre_Empleado, Apellidos_Empleado, Dpi_Empleado, Nit_Empleado,
                Telefono_Empleado, Direccion_Empleado,
                Nacimiento_Empleado, Contratacion_Empleado);

            objEmpleados.mostrar_Empleados(Tabla_Empleados);
            BloquearCampos();
        }

        // Btn_Eliminar_Emp: elimina el empleado seleccionado en el grid
        private void Btn_Eliminar_Emp_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Desea eliminar este empleado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                objEmpleados.EliminarEmpleado(idEmpleadoSeleccionado);
                objEmpleados.mostrar_Empleados(Tabla_Empleados);
                LimpiarCampos();
                BloquearCampos();
            }
        }

        // Btn_Limpiar_Emp: limpia el formulario para capturar un nuevo registro
        private void Btn_Limpiar_Emp_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos();
        }

        private void LimpiarCampos()
        {
            idEmpleadoSeleccionado = 0;
            Tipo_Empleado1.SelectedIndex = -1;
            Estado_Empleado.SelectedIndex = -1;
            Nombre_Empleado.Clear();
            Apellidos_Empleado.Clear();
            Dpi_Empleado.Clear();
            Nit_Empleado.Clear();
            Telefono_Empleado.Clear();
            Direccion_Empleado.Clear();
            Nacimiento_Empleado.Value = DateTime.Now;
            Contratacion_Empleado.Value = DateTime.Now;
        }

        // ==== AGREGADO: bloquea todos los campos (solo lectura/visualización) ====
        private void BloquearCampos()
        {
            Tipo_Empleado1.Enabled = false;
            Estado_Empleado.Enabled = false;
            Nombre_Empleado.ReadOnly = true;
            Apellidos_Empleado.ReadOnly = true;
            Dpi_Empleado.ReadOnly = true;
            Nit_Empleado.ReadOnly = true;
            Telefono_Empleado.ReadOnly = true;
            Direccion_Empleado.ReadOnly = true;
            Nacimiento_Empleado.Enabled = false;
            Contratacion_Empleado.Enabled = false;
        }

        // ==== AGREGADO: habilita todos los campos para poder capturar/editar ====
        private void HabilitarCampos()
        {
            Tipo_Empleado1.Enabled = true;
            Estado_Empleado.Enabled = true;
            Nombre_Empleado.ReadOnly = false;
            Apellidos_Empleado.ReadOnly = false;
            Dpi_Empleado.ReadOnly = false;
            Nit_Empleado.ReadOnly = false;
            Telefono_Empleado.ReadOnly = false;
            Direccion_Empleado.ReadOnly = false;
            Nacimiento_Empleado.Enabled = true;
            Contratacion_Empleado.Enabled = true;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Limpiar_Emp_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Estado_Empleado formTipos = new Estado_Empleado();
            formTipos.ShowDialog(); // se abre encima, pausa Transportes hasta cerrarla
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Dpi_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            TextBox txt = (TextBox)sender;

            // Solo números
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (txt.Text.Length >= 13 && txt.SelectionLength == 0)
            {
                e.Handled = true;
            }
        }

        private void Nit_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // permite backspace, etc.

            TextBox txt = (TextBox)sender;
            string texto = txt.Text;

            // Si ya hay un guion, solo se permite UN número más después de él
            if (texto.Contains("-"))
            {
                int posGuion = texto.IndexOf("-");
                if (texto.Length > posGuion + 1)
                {
                    e.Handled = true;
                    return;
                }
            }


            if (e.KeyChar == '-')
            {
                // No permite que el guion sea el primer digito 
                if (texto.Contains("-") || texto.Length == 0)
                {
                    e.Handled = true;
                }
                return;
            }

            // Solo números
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }


            if (texto.Length >= 9 && txt.SelectionLength == 0)
            {
                e.Handled = true;
            }
        }

        private void Telefono_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            TextBox txt = (TextBox)sender;

            // Solo números
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (txt.Text.Length >= 8 && txt.SelectionLength == 0)
            {
                e.Handled = true;
            }
        }

        private void Empleados_Load_1(object sender, EventArgs e)
        {
            try
            {

                // --- Verificación de seguridad ---
                CPermisoModulo permisosPorRol = permisosController.ObtenerPermisos(Modulos.Empleados, Sesion.IdsRoles);
                CPermisoModulo permisosPorUsuario = permisosUsuarioController.ObtenerPermisos(Modulos.Empleados, Sesion.IdUsuario);

                // Combina: si CUALQUIERA de los dos (rol o usuario específico) da el permiso, lo tiene
                misPermisos = new CPermisoModulo
                {
                    TieneAcceso = permisosPorRol.TieneAcceso || permisosPorUsuario.TieneAcceso,
                    PuedeInsertar = permisosPorRol.PuedeInsertar || permisosPorUsuario.PuedeInsertar,
                    PuedeEditar = permisosPorRol.PuedeEditar || permisosPorUsuario.PuedeEditar,
                    PuedeEliminar = permisosPorRol.PuedeEliminar || permisosPorUsuario.PuedeEliminar,
                    PuedeImprimir = permisosPorRol.PuedeImprimir || permisosPorUsuario.PuedeImprimir
                };

                if (!misPermisos.TieneAcceso)
                {
                    DeshabilitarFormularioCompleto();
                    MessageBox.Show("No tienes acceso a este módulo.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // no cierra el formulario, solo detiene la carga de datos
                }

                

                AplicarPermisosBotones();
                // --- fin verificación ---

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Permisos de botones según el rol del usuario
        private void AplicarPermisosBotones()
        {
            Btn_Guardar_Emp.Enabled = misPermisos.PuedeInsertar;
            Btn_Actualizar_Emp.Enabled = misPermisos.PuedeEditar;
            Btn_Eliminar_Emp.Enabled = misPermisos.PuedeEliminar;
            // Si tienes botón de imprimir/reportes en este form, lo controlas con PuedeImprimir
        }
        //Desabilita todos los controles del formulario, útil cuando el usuario no tiene permisos
        private void DeshabilitarFormularioCompleto()
        {
            foreach (Control control in this.Controls)
            {
                DeshabilitarControlRecursivo(control);
            }
        }
        //desabilita un control y todos sus controles hijos (si los tiene)
        private void DeshabilitarControlRecursivo(Control control)
        {
            control.Enabled = false;

            // Si el control tiene hijos (panels, group boxes, etc.), deshabilita también esos
            foreach (Control hijo in control.Controls)
            {
                DeshabilitarControlRecursivo(hijo);
            }
        }
    }
}