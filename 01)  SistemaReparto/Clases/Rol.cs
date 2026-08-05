using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReparto.Clases
{
    public class CRol
    {
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Estado { get; set; } // Agregado para el estado del rol

        public CRol() {
          
            
        }

        public CRol(string nombre, string descripcion, string estado)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = estado;
        }

        public CRol(int idRol, string nombre, string descripcion, string estado)
        {
            IdRol = idRol;
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = estado;
        }
    }
}
