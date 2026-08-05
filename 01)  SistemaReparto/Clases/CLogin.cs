using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReparto.Clases
{
    internal class CLogin
    {
        public bool ValidarLogin(string usuarioIngresado, string contrasenaIngresada)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                // 1. Buscar el usuario por su nombre de usuario
                string query = @"SELECT u.id_usuario, u.usuario_usuario, u.contrasena_usuario, u.estado_usuario, u.id_empleado,
                                         CONCAT(e.nombre_empleado, ' ', e.apellido_empleado) AS nombre_empleado
                                  FROM usuario u
                                  LEFT JOIN empleado e ON u.id_empleado = e.id_empleado
                                  WHERE u.usuario_usuario = @usuario";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@usuario", usuarioIngresado);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Usuario no encontrado", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reader.Close();
                    return false;
                }
                //SOLO USUARIOS CON ESTADO ACTIVO PUEDEN INGRESAR
                string estado = reader["estado_usuario"].ToString();
                if (estado != "Activo")
                {
                    MessageBox.Show("Este usuario está inactivo. Contacta al administrador.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reader.Close();
                    return false;
                }

                string hashGuardado = reader["contrasena_usuario"].ToString();

                // 2. Verificar contraseña (compatible con texto plano viejo y bcrypt nuevo)
                bool contrasenaCorrecta;
                if (hashGuardado.StartsWith("$2a$") || hashGuardado.StartsWith("$2b$") || hashGuardado.StartsWith("$2y$"))
                {
                    contrasenaCorrecta = BCrypt.Net.BCrypt.Verify(contrasenaIngresada, hashGuardado);
                }
                else
                {
                    contrasenaCorrecta = (contrasenaIngresada == hashGuardado);
                }

                if (!contrasenaCorrecta)
                {
                    MessageBox.Show("Contraseña incorrecta", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reader.Close();
                    return false;
                }

                // 3. Guardar datos básicos en la Sesión
                int idUsuario = Convert.ToInt32(reader["id_usuario"]);
                Sesion.IdUsuario = idUsuario;
                Sesion.NombreUsuario = reader["usuario_usuario"].ToString();
                Sesion.NombreEmpleado = reader["nombre_empleado"] == DBNull.Value ? "" : reader["nombre_empleado"].ToString();

                reader.Close();

                // 4. Actualizar último acceso
                string queryUpdate = "UPDATE usuario SET ultimo_acceso_usuario = @fecha WHERE id_usuario = @id";
                MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, conexion);
                cmdUpdate.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmdUpdate.Parameters.AddWithValue("@id", idUsuario);
                cmdUpdate.ExecuteNonQuery();

                // 5. Traer TODOS los roles del usuario 
                Sesion.Roles.Clear();

                string queryRoles = @"SELECT r.id_rol, r.nombre_rol
                                       FROM usuario_rol ur
                                       INNER JOIN rol r ON ur.id_rol = r.id_rol
                                       WHERE ur.id_usuario = @idUsuario";
                MySqlCommand cmdRoles = new MySqlCommand(queryRoles, conexion);
                cmdRoles.Parameters.AddWithValue("@idUsuario", idUsuario);
                MySqlDataReader readerRoles = cmdRoles.ExecuteReader();

                while (readerRoles.Read())
                {
                    Sesion.Roles.Add(new RolInfo
                    {
                        IdRol = Convert.ToInt32(readerRoles["id_rol"]),
                        NombreRol = readerRoles["nombre_rol"].ToString()
                    });
                }
                readerRoles.Close();

                if (Sesion.Roles.Count == 0)
                {
                    MessageBox.Show("Este usuario no tiene ningún rol asignado. Contacta al administrador.",
                        "Acceso limitado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cn.cerrarConexion();
            }
        }
    }
}
