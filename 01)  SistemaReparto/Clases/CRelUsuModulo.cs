using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReparto.Clases
{
    public class CRelUsuModulo
    {
        public int IdModulo { get; set; }
        public int IdUsuario { get; set; }
        public bool DerInsertar { get; set; }
        public bool DerEditar { get; set; }
        public bool DerEliminar { get; set; }
        public bool DerImprimir { get; set; }

        // Extra: solo para mostrar (viene de JOIN)
        public string NombreModulo { get; set; }

        public CRelUsuModulo() { }

        public CRelUsuModulo(int idModulo, int idUsuario, bool insertar, bool editar, bool eliminar, bool imprimir)
        {
            IdModulo = idModulo;
            IdUsuario = idUsuario;
            DerInsertar = insertar;
            DerEditar = editar;
            DerEliminar = eliminar;
            DerImprimir = imprimir;
        }
    }
}
