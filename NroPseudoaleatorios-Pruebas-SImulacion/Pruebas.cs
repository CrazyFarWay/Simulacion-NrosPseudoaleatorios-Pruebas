using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NroPseudoaleatorios_Pruebas_SImulacion
{
    internal class Pruebas
    {
        public static bool PruebaPromedio(double[] numerosPseudoaleatorios, double estadisticoAlfa)
        {
            int cantidadNumeros = numerosPseudoaleatorios.Length;
            // Calcular el promedio aritmético de los datos
            double promedio = numerosPseudoaleatorios.Average();

            // Calcular el estadístico Z
            double estadistico = ((promedio - 0.5) * Math.Sqrt(cantidadNumeros)) / (Math.Sqrt(1.0 / 12.0));

            // Verificar si se cumple la hipótesis
            return Math.Abs(estadistico) < estadisticoAlfa;
        }

        public static bool PruebaFrecuencias(double[] numerosPseudoaleatorios, int numeroSubintervalos, double estadisticoAlfa)
        {
            int cantidadNumeros = numerosPseudoaleatorios.Length;

            // Calcular la frecuencia esperada en cada subintervalo
            double frecuenciaEsperada = (double) cantidadNumeros / numeroSubintervalos;

            // Calcular la frecuencia observada en cada subintervalo
            double[] frecuenciaObservada = new double[numeroSubintervalos];

            for (int i = 0; i < cantidadNumeros; i++)
            {
                int subintervaloCorrespondiente = (int)(numerosPseudoaleatorios[i] * numeroSubintervalos);
                frecuenciaObservada[subintervaloCorrespondiente]++;
            }

            // Calcular el estadístico chi-cuadrado
            double chiCuadrado = 0;
            for (int i = 0; i < numeroSubintervalos; i++)
            {
                double diferenciaFrecuencias = frecuenciaObservada[i] - frecuenciaEsperada;
                chiCuadrado += diferenciaFrecuencias * diferenciaFrecuencias;
            }

            chiCuadrado /= frecuenciaEsperada;

            // Verificar si se cumple la hipótesis
            return chiCuadrado < estadisticoAlfa;
        }

        public static bool PruebaSerie(List<(double, double)> tuplasNumerosPseudoaleatorios, int x, double estadisticoAlfa)
        {
            int cantidadTuplas = tuplasNumerosPseudoaleatorios.Count;
            int cantidadCeldas = x * x;

            // Calcular frecuencia observada en cada celda
            int[,] frecuenciasObservadas = new int[x, x];

            for (int numeroTupla = 0; numeroTupla < cantidadTuplas; numeroTupla++)
            {
                (double, double) tupla = tuplasNumerosPseudoaleatorios[numeroTupla];
                 
                int j = (int) (tupla.Item1 * x);
                int k = (int) (tupla.Item2 * x);
                frecuenciasObservadas[j, k]++;
            }

            // Calcular frecuencia esperada
            double frecuenciaEsperada = (double) cantidadTuplas / cantidadCeldas;

            // Calcular estadístico
            double chiCuadrado = 0.0;
            for (int j = 0; j < x; j++)
            {
                for (int k = 0; k < x; k++)
                {
                    double diferenciaFrecuencias = frecuenciasObservadas[j, k] - frecuenciaEsperada;
                    chiCuadrado += diferenciaFrecuencias * diferenciaFrecuencias;
                }
            }
            chiCuadrado *= (double) cantidadCeldas / cantidadTuplas;

            // Comparar estadístico con chi-cuadrado
            return chiCuadrado < estadisticoAlfa;
        }

        public bool PruebaKolmogorovSmirnov(double[] numerosPseudoaleatorios, double estadisticoAlfa)
        {
            int cantidadNumeros = numerosPseudoaleatorios.Length;
         
            // Ordenar lista de numeros
            double[] numerosOrdenados = numerosPseudoaleatorios.OrderBy(num => num).ToArray();

            // Calcular distribuciones acumuladas
            double[] distribucionesAcumuladas = new double[cantidadNumeros];

            for (int i = 0; i < cantidadNumeros; i++)
            {
                distribucionesAcumuladas[i] = (double) (i + 1) / cantidadNumeros;
            }

            // Calcular estadistico k-s
            double[] diferenciasFrecuenciaNumero = new double[cantidadNumeros];
            double estadisticoKs = 0.0;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                diferenciasFrecuenciaNumero[i] = Math.Abs(distribucionesAcumuladas[i] - numerosOrdenados[i]);
            }

            estadisticoKs = diferenciasFrecuenciaNumero.Max();

            return estadisticoKs < estadisticoAlfa;
        }

        public static bool PruebaCorridaArribaAbajoMedia(double[] numerosPseudoaleatorios, double estadisticoAlfa)
        {
            int cantidadNumeros = numerosPseudoaleatorios.Length;

            // Generar la secuencia binaria
            int[] secuenciaBinaria = new int[cantidadNumeros];

            for (int i = 0; i < cantidadNumeros; i++)
            {
                secuenciaBinaria[i] = (numerosPseudoaleatorios[i] <= 0.5) ? 0 : 1;
            }

            // Calcular la secuencia de corridas
            List<int> frecuenciasObservadas = new List<int>();

            for (int i = 0; i < secuenciaBinaria.Length; i++)
            {
                int contador = 1;
                int numeroBinario = secuenciaBinaria[i];

                for (int j = i; j < secuenciaBinaria.Length - i; j++)
                {
                   int otroNumeroBinario = secuenciaBinaria[j];

                   if (numeroBinario == otroNumeroBinario)
                    {
                        contador++;
                    } 
                    else
                    {
                        break;
                    }
                }

                frecuenciasObservadas.Add(contador);
            }

            int cantidadFrecuenciasObservadas = frecuenciasObservadas.Count;
            double[] frecuenciasEsperadas = new double[cantidadFrecuenciasObservadas];

            for (int i = 0; i < cantidadFrecuenciasObservadas; i++)
            {
                frecuenciasEsperadas[i] = (cantidadNumeros - i + 3) / (Math.Pow(2, i + 1));
            }

            // Calcular chi cuadrado
            double chiCuadrado = 0.0;
            for (int i = 1; i <= cantidadFrecuenciasObservadas; i++)
            {
                double diferenciaFrecuencias = (frecuenciasObservadas[i] - frecuenciasEsperadas[i]);
                chiCuadrado += (diferenciaFrecuencias * diferenciaFrecuencias) / frecuenciasEsperadas[i];
            }

            // Comparar estadístico con chi-cuadrado
            return chiCuadrado < estadisticoAlfa;
        }

    }
}
