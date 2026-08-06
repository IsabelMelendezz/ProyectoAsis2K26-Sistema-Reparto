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
        public static class Modulos
        {
            public const int Pedidos = 1;
            public const int Rutas = 2;
            public const int Reportes = 3;
            public const int Usuarios = 4;
            public const int AreasCubiertas = 5;
            public const int Paquetes = 6;
            public const int Bodegas = 7;
            public const int Transportes = 8;
            public const int Empleados = 9;
            public const int Sucursales = 10;
            public const int Asignacion = 11;
        }
    }
}
