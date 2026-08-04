//Lourdes Isabel Melendez Pineda 
//9959-23-1379



using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaReparto.Clases
{
    internal class CPedidos
    {
        CConexion objetoConexion = new CConexion();

        public void MostrarPedidos(DataGridView dgvPedidos)
        {
            try
            {
                string consulta = @"SELECT
                        p.id_pedido,
                        p.codigo_pedido,
                        p.id_cliente,
                        p.id_estado_pedido,
                        p.id_ruta,
                        p.fecha_solicitud_pedido AS fecha_solicitud,
                        p.id_direccion_origen_pedido,
                        p.id_direccion_destino_pedido,
                        CONCAT(dO.direccion_detalle, ' - ', aO.zona_area_cubierta, ', ', aO.municipio_area_cubierta, ', ', aO.departamento_area_cubierta) AS direccion_origen,
                        CONCAT(dD.direccion_detalle, ' - ', aD.zona_area_cubierta, ', ', aD.municipio_area_cubierta, ', ', aD.departamento_area_cubierta) AS direccion_destino,
                        p.peso_total_pedido AS peso_total,
                        p.cantidad_paquetes_pedido AS cantidad_paquetes,
                        p.observaciones_pedido AS observaciones
                    FROM pedido p
                    LEFT JOIN direccion dO ON dO.id_direccion = p.id_direccion_origen_pedido
                    LEFT JOIN area_cubierta aO ON aO.id_area = dO.id_area
                    LEFT JOIN direccion dD ON dD.id_direccion = p.id_direccion_destino_pedido
                    LEFT JOIN area_cubierta aD ON aD.id_area = dD.id_area
                    ORDER BY p.id_pedido;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(
                    consulta,
                    objetoConexion.establecerConexion());

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgvPedidos.DataSource = tabla;

                ConfigurarEstiloTabla(dgvPedidos);

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los pedidos.\n" + ex.Message);
            }
        }


        private void ConfigurarEstiloTabla(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.FromArgb(230, 230, 230);
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
            dgv.MultiSelect = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 66, 143);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersHeight = 38;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 225, 245);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(21, 66, 143);
            dgv.DefaultCellStyle.Padding = new Padding(4);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 252);

            dgv.RowTemplate.Height = 32;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Nombre de columna -> (texto amigable, peso relativo de ancho)
            var config = new Dictionary<string, (string texto, int peso)>
            {
                { "id_pedido",          ("ID", 6) },
                { "codigo_pedido",      ("Codigo", 12) },
                { "id_cliente",         ("Cliente", 9) },
                { "id_estado_pedido",   ("Estado", 9) },
                { "id_ruta",            ("Ruta", 8) },
                { "fecha_solicitud",    ("Fecha Solicitud", 13) },
                { "direccion_origen",   ("Direccion Origen", 20) },
                { "direccion_destino",  ("Direccion Destino", 20) },
                { "peso_total",         ("Peso (kg)", 9) },
                { "cantidad_paquetes",  ("Paquetes", 9) },
                { "observaciones",      ("Observaciones", 16) },
            };

            // columnas tecnicas que se usan internamente pero no deben mostrarse al usuario
            var columnasOcultas = new HashSet<string>
            {
                "id_direccion_origen_pedido",
                "id_direccion_destino_pedido",
            };

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (columnasOcultas.Contains(col.Name))
                {
                    col.Visible = false;
                    continue;
                }

                if (config.TryGetValue(col.Name, out var datos))
                {
                    col.HeaderText = datos.texto;
                    col.FillWeight = datos.peso;
                }
                else
                {
                    col.FillWeight = 10;
                }

                col.MinimumWidth = 60;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }

        public void LlenarComboCliente(ComboBox cboCliente)
        {
            try
            {
                string consulta = @"SELECT id_cliente,
                        CONCAT(nombres_cliente, ' ', apellidos_cliente) AS nombre_completo
                    FROM cliente
                    ORDER BY nombres_cliente ASC;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, objetoConexion.establecerConexion());

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                cboCliente.DataSource = tabla;
                cboCliente.DisplayMember = "nombre_completo";
                cboCliente.ValueMember = "id_cliente";
                cboCliente.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes.\n" + ex.Message);
            }
        }

    
        public void LlenarComboRuta(ComboBox cboRuta)
        {
            try
            {
                string consulta = @"SELECT r.id_ruta,
                        CONCAT(
                            'Ruta ', r.id_ruta,
                            ' - ', tr.nombre_tipo_ruta,
                            ' - ', b.nombre_bodega,
                            ' - ', a.zona_area_cubierta, ', ', a.municipio_area_cubierta,
                            ' (', er.nombre_estado_ruta, ')'
                        ) AS descripcion_ruta
                    FROM ruta r
                    LEFT JOIN tipo_ruta tr ON tr.id_tipo_ruta = r.id_tipo_ruta
                    LEFT JOIN bodega b ON b.id_bodega = r.id_bodega
                    LEFT JOIN area_cubierta a ON a.id_area = r.id_area
                    LEFT JOIN estado_ruta er ON er.id_estado_ruta = r.id_estado_ruta
                    ORDER BY r.id_ruta ASC;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, objetoConexion.establecerConexion());

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                cboRuta.DataSource = tabla;
                cboRuta.DisplayMember = "descripcion_ruta";
                cboRuta.ValueMember = "id_ruta";
                cboRuta.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las rutas.\n" + ex.Message);
            }
        }

        // Devuelve el texto plano de una ruta ya asignada a un pedido,
        // para mostrarlo como informacion de SOLO LECTURA en el CRUD de Pedidos.
        // No se usa para editar; solo para contexto de nuestro pedido :) .
        private string ObtenerDescripcionRuta(int idRuta)
        {
            try
            {
                string consulta = @"SELECT CONCAT(
                            'Ruta ', r.id_ruta,
                            ' - ', tr.nombre_tipo_ruta,
                            ' - ', b.nombre_bodega,
                            ' - ', a.zona_area_cubierta, ', ', a.municipio_area_cubierta,
                            ' (', er.nombre_estado_ruta, ')'
                        ) AS descripcion_ruta
                    FROM ruta r
                    LEFT JOIN tipo_ruta tr ON tr.id_tipo_ruta = r.id_tipo_ruta
                    LEFT JOIN bodega b ON b.id_bodega = r.id_bodega
                    LEFT JOIN area_cubierta a ON a.id_area = r.id_area
                    LEFT JOIN estado_ruta er ON er.id_estado_ruta = r.id_estado_ruta
                    WHERE r.id_ruta = @id_ruta
                    LIMIT 1;";

                MySqlCommand cmd = new MySqlCommand(consulta, objetoConexion.establecerConexion());
                cmd.Parameters.AddWithValue("@id_ruta", idRuta);

                object resultado = cmd.ExecuteScalar();
                objetoConexion.cerrarConexion();

                return resultado != null ? resultado.ToString() : "Ruta no encontrada";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la informacion de la ruta.\n" + ex.Message);
                return string.Empty;
            }
        }

        public void LlenarComboEstadoPedido(ComboBox cboEstadoPedido)
        {
            try
            {
                string consulta = "SELECT id_estado_pedido, nombre_estado_pedido FROM estado_pedido ORDER BY id_estado_pedido ASC;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, objetoConexion.establecerConexion());

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                cboEstadoPedido.DataSource = tabla;
                cboEstadoPedido.DisplayMember = "nombre_estado_pedido";
                cboEstadoPedido.ValueMember = "id_estado_pedido";
                cboEstadoPedido.SelectedIndex = -1;

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los estados de pedido.\n" + ex.Message);
            }
        }

        public void LlenarComboDepartamento(ComboBox cboDepartamento)
        {
            try
            {
                string consulta = @"SELECT DISTINCT departamento_area_cubierta
                    FROM area_cubierta
                    WHERE departamento_area_cubierta IS NOT NULL
                    ORDER BY departamento_area_cubierta ASC;";

                MySqlCommand cmd = new MySqlCommand(consulta, objetoConexion.establecerConexion());

                MySqlDataReader reader = cmd.ExecuteReader();

                cboDepartamento.Items.Clear();

                while (reader.Read())
                {
                    cboDepartamento.Items.Add(reader["departamento_area_cubierta"].ToString());
                }

                reader.Close();
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los departamentos.\n" + ex.Message);
            }
        }

        public void LlenarComboMunicipio(ComboBox cboMunicipio, string departamento)
        {
            try
            {
                cboMunicipio.Items.Clear();
                cboMunicipio.Text = string.Empty;

                if (string.IsNullOrWhiteSpace(departamento))
                    return;

                string consulta = @"SELECT DISTINCT municipio_area_cubierta
                    FROM area_cubierta
                    WHERE departamento_area_cubierta = @departamento
                    ORDER BY municipio_area_cubierta ASC;";

                MySqlCommand cmd = new MySqlCommand(consulta, objetoConexion.establecerConexion());
                cmd.Parameters.AddWithValue("@departamento", departamento);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboMunicipio.Items.Add(reader["municipio_area_cubierta"].ToString());
                }

                reader.Close();
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los municipios.\n" + ex.Message);
            }
        }

        public void LlenarComboZona(ComboBox cboZona, string departamento, string municipio)
        {
            try
            {
                cboZona.Items.Clear();
                cboZona.Text = string.Empty;

                if (string.IsNullOrWhiteSpace(departamento) || string.IsNullOrWhiteSpace(municipio))
                    return;

                string consulta = @"SELECT DISTINCT zona_area_cubierta
                    FROM area_cubierta
                    WHERE departamento_area_cubierta = @departamento
                    AND municipio_area_cubierta = @municipio
                    ORDER BY zona_area_cubierta ASC;";

                MySqlCommand cmd = new MySqlCommand(consulta, objetoConexion.establecerConexion());
                cmd.Parameters.AddWithValue("@departamento", departamento);
                cmd.Parameters.AddWithValue("@municipio", municipio);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboZona.Items.Add(reader["zona_area_cubierta"].ToString());
                }

                reader.Close();
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las zonas.\n" + ex.Message);
            }
        }

        // concatene el id_area para que muestre departamento y  municipio y zona.
        private int ObtenerOCrearIdArea(string departamento, string municipio, string zona)
        {
            string consultaBuscar = @"SELECT id_area FROM area_cubierta
                WHERE departamento_area_cubierta = @departamento
                AND municipio_area_cubierta = @municipio
                AND zona_area_cubierta = @zona
                LIMIT 1;";

            MySqlCommand cmdBuscar = new MySqlCommand(consultaBuscar, objetoConexion.establecerConexion());
            cmdBuscar.Parameters.AddWithValue("@departamento", departamento);
            cmdBuscar.Parameters.AddWithValue("@municipio", municipio);
            cmdBuscar.Parameters.AddWithValue("@zona", zona);

            object resultado = cmdBuscar.ExecuteScalar();
            objetoConexion.cerrarConexion();

            if (resultado != null)
            {
                return Convert.ToInt32(resultado);
            }

            string consultaInsertar = @"INSERT INTO area_cubierta
                (zona_area_cubierta, municipio_area_cubierta, departamento_area_cubierta)
                VALUES (@zona, @municipio, @departamento);
                SELECT LAST_INSERT_ID();";

            MySqlCommand cmdInsertar = new MySqlCommand(consultaInsertar, objetoConexion.establecerConexion());
            cmdInsertar.Parameters.AddWithValue("@departamento", departamento);
            cmdInsertar.Parameters.AddWithValue("@municipio", municipio);
            cmdInsertar.Parameters.AddWithValue("@zona", zona);

            int nuevoIdArea = Convert.ToInt32(cmdInsertar.ExecuteScalar());
            objetoConexion.cerrarConexion();

            return nuevoIdArea;
        }

        // Busca la direccion (id_area + direccion_detalle) y la reutiliza si ya existe,
        // o la crea si es la primera vez que se registra.
        private int ObtenerOCrearIdDireccion(string departamento, string municipio, string zona, string direccionDetalle)
        {
            int idArea = ObtenerOCrearIdArea(departamento, municipio, zona);

            string consultaBuscar = @"SELECT id_direccion FROM direccion
                WHERE id_area = @id_area AND direccion_detalle = @detalle
                LIMIT 1;";

            MySqlCommand cmdBuscar = new MySqlCommand(consultaBuscar, objetoConexion.establecerConexion());
            cmdBuscar.Parameters.AddWithValue("@id_area", idArea);
            cmdBuscar.Parameters.AddWithValue("@detalle", direccionDetalle);

            object resultado = cmdBuscar.ExecuteScalar();
            objetoConexion.cerrarConexion();

            if (resultado != null)
            {
                return Convert.ToInt32(resultado);
            }

            string consultaInsertar = @"INSERT INTO direccion (id_area, direccion_detalle)
                VALUES (@id_area, @detalle);
                SELECT LAST_INSERT_ID();";

            MySqlCommand cmdInsertar = new MySqlCommand(consultaInsertar, objetoConexion.establecerConexion());
            cmdInsertar.Parameters.AddWithValue("@id_area", idArea);
            cmdInsertar.Parameters.AddWithValue("@detalle", direccionDetalle);

            int nuevoIdDireccion = Convert.ToInt32(cmdInsertar.ExecuteScalar());
            objetoConexion.cerrarConexion();

            return nuevoIdDireccion;
        }

        public void GuardarPedido(
            TextBox TxtCodigoPedido,
            ComboBox cboCliente,
            ComboBox cboEstadoPedido,
            DateTimePicker dateTimePedido,
            ComboBox comboBoxDepartamentoOrigen,
            ComboBox comboBoxMunicipioOrigen,
            ComboBox comboBoxZonaOrigen,
            TextBox TextBoxDireccionOrigen,
            ComboBox comboBoxDepartamentoDestino,
            ComboBox comboBoxMunicipioDestino,
            ComboBox comboBoxZonaDestino,
            TextBox TextBoxDireccionDestino,
            TextBox txtPesoTotal,
            TextBox TxtCantidadPaquetes,
            TextBox TxtObservaciones)
        {
            try
            {
                if (!ValidarDireccion(comboBoxDepartamentoOrigen, comboBoxMunicipioOrigen, comboBoxZonaOrigen, TextBoxDireccionOrigen, "origen")
                    || !ValidarDireccion(comboBoxDepartamentoDestino, comboBoxMunicipioDestino, comboBoxZonaDestino, TextBoxDireccionDestino, "destino"))
                {
                    return;
                }

                if (cboCliente.SelectedValue == null || cboEstadoPedido.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un cliente y un estado de pedido antes de guardar.");
                    return;
                }

                int idDireccionOrigen = ObtenerOCrearIdDireccion(
                    comboBoxDepartamentoOrigen.Text, comboBoxMunicipioOrigen.Text, comboBoxZonaOrigen.Text, TextBoxDireccionOrigen.Text);

                int idDireccionDestino = ObtenerOCrearIdDireccion(
                    comboBoxDepartamentoDestino.Text, comboBoxMunicipioDestino.Text, comboBoxZonaDestino.Text, TextBoxDireccionDestino.Text);

                string consulta = @"INSERT INTO pedido
                (codigo_pedido, id_cliente, id_estado_pedido, id_ruta, id_direccion_origen_pedido, id_direccion_destino_pedido, fecha_solicitud_pedido, peso_total_pedido, cantidad_paquetes_pedido, observaciones_pedido)
                VALUES
                (@codigo_pedido, @id_cliente, @id_estado_pedido, @id_ruta, @id_direccion_origen, @id_direccion_destino, @fecha_solicitud, @peso_total, @cantidad_paquetes, @observaciones);";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@codigo_pedido", TxtCodigoPedido.Text);
                comando.Parameters.AddWithValue("@id_cliente", cboCliente.SelectedValue);
                comando.Parameters.AddWithValue("@id_estado_pedido", cboEstadoPedido.SelectedValue);

          
                comando.Parameters.AddWithValue("@id_ruta", DBNull.Value);

                comando.Parameters.AddWithValue("@id_direccion_origen", idDireccionOrigen);
                comando.Parameters.AddWithValue("@id_direccion_destino", idDireccionDestino);
                comando.Parameters.AddWithValue("@fecha_solicitud", dateTimePedido.Value.Date);
                comando.Parameters.AddWithValue("@peso_total", txtPesoTotal.Text);
                comando.Parameters.AddWithValue("@cantidad_paquetes", TxtCantidadPaquetes.Text);
                comando.Parameters.AddWithValue("@observaciones", TxtObservaciones.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Pedido registrado correctamente.");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pedido.\n" + ex.Message);
            }
        }

        public void EliminarPedido(int idPedido)
        {
            try
            {
                string consulta = "DELETE FROM pedido WHERE id_pedido = @id;";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@id", idPedido);

                comando.ExecuteNonQuery();

                MessageBox.Show("Pedido eliminado correctamente.");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el pedido.\n" + ex.Message);
            }
        }

        public void ModificarPedido(
            int idPedido,
            TextBox TxtCodigoPedido,
            ComboBox cboCliente,
            ComboBox cboEstadoPedido,
            DateTimePicker dateTimePedido,
            ComboBox comboBoxDepartamentoOrigen,
            ComboBox comboBoxMunicipioOrigen,
            ComboBox comboBoxZonaOrigen,
            TextBox TextBoxDireccionOrigen,
            ComboBox comboBoxDepartamentoDestino,
            ComboBox comboBoxMunicipioDestino,
            ComboBox comboBoxZonaDestino,
            TextBox TextBoxDireccionDestino,
            TextBox txtPesoTotal,
            TextBox TxtCantidadPaquetes,
            TextBox TxtObservaciones)
        {
            try
            {
                if (!ValidarDireccion(comboBoxDepartamentoOrigen, comboBoxMunicipioOrigen, comboBoxZonaOrigen, TextBoxDireccionOrigen, "origen")
                    || !ValidarDireccion(comboBoxDepartamentoDestino, comboBoxMunicipioDestino, comboBoxZonaDestino, TextBoxDireccionDestino, "destino"))
                {
                    return;
                }

                if (cboCliente.SelectedValue == null || cboEstadoPedido.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un cliente y un estado de pedido antes de guardar.");
                    return;
                }

                int idDireccionOrigen = ObtenerOCrearIdDireccion(
                    comboBoxDepartamentoOrigen.Text, comboBoxMunicipioOrigen.Text, comboBoxZonaOrigen.Text, TextBoxDireccionOrigen.Text);

                int idDireccionDestino = ObtenerOCrearIdDireccion(
                    comboBoxDepartamentoDestino.Text, comboBoxMunicipioDestino.Text, comboBoxZonaDestino.Text, TextBoxDireccionDestino.Text);

             
                string consulta = @"UPDATE pedido SET
                    codigo_pedido = @codigo_pedido,
                    id_cliente = @id_cliente,
                    id_estado_pedido = @id_estado_pedido,
                    id_direccion_origen_pedido = @id_direccion_origen,
                    id_direccion_destino_pedido = @id_direccion_destino,
                    fecha_solicitud_pedido = @fecha_solicitud,
                    peso_total_pedido = @peso_total,
                    cantidad_paquetes_pedido = @cantidad_paquetes,
                    observaciones_pedido = @observaciones
                    WHERE id_pedido = @id_pedido;";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@id_pedido", idPedido);
                comando.Parameters.AddWithValue("@codigo_pedido", TxtCodigoPedido.Text);
                comando.Parameters.AddWithValue("@id_cliente", cboCliente.SelectedValue);
                comando.Parameters.AddWithValue("@id_estado_pedido", cboEstadoPedido.SelectedValue);

                comando.Parameters.AddWithValue("@id_direccion_origen", idDireccionOrigen);
                comando.Parameters.AddWithValue("@id_direccion_destino", idDireccionDestino);
                comando.Parameters.AddWithValue("@fecha_solicitud", dateTimePedido.Value.Date);
                comando.Parameters.AddWithValue("@peso_total", txtPesoTotal.Text);
                comando.Parameters.AddWithValue("@cantidad_paquetes", TxtCantidadPaquetes.Text);
                comando.Parameters.AddWithValue("@observaciones", TxtObservaciones.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Pedido modificado correctamente.");

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el pedido.\n" + ex.Message);
            }
        }

        private bool ValidarDireccion(ComboBox cboDepartamento, ComboBox cboMunicipio, ComboBox cboZona, TextBox txtDireccion, string etiqueta)
        {
            if (string.IsNullOrWhiteSpace(cboDepartamento.Text)
                || string.IsNullOrWhiteSpace(cboMunicipio.Text)
                || string.IsNullOrWhiteSpace(cboZona.Text)
                || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Complete el departamento, municipio, zona y direccion de " + etiqueta + " antes de guardar.");
                return false;
            }

            return true;
        }

        public void BuscarPedido(string textoBuscar, DataGridView dgvPedidos)
        {
            try
            {
                string consulta = @"SELECT
                        p.id_pedido,
                        p.codigo_pedido,
                        p.id_cliente,
                        p.id_estado_pedido,
                        p.id_ruta,
                        p.fecha_solicitud_pedido AS fecha_solicitud,
                        p.id_direccion_origen_pedido,
                        p.id_direccion_destino_pedido,
                        CONCAT(dO.direccion_detalle, ' - ', aO.zona_area_cubierta, ', ', aO.municipio_area_cubierta, ', ', aO.departamento_area_cubierta) AS direccion_origen,
                        CONCAT(dD.direccion_detalle, ' - ', aD.zona_area_cubierta, ', ', aD.municipio_area_cubierta, ', ', aD.departamento_area_cubierta) AS direccion_destino,
                        p.peso_total_pedido AS peso_total,
                        p.cantidad_paquetes_pedido AS cantidad_paquetes,
                        p.observaciones_pedido AS observaciones
                    FROM pedido p
                    LEFT JOIN direccion dO ON dO.id_direccion = p.id_direccion_origen_pedido
                    LEFT JOIN area_cubierta aO ON aO.id_area = dO.id_area
                    LEFT JOIN direccion dD ON dD.id_direccion = p.id_direccion_destino_pedido
                    LEFT JOIN area_cubierta aD ON aD.id_area = dD.id_area
                    WHERE p.codigo_pedido LIKE @buscar
                       OR dO.direccion_detalle LIKE @buscar
                       OR dD.direccion_detalle LIKE @buscar
                       OR aO.zona_area_cubierta LIKE @buscar
                       OR aD.zona_area_cubierta LIKE @buscar
                       OR CAST(p.id_pedido AS CHAR) LIKE @buscar
                    ORDER BY p.id_pedido;";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@buscar", "%" + textoBuscar + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgvPedidos.DataSource = tabla;

                ConfigurarEstiloTabla(dgvPedidos);

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el pedido.\n" + ex.Message);
            }
        }

        // Trae departamento, municipio, zona, detalle de una direccion ya guardada,
        private DataRow ObtenerDatosDireccion(int idDireccion)
        {
            string consulta = @"SELECT a.departamento_area_cubierta, a.municipio_area_cubierta, a.zona_area_cubierta, d.direccion_detalle
                FROM direccion d
                INNER JOIN area_cubierta a ON a.id_area = d.id_area
                WHERE d.id_direccion = @id_direccion
                LIMIT 1;";

            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, objetoConexion.establecerConexion());
            adapter.SelectCommand.Parameters.AddWithValue("@id_direccion", idDireccion);

            DataTable tabla = new DataTable();
            adapter.Fill(tabla);

            objetoConexion.cerrarConexion();

            return tabla.Rows.Count > 0 ? tabla.Rows[0] : null;
        }

        private void CargarDireccionEnCombos(int idDireccion, ComboBox cboDepartamento, ComboBox cboMunicipio, ComboBox cboZona, TextBox txtDireccion)
        {
            DataRow fila = ObtenerDatosDireccion(idDireccion);

            if (fila == null)
                return;

            string departamento = fila["departamento_area_cubierta"].ToString();
            string municipio = fila["municipio_area_cubierta"].ToString();
            string zona = fila["zona_area_cubierta"].ToString();

            cboDepartamento.Text = departamento;

            LlenarComboMunicipio(cboMunicipio, departamento);
            cboMunicipio.Text = municipio;

            LlenarComboZona(cboZona, departamento, municipio);
            cboZona.Text = zona;

            txtDireccion.Text = fila["direccion_detalle"].ToString();
        }

        public void SeleccionarPedido(
            DataGridView dgvPedidos,
            TextBox TxtCodigoPedido,
            ComboBox cboCliente,
            Label lblRuta,
            ComboBox cboEstadoPedido,
            DateTimePicker dateTimePedido,
            ComboBox comboBoxDepartamentoOrigen,
            ComboBox comboBoxMunicipioOrigen,
            ComboBox comboBoxZonaOrigen,
            TextBox TextBoxDireccionOrigen,
            ComboBox comboBoxDepartamentoDestino,
            ComboBox comboBoxMunicipioDestino,
            ComboBox comboBoxZonaDestino,
            TextBox TextBoxDireccionDestino,
            TextBox txtPesoTotal,
            TextBox TxtCantidadPaquetes,
            TextBox TxtObservaciones)
        {
            try
            {
                TxtCodigoPedido.Text = dgvPedidos.CurrentRow.Cells["codigo_pedido"].Value.ToString();

                cboCliente.SelectedValue = dgvPedidos.CurrentRow.Cells["id_cliente"].Value;
                cboEstadoPedido.SelectedValue = dgvPedidos.CurrentRow.Cells["id_estado_pedido"].Value;

                // La ruta se muestra como texto informativo (solo lectura).
                // No se puede editar desde aqui: eso vive en la pantalla
                // "Asignacion de Pedidos a Ruta".
                object valorRuta = dgvPedidos.CurrentRow.Cells["id_ruta"].Value;
                if (valorRuta == DBNull.Value || valorRuta == null)
                    lblRuta.Text = "Sin ruta asignada";
                else
                    lblRuta.Text = ObtenerDescripcionRuta(Convert.ToInt32(valorRuta));

                dateTimePedido.Value = Convert.ToDateTime(dgvPedidos.CurrentRow.Cells["fecha_solicitud"].Value);

                object idDireccionOrigenObj = dgvPedidos.CurrentRow.Cells["id_direccion_origen_pedido"].Value;
                if (idDireccionOrigenObj != null && idDireccionOrigenObj != DBNull.Value)
                {
                    CargarDireccionEnCombos(
                        Convert.ToInt32(idDireccionOrigenObj),
                        comboBoxDepartamentoOrigen, comboBoxMunicipioOrigen, comboBoxZonaOrigen, TextBoxDireccionOrigen);
                }

                object idDireccionDestinoObj = dgvPedidos.CurrentRow.Cells["id_direccion_destino_pedido"].Value;
                if (idDireccionDestinoObj != null && idDireccionDestinoObj != DBNull.Value)
                {
                    CargarDireccionEnCombos(
                        Convert.ToInt32(idDireccionDestinoObj),
                        comboBoxDepartamentoDestino, comboBoxMunicipioDestino, comboBoxZonaDestino, TextBoxDireccionDestino);
                }

                txtPesoTotal.Text = dgvPedidos.CurrentRow.Cells["peso_total"].Value.ToString();
                TxtCantidadPaquetes.Text = dgvPedidos.CurrentRow.Cells["cantidad_paquetes"].Value.ToString();
                TxtObservaciones.Text = dgvPedidos.CurrentRow.Cells["observaciones"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un registro.");
            }
        }

        public void LimpiarCampos(
            TextBox TxtCodigoPedido,
            ComboBox cboCliente,
            Label lblRuta,
            ComboBox cboEstadoPedido,
            DateTimePicker dateTimePedido,
            ComboBox comboBoxDepartamentoOrigen,
            ComboBox comboBoxMunicipioOrigen,
            ComboBox comboBoxZonaOrigen,
            TextBox TextBoxDireccionOrigen,
            ComboBox comboBoxDepartamentoDestino,
            ComboBox comboBoxMunicipioDestino,
            ComboBox comboBoxZonaDestino,
            TextBox TextBoxDireccionDestino,
            TextBox txtPesoTotal,
            TextBox TxtCantidadPaquetes,
            TextBox TxtObservaciones)
        {
            TxtCodigoPedido.Clear();
            cboCliente.SelectedIndex = -1;
            lblRuta.Text = "Sin ruta asignada";
            cboEstadoPedido.SelectedIndex = -1;

            dateTimePedido.Value = DateTime.Now;

            comboBoxDepartamentoOrigen.SelectedIndex = -1;
            comboBoxDepartamentoOrigen.Text = string.Empty;
            comboBoxMunicipioOrigen.Items.Clear();
            comboBoxMunicipioOrigen.Text = string.Empty;
            comboBoxZonaOrigen.Items.Clear();
            comboBoxZonaOrigen.Text = string.Empty;
            TextBoxDireccionOrigen.Clear();

            comboBoxDepartamentoDestino.SelectedIndex = -1;
            comboBoxDepartamentoDestino.Text = string.Empty;
            comboBoxMunicipioDestino.Items.Clear();
            comboBoxMunicipioDestino.Text = string.Empty;
            comboBoxZonaDestino.Items.Clear();
            comboBoxZonaDestino.Text = string.Empty;
            TextBoxDireccionDestino.Clear();

            txtPesoTotal.Clear();
            TxtCantidadPaquetes.Clear();
            TxtObservaciones.Clear();
        }
    }
}