using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReparto.Clases
{
    internal class CRelRolMod_cont
    {
        // ---------- Combos ----------

        public List<CModulo> ListarTodosLosModulos()
        {
            List<CModulo> lista = new List<CModulo>();
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = "SELECT id_modulo, nombre_modulos, estatus_modulo FROM modulos WHERE estatus_modulo = 'Activo'";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new CModulo(
                        Convert.ToInt32(reader["id_modulo"]),
                        reader["nombre_modulos"].ToString(),
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
                string query = @"SELECT m.id_modulo, m.nombre_modulos, m.estatus_modulo
                                  FROM modulos m
                                  WHERE m.estatus_modulo = 'Activo'
                                  AND m.id_modulo NOT IN (
                                      SELECT id_modulo FROM relrolmodulo WHERE id_rol = @idRol
                                  )";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idRol", idRol);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new CModulo(
                        Convert.ToInt32(reader["id_modulo"]),
                        reader["nombre_modulos"].ToString(),
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
        public List<CRelRolModulo> ListarModulosAsignados(int idRol)
        {
            List<CRelRolModulo> lista = new List<CRelRolModulo>();
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"SELECT rm.id_modulo, rm.id_rol, rm.der_insertar, rm.der_editar, rm.der_eliminar, rm.der_imprimir,
                                         m.nombre_modulos
                                  FROM relrolmodulo rm
                                  INNER JOIN modulos m ON rm.id_modulo = m.id_modulo
                                  WHERE rm.id_rol = @idRol";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idRol", idRol);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new CRelRolModulo
                    {
                        IdModulo = Convert.ToInt32(reader["id_modulo"]),
                        IdRol = Convert.ToInt32(reader["id_rol"]),
                        DerInsertar = reader["der_insertar"].ToString() == "S",
                        DerEditar = reader["der_editar"].ToString() == "S",
                        DerEliminar = reader["der_eliminar"].ToString() == "S",
                        DerImprimir = reader["der_imprimir"].ToString() == "S",
                        NombreModulo = reader["nombre_modulos"].ToString()
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
        public bool AsignarModulo(CRelRolModulo r)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"INSERT INTO relrolmodulo (id_modulo, id_rol, der_insertar, der_editar, der_eliminar, der_imprimir) 
                                  VALUES (@idModulo, @idRol, @insertar, @editar, @eliminar, @imprimir)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idModulo", r.IdModulo);
                cmd.Parameters.AddWithValue("@idRol", r.IdRol);
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
        public bool ActualizarPermisos(CRelRolModulo r)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"UPDATE relrolmodulo 
                                  SET der_insertar=@insertar, der_editar=@editar, der_eliminar=@eliminar, der_imprimir=@imprimir
                                  WHERE id_modulo=@idModulo AND id_rol=@idRol";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@insertar", r.DerInsertar ? "S" : "N");
                cmd.Parameters.AddWithValue("@editar", r.DerEditar ? "S" : "N");
                cmd.Parameters.AddWithValue("@eliminar", r.DerEliminar ? "S" : "N");
                cmd.Parameters.AddWithValue("@imprimir", r.DerImprimir ? "S" : "N");
                cmd.Parameters.AddWithValue("@idModulo", r.IdModulo);
                cmd.Parameters.AddWithValue("@idRol", r.IdRol);

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
        public bool EliminarAsignacion(int idModulo, int idRol)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = "DELETE FROM relrolmodulo WHERE id_modulo=@idModulo AND id_rol=@idRol";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idModulo", idModulo);
                cmd.Parameters.AddWithValue("@idRol", idRol);

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

