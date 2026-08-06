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
using static SistemaReparto.Clases.CModulo;
namespace SistemaReparto
{
    public partial class Area_Cubierta : Form
    {
        // ==== AGREGANDO: objeto CRUD e ID del vehiculo seleccionado en la tabla ====
        private CAreaCubierta objArea = new CAreaCubierta();
        private int idAreaSeleccionada = 0;
        //Victor Omar GOmez Carrascosa 9959-23-10733
        //LLamada de las clases para la verificación de permisos
        private CPermisoModulo misPermisos;
        private ModuloRolController permisosController = new ModuloRolController();
        private ModuloUsuarioController permisosUsuarioController = new ModuloUsuarioController();

        public Area_Cubierta()
        {
            InitializeComponent();

            this.Load += Area_Cubierta_Load;
            this.Dgv_Tabla_Area.SelectionChanged += Dgv_Tabla_Area_SelectionChanged;

            this.Btn_Nueva_Area.Click += Btn_Nueva_Area_Click;
            this.Btn_Editar_Area.Click += Btn_Editar_Area_Click;
            this.Btn_Eliminar_Area.Click += Btn_Eliminar_Area_Click;
            this.Btn_Actualizar_Area.Click += Btn_Actualizar_Area_Click;
            this.Btn_Limpiar_Area.Click += Btn_Limpiar_Area_Click;
            this.Btn_Guardar_Area.Click += Btn_Guardar_Area_Click;
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
        private void Btn_Nueva_Area_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
        }

        private void Area_Cubierta_Load(object sender, EventArgs e)
        {
            objArea.mostrarAreas(Dgv_Tabla_Area);

            // Al cargar el formulario, los campos inician bloqueados hasta seleccionar o presionar Nuevo/Editar
            BloquearCampos();
        }

        private void Dgv_Tabla_Area_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_Tabla_Area.CurrentRow == null) return;

            idAreaSeleccionada = objArea.SeleccionarArea(
                Dgv_Tabla_Area,
                Txt_Zona_Area_Cubierta, Txt_Municipio_Area_Cubierta, Txt_Departamento_Area_Cubierta, Txt_Descripcion_Area_Cubierta);

            BloquearCampos();
        }

        private void Btn_Editar_Area_Click(object sender, EventArgs e)
        {
            if (idAreaSeleccionada <= 0)
            {
                MessageBox.Show("Debe seleccionar un área de la tabla antes de editar.");
                return;
            }

            HabilitarCampos();
        }
        // Btn_Eliminar_Emp: elimina el empleado seleccionado en la tabla 
        private void Btn_Eliminar_Area_Click(object sender, EventArgs e)
        {
            if (idAreaSeleccionada <= 0)
            {
                MessageBox.Show("Debe seleccionar un área de la tabla antes de eliminar.");
                return;
            }

            var confirmar = MessageBox.Show("¿Desea eliminar esta área?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                objArea.EliminarArea(idAreaSeleccionada);
                objArea.mostrarAreas(Dgv_Tabla_Area);
                LimpiarCampos();
                BloquearCampos();
            }
        }

        // Btn_Actualizar_Emp: actualiza los datos de los textbox y componentes 
        private void Btn_Actualizar_Area_Click(object sender, EventArgs e)
        {
            objArea.ModificarArea(
                idAreaSeleccionada,
                Txt_Zona_Area_Cubierta, Txt_Municipio_Area_Cubierta, Txt_Departamento_Area_Cubierta, Txt_Descripcion_Area_Cubierta);

            objArea.mostrarAreas(Dgv_Tabla_Area);
            BloquearCampos();
        }

        // Btn_Limpiar_Emp: limpia el formulario para capturar un nuevo registro
        private void Btn_Limpiar_Area_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos();
        }
        private void LimpiarCampos()
        {
            idAreaSeleccionada = 0;
            Txt_Zona_Area_Cubierta.Clear();
            Txt_Municipio_Area_Cubierta.Clear();
            Txt_Departamento_Area_Cubierta.Clear();
            Txt_Descripcion_Area_Cubierta.Clear();
        }

        private void Btn_Guardar_Area_Click(object sender, EventArgs e)
        {
            objArea.GuardarArea(
               Txt_Zona_Area_Cubierta, Txt_Municipio_Area_Cubierta, Txt_Departamento_Area_Cubierta, Txt_Descripcion_Area_Cubierta);

            objArea.mostrarAreas(Dgv_Tabla_Area);
            LimpiarCampos();
            BloquearCampos();
        }

        // ==== AGREGADO: bloquea todos los campos (solo lectura/visualización) ====
        private void BloquearCampos()
        {
            Txt_Zona_Area_Cubierta.ReadOnly = true;
            Txt_Municipio_Area_Cubierta.ReadOnly = true;
            Txt_Departamento_Area_Cubierta.ReadOnly = true;
            Txt_Descripcion_Area_Cubierta.ReadOnly = true;
        }

        private void HabilitarCampos()
        {
            Txt_Zona_Area_Cubierta.ReadOnly = false;
            Txt_Municipio_Area_Cubierta.ReadOnly = false;
            Txt_Departamento_Area_Cubierta.ReadOnly = false;
            Txt_Descripcion_Area_Cubierta.ReadOnly = false;
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

            int pos = Txt_Zona_Area_Cubierta.SelectionStart;

            bool esLetra = pos < 2 || pos >= 5;    // posiciones 0,1 y 5,6,7 letras
            bool esNumero = pos >= 2 && pos < 5;   // posiciones 2,3,4 números

            if (esLetra && !char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (esNumero && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnProbarConexion_Click_Click_1(object sender, EventArgs e)
        {
            Asignacion_Empleado_Rutas formTipos = new Asignacion_Empleado_Rutas();
            formTipos.ShowDialog(); // se abre encima, pausa Transportes hasta cerrarla
        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void Area_Cubierta_Load_1(object sender, EventArgs e)
        {
            try
            {

                // --- Verificación de seguridad ---
                CPermisoModulo permisosPorRol = permisosController.ObtenerPermisos(Modulos.AreasCubiertas, Sesion.IdsRoles);
                CPermisoModulo permisosPorUsuario = permisosUsuarioController.ObtenerPermisos(Modulos.AreasCubiertas, Sesion.IdUsuario);

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


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Permisos de botones según el rol del usuario
        private void AplicarPermisosBotones()
        {
            Btn_Guardar_Area.Enabled = misPermisos.PuedeInsertar;
            Btn_Actualizar_Area.Enabled = misPermisos.PuedeEditar;
            Btn_Eliminar_Area.Enabled = misPermisos.PuedeEliminar;
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
