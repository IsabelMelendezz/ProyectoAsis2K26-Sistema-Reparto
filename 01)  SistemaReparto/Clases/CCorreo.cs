using System;

namespace SistemaReparto.Clases
{
    internal class CCorreo
    {
        public bool EnviarCorreo(string destino, string asunto, string mensaje)
        {
            try
            {
                // Aquí implementaremos el envío por Gmail
                // Por el momento solo devolvemos true para que compile.

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}