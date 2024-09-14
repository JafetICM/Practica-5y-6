using System;

namespace CalculadoraDeCambio
{
    public class CalculadoraDeCambio
    {
        public string CalcularCambio(decimal cantidadAPagar, decimal cantidadPagada)
        {
            decimal cambio = cantidadPagada - cantidadAPagar;
            if (cambio < 0)
            {
                return "La cantidad pagada es menor que la cantidad a pagar.";
            }

            // Convertir cambio a centavos para trabajar más fácilmente
            int cambioEnCentavos = (int)(cambio * 100);

            // Denominaciones en centavos
            int[] denominaciones = { 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 1 };
            int[] resultado = new int[denominaciones.Length];

            // Calcular el número de monedas
            for (int i = 0; i < denominaciones.Length; i++)
            {
                resultado[i] = cambioEnCentavos / denominaciones[i];
                cambioEnCentavos %= denominaciones[i];
            }

            // Formatear el resultado en una cadena de texto
            return $"Monedas de 100 pesos: {resultado[0]}\n" +
                   $"Monedas de 50 pesos: {resultado[1]}\n" +
                   $"Monedas de 20 pesos: {resultado[2]}\n" +
                   $"Monedas de 10 pesos: {resultado[3]}\n" +
                   $"Monedas de 5 pesos: {resultado[4]}\n" +
                   $"Monedas de 2 pesos: {resultado[5]}\n" +
                   $"Monedas de 1 peso: {resultado[6]}\n" +
                   $"Monedas de 50 centavos: {resultado[7]}\n" +
                   $"Monedas de 20 centavos: {resultado[8]}\n" +
                   $"Monedas de 10 centavos: {resultado[9]}\n" +
                   $"Monedas de 5 centavos: {resultado[10]}\n" +
                   $"Monedas de 1 centavo: {resultado[11]}";
        }
    }
}
