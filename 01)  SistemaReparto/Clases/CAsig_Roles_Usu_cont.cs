using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaReparto.Clases
{
    internal class UsuarioRolController
    {
        // ---------- Para llenar los ComboBox ----------

        // Trae todos los usuarios activos (muestra nombre de usuario, guarda id)
        public List<CUsuarios> ListarUsuariosParaCombo()
        {
            List<CUsuarios> lista = new List<CUsuarios>();
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = "SELECT id_usuario, usuario_usuario FROM usuario WHERE estado_usuario = 'Activo'";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new CUsuarios
                    {
                        IdUsuario = Convert.ToInt32(reader["id_usuario"]),
                        NombreUsuario = reader["usuario_usuario"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.cerrarConexion();
            }
            return lista;
        }

        // Trae todos los roles activos (muestra nombre, guarda id)
        public List<CRol> ListarRolesParaCombo()
        {
            List<CRol> lista = new List<CRol>();
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = "SELECT id_rol, nombre_rol FROM rol WHERE estado_rol = 'Activo'";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new CRol
                    {
                        IdRol = Convert.ToInt32(reader["id_rol"]),
                        Nombre = reader["nombre_rol"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.cerrarConexion();
            }
            return lista;
        }
        //LISTA ROLES DISPONIBLES PARA UN USUARIO (para el combo de edición)
        public List<CRol> ListarRolessDisponibles(int idRol)
        {
            List<CRol> lista = new List<CRol>();
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"SELECT m.id_rol, m.nombre_rol, m.estado_rol
                                  FROM rol m
                                  WHERE m.estado_rol = 'Activo'
                                  AND m.id_rol NOT IN (
                                      SELECT id_rol FROM usuario_rol WHERE id_rol = @idRol
                                  )";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idRol", idRol);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new CRol(
                        Convert.ToInt32(reader["id_rol"]),
                        reader["nombre_rol"].ToString(),
                        null, // Descripcion no está en el SELECT, así que se pasa null
                        reader["estado_rol"].ToString()
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

        // ---------- CRUD de usuario_rol ----------

        // CREATE
        public bool AsignarRol(CAsig_Roles_Usu ur)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = "INSERT INTO usuario_rol (id_usuario, id_rol, fecha_asignacion_usuario_rol) VALUES (@idUsuario, @idRol, @fecha)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idUsuario", ur.IdUsuario);
                cmd.Parameters.AddWithValue("@idRol", ur.IdRol);
                cmd.Parameters.AddWithValue("@fecha", ur.FechaAsignacion);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (MySqlException ex) when (ex.Number == 1062) // llave duplicada
            {
                MessageBox.Show("Este usuario ya tiene asignado ese rol.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cn.cerrarConexion();
            }
        }

        // READ (todos, con JOIN para mostrar nombres en la grid)
        public List<CAsig_Roles_Usu> ListarAsignaciones()
        {
            List<CAsig_Roles_Usu> lista = new List<CAsig_Roles_Usu>();
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"SELECT ur.id_usuario, ur.id_rol, ur.fecha_asignacion_usuario_rol,
                                         u.usuario_usuario AS nombre_usuario, r.nombre_rol AS nombre_rol
                                  FROM usuario_rol ur
                                  INNER JOIN usuario u ON ur.id_usuario = u.id_usuario
                                  INNER JOIN rol r ON ur.id_rol = r.id_rol";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new CAsig_Roles_Usu(
                        Convert.ToInt32(reader["id_usuario"]),
                        Convert.ToInt32(reader["id_rol"]),
                        Convert.ToDateTime(reader["fecha_asignacion_usuario_rol"]),
                        reader["nombre_usuario"].ToString(),
                        reader["nombre_rol"].ToString()
                    ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar asignaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.cerrarConexion();
            }
            return lista;
        }

        // UPDATE (llave compuesta: se identifica la fila original por su id_usuario/id_rol previos)
        public bool EditarAsignacion(int idUsuarioOriginal, int idRolOriginal, CAsig_Roles_Usu nuevo)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"UPDATE usuario_rol 
                                  SET id_usuario=@nuevoUsuario, id_rol=@nuevoRol, fecha_asignacion_usuario_rol=@fecha 
                                  WHERE id_usuario=@viejoUsuario AND id_rol=@viejoRol";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nuevoUsuario", nuevo.IdUsuario);
                cmd.Parameters.AddWithValue("@nuevoRol", nuevo.IdRol);
                cmd.Parameters.AddWithValue("@fecha", nuevo.FechaAsignacion);
                cmd.Parameters.AddWithValue("@viejoUsuario", idUsuarioOriginal);
                cmd.Parameters.AddWithValue("@viejoRol", idRolOriginal);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Ya existe una asignación con ese usuario y rol.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar asignación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cn.cerrarConexion();
            }
        }

        // DELETE (por llave compuesta)
        public bool EliminarAsignacion(int idUsuario, int idRol)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = "DELETE FROM usuario_rol WHERE id_usuario=@idUsuario AND id_rol=@idRol";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
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