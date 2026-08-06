using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReparto.Clases
{
    public class CPermisoModulo
    {
        public bool PuedeInsertar { get; set; }
        public bool PuedeEditar { get; set; }
        public bool PuedeEliminar { get; set; }
        public bool PuedeImprimir { get; set; }

    
        public bool TieneAcceso { get; set; }
    }
}
