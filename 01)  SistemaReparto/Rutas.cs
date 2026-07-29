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
    public partial class Rutas : Form
    {
        // ==== AGREGANDO: objeto CRUD e ID del vehiculo seleccionado en la tabla ====
        private CRutas objRuta = new CRutas();
        private int idRutaSeleccionado = 0;
        public Rutas()
        {
            InitializeComponent();

            this.Load += Rutas_Load;
            this.Dgv_Tabla_Rutas.SelectionChanged += Dgv_Tabla_Rutas_SelectionChanged;

            this.Btn_Nueva_Ruta.Click += Btn_Nueva_Ruta_Click;
            this.Btn_Editar_Ruta.Click += Btn_Editar_Ruta_Click;
            this.Btn_Eliminar_Ruta.Click += Btn_Eliminar_Ruta_Click;
            this.Btn_Actualizar_Ruta.Click += Btn_Actualizar_Ruta_Click;
            this.Btn_Limpiar_Ruta.Click += Btn_Limpiar_Ruta_Click;
            this.Btn_Guardar_Ruta.Click += Btn_Guardar_Ruta_Click;

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
        private void Btn_Nueva_Ruta_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
        }

        private void Rutas_Load(object sender, EventArgs e)
        {
            objRuta.llenarComboBodega(Cbo_Id_Bodega);
            objRuta.llenarComboArea(Cbo_Id_Area);
            objRuta.llenarComboTipoRuta(Cbo_Tipo_Ruta);
            objRuta.llenarComboEstadoRuta(Cbo_Estado_Ruta);
            objRuta.mostrarRutas(Dgv_Tabla_Rutas);

            // Al cargar el formulario, los campos inician bloqueados hasta seleccionar o presionar Nuevo/Editar
            BloquearCampos();
        }

        private void Dgv_Tabla_Rutas_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_Tabla_Rutas.CurrentRow == null) return;

            idRutaSeleccionado = objRuta.SeleccionarRuta(
                Dgv_Tabla_Rutas,
                Cbo_Id_Bodega, Cbo_Id_Area, Cbo_Tipo_Ruta, Cbo_Estado_Ruta,
                Fecha_Ruta, Hora_Inicio, Hora_Fin,
                text_Distancia, text_observaciones);

            BloquearCampos();
        }

        private void Btn_Editar_Ruta_Click(object sender, EventArgs e)
        {
            if (idRutaSeleccionado <= 0)
            {
                MessageBox.Show("Debe seleccionar una ruta de la tabla antes de editar.");
                return;
            }

            HabilitarCampos();
        }
        // Btn_Eliminar_Emp: elimina el empleado seleccionado en la tabla 
        private void Btn_Eliminar_Ruta_Click(object sender, EventArgs e)
        {
            if (idRutaSeleccionado <= 0)
            {
                MessageBox.Show("Debe seleccionar una ruta de la tabla antes de eliminar.");
                return;
            }

            var confirmar = MessageBox.Show("¿Desea eliminar esta ruta?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                objRuta.EliminarRuta(idRutaSeleccionado);
                objRuta.mostrarRutas(Dgv_Tabla_Rutas);
                LimpiarCampos();
                BloquearCampos();
            }
        }

        // Btn_Actualizar_Emp: actualiza los datos de los textbox y componentes 
        private void Btn_Actualizar_Ruta_Click(object sender, EventArgs e)
        {
            objRuta.ModificarRuta(
                idRutaSeleccionado,
                Cbo_Id_Bodega, Cbo_Id_Area, Cbo_Tipo_Ruta, Cbo_Estado_Ruta,
                Fecha_Ruta, Hora_Inicio, Hora_Fin,
                text_Distancia, text_observaciones);

            objRuta.mostrarRutas(Dgv_Tabla_Rutas);
            BloquearCampos();
        }

        // Btn_Limpiar_Emp: limpia el formulario para capturar un nuevo registro
        private void Btn_Limpiar_Ruta_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos();
        }
        private void LimpiarCampos()
        {
            idRutaSeleccionado = 0;
            Cbo_Id_Bodega.SelectedIndex = -1;
            Cbo_Id_Area.SelectedIndex = -1;
            Cbo_Tipo_Ruta.SelectedIndex = -1;
            Cbo_Estado_Ruta.SelectedIndex = -1;
            Fecha_Ruta.Value = DateTime.Now;
            Hora_Inicio.Value = DateTime.Now;
            Hora_Fin.Value = DateTime.Now;
            text_Distancia.Clear();
            text_observaciones.Clear();
        }

        private void Btn_Guardar_Ruta_Click(object sender, EventArgs e)
        {
            objRuta.GuardarRuta(
               Cbo_Id_Bodega, Cbo_Id_Area, Cbo_Tipo_Ruta, Cbo_Estado_Ruta,
               Fecha_Ruta, Hora_Inicio, Hora_Fin,
               text_Distancia, text_observaciones);

            objRuta.mostrarRutas(Dgv_Tabla_Rutas);
            LimpiarCampos();
            BloquearCampos();
        }

        // ==== AGREGADO: bloquea todos los campos (solo lectura/visualización) ====
        private void BloquearCampos()
        {
            Cbo_Id_Bodega.Enabled = false;
            Cbo_Id_Area.Enabled = false;
            Cbo_Tipo_Ruta.Enabled = false;
            Cbo_Estado_Ruta.Enabled = false;
            Fecha_Ruta.Enabled = false;
            Hora_Inicio.Enabled = false;
            Hora_Fin.Enabled = false;
            text_Distancia.ReadOnly = true;
            text_observaciones.ReadOnly = true;
        }
        // ==== AGREGADO: habilita todos los campos para poder capturar/editar ====
        private void HabilitarCampos()
        {
            Cbo_Id_Bodega.Enabled = true;
            Cbo_Id_Area.Enabled = true;
            Cbo_Tipo_Ruta.Enabled = true;
            Cbo_Estado_Ruta.Enabled = true;
            Fecha_Ruta.Enabled = true;
            Hora_Inicio.Enabled = true;
            Hora_Fin.Enabled = true;
            text_Distancia.ReadOnly = false;
            text_observaciones.ReadOnly = false;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnProbarConexion_Click_Click(object sender, EventArgs e)
        {
            Tipo_Rutas formTipos = new Tipo_Rutas();
            formTipos.ShowDialog(); // se abre encima, pausa Transportes hasta cerrarla
        }

        private void Btn_Estado_Transporte_Click(object sender, EventArgs e)
        {
            EstadoRutas formTipos = new EstadoRutas();
            formTipos.ShowDialog(); // se abre encima, pausa Transportes hasta cerrarla
        }

        //private void btnProbarConexion_Click_Click(object sender, EventArgs e)
        //{
        //    Tipo_Transporte formTipos = new Tipo_Transporte();
        //    formTipos.ShowDialog(); // se abre encima, pausa Transportes hasta cerrarla

        //}

        //private void Btn_Estado_Transporte_Click(object sender, EventArgs e)
        //{
        //    Estado_Transporte formTipos = new Estado_Transporte();
        //    formTipos.ShowDialog(); // se abre encima, pausa Transportes hasta cerrarla

        //}
    }
}
