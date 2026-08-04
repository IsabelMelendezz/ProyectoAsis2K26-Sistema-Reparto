using MySql.Data.MySqlClient;
using System;

namespace SistemaReparto.Clases
{
    internal class CRecuperarPassword
    {
        CConexion objetoConexion = new CConexion();

        public bool ExisteUsuario(string usuario)
        {
            try
            {
                string consulta = @"SELECT COUNT(*) 
                            FROM usuarios
                            WHERE usuario = @usuario;";

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
                CToken objetoToken = new CToken();
                string token = objetoToken.GenerarToken();

                // Fecha de expiración (5 minutos)
                DateTime fechaExpiracion = DateTime.Now.AddMinutes(5);

                string consulta = @"UPDATE usuarios
                            SET token_recuperacion = @token,
                                fecha_expiracion_token = @fecha
                            WHERE usuario = @usuario;";

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

        public bool ValidarTokenUsuario(string usuario, string token)
        {
            try
            {
                string consulta = @"SELECT COUNT(*)
                            FROM usuarios
                            WHERE usuario = @usuario
                            AND token_recuperacion = @token
                            AND fecha_expiracion_token >= NOW();";

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
                string consulta = @"UPDATE usuarios
                            SET contrasena = @contrasena
                            WHERE usuario = @usuario;";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    objetoConexion.establecerConexion());

                comando.Parameters.AddWithValue("@contrasena", nuevaContrasena);
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
                string consulta = @"UPDATE usuarios
                            SET token_recuperacion = NULL,
                                fecha_expiracion_token = NULL
                            WHERE usuario = @usuario;";

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