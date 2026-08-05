using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReparto.Clases
{
    public class RolInfo
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
    }

    public static class Sesion
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static string NombreEmpleado { get; set; }

        //Lista de roles del usuario actual
        public static List<RolInfo> Roles { get; set; } = new List<RolInfo>();

        public static bool HaySesionActiva => IdUsuario > 0;

        // Rol espesifico por nombre (ejemplo: "Administrador")
        public static bool TieneRol(string nombreRol)
        {
            return Roles.Any(r => r.NombreRol.Equals(nombreRol, System.StringComparison.OrdinalIgnoreCase));
        }

        // Rol espesifico por id (ejemplo: 1)
        public static bool TieneRol(int idRol)
        {
            return Roles.Any(r => r.IdRol == idRol);
        }

        // Todos los roles del usuario actual como texto, separados por comas
        public static string RolesComoTexto()
        {
            return string.Join(", ", Roles.Select(r => r.NombreRol));
        }

        public static void CerrarSesion()
        {
            IdUsuario = 0;
            NombreUsuario = null;
            NombreEmpleado = null;
            Roles.Clear();
        }
    }
}
