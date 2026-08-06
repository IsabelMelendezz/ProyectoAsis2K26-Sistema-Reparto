using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using BCrypt.Net;

namespace SistemaReparto.Clases
{
    internal class CRecuperarPassword
    {
        CConexion objetoConexion = new CConexion();
        CCorreo objetoCorreo = new CCorreo();
        CToken objetoToken = new CToken();

        public bool ExisteUsuario(string usuario)
        {
            try
            {
                string consulta = @"SELECT COUNT(*)
                            FROM usuario
                            WHERE usuario_usuario = @usuario;";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@usuario", usuario);

                int cantidad = Convert.ToInt32(comando.ExecuteScalar());

                objetoConexion.cerrarConexion();

                return cantidad > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el usuario.\n" + ex.Message);
                return false;
            }
        }

        public string GuardarTokenUsuario(string usuario)
        {
            try
            {
                // Generar el token
                string token = objetoToken.GenerarToken();

                // Fecha de expiración (10 minutos)
                DateTime fechaExpiracion = DateTime.Now.AddMinutes(10);

                string consulta = @"UPDATE usuario
                            SET token_recuperacion_usuario = @token,
                                fecha_expiracion_token_usuario = @fecha
                            WHERE usuario_usuario = @usuario;";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@token", token);
                comando.Parameters.AddWithValue("@fecha", fechaExpiracion);
                comando.Parameters.AddWithValue("@usuario", usuario);

                comando.ExecuteNonQuery();

                objetoConexion.cerrarConexion();

                return token;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el token.\n" + ex.Message);
                return "";
            }
        }

        public bool EnviarCodigo(string usuario, string correoDestino)
        {
            try
            {
                // Verificar que el usuario exista
                if (!ExisteUsuario(usuario))
                {
                    MessageBox.Show("El usuario no existe.");
                    return false;
                }

                // Generar y guardar el token
                string token = GuardarTokenUsuario(usuario);

                if (string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("No fue posible generar el código de recuperación.");
                    return false;
                }

                // Asunto del correo
                string asunto = "Nortek Solutions | Recuperación de contraseña";

                // Mensaje del correo
                string mensaje =
                    "Hola " + usuario + ".\n\n" +
                    "Hemos recibido una solicitud para recuperar la contraseña de su cuenta.\n\n" +
                    "Su código de recuperación es:\n\n" +
                    token +
                    "\n\nEste código es válido por 10 minutos.\n\n" +
                    "Si usted no solicitó este cambio, puede ignorar este mensaje.\n\n" +
                    "Atentamente,\n\n" +
                    "Equipo Nortek Solutions";

                // Enviar el correo
                bool enviado = objetoCorreo.EnviarCorreo(correoDestino, asunto, mensaje);

                if (!enviado)
                {
                    MessageBox.Show("No fue posible enviar el correo.");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el código.\n" + ex.Message);
                return false;
            }
        }

        public bool ValidarTokenUsuario(string usuario, string token)
        {
            try
            {
                string consulta = @"SELECT COUNT(*)
                    FROM usuario
                    WHERE usuario_usuario = @usuario
                    AND token_recuperacion_usuario = @token
                    AND fecha_expiracion_token_usuario >= NOW();";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@token", token);

                int cantidad = Convert.ToInt32(comando.ExecuteScalar());

                objetoConexion.cerrarConexion();

                return cantidad > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el token.\n" + ex.Message);
                return false;
            }
        }

        public void ActualizarContrasena(string usuario, string nuevaContrasena)
        {
            try
            {
                string consulta = @"UPDATE usuario
                            SET contrasena_usuario = @contrasena
                            WHERE usuario_usuario = @usuario;";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                // Generar el hash de la nueva contraseña
                string hash = BCrypt.Net.BCrypt.HashPassword(nuevaContrasena);

                comando.Parameters.AddWithValue("@contrasena", hash);
                comando.Parameters.AddWithValue("@usuario", usuario);

                comando.ExecuteNonQuery();

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la contraseña.\n" + ex.Message);
            }
        }

        public void LimpiarTokenUsuario(string usuario)
        {
            try
            {
                string consulta = @"UPDATE usuario
                            SET token_recuperacion_usuario = NULL,
                                fecha_expiracion_token_usuario = NULL
                            WHERE usuario_usuario = @usuario;";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@usuario", usuario);

                comando.ExecuteNonQuery();

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar el token.\n" + ex.Message);
            }
        }
    }
}