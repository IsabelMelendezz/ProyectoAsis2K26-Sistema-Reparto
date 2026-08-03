using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReparto.Clases
{
    internal class CRelUsuMod_cont
    {
        // ---------- Combos ----------

        public List<CModulo> ListarTodosLosModulos()
        {
            List<CModulo> lista = new List<CModulo>();
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = "SELECT id_modulo, nombre_modulo, estatus_modulo FROM modulo WHERE estatus_modulo = 'Activo'";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new CModulo(
                        Convert.ToInt32(reader["id_modulo"]),
                        reader["nombre_modulo"].ToString(),
                        reader["estatus_modulo"].ToString()
                    ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar módulos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.cerrarConexion();
            }
            return lista;
        }

        // Módulos que el rol AÚN NO tiene asignados (para el combo "Modulos Disponibles")
        public List<CModulo> ListarModulosDisponibles(int idRol)
        {
            List<CModulo> lista = new List<CModulo>();
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"SELECT m.id_modulo, m.nombre_modulo, m.estatus_modulo
                                  FROM modulo m
                                  WHERE m.estatus_modulo = 'Activo'
                                  AND m.id_modulo NOT IN (
                                      SELECT id_modulo FROM relacion_rol_modulo WHERE id_rol = @idRol
                                  )";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idRol", idRol);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new CModulo(
                        Convert.ToInt32(reader["id_modulo"]),
                        reader["nombre_modulo"].ToString(),
                        reader["estatus_modulo"].ToString()
                    ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar módulos disponibles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.cerrarConexion();
            }
            return lista;
        }

        // Módulos YA asignados a ese rol, con sus permisos (para el ListBox "Modulos Asignados")
        public List<CRelUsuModulo> ListarModulosAsignados(int IdUsuario)
        {
            List<CRelUsuModulo> lista = new List<CRelUsuModulo>();
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"SELECT rm.id_modulo, rm.id_usuario, rm.der_insertar_relusumodulo, rm.der_editar_relusumodulo, rm.der_eliminar_relusumodulo, rm.der_imprimir_relusumodulo,
                                         m.nombre_modulo
                                  FROM relacion_usuario_modulo rm
                                  INNER JOIN modulo m ON rm.id_modulo = m.id_modulo
                                  WHERE rm.id_usuario = @idUsuario";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idUsuario", IdUsuario);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new CRelUsuModulo
                    {
                        IdModulo = Convert.ToInt32(reader["id_modulo"]),
                        IdUsuario = Convert.ToInt32(reader["id_usuario"]),
                        DerInsertar = reader["der_insertar_relusumodulo"].ToString() == "S",
                        DerEditar = reader["der_editar_relusumodulo"].ToString() == "S",
                        DerEliminar = reader["der_eliminar_relusumodulo"].ToString() == "S",
                        DerImprimir = reader["der_imprimir_relusumodulo"].ToString() == "S",
                        NombreModulo = reader["nombre_modulo"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar módulos asignados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.cerrarConexion();
            }
            return lista;
        }

        // ---------- CRUD ----------

        // CREATE
        public bool AsignarModulo(CRelUsuModulo r)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"INSERT INTO relacion_usuario_modulo (id_modulo, id_usuario, der_insertar_relusumodulo, der_editar_relusumodulo, der_eliminar_relusumodulo, der_imprimir_relusumodulo) 
                                  VALUES (@idModulo, @idUsuario, @insertar, @editar, @eliminar, @imprimir)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idModulo", r.IdModulo);
                cmd.Parameters.AddWithValue("@idUsuario", r.IdUsuario);
                cmd.Parameters.AddWithValue("@insertar", r.DerInsertar ? "S" : "N");
                cmd.Parameters.AddWithValue("@editar", r.DerEditar ? "S" : "N");
                cmd.Parameters.AddWithValue("@eliminar", r.DerEliminar ? "S" : "N");
                cmd.Parameters.AddWithValue("@imprimir", r.DerImprimir ? "S" : "N");

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Este módulo ya está asignado a ese rol.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar módulo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cn.cerrarConexion();
            }
        }

        // UPDATE (permisos de un módulo ya asignado a un rol)
        public bool ActualizarPermisos(CRelUsuModulo r)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"UPDATE relacion_usuario_modulo 
                                  SET der_insertar_relusumodulo=@insertar, der_editar_relusumodulo=@editar, der_eliminar_relusumodulo=@eliminar, der_imprimir_relusumodulo=@imprimir
                                  WHERE id_modulo=@idModulo AND id_usuario=@idUsuario";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@insertar", r.DerInsertar ? "S" : "N");
                cmd.Parameters.AddWithValue("@editar", r.DerEditar ? "S" : "N");
                cmd.Parameters.AddWithValue("@eliminar", r.DerEliminar ? "S" : "N");
                cmd.Parameters.AddWithValue("@imprimir", r.DerImprimir ? "S" : "N");
                cmd.Parameters.AddWithValue("@idModulo", r.IdModulo);
                cmd.Parameters.AddWithValue("@idUsuario", r.IdUsuario);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar permisos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cn.cerrarConexion();
            }
        }

        // DELETE
        public bool EliminarAsignacion(int idModulo, int idUsuario)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = "DELETE FROM relacion_usuario_modulo WHERE id_modulo=@idModulo AND id_usuario=@idUsuario";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idModulo", idModulo);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar asignación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cn.cerrarConexion();
            }
        }
    }
}
