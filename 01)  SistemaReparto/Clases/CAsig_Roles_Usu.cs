using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReparto.Clases
{
    public class CAsig_Roles_Usu
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public DateTime FechaAsignacion { get; set; }

        // Extra: solo para mostrar en pantalla (vienen de un JOIN)
        public string NombreUsuario { get; set; }
        public string NombreRol { get; set; }

        public CAsig_Roles_Usu() { }

        public CAsig_Roles_Usu(int idUsuario, int idRol, DateTime fechaAsignacion)
        {
            IdUsuario = idUsuario;
            IdRol = idRol;
            FechaAsignacion = fechaAsignacion;
        }

        public CAsig_Roles_Usu(int idUsuario, int idRol, DateTime fechaAsignacion, string nombreUsuario, string nombreRol)
        {
            IdUsuario = idUsuario;
            IdRol = idRol;
            FechaAsignacion = fechaAsignacion;
            NombreUsuario = nombreUsuario;
            NombreRol = nombreRol;
        }
    }
}
