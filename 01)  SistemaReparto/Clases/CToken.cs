using System;
using System.Linq;

namespace SistemaReparto.Clases
{
    internal class CToken
    {
        public string GenerarToken()
        {
            const string letras = "ABCDEFGHJKLMNPQRSTUVWXYZ";
            const string numeros = "23456789";

            Random random = new Random();

            char[] token = new char[6];

            // Generar 3 letras
            token[0] = letras[random.Next(letras.Length)];
            token[1] = letras[random.Next(letras.Length)];
            token[2] = letras[random.Next(letras.Length)];

            // Generar 3 números
            token[3] = numeros[random.Next(numeros.Length)];
            token[4] = numeros[random.Next(numeros.Length)];
            token[5] = numeros[random.Next(numeros.Length)];

            // Mezclar el orden de los caracteres
            token = token.OrderBy(x => random.Next()).ToArray();

            return new string(token);
        }
    }
}