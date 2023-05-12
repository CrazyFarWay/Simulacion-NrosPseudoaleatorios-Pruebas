using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NroPseudoaleatorios_Pruebas_SImulacion
{
    internal class GeneradorNumeros
    {
        public double[] calcularParteCentralCuadrado(Int64 digitosDeseados, Int64 semilla)
        {
            List<double> arrayResultados = new List<double>();

            // Generar los primeros 10 números pseudoaleatorios
            for (int i = 0; i < digitosDeseados; i++)
            {
                // Elevar la semilla al cuadrado
                Int64 cuadrado = semilla * semilla;
                string cuadradoStr = cuadrado.ToString();
                int cantidadDigitosCuadrado = cuadradoStr.Length;

                if ( (cantidadDigitosCuadrado - digitosDeseados) % 2 != 0 )
                {
                    cuadrado = cuadrado * 10;
                }

                // Tomar los dígitos centrales del cuadrado como la nueva semilla
                int digitos = Convert.ToInt32(digitosDeseados);
                int centro = cuadradoStr.Length / 2;
                Int64 nuevoNum = Int64.Parse(cuadradoStr.Substring(centro - (digitos / 2), digitos));

                // Asignar el nuevo número como la semilla para la próxima iteración
                semilla = nuevoNum;
                int cantidadDigitosSemilla = semilla.ToString().Length;
                double nuevoNumDecimal = (double) semilla / (double) Math.Pow(10, cantidadDigitosSemilla);
                arrayResultados.Add(nuevoNumDecimal);


                // Mostrar el número pseudoaleatorio generado
                Console.WriteLine(nuevoNumDecimal);
            }

            return arrayResultados.ToArray();
        }

        public double[] calcularLehmer(Int64 digitosDeseados, Int64 semilla, Int64 t)
        {
            List<double> arrayResultados = new List<double>();
            int k = t.ToString().Length; // Cálculo de la cantidad de dígitos en t


            for (int i = 0; i < digitosDeseados; i++)
            {
                // multiplicar n*t
                Int64 aux = semilla * t;

                // Tomar los k digitos de la izquiera del resultado de numAux
                string numerosIzquierdaStr = aux.ToString().Substring(0, k);
                Int64 numerosIzquierda = Int64.Parse(numerosIzquierdaStr);

                // Tomar los digitos de la restantes 
                int longitudRestante = aux.ToString().Length - k;
                string numerosRestantesStr = aux.ToString().Substring(k, longitudRestante); // enviamos k-1 porque la funcion Substring recibe un intervalo exclusivo
                Int64 numerosRestantes = Int64.Parse(numerosRestantesStr);

                // Obtenemos la nueva semilla
                semilla = numerosRestantes - numerosIzquierda;

                // Obtenemos el numero aleatoreo
                int cantidadDigitosSemilla = semilla.ToString().Length;
                double nuevoNumDecimal = (double)semilla / (double)Math.Pow(10, cantidadDigitosSemilla);

                arrayResultados.Add(nuevoNumDecimal);

                // Mostrar el número pseudoaleatorio generado
                Console.WriteLine(nuevoNumDecimal);
            }
            return arrayResultados.ToArray();
        }

        public void calcularCongruencialMixto()
        {

        }

        public void calcularCongruencialMultiplicativo()
        {

        }

        public void calcularCongruencialAditivo()
        {

        }
    }
}
