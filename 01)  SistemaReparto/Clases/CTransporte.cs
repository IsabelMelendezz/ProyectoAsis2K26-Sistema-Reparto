//Carlos David Calderón Ramirez
//9959-23-848

using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SistemaReparto.Clases
{

    internal class CTransporte
    {

        public void mostrarVehiculo(DataGridView TablaTransporte)
        {
            try
            {
                CConexion objetoConexion = new CConexion();
                String query = "SELECT t.id_vehiculo AS Id_Vehiculo, " +
                               "t.placa_vehiculo AS Placa, " +
                               "t.marca_vehiculo AS Marca, " +
                               "t.modelo_vehiculo AS Modelo, " +
                               "t.anio_vehiculo AS Año, " +
                               "t.capacidad_peso_vehiculo AS Capacidad_Peso, " +
                               "tv.nombre_tipo_vehiculo AS Vehiculo, " +
                               "ev.nombre_estado_vehiculo AS Estado " +
                               "FROM vehiculo t " +
                               "INNER JOIN tipo_vehiculo tv ON t.id_tipo_vehiculo = tv.id_tipo_vehiculo " +
                               "INNER JOIN estado_vehiculo ev ON t.id_estado_vehiculo = ev.id_estado_vehiculo";

                TablaTransporte.DataSource = null;
                TablaTransporte.Columns.Clear();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                TablaTransporte.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());

            }
        }


        public void llenarComboTipoVehiculo(ComboBox Cbo_Tipo_Transporte)
        {
            try
            {
                Cbo_Tipo_Transporte.DataSource = null;
                Cbo_Tipo_Transporte.Items.Clear();
                CConexion objetoConexion = new CConexion();
                string query = "SELECT id_tipo_vehiculo, nombre_tipo_vehiculo FROM tipo_vehiculo";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Cbo_Tipo_Transporte.DataSource = dt;
                Cbo_Tipo_Transporte.DisplayMember = "nombre_tipo_vehiculo";
                Cbo_Tipo_Transporte.ValueMember = "id_tipo_vehiculo";
                Cbo_Tipo_Transporte.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargó el combo de Tipo Empleado, error: " + ex.ToString());
            }
        }


        public void llenarComboEstadoVehiculo(ComboBox Cbo_Estado_Transporte)
        {
            try
            {
                Cbo_Estado_Transporte.DataSource = null;
                Cbo_Estado_Transporte.Items.Clear();
                CConexion objetoConexion = new CConexion();
                string query = "SELECT id_estado_vehiculo, nombre_estado_vehiculo FROM estado_vehiculo";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Cbo_Estado_Transporte.DataSource = dt;
                Cbo_Estado_Transporte.DisplayMember = "nombre_estado_vehiculo";
                Cbo_Estado_Transporte.ValueMember = "id_estado_vehiculo";
                Cbo_Estado_Transporte.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargó el combo de Estado Empleado, error: " + ex.ToString());
            }
        }




        public int GuardarVehiculo(ComboBox Cbo_Tipo_Transporte, ComboBox Cbo_Estado_Transporte,
            TextBox placa, TextBox año, TextBox modelo, TextBox marca,
            TextBox peso)
        {
            try
            {
                if (Cbo_Tipo_Transporte.SelectedValue == null || Cbo_Estado_Transporte.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar Tipo de Vehiculo y Estado.");
                    return -1;
                }

                if (!Regex.IsMatch(placa.Text, @"^[A-Za-z]{2}[0-9]{3}[A-Za-z]{3}$"))
                {
                    MessageBox.Show("La placa debe tener el formato: 2 letras, 3 números, 3 letras (Ej: PO159HRC)");
                    return -1;
                }

                CConexion objetoConexion = new CConexion();
                MySqlConnection conexion = objetoConexion.establecerConexion();

                string query = "INSERT INTO vehiculo " +
                    "(id_tipo_vehiculo, id_estado_vehiculo, placa_vehiculo, anio_vehiculo,modelo_vehiculo, marca_vehiculo, capacidad_peso_vehiculo) " +
                    "VALUES (@tipov, @estadov, @placa, @anio, @modelo, @marca, @capacidad_peso)";

                MySqlCommand myComand = new MySqlCommand(query, conexion);
                myComand.Parameters.AddWithValue("@tipov", Cbo_Tipo_Transporte.SelectedValue);
                myComand.Parameters.AddWithValue("@estadov", Cbo_Estado_Transporte.SelectedValue);
                myComand.Parameters.AddWithValue("@placa", placa.Text);
                myComand.Parameters.AddWithValue("@anio", año.Text);
                myComand.Parameters.AddWithValue("@modelo", modelo.Text);
                myComand.Parameters.AddWithValue("@marca", marca.Text);
                myComand.Parameters.AddWithValue("@capacidad_peso", peso.Text);
                

                myComand.ExecuteNonQuery();

                int nuevoId = Convert.ToInt32(myComand.LastInsertedId);

                MessageBox.Show("Se guardó el vehiculo correctamente");
                objetoConexion.cerrarConexion();

                return nuevoId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardó el vehiculo, error: " + ex.ToString());
                return -1;
            }
        }


        // SELECCIONAR (cargar fila tabla de controles)
        // 
        public int SeleccionarVehiculo(DataGridView tablaVehiculos,
            ComboBox Cbo_Tipo_Transporte, ComboBox Cbo_Estado_Transporte,
            TextBox placa, TextBox año, TextBox modelo, TextBox marca,
            TextBox peso)
        {
            try
            {
                DataGridViewRow fila = tablaVehiculos.CurrentRow;

                if (fila == null || fila.IsNewRow || fila.Cells["Id_Vehiculo"].Value == null)
                    return -1;

                int idVehiculo = Convert.ToInt32(fila.Cells["Id_Vehiculo"].Value);

                placa.Text = ObtenerTexto(fila, "Placa");
                año.Text = ObtenerTexto(fila, "Año");
                modelo.Text = ObtenerTexto(fila, "Modelo");
                marca.Text = ObtenerTexto(fila, "Marca");
                peso.Text = ObtenerTexto(fila, "Capacidad_Peso");
                

                Cbo_Tipo_Transporte.Text = ObtenerTexto(fila, "Vehiculo");
                Cbo_Estado_Transporte.Text = ObtenerTexto(fila, "Estado");

                return idVehiculo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No logro seleccionar el vehiculo: " + ex.ToString());
                return -1;
            }
        }

        private string ObtenerTexto(DataGridViewRow fila, string columna)
        {
            object valor = fila.Cells[columna].Value;
            return (valor == null || valor == DBNull.Value) ? string.Empty : valor.ToString();
        }

        // MODIFICAR (UPDATE)

        public void ModificarVehiculo(int idVehiculo, ComboBox Cbo_Tipo_Transporte, ComboBox Cbo_Estado_Transporte,
            TextBox placa, TextBox año, TextBox modelo, TextBox marca, TextBox peso)
        {
            try
            {
                if (idVehiculo <= 0)
                {
                    MessageBox.Show("Debe seleccionar un vehiculo de la tabla antes de editar.");
                    return;
                }

                if (!Regex.IsMatch(placa.Text, @"^[A-Za-z]{2}[0-9]{3}[A-Za-z]{3}$"))
                {
                    MessageBox.Show("La placa debe tener el formato: 2 letras, 3 números, 3 letras (Ej: PO159HRC)");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "UPDATE vehiculo SET " +
                    "id_tipo_vehiculo = @tipov, " +
                    "id_estado_vehiculo = @estadov, " +
                    "placa_vehiculo = @placa, " +
                    "anio_vehiculo = @anio, " +
                    "modelo_vehiculo = @modelo, " +
                    "marca_vehiculo = @marca, " +
                    "capacidad_peso_vehiculo = @capacidad_peso, ";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@tipov", Cbo_Tipo_Transporte.SelectedValue);
                myComand.Parameters.AddWithValue("@estadov", Cbo_Estado_Transporte.SelectedValue);
                myComand.Parameters.AddWithValue("@placa", placa.Text);
                myComand.Parameters.AddWithValue("@anio", año.Text);
                myComand.Parameters.AddWithValue("@modelo", modelo.Text);
                myComand.Parameters.AddWithValue("@marca", marca.Text);
                myComand.Parameters.AddWithValue("@capacidad_peso", peso.Text);
         

                int filas = myComand.ExecuteNonQuery();
                if (filas > 0)
                    MessageBox.Show("Se modificó correctamente");
                else
                    MessageBox.Show("No se encontró ningún registro con ese ID");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizó el vehiculo, error: " + ex.ToString());
            }
        }

        // ELIMINAR (DELETE)

        public void EliminarVehiculo(int idVehiculo)
        {
            try
            {
                if (idVehiculo <= 0)
                {
                    MessageBox.Show("Debe seleccionar un vehiculo de la tabla antes de eliminar.");
                    return;
                }

                CConexion objetoConexion = new CConexion();
                string query = "DELETE FROM vehiculo WHERE id_vehiculo = @id";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@id", idVehiculo);

                int filasAfectadas = myComand.ExecuteNonQuery();

                if (filasAfectadas > 0)
                    MessageBox.Show("Se eliminó correctamente");
                else
                    MessageBox.Show("No se encontró ningún registro con ese ID");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el registro, error: " + ex.ToString());
            }
        }


    }
}
