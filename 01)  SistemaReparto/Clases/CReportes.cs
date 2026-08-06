
//Carlos David Calderón Ramirez
//9959-23-848


using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScottPlot;
using ScottPlot.WinForms;
using ScottPlot.Plottables;

namespace SistemaReparto.Clases
{
    internal class CReportes
    {

        public void ReportePedidos(DataGridView dgv, DateTime Dt_Desde_Reporte, DateTime Dt_Hasta_Reporte)
        {
            try
            {
                if (Dt_Desde_Reporte.Date > Dt_Hasta_Reporte.Date)
                {
                    MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final.",
                                    "Rango de fechas",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                CConexion objetoConexion = new CConexion();

                string query = @"SELECT
                        p.id_pedido       AS Id_Pedido,
                        p.codigo_pedido        AS Codigo,
                        CONCAT(c.nombres_cliente, ' ', c.apellidos_cliente) AS Cliente,
                        ep.nombre_estado_pedido AS Estado,
                        p.fecha_solicitud_pedido AS Fecha_Solicitud,
                        p.id_direccion_origen_pedido  AS Origen,
                        p.id_direccion_destino_pedido AS Destino,
                        p.peso_total_pedido        AS Peso_Total,
                        p.cantidad_paquetes_pedido AS Cantidad_Paquetes
                    FROM pedido p
                    INNER JOIN cliente c ON p.id_cliente = c.id_cliente
                    INNER JOIN estado_pedido ep ON p.id_estado_pedido = ep.id_estado_pedido
                    WHERE p.fecha_solicitud_pedido BETWEEN @desde AND @hasta
                    ORDER BY p.fecha_solicitud_pedido DESC";

                MySqlCommand cmd = new MySqlCommand(query, objetoConexion.establecerConexion());
                cmd.Parameters.AddWithValue("@desde", Dt_Desde_Reporte.Date);
                cmd.Parameters.AddWithValue("@hasta", Dt_Hasta_Reporte.Date);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgv.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se generó el reporte de pedidos, error: " + ex.ToString());
            }
        }

  
        public void ReporteRutas(DataGridView dgv, DateTime Dt_Desde_Reporte, DateTime Dt_Hasta_Reporte)
        {
            try
            {
                if (Dt_Desde_Reporte.Date > Dt_Hasta_Reporte.Date)
                {
                    MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final.",
                                    "Rango de fechas",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                CConexion objetoConexion = new CConexion();

                string query = @"SELECT
                        r.id_ruta     AS Id_Ruta,
                        b.nombre_bodega          AS Bodega,
                        tr.nombre_tipo_ruta      AS Tipo_Ruta,
                        er.nombre_estado_ruta    AS Estado,
                        r.fecha_ruta             AS Fecha,
                        r.hora_inicio_ruta       AS Hora_Inicio,
                        r.hora_fin_ruta          AS Hora_Fin,
                        r.distancia_km_ruta      AS Distancia_Km
                    FROM ruta r
                    INNER JOIN bodega b ON r.id_bodega = b.id_bodega
                    INNER JOIN tipo_ruta tr ON r.id_tipo_ruta = tr.id_tipo_ruta
                    INNER JOIN estado_ruta er ON r.id_estado_ruta = er.id_estado_ruta
                    WHERE r.fecha_ruta BETWEEN @desde AND @hasta
                    ORDER BY r.fecha_ruta DESC";

                MySqlCommand cmd = new MySqlCommand(query, objetoConexion.establecerConexion());
                cmd.Parameters.AddWithValue("@desde", Dt_Desde_Reporte.Date);
                cmd.Parameters.AddWithValue("@hasta", Dt_Hasta_Reporte.Date);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgv.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se generó el reporte de rutas, error: " + ex.ToString());
            }
        }

        public void ReporteEmpleados(DataGridView dgv, DateTime Dt_Desde_Reporte, DateTime Dt_Hasta_Reporte)
        {
            try
            {
                if (Dt_Desde_Reporte.Date > Dt_Hasta_Reporte.Date)
                {
                    MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final.",
                                    "Rango de fechas",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                CConexion objetoConexion = new CConexion();

                string query = @"SELECT
                    e.id_empleado   AS Id_Empleado,
                    CONCAT(e.nombre_empleado, ' ', e.apellido_empleado) AS Nombre_Completo,
                    te.nombre_tipo_empleado       AS Tipo,
                    ee.nombre_estado_empleado     AS Estado,
                    e.telefono_empleado           AS Telefono,
                    e.fecha_contratacion_empleado AS Fecha_Contratacion
                    FROM empleado e
                    INNER JOIN tipo_empleado te ON e.id_tipo_empleado = te.id_tipo_empleado
                    INNER JOIN estado_empleado ee ON e.id_estado_empleado = ee.id_estado_empleado
                    WHERE e.fecha_contratacion_empleado BETWEEN @desde AND @hasta
                    ORDER BY e.fecha_contratacion_empleado DESC";

                MySqlCommand cmd = new MySqlCommand(query, objetoConexion.establecerConexion());
                cmd.Parameters.AddWithValue("@desde", Dt_Desde_Reporte.Date);
                cmd.Parameters.AddWithValue("@hasta", Dt_Hasta_Reporte.Date);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgv.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se generó el reporte de empleados, error: " + ex.ToString());
            }
        }


        public void ReporteVehiculos(DataGridView dgv, DateTime Dt_Desde_Reporte, DateTime Dt_Hasta_Reporte)
        {
            try
            {
                if (Dt_Desde_Reporte.Date > Dt_Hasta_Reporte.Date)
                {
                    MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final.",
                                    "Rango de fechas",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                CConexion objetoConexion = new CConexion();

                string query = @"SELECT
                v.id_vehiculo       AS Id_Vehiculo,
                v.placa_vehiculo      AS Placa,
                v.marca_vehiculo      AS Marca,
                v.modelo_vehiculo      AS Modelo,
                v.anio_vehiculo         AS Año,
                v.capacidad_peso_vehiculo   AS Capacidad_Peso,
                tv.nombre_tipo_vehiculo     AS Tipo,
                ev.nombre_estado_vehiculo   AS Estado
                FROM vehiculo v
                INNER JOIN tipo_vehiculo tv ON v.id_tipo_vehiculo = tv.id_tipo_vehiculo
                INNER JOIN estado_vehiculo ev ON v.id_estado_vehiculo = ev.id_estado_vehiculo
                ORDER BY v.placa_vehiculo";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgv.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se generó el reporte de empleados, error: " + ex.ToString());
            }
        }


        public void GraficaPedido(FormsPlot formsPlot1, DateTime Dt_Desde_Reporte, DateTime Dt_Hasta_Reporte)
        {
            try
            {
                if (Dt_Desde_Reporte.Date > Dt_Hasta_Reporte.Date)
                {
                    MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final.",
                                    "Rango de fechas",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                CConexion objetoConexion = new CConexion();

                string query = @"SELECT
                    DATE(fecha_solicitud_pedido) AS Fecha,
                    COUNT(*) AS Total
                    FROM pedido
                    WHERE fecha_solicitud_pedido BETWEEN @desde AND @hasta
                    GROUP BY DATE(fecha_solicitud_pedido)
                    ORDER BY Fecha;";

                MySqlCommand cmd = new MySqlCommand(query, objetoConexion.establecerConexion());

                cmd.Parameters.AddWithValue("@desde", Dt_Desde_Reporte.Date);
                cmd.Parameters.AddWithValue("@hasta", Dt_Hasta_Reporte.Date);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No existen pedidos registrados en el rango de fechas seleccionado.");

                    formsPlot1.Plot.Clear();
                    formsPlot1.Refresh();

                    objetoConexion.cerrarConexion();
                    return;
                }

                List<PieSlice> slices = new();

                foreach (DataRow fila in dt.Rows)
                {
                    slices.Add(new PieSlice()
                    {
                        Value = Convert.ToDouble(fila["Total"]),
                        Label = Convert.ToDateTime(fila["Fecha"]).ToString("dd/MM")
                    });
                }

                formsPlot1.Plot.Clear();

                // Crear gráfica pastel
                var pie = formsPlot1.Plot.Add.Pie(slices);


                // Colores personalizados
                ScottPlot.Color[] colores =
                {
                    ScottPlot.Color.FromHex("#3498DB"), // Azul
                    ScottPlot.Color.FromHex("#2ECC71"), // Verde
                    ScottPlot.Color.FromHex("#F1C40F"), // Amarillo
                    ScottPlot.Color.FromHex("#E74C3C"), // Rojo
                    ScottPlot.Color.FromHex("#9B59B6"), // Morado
                    ScottPlot.Color.FromHex("#1ABC9C"), // Turquesa
                    ScottPlot.Color.FromHex("#E67E22")  // Naranja
                };


                // Aplicar colores
                for (int i = 0; i < pie.Slices.Count; i++)
                {
                    pie.Slices[i].FillColor = colores[i % colores.Length];
                }
                
                formsPlot1.Plot.Title("Pedidos realizados por fecha", size: 24);

                // Convertir a dona (opcional)
                pie.DonutFraction = 0.45;


                formsPlot1.Refresh();

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void GraficaRuta(FormsPlot formsPlot1, DateTime Dt_Desde_Reporte, DateTime Dt_Hasta_Reporte)
        {
            try
            {
                if (Dt_Desde_Reporte.Date > Dt_Hasta_Reporte.Date)
                {
                    MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final.",
                                    "Rango de fechas",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                CConexion objetoConexion = new CConexion();
                string query = @"SELECT
                                DATE(fecha_ruta) AS Fecha,
                                COUNT(*) AS Total
                                FROM ruta
                                WHERE fecha_ruta BETWEEN @desde AND @hasta
                                GROUP BY DATE(fecha_ruta)
                                ORDER BY Fecha;";


                MySqlCommand cmd = new MySqlCommand(query, objetoConexion.establecerConexion());
                cmd.Parameters.AddWithValue("@desde", Dt_Desde_Reporte.Date);
                cmd.Parameters.AddWithValue("@hasta", Dt_Hasta_Reporte.Date);
                
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                
                adapter.Fill(dt);
                
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No existen rutas registradas en el rango de fechas seleccionado.");
                    formsPlot1.Plot.Clear();
                    formsPlot1.Refresh();
                    objetoConexion.cerrarConexion();
                    return;
                }
                List<PieSlice> slices = new();
                foreach (DataRow fila in dt.Rows)
                {
                    slices.Add(new PieSlice()
                    {
                        Value = Convert.ToDouble(fila["Total"]),
                        Label = Convert.ToDateTime(fila["Fecha"]).ToString("dd/MM")
                    });
                }
                formsPlot1.Plot.Clear();
                var pie = formsPlot1.Plot.Add.Pie(slices);
                ScottPlot.Color[] colores =
                {
            ScottPlot.Color.FromHex("#3498DB"),
            ScottPlot.Color.FromHex("#2ECC71"),
            ScottPlot.Color.FromHex("#F1C40F"),
            ScottPlot.Color.FromHex("#E74C3C"),
            ScottPlot.Color.FromHex("#9B59B6"),
            ScottPlot.Color.FromHex("#1ABC9C"),
            ScottPlot.Color.FromHex("#E67E22")
        };
                for (int i = 0; i < pie.Slices.Count; i++)
                {
                    pie.Slices[i].FillColor = colores[i % colores.Length];
                }

                formsPlot1.Plot.Title("Rutas realizadas por fecha", size: 24);
                formsPlot1.Refresh();
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void GraficaEmpleado(FormsPlot formsPlot1, DateTime Dt_Desde_Reporte, DateTime Dt_Hasta_Reporte)
        {
            try
            {
                if (Dt_Desde_Reporte.Date > Dt_Hasta_Reporte.Date)
                {
                    MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final.",
                                    "Rango de fechas",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                CConexion objetoConexion = new CConexion();
                string query = @"SELECT
            DATE(fecha_contratacion_empleado) AS Fecha,
            COUNT(*) AS Total
            FROM empleado
            WHERE fecha_contratacion_empleado BETWEEN @desde AND @hasta
            GROUP BY DATE(fecha_contratacion_empleado)
            ORDER BY Fecha;";
                MySqlCommand cmd = new MySqlCommand(query, objetoConexion.establecerConexion());
                cmd.Parameters.AddWithValue("@desde", Dt_Desde_Reporte.Date);
                cmd.Parameters.AddWithValue("@hasta", Dt_Hasta_Reporte.Date);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No existen empleados contratados en el rango de fechas seleccionado.");
                    formsPlot1.Plot.Clear();
                    formsPlot1.Refresh();
                    objetoConexion.cerrarConexion();
                    return;
                }
                List<PieSlice> slices = new();
                foreach (DataRow fila in dt.Rows)
                {
                    slices.Add(new PieSlice()
                    {
                        Value = Convert.ToDouble(fila["Total"]),
                        Label = Convert.ToDateTime(fila["Fecha"]).ToString("dd/MM")
                    });
                }
                formsPlot1.Plot.Clear();
                var pie = formsPlot1.Plot.Add.Pie(slices);
                ScottPlot.Color[] colores =
                {
            ScottPlot.Color.FromHex("#3498DB"),
            ScottPlot.Color.FromHex("#2ECC71"),
            ScottPlot.Color.FromHex("#F1C40F"),
            ScottPlot.Color.FromHex("#E74C3C"),
            ScottPlot.Color.FromHex("#9B59B6"),
            ScottPlot.Color.FromHex("#1ABC9C"),
            ScottPlot.Color.FromHex("#E67E22")
        };
                for (int i = 0; i < pie.Slices.Count; i++)
                {
                    pie.Slices[i].FillColor = colores[i % colores.Length];
                }

                formsPlot1.Plot.Title("Empleados contratados por fecha", size: 24);
                formsPlot1.Refresh();
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void GraficaVehiculo(FormsPlot formsPlot1, DateTime Dt_Desde_Reporte, DateTime Dt_Hasta_Reporte)
        {
            try
            {
                if (Dt_Desde_Reporte.Date > Dt_Hasta_Reporte.Date)
                {
                    MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final.",
                                    "Rango de fechas",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                CConexion objetoConexion = new CConexion();
                // La tabla vehiculo no tiene columna de fecha, se agrupa por Tipo de Vehículo
                string query = @"SELECT
                    tv.nombre_tipo_vehiculo AS Tipo,
                    COUNT(*) AS Total
                 FROM vehiculo v
                 INNER JOIN tipo_vehiculo tv ON v.id_tipo_vehiculo = tv.id_tipo_vehiculo
                 GROUP BY tv.nombre_tipo_vehiculo
                 ORDER BY Total DESC;";
                
                MySqlCommand cmd = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                
                
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No existen vehículos registrados.",
                                    "Sin resultados",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    formsPlot1.Plot.Clear();
                    formsPlot1.Refresh();
                    objetoConexion.cerrarConexion();
                    return;
                }
                
                List<double> valores = new();
                List<string> tipos = new();
                
                foreach (DataRow fila in dt.Rows)
                {
                    valores.Add(Convert.ToDouble(fila["Total"]));
                    tipos.Add(fila["Tipo"].ToString());
                }
                
                formsPlot1.Plot.Clear();
                
                formsPlot1.Plot.Add.Bars(valores.ToArray());
                
                formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(Enumerable.Range(0, tipos.Count).Select(x => (double)x).ToArray(),tipos.ToArray());
               
                formsPlot1.Plot.Title("Distribución de vehículos por tipo", size: 24);
                
                formsPlot1.Plot.Axes.AutoScale();
                formsPlot1.Refresh();
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se generó la gráfica.\n\nError: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }





    }



}

