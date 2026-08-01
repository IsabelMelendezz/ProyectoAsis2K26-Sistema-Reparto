using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace SistemaReparto.Clases
{
    internal class CUsuarios_cont
    {
        // CREATE
        public bool AnadirUsuario(CUsuarios u)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"INSERT INTO usuarios (id_empleado, usuario, correo, contrasena, fecha_creacion, estado) 
                                  VALUES (@idEmpleado, @usuario, @correo, @contrasena, @fechaCreacion, @estado)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idEmpleado", u.IdEmpleado);
                cmd.Parameters.AddWithValue("@usuario", u.NombreUsuario);
                cmd.Parameters.AddWithValue("@correo", u.Correo);
                cmd.Parameters.AddWithValue("@contrasena", u.Contrasena); 
                cmd.Parameters.AddWithValue("@fechaCreacion", u.FechaCreacion);
                cmd.Parameters.AddWithValue("@estado", u.Estado);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Ese nombre de usuario ya existe, o ese empleado ya tiene una cuenta.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cn.cerrarConexion();
            }
        }

        // READ (todos, con JOIN a empleados para mostrar el nombre real)
        public List<CUsuarios> ListarUsuarios()
        {
            List<CUsuarios> lista = new List<CUsuarios>();
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"SELECT u.id_usuario, u.id_empleado, u.usuario, u.correo, 
                                         u.ultimo_acceso, u.fecha_creacion, u.estado,
                                         CONCAT(e.nombres, ' ', e.apellidos) AS nombre_empleado
                                  FROM usuarios u
                                  left JOIN empleados e ON u.id_empleado = e.id_empleado";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new CUsuarios(
                        Convert.ToInt32(reader["id_usuario"]),
                        Convert.ToInt32(reader["id_empleado"]),
                        reader["usuario"].ToString(),
                        reader["correo"] == DBNull.Value ? "" : reader["correo"].ToString(),
                        reader["ultimo_acceso"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ultimo_acceso"]),
                        Convert.ToDateTime(reader["fecha_creacion"]),
                        reader["estado"].ToString(),
                        reader["nombre_empleado"].ToString()
                    ));
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

        // READ simplificado (solo id + nombre, para usar en Asignacion Roles a Usuarios)
        public List<CUsuarios> ListarUsuariosParaCombo()
        {
            List<CUsuarios> lista = new List<CUsuarios>();
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = "SELECT id_usuario, usuario FROM usuarios WHERE estado = 'Activo'";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new   CUsuarios
                    {
                        IdUsuario = Convert.ToInt32(reader["id_usuario"]),
                        NombreUsuario = reader["usuario"].ToString()
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

        // UPDATE
        public bool EditarUsuario(CUsuarios u)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = @"UPDATE usuarios 
                                  SET id_empleado=@idEmpleado, usuario=@usuario, correo=@correo, estado=@estado 
                                  WHERE id_usuario=@id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idEmpleado", u.IdEmpleado);
                cmd.Parameters.AddWithValue("@usuario", u.NombreUsuario);
                cmd.Parameters.AddWithValue("@correo", u.Correo);
                cmd.Parameters.AddWithValue("@estado", u.Estado);
                cmd.Parameters.AddWithValue("@id", u.IdUsuario);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cn.cerrarConexion();
            }
        }

        // Cambiar contraseña (aparte, por seguridad)
        public bool CambiarContrasena(int idUsuario, string nuevaContrasena)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = "UPDATE usuarios SET contrasena=@contrasena WHERE id_usuario=@id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@contrasena", nuevaContrasena); // Recomendado: hashear antes
                cmd.Parameters.AddWithValue("@id", idUsuario);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar contraseña: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cn.cerrarConexion();
            }
        }

        // DELETE
        public bool BorrarUsuario(int idUsuario)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = "DELETE FROM usuarios WHERE id_usuario=@id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", idUsuario);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("No se puede eliminar: este usuario tiene roles u otros registros asignados.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cn.cerrarConexion();
            }
        }
    }
}