using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReparto.Clases
{
    internal class CConexion
    {
        MySqlConnection conexion = new MySqlConnection();
        static string servidor = "localhost";
        static string bd = "sistema_reparto";
        static string usuario = "root";
        static string password = "Isa2004";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
      //string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database" + bd + ";";

        public MySqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                //MessageBox.Show("Se conecto a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto a la base de datos, error: " + ex.ToString());
            }
            return conexion;
        }

        public void cerrarConexion() { conexion.Close(); }
    }
}
