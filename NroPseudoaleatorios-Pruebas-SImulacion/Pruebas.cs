using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NroPseudoaleatorios_Pruebas_SImulacion
{
    internal class Pruebas
    {
        static void Menu(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Seleccione un método para ejecutar:");
                Console.WriteLine("1. Prueba de promedio");
                Console.WriteLine("2. Prueba de frecuencias");
                Console.WriteLine("3. Prueba de serie");
                Console.WriteLine("4. Prueba de Kolmogorov-Smirnov");
                Console.WriteLine("5. Prueba de corrida arriba-abajo-media");
                Console.WriteLine("0. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Llamar al método PruebaPromedio con los parámetros necesarios
                        Console.WriteLine("Ingrese el valor de n:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double[] datos = new double[n];
                        Console.WriteLine("Ingrese los datos:");
                        for (int i = 0; i < n; i++)
                        {
                            datos[i] = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine("Ingrese el valor de Zc:");
                        double Zc = Convert.ToDouble(Console.ReadLine());
                        PruebaPromedio(n, datos, Zc);
                        break;
                    case 2:
                        // Llamar al método PruebaFrecuencias con los parámetros necesarios
                        Console.WriteLine("Ingrese el valor de n:");
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        double[] datos2 = new double[n2];
                        Console.WriteLine("Ingrese los datos:");
                        for (int i = 0; i < n2; i++)
                        {
                            datos2[i] = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine("Ingrese el valor de x:");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de alfa:");
                        double alfa = Convert.ToDouble(Console.ReadLine());
                        PruebaFrecuencias(n2, datos2, x, alfa);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese los números separados por coma:");
                        string numerosStr = Console.ReadLine();
                        double[] numeros = Array.ConvertAll(numerosStr.Split(','), Double.Parse);

                        Console.WriteLine("Ingrese el valor de x:");
                        int x = Convert.ToInt32(Console.ReadLine());

                        bool resultadoSerie = PruebaSerie(numeros, x);
                        Console.WriteLine(resultadoSerie ? "Se acepta la hipótesis" : "Se rechaza la hipótesis");
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el valor de n:");
                        int n4 = Convert.ToInt32(Console.ReadLine());
                        double[] datos4 = new double[n4];
                        Console.WriteLine("Ingrese los datos:");
                        for (int i = 0; i < n4; i++)
                        {
                            datos4[i] = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine("Ingrese el nivel de significancia:");
                        double nivelSignificancia = Convert.ToDouble(Console.ReadLine());
                        bool resultadoKS = PruebaKolmogorovSmirnov(datos4, nivelSignificancia);
                        Console.WriteLine(resultadoKS ? "Se acepta la hipótesis" : "Se rechaza la hipótesis");
                        break;
                    case 5:
                        Console.WriteLine("Ingrese el valor de n:");
                        int n5 = Convert.ToInt32(Console.ReadLine());
                        List<double> numeros5 = new List<double>();
                        Console.WriteLine("Ingrese los datos:");
                        for (int i = 0; i < n5; i++)
                        {
                            numeros5.Add(Convert.ToDouble(Console.ReadLine()));
                        }
                        bool resultadoCorrida = PruebaCorridaArribaAbajoMedia(numeros5);
                        Console.WriteLine(resultadoCorrida ? "Se acepta la hipótesis" : "Se rechaza la hipótesis");
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Seleccione una opción válida.");
                        break;
                }

            } while (opcion != 0);
        }
        public static bool PruebaPromedio(int n, double[] datos, double Zc)
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
            public static bool PruebaFrecuencias(int n, double[] datos, int x, double alfa)
            {
                // Calcular la frecuencia esperada en cada subintervalo
                double[] frecuenciaEsperada = new double[x];
                for (int i = 0; i < x; i++)
                {
                    frecuenciaEsperada[i] = (double)n / x;
                }

                // Calcular la frecuencia observada en cada subintervalo
                double[] frecuenciaObservada = new double[x];
                for (int i = 0; i < n; i++)
                {
                    int j = (int)(datos[i] * x);
                    frecuenciaObservada[j]++;
                }

                // Calcular el estadístico chi-cuadrado
                double chiCuadrado = 0;
                for (int i = 0; i < x; i++)
                {
                    double diferencia = frecuenciaObservada[i] - frecuenciaEsperada[i];
                    chiCuadrado += diferencia * diferencia / frecuenciaEsperada[i];
                }

                // Calcular el valor crítico
                double valorCritico = ChiCuadrado.InvCDF(x - 1, 1 - alfa);

                // Verificar si se cumple la hipótesis
                if (chiCuadrado < valorCritico)
                {
                    Console.WriteLine("No se puede rechazar la hipótesis de que los números pseudo aleatorios generados provienen de un universo uniforme.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Se rechaza la hipótesis de que los números pseudo aleatorios generados provienen de un universo uniforme.");
                    return false;
                }
            }

        public static bool PruebaSerie(double[] numeros, int x)
        {
            int n = numeros.Length;
            int x2 = x * x;
            int[] frecuenciasObservadas = new int[x2];

            // Dividir el cuadrado unitario en x2 celdas
            for (int i = 0; i < n - 1; i += 2)
            {
                int j = (int)(numeros[i] * x);
                int k = (int)(numeros[i + 1] * x);
                frecuenciasObservadas[j * x + k]++;
            }

            // Calcular estadístico
            double frecuenciaEsperada = (double)n / x2;
            double estadistico = 0.0;
            for (int j = 0; j < x; j++)
            {
                for (int k = 0; k < x; k++)
                {
                    double fjK = frecuenciasObservadas[j * x + k];
                    estadistico += (fjK - frecuenciaEsperada) * (fjK - frecuenciaEsperada);
                }
            }
            estadistico *= x2 / (double)n;

            // Comparar estadístico con chi-cuadrado
            int gradosLibertad = x2 - x;
            double chiCuadrado = DistribucionChiCuadrado.CalcularValor(gradosLibertad, 0.05);
            return estadistico < chiCuadrado;
        }

        public bool PruebaKolmogorovSmirnov(double[] numerosAleatorios, double nivelSignificancia)
        {
            int n = numerosAleatorios.Length;
            double[] x = numerosAleatorios.OrderBy(num => num).ToArray();
            double[] En = new double[n];
            double Dn = 0.0;

            for (int i = 0; i < n; i++)
            {
                En[i] = (double)(i + 1) / n;
            }

            for (int i = 0; i < n; i++)
            {
                double diff1 = Math.Abs(En[i] - x[i]);
                double diff2 = Math.Abs(En[i] - x[i + 1]);
                double maxDiff = Math.Max(diff1, diff2);
                Dn = Math.Max(Dn, maxDiff);
            }

            double da = 1.36 / Math.Sqrt(n);
            return Dn < da;
        }

        public static bool PruebaCorridaArribaAbajoMedia(List<double> numeros)
        {
            int n = numeros.Count;
            double media = numeros.Average();
            int[] s = new int[n]; // secuencia binaria
            int[] r = new int[n]; // secuencia de corridas
            int frecuenciaEsperada;
            int frecuenciaObservada;

            // Generar la secuencia binaria
            for (int i = 0; i < n; i++)
            {
                if (numeros[i] < media)
                {
                    s[i] = 0;
                }
                else
                {
                    s[i] = 1;
                }
            }

            // Calcular la secuencia de corridas
            int j = 0;
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    r[j] = s[i];
                    k = s[i];
                }
                else
                {
                    if (s[i] == k)
                    {
                        r[j]++;
                    }
                    else
                    {
                        k = s[i];
                        j++;
                        r[j] = 1;
                    }
                }
            }
            int totalCorridas = j + 1;

            // Calcular la frecuencia esperada y observada
            double chiCuadrado = 0.0;
            for (int i = 1; i <= n; i++)
            {
                if (i <= (n + 1) / 2)
                {
                    frecuenciaEsperada = (n - i + 3) / Math.Pow(2, i + 1);
                }
                else
                {
                    frecuenciaEsperada = (n - i + 3) / Math.Pow(2, n - i + 1);
                }
                frecuenciaObservada = r[i - 1];
                chiCuadrado += Math.Pow(frecuenciaObservada - frecuenciaEsperada, 2) / frecuenciaEsperada;
            }

            // Comparar con el valor crítico
            double valorCritico = ChiCuadrado.InvCDF((totalCorridas - 1), 0.05);
            return chiCuadrado < valorCritico;
        }

    }
}
