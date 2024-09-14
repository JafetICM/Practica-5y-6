using System;

namespace TorreHanoi
{
    public class TorreHanoi
    {
        public string ResolverTorresDeHanoi(int numDiscos, char origen, char destino, char auxiliar)
        {
            string resultado = string.Empty;

            // Caso base: si solo hay un disco, se mueve directamente
            if (numDiscos == 1)
            {
                resultado += $"Mover disco 1 de {origen} a {destino}\n";
                return resultado;
            }

            // Mueve n-1 discos desde el origen hasta el auxiliar usando el destino como apoyo
            resultado += ResolverTorresDeHanoi(numDiscos - 1, origen, auxiliar, destino);

            // Mueve el disco n desde el origen hasta el destino
            resultado += $"Mover disco {numDiscos} de {origen} a {destino}\n";

            // Mueve n-1 discos desde el auxiliar hasta el destino usando el origen como apoyo
            resultado += ResolverTorresDeHanoi(numDiscos - 1, auxiliar, destino, origen);

            return resultado;
        }
    }
}
