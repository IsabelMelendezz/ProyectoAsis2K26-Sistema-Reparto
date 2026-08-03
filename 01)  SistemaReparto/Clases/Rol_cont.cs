using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaReparto.Clases
{
    internal class rol_cont
    {
        // CREATE
        public bool AnadirRol(CRol rol)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = "INSERT INTO rol (nombre_rol, descripcion_rol,estado_rol) VALUES (@nombre, @descripcion,@estado)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", rol.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", rol.Descripcion);
                cmd.Parameters.AddWithValue("@estado",rol.Estado);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir rol: " + ex.Message);
                return false;
            }
            finally
            {
                cn.cerrarConexion();
            }
        }

        // READ (todos, para llenar la grid)
        public List<CRol> ListarRoles()
        {
            List<CRol> lista = new List<CRol>();
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = "SELECT id_rol, nombre_rol, descripcion_rol,estado_rol FROM rol";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new CRol(
                        Convert.ToInt32(reader["id_rol"]),
                        reader["nombre_rol"].ToString(),
                        reader["descripcion_rol"].ToString(),
                        reader["estado_rol"].ToString()
                    ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar roles: " + ex.Message);
            }
            finally
            {
                cn.cerrarConexion();
            }
            return lista;
        }

        // UPDATE
        public bool EditarRol(CRol rol)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = "UPDATE rol SET nombre_rol=@nombre, descripcion_rol=@descripcion,estado_rol=@estado WHERE id_rol=@id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", rol.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", rol.Descripcion);
                cmd.Parameters.AddWithValue("@id", rol.IdRol);
                    cmd.Parameters.AddWithValue("@estado",rol.Estado);
                
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar rol: " + ex.Message);
                return false;
            }
            finally
            {
                cn.cerrarConexion();
            }
        }

        // DELETE
        public bool BorrarRol(int idRol)
        {
            CConexion cn = new CConexion();
            MySqlConnection conexion = cn.establecerConexion();

            try
            {
                string query = "DELETE FROM rol WHERE id_rol=@id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", idRol);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar rol: " + ex.Message);
                return false;
            }
            finally
            {
                cn.cerrarConexion();
            }
        }
    }
}
