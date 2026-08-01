using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReparto.Clases
{
    public class CModulo
    {
        public int IdModulo { get; set; }
        public string NombreModulo { get; set; }
        public string EstatusModulo { get; set; }

        public CModulo() { }

        public CModulo(int idModulo, string nombreModulo, string estatusModulo)
        {
            IdModulo = idModulo;
            NombreModulo = nombreModulo;
            EstatusModulo = estatusModulo;
        }
    }
}
