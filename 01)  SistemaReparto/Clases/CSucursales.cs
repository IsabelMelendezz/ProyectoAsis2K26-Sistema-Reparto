using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaReparto.Clases
{
    internal class CSucursales
    {

        private const string CONSULTA_BASE =
            "SELECT " +
            "  s.id_sucursal, " +
            "  s.nombre_sucursal, " +
            "  CONCAT(d.direccion_detalle, ' - Zona_area_cubierta ', a.zona_area_cubierta, ', ', a.municipio_area_cubierta, ', ', a.departamento_area_cubierta) AS direccion_completa, " +
            "  s.telefono_sucursal, " +
            "  s.correo_sucursal, " +
            "  d.direccion_detalle, " +
            "  a.id_area, " +
            "  a.zona_area_cubierta, " +
            "  a.municipio_area_cubierta, " +
            "  a.departamento_area_cubierta " +
            "FROM sucursal s " +
            "LEFT JOIN direccion d ON s.id_direccion = d.id_direccion " +
            "LEFT JOIN area_cubierta a ON d.id_area = a.id_area ";

        public void MostrarSucursales(DataGridView tablaSucursales)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                DataTable dt = new DataTable();

                string consulta = CONSULTA_BASE + "ORDER BY s.id_sucursal";

                MySqlDataAdapter adapter = new MySqlDataAdapter(
                    consulta,
                    objetoConexion.establecerConexion());

                adapter.Fill(dt);

                tablaSucursales.DataSource = dt;

                ConfigurarColumnasGrid(tablaSucursales);

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar las sucursales.\n" + ex.Message);
            }
        }

        
        private void ConfigurarColumnasGrid(DataGridView tabla)
        {
            string[] columnasOcultas = { "direccion_detalle", "id_area", "zona_area_cubierta", "municipio_area_cubierta", "departamento_area_cubierta" };

            foreach (string columna in columnasOcultas)
            {
                if (tabla.Columns.Contains(columna))
                    tabla.Columns[columna].Visible = false;
            }

            if (tabla.Columns.Contains("id_sucursal"))
                tabla.Columns["id_sucursal"].HeaderText = "ID";
            if (tabla.Columns.Contains("nombre_sucursal"))
                tabla.Columns["nombre_sucursal"].HeaderText = "Nombre";
            if (tabla.Columns.Contains("direccion_completa"))
                tabla.Columns["direccion_completa"].HeaderText = "Dirección";
            if (tabla.Columns.Contains("telefono_sucursal"))
                tabla.Columns["telefono_sucursal"].HeaderText = "Teléfono";
            if (tabla.Columns.Contains("correo_sucursal"))
                tabla.Columns["correo_sucursal"].HeaderText = "Correo";
        }

        

        public void CargarDepartamentos(ComboBox comboBoxDepartamento)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                DataTable dt = new DataTable();

                string consulta =
                    "SELECT DISTINCT departamento_area_cubierta FROM area_cubierta " +
                    "WHERE departamento_area_cubierta IS NOT NULL ORDER BY departamento_area_cubierta";

                MySqlDataAdapter adapter = new MySqlDataAdapter(
                    consulta,
                    objetoConexion.establecerConexion());

                adapter.Fill(dt);

                comboBoxDepartamento.DataSource = dt;
                comboBoxDepartamento.DisplayMember = "departamento_area_cubierta";
                comboBoxDepartamento.ValueMember = "departamento_area_cubierta";
                comboBoxDepartamento.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los departamentos.\n" + ex.Message);
            }
        }

        public void CargarMunicipios(ComboBox comboBoxMunicipio, string departamento)
        {
            try
            {
                comboBoxMunicipio.DataSource = null;
                comboBoxMunicipio.Items.Clear();

                if (string.IsNullOrWhiteSpace(departamento))
                    return;

                CConexion objetoConexion = new CConexion();

                DataTable dt = new DataTable();

                string consulta =
                    "SELECT DISTINCT municipio_area_cubierta FROM area_cubierta " +
                    "WHERE departamento_area_cubierta = @departamento AND municipio_area_cubierta IS NOT NULL " +
                    "ORDER BY municipio_area_cubierta";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@departamento", departamento);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);

                comboBoxMunicipio.DataSource = dt;
                comboBoxMunicipio.DisplayMember = "municipio_area_cubierta";
                comboBoxMunicipio.ValueMember = "municipio_area_cubierta";
                comboBoxMunicipio.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los municipios.\n" + ex.Message);
            }
        }

        public void CargarZonas(ComboBox comboBoxZona, string departamento, string municipio)
        {
            try
            {
                comboBoxZona.DataSource = null;
                comboBoxZona.Items.Clear();

                if (string.IsNullOrWhiteSpace(departamento) || string.IsNullOrWhiteSpace(municipio))
                    return;

                CConexion objetoConexion = new CConexion();

                DataTable dt = new DataTable();

                string consulta =
                    "SELECT id_area, zona_area_cubierta FROM area_cubierta " +
                    "WHERE departamento_area_cubierta = @departamento AND municipio_area_cubierta = @municipio " +
                    "ORDER BY zona_area_cubierta";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@departamento", departamento);
                comando.Parameters.AddWithValue("@municipio", municipio);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);

                comboBoxZona.DataSource = dt;
                comboBoxZona.DisplayMember = "zona_area_cubierta";
                comboBoxZona.ValueMember = "id_area";
                comboBoxZona.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las zonas.\n" + ex.Message);
            }
        }


        public void SeleccionarSucursal(
            DataGridView tablaSucursales,
            TextBox txtIdSucursal,
            TextBox txtNombre,
            ComboBox comboBoxDepartamento,
            ComboBox comboBoxMunicipio,
            ComboBox comboBoxZona,
            TextBox txtDireccion,
            TextBox txtTelefono,
            TextBox txtCorreo)
        {
            try
            {
                DataGridViewRow fila = tablaSucursales.CurrentRow;

                if (fila == null)
                    return;

                txtIdSucursal.Text = fila.Cells["id_sucursal"].Value?.ToString();
                txtNombre.Text = fila.Cells["nombre_sucursal"].Value?.ToString();
                txtTelefono.Text = fila.Cells["telefono_sucursal"].Value?.ToString();
                txtCorreo.Text = fila.Cells["correo_sucursal"].Value?.ToString();
                txtDireccion.Text = fila.Cells["direccion_detalle"].Value?.ToString();

                object departamentoObj = fila.Cells["departamento_area_cubierta"].Value;
                object municipioObj = fila.Cells["municipio_area_cubierta"].Value;
                object idAreaObj = fila.Cells["id_area"].Value;

               
                if (departamentoObj != null && departamentoObj != DBNull.Value)
                    comboBoxDepartamento.SelectedValue = departamentoObj.ToString();
                else
                    comboBoxDepartamento.SelectedIndex = -1;

                if (municipioObj != null && municipioObj != DBNull.Value)
                    comboBoxMunicipio.SelectedValue = municipioObj.ToString();

                if (idAreaObj != null && idAreaObj != DBNull.Value)
                    comboBoxZona.SelectedValue = Convert.ToInt32(idAreaObj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la sucursal.\n" + ex.Message);
            }
        }

        public void Nuevo(
            TextBox txtIdSucursal,
            TextBox txtNombre,
            ComboBox comboBoxDepartamento,
            ComboBox comboBoxMunicipio,
            ComboBox comboBoxZona,
            TextBox txtDireccion,
            TextBox txtTelefono,
            TextBox txtCorreo)
        {
            txtIdSucursal.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            comboBoxDepartamento.SelectedIndex = -1;

            comboBoxMunicipio.DataSource = null;
            comboBoxMunicipio.Items.Clear();

            comboBoxZona.DataSource = null;
            comboBoxZona.Items.Clear();

            txtIdSucursal.Text = "Autogenerado";

            txtNombre.Focus();
        }


        private bool ValidarCampos(
            TextBox txtNombre,
            ComboBox comboBoxDepartamento,
            ComboBox comboBoxMunicipio,
            ComboBox comboBoxZona,
            TextBox txtDireccion,
            TextBox txtTelefono,
            TextBox txtCorreo)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la sucursal.");
                txtNombre.Focus();
                return false;
            }

            if (comboBoxDepartamento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el departamento.");
                comboBoxDepartamento.Focus();
                return false;
            }

            if (comboBoxMunicipio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el municipio.");
                comboBoxMunicipio.Focus();
                return false;
            }

            if (comboBoxZona.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la zona.");
                comboBoxZona.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Ingrese el detalle de la dirección.");
                txtDireccion.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese el teléfono.");
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Ingrese el correo.");
                txtCorreo.Focus();
                return false;
            }

            return true;
        }

        
        private void InsertarSucursal(
            TextBox txtNombre,
            ComboBox comboBoxZona,
            TextBox txtDireccion,
            TextBox txtTelefono,
            TextBox txtCorreo)
        {
            CConexion objetoConexion = new CConexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();

            MySqlTransaction transaccion = conexion.BeginTransaction();

            try
            {
                int idArea = Convert.ToInt32(comboBoxZona.SelectedValue);

                string consultaDireccion =
                    "INSERT INTO direccion (id_area, direccion_detalle) " +
                    "VALUES (@id_area, @detalle)";

                MySqlCommand comandoDireccion = new MySqlCommand(consultaDireccion, conexion, transaccion);
                comandoDireccion.Parameters.AddWithValue("@id_area", idArea);
                comandoDireccion.Parameters.AddWithValue("@detalle", txtDireccion.Text);
                comandoDireccion.ExecuteNonQuery();

                int idDireccion = (int)comandoDireccion.LastInsertedId;

                string consultaSucursal =
                    "INSERT INTO sucursal (nombre_sucursal, id_direccion, telefono_sucursal, correo_sucursal) " +
                    "VALUES (@nombre, @id_direccion, @telefono, @correo)";

                MySqlCommand comandoSucursal = new MySqlCommand(consultaSucursal, conexion, transaccion);
                comandoSucursal.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comandoSucursal.Parameters.AddWithValue("@id_direccion", idDireccion);
                comandoSucursal.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                comandoSucursal.Parameters.AddWithValue("@correo", txtCorreo.Text);
                comandoSucursal.ExecuteNonQuery();

                transaccion.Commit();
            }
            catch
            {
                transaccion.Rollback();
                throw;
            }
            finally
            {
                objetoConexion.cerrarConexion();
            }
        }

      
        private void ActualizarSucursal(
            TextBox txtIdSucursal,
            TextBox txtNombre,
            ComboBox comboBoxZona,
            TextBox txtDireccion,
            TextBox txtTelefono,
            TextBox txtCorreo)
        {
            CConexion objetoConexion = new CConexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();

            MySqlTransaction transaccion = conexion.BeginTransaction();

            try
            {
                int idSucursal = Convert.ToInt32(txtIdSucursal.Text);
                int idArea = Convert.ToInt32(comboBoxZona.SelectedValue);

                string consultaObtener =
                    "SELECT id_direccion FROM sucursal WHERE id_sucursal = @id_sucursal";

                MySqlCommand comandoObtener = new MySqlCommand(consultaObtener, conexion, transaccion);
                comandoObtener.Parameters.AddWithValue("@id_sucursal", idSucursal);

                object resultado = comandoObtener.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value)
                {
                    // La sucursal no tenía dirección asignada: se crea una nueva
                    string consultaInsertar =
                        "INSERT INTO direccion (id_area, direccion_detalle) VALUES (@id_area, @detalle)";

                    MySqlCommand comandoInsertar = new MySqlCommand(consultaInsertar, conexion, transaccion);
                    comandoInsertar.Parameters.AddWithValue("@id_area", idArea);
                    comandoInsertar.Parameters.AddWithValue("@detalle", txtDireccion.Text);
                    comandoInsertar.ExecuteNonQuery();

                    int nuevoIdDireccion = (int)comandoInsertar.LastInsertedId;

                    string consultaVincular =
                        "UPDATE sucursal SET id_direccion = @id_direccion WHERE id_sucursal = @id_sucursal";

                    MySqlCommand comandoVincular = new MySqlCommand(consultaVincular, conexion, transaccion);
                    comandoVincular.Parameters.AddWithValue("@id_direccion", nuevoIdDireccion);
                    comandoVincular.Parameters.AddWithValue("@id_sucursal", idSucursal);
                    comandoVincular.ExecuteNonQuery();
                }
                else
                {
                    int idDireccion = Convert.ToInt32(resultado);

                    string consultaActualizarDireccion =
                        "UPDATE direccion SET id_area = @id_area, direccion_detalle = @detalle " +
                        "WHERE id_direccion = @id_direccion";

                    MySqlCommand comandoActualizarDireccion = new MySqlCommand(consultaActualizarDireccion, conexion, transaccion);
                    comandoActualizarDireccion.Parameters.AddWithValue("@id_area", idArea);
                    comandoActualizarDireccion.Parameters.AddWithValue("@detalle", txtDireccion.Text);
                    comandoActualizarDireccion.Parameters.AddWithValue("@id_direccion", idDireccion);
                    comandoActualizarDireccion.ExecuteNonQuery();
                }

                string consultaSucursal =
                    "UPDATE sucursal SET nombre_sucursal = @nombre, telefono_sucursal = @telefono, correo_sucursal = @correo " +
                    "WHERE id_sucursal = @id_sucursal";

                MySqlCommand comandoSucursal = new MySqlCommand(consultaSucursal, conexion, transaccion);
                comandoSucursal.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comandoSucursal.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                comandoSucursal.Parameters.AddWithValue("@correo", txtCorreo.Text);
                comandoSucursal.Parameters.AddWithValue("@id_sucursal", idSucursal);
                comandoSucursal.ExecuteNonQuery();

                transaccion.Commit();
            }
            catch
            {
                transaccion.Rollback();
                throw;
            }
            finally
            {
                objetoConexion.cerrarConexion();
            }
        }

       
        private void EliminarSucursal(TextBox txtIdSucursal)
        {
            CConexion objetoConexion = new CConexion();
            MySqlConnection conexion = objetoConexion.establecerConexion();

            try
            {
                int idSucursal = Convert.ToInt32(txtIdSucursal.Text);

                string consultaObtener =
                    "SELECT id_direccion FROM sucursal WHERE id_sucursal = @id_sucursal";

                MySqlCommand comandoObtener = new MySqlCommand(consultaObtener, conexion);
                comandoObtener.Parameters.AddWithValue("@id_sucursal", idSucursal);

                object resultado = comandoObtener.ExecuteScalar();

                string consultaEliminar =
                    "DELETE FROM sucursal WHERE id_sucursal = @id_sucursal";

                MySqlCommand comandoEliminar = new MySqlCommand(consultaEliminar, conexion);
                comandoEliminar.Parameters.AddWithValue("@id_sucursal", idSucursal);
                comandoEliminar.ExecuteNonQuery();

                if (resultado != null && resultado != DBNull.Value)
                {
                    try
                    {
                        int idDireccion = Convert.ToInt32(resultado);

                        string consultaEliminarDireccion =
                            "DELETE FROM direccion WHERE id_direccion = @id_direccion";

                        MySqlCommand comandoEliminarDireccion = new MySqlCommand(consultaEliminarDireccion, conexion);
                        comandoEliminarDireccion.Parameters.AddWithValue("@id_direccion", idDireccion);
                        comandoEliminarDireccion.ExecuteNonQuery();
                    }
                    catch
                    {
                        
                    }
                }
            }
            finally
            {
                objetoConexion.cerrarConexion();
            }
        }

        public void Guardar(
            TextBox txtNombre,
            ComboBox comboBoxDepartamento,
            ComboBox comboBoxMunicipio,
            ComboBox comboBoxZona,
            TextBox txtDireccion,
            TextBox txtTelefono,
            TextBox txtCorreo,
            DataGridView tablaSucursales,
            TextBox txtIdSucursal)
        {
            if (!ValidarCampos(
                txtNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                txtDireccion,
                txtTelefono,
                txtCorreo))
                return;

            try
            {
                InsertarSucursal(
                    txtNombre,
                    comboBoxZona,
                    txtDireccion,
                    txtTelefono,
                    txtCorreo);

                MessageBox.Show("Sucursal registrada correctamente.");

                MostrarSucursales(tablaSucursales);

                Nuevo(
                    txtIdSucursal,
                    txtNombre,
                    comboBoxDepartamento,
                    comboBoxMunicipio,
                    comboBoxZona,
                    txtDireccion,
                    txtTelefono,
                    txtCorreo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar la sucursal.\n" + ex.Message);
            }
        }


        public void Editar(
            TextBox txtIdSucursal,
            TextBox txtNombre,
            ComboBox comboBoxDepartamento,
            ComboBox comboBoxMunicipio,
            ComboBox comboBoxZona,
            TextBox txtDireccion,
            TextBox txtTelefono,
            TextBox txtCorreo,
            DataGridView tablaSucursales)
        {
            if (!int.TryParse(txtIdSucursal.Text, out int id))
            {
                MessageBox.Show("Seleccione una sucursal válida para editar.");
                return;
            }

            if (!ValidarCampos(
                txtNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                txtDireccion,
                txtTelefono,
                txtCorreo))
                return;

            try
            {
                ActualizarSucursal(
                    txtIdSucursal,
                    txtNombre,
                    comboBoxZona,
                    txtDireccion,
                    txtTelefono,
                    txtCorreo);

                MessageBox.Show("Sucursal actualizada correctamente.");

                MostrarSucursales(tablaSucursales);

                Nuevo(
                    txtIdSucursal,
                    txtNombre,
                    comboBoxDepartamento,
                    comboBoxMunicipio,
                    comboBoxZona,
                    txtDireccion,
                    txtTelefono,
                    txtCorreo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la sucursal.\n" + ex.Message);
            }
        }

        public void Eliminar(
            TextBox txtIdSucursal,
            TextBox txtNombre,
            ComboBox comboBoxDepartamento,
            ComboBox comboBoxMunicipio,
            ComboBox comboBoxZona,
            TextBox txtDireccion,
            TextBox txtTelefono,
            TextBox txtCorreo,
            DataGridView tablaSucursales)
        {
            if (!int.TryParse(txtIdSucursal.Text, out int idSucursal))
            {
                MessageBox.Show("Seleccione una sucursal válida para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea eliminar esta sucursal?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                EliminarSucursal(txtIdSucursal);

                MessageBox.Show("Sucursal eliminada correctamente.");

                MostrarSucursales(tablaSucursales);

                Nuevo(
                    txtIdSucursal,
                    txtNombre,
                    comboBoxDepartamento,
                    comboBoxMunicipio,
                    comboBoxZona,
                    txtDireccion,
                    txtTelefono,
                    txtCorreo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la sucursal.\n" + ex.Message);
            }
        }

        public void Buscar(
            TextBox txtBuscar,
            DataGridView tablaSucursales)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string consulta =
                    CONSULTA_BASE +
                    "WHERE s.nombre_sucursal LIKE @buscar " +
                    "OR d.direccion_detalle LIKE @buscar " +
                    "OR a.zona_area_cubierta LIKE @buscar " +
                    "OR a.municipio_area_cubierta LIKE @buscar " +
                    "OR a.departamento_area_cubierta LIKE @buscar " +
                    "OR s.telefono_sucursal LIKE @buscar " +
                    "OR s.correo_sucursal LIKE @buscar " +
                    "ORDER BY s.id_sucursal";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@buscar",
                    "%" + txtBuscar.Text + "%");

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(comando);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                tablaSucursales.DataSource = dt;

                ConfigurarColumnasGrid(tablaSucursales);

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar.\n" + ex.Message);
            }
        }

        public void Actualizar(
            DataGridView tablaSucursales,
            TextBox txtIdSucursal,
            TextBox txtNombre,
            ComboBox comboBoxDepartamento,
            ComboBox comboBoxMunicipio,
            ComboBox comboBoxZona,
            TextBox txtDireccion,
            TextBox txtTelefono,
            TextBox txtCorreo)
        {
            MostrarSucursales(tablaSucursales);

            Nuevo(
                txtIdSucursal,
                txtNombre,
                comboBoxDepartamento,
                comboBoxMunicipio,
                comboBoxZona,
                txtDireccion,
                txtTelefono,
                txtCorreo);
        }

    }

}
