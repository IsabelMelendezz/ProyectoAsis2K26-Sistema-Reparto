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

namespace SistemaReparto
{
    public partial class Empleados : Form
    {
        // ==== AGREGADO: objeto CRUD e ID del empleado seleccionado en el grid ====
        private CEmpleados objEmpleados = new CEmpleados();
        private int idEmpleadoSeleccionado = 0;

        public Empleados()
        {
            InitializeComponent();

            // ==== AGREGADO: eventos de sincronización 
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

        private void Empleados_Load(object sender, EventArgs e)
        {
            objEmpleados.llenarComboTipoEmpleado(Tipo_Empleado1);
            objEmpleados.llenarComboEstadoEmpleado(Estado_Empleado);
            objEmpleados.mostrarEmpleados(Tabla_Empleados);
        }

        private void Tabla_Empleados_SelectionChanged(object sender, EventArgs e)
        {
            if (Tabla_Empleados.CurrentRow == null) return;

            idEmpleadoSeleccionado = objEmpleados.SeleccionarEmpleado(
                Tabla_Empleados,
                Tipo_Empleado1, Estado_Empleado,
                Nombre_Empleado, Apellidos_Empleado, Dpi_Empleado, Nit_Empleado,
                Telefono_Empleado, Correo_Empleado, Direccion_Empleado,
                Nacimiento_Empleado, Contratacion_Empleado);
        }

        // Btn_Nuevo_Emp: solo limpia el formulario para capturar un registro nuevo
        private void Btn_Nuevo_Emp_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Btn_Guardar_Emp: valida y guarda (INSERT) un nuevo empleado
        private void Btn_Guardar_Emp_Click(object sender, EventArgs e)
        {
            objEmpleados.GuardarEmpleado(
                Tipo_Empleado1, Estado_Empleado,
                Nombre_Empleado, Apellidos_Empleado, Dpi_Empleado, Nit_Empleado,
                Telefono_Empleado, Correo_Empleado, Direccion_Empleado,
                Nacimiento_Empleado, Contratacion_Empleado);

            objEmpleados.mostrarEmpleados(Tabla_Empleados);
            LimpiarCampos();
        }

        // Btn_Editar_Emp: modifica el empleado seleccionado en el grid
        private void Btn_Editar_Emp_Click(object sender, EventArgs e)
        {
            objEmpleados.ModificarEmpleado(
                idEmpleadoSeleccionado,
                Tipo_Empleado1, Estado_Empleado,
                Nombre_Empleado, Apellidos_Empleado, Dpi_Empleado, Nit_Empleado,
                Telefono_Empleado, Correo_Empleado, Direccion_Empleado,
                Nacimiento_Empleado, Contratacion_Empleado);

            objEmpleados.mostrarEmpleados(Tabla_Empleados);
        }

        // Btn_Eliminar_Emp: elimina el empleado seleccionado en el grid
        private void Btn_Eliminar_Emp_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Desea eliminar este empleado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                objEmpleados.EliminarEmpleado(idEmpleadoSeleccionado);
                objEmpleados.mostrarEmpleados(Tabla_Empleados);
                LimpiarCampos();
            }
        }

        // Btn_Actualizar_Emp: refresca el grid con los datos actuales de la BD
        private void Btn_Actualizar_Emp_Click(object sender, EventArgs e)
        {
            objEmpleados.mostrarEmpleados(Tabla_Empleados);
        }

        // Btn_Limpiar_Emp: limpia el formulario para capturar un nuevo registro
        private void Btn_Limpiar_Emp_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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
            Correo_Empleado.Clear();
            Direccion_Empleado.Clear();
            Nacimiento_Empleado.Value = DateTime.Now;
            Contratacion_Empleado.Value = DateTime.Now;
        }
    }
}