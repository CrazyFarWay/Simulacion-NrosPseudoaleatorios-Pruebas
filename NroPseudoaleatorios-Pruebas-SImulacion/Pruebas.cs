using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NroPseudoaleatorios_Pruebas_SImulacion
{
    internal class Pruebas
    {
        public static bool EjecutarPruebaPromedio(int n, double[] datos, double Zc)
        {
            // Calcular el promedio aritmético de los datos
            double promedio = 0;
            for (int i = 0; i < n; i++)
            {
                promedio += datos[i];
            }
            promedio /= n;

            // Calcular el estadístico Z
            double Z = (promedio - 0.5) * Math.Sqrt(n) / Math.Sqrt(1.0 / 12.0);

            // Verificar si se cumple la hipótesis
            if (Math.Abs(Z) < Zc)
            {
                Console.WriteLine("No se puede rechazar la hipótesis de que los números pseudo aleatorios generados provienen de un universo uniforme con media 0.5.");
                return true;
            }
            else
            {
                Console.WriteLine("Se rechaza la hipótesis de que los números pseudo aleatorios generados provienen de un universo uniforme con media 0.5.");
                return false;
            }
        }
    }
}
