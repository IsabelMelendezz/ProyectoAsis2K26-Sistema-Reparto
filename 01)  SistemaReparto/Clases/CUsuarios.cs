using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SistemaReparto.Clases
{
    public class CUsuarios
    {
        public int IdUsuario { get; set; }
        public int IdEmpleado { get; set; }
        public string NombreUsuario { get; set; }     // columna "usuario"
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public DateTime? UltimoAcceso { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Estado { get; set; }             // "Activo" / "Inactivo"

        // Extra: solo para mostrar en pantalla (viene de un JOIN con empleados)
        public string NombreEmpleado { get; set; }

        public CUsuarios() { }

        // Constructor para crear
        public CUsuarios(int idEmpleado, string nombreUsuario, string correo, string contrasena, string estado)
        {
            IdEmpleado = idEmpleado;
            NombreUsuario = nombreUsuario;
            Correo = correo;
            Contrasena = contrasena;
            Estado = estado;
            FechaCreacion = DateTime.Now;
        }

        // Constructor completo (desde la BD)
        public CUsuarios(int idUsuario, int idEmpleado, string nombreUsuario, string correo, string contrasena,
                        DateTime? ultimoAcceso, DateTime fechaCreacion, string estado, string nombreEmpleado)
        {
            IdUsuario = idUsuario;
            IdEmpleado = idEmpleado;
            NombreUsuario = nombreUsuario;
            Correo = correo;
            Contrasena = contrasena;
            UltimoAcceso = ultimoAcceso;
            FechaCreacion = fechaCreacion;
            Estado = estado;
           
            NombreEmpleado = nombreEmpleado;
        }
    }
}
