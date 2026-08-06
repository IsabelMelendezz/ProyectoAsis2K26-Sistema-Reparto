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
        public List<CRelRolModulo> ListarModulosAsignados(int idRol)
        {
            List<CRelRolModulo> lista = new List<CRelRolModulo>();
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"SELECT rm.id_modulo, rm.id_rol, rm.der_insertar_relrolmodulo, rm.der_editar_relrolmodulo, rm.der_eliminar_relrolmodulo, rm.der_imprimir_relrolmodulo,
                                         m.nombre_modulo
                                  FROM relacion_rol_modulo rm
                                  INNER JOIN modulo m ON rm.id_modulo = m.id_modulo
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
                        DerInsertar = reader["der_insertar_relrolmodulo"].ToString() == "S",
                        DerEditar = reader["der_editar_relrolmodulo"].ToString() == "S",
                        DerEliminar = reader["der_eliminar_relrolmodulo"].ToString() == "S",
                        DerImprimir = reader["der_imprimir_relrolmodulo"].ToString() == "S",
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
        public bool AsignarModulo(CRelRolModulo r)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"INSERT INTO relacion_rol_modulo (id_modulo, id_rol, der_insertar_relrolmodulo, der_editar_relrolmodulo, der_eliminar_relrolmodulo, der_imprimir_relrolmodulo) 
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
                string query = @"UPDATE relacion_rol_modulo 
                                  SET der_insertar_relrolmodulo=@insertar, der_editar_relrolmodulo=@editar, der_eliminar_relrolmodulo=@eliminar, der_imprimir_relrolmodulo=@imprimir
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
                string query = "DELETE FROM relacion_rol_modulo WHERE id_modulo=@idModulo AND id_rol=@idRol";
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
    internal class ModuloRolController
    {
        // Recibe el idModulo y la lista de roles que tiene el usuario logueado.
        // Si el usuario tiene varios roles, se combinan los permisos:
        // si CUALQUIER rol le da el permiso, el usuario lo tiene.
        public CPermisoModulo ObtenerPermisos(int idModulo, List<int> idsRolesUsuario)
        {
            CPermisoModulo permisos = new CPermisoModulo();

            if (idsRolesUsuario == null || idsRolesUsuario.Count == 0)
                return permisos; // todo en false por defecto

            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                var placeholders = new List<string>();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;

                for (int i = 0; i < idsRolesUsuario.Count; i++)
                {
                    string paramName = $"@rol{i}";
                    placeholders.Add(paramName);
                    cmd.Parameters.AddWithValue(paramName, idsRolesUsuario[i]);
                }

                string query = $@"SELECT 
                                    der_insertar_relrolmodulo,
                                    der_editar_relrolmodulo,
                                    der_eliminar_relrolmodulo,
                                    der_imprimir_relrolmodulo
                                  FROM relacion_rol_modulo
                                  WHERE id_modulo = @idModulo
                                  AND id_rol IN ({string.Join(",", placeholders)})";

                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@idModulo", idModulo);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    permisos.TieneAcceso = true; // encontró al menos una fila = tiene acceso al módulo

                    // Combina permisos: si CUALQUIER rol dice "S", el usuario puede
                    if (reader["der_insertar_relrolmodulo"].ToString() == "S")
                        permisos.PuedeInsertar = true;

                    if (reader["der_editar_relrolmodulo"].ToString() == "S")
                        permisos.PuedeEditar = true;

                    if (reader["der_eliminar_relrolmodulo"].ToString() == "S")
                        permisos.PuedeEliminar = true;

                    if (reader["der_imprimir_relrolmodulo"].ToString() == "S")
                        permisos.PuedeImprimir = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener permisos del módulo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.cerrarConexion();
            }

            return permisos;
        }
    }









    internal class ModuloUsuarioController
    {
        // Recibe el idModulo y el idUsuario del usuario logueado.
        // A diferencia de los roles, aquí no hay que combinar nada:
        // el usuario tiene o no tiene el permiso directamente.
        public CPermisoModulo ObtenerPermisos(int idModulo, int idUsuario)
        {
            CPermisoModulo permisos = new CPermisoModulo();

            if (idUsuario <= 0)
                return permisos; // todo en false por defecto

            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"SELECT 
                                der_insertar_relusumodulo,
                                der_editar_relusumodulo,
                                der_eliminar_relusumodulo,
                                der_imprimir_relusumodulo
                              FROM relacion_usuario_modulo
                              WHERE id_modulo = @idModulo
                              AND id_usuario = @idUsuario";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idModulo", idModulo);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    permisos.TieneAcceso = true; // encontró la fila = tiene acceso al módulo

                    if (reader["der_insertar_relusumodulo"].ToString() == "S")
                        permisos.PuedeInsertar = true;

                    if (reader["der_editar_relusumodulo"].ToString() == "S")
                        permisos.PuedeEditar = true;

                    if (reader["der_eliminar_relusumodulo"].ToString() == "S")
                        permisos.PuedeEliminar = true;

                    if (reader["der_imprimir_relusumodulo"].ToString() == "S")
                        permisos.PuedeImprimir = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener permisos del módulo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.cerrarConexion();
            }

            return permisos;
        }
    }
}


