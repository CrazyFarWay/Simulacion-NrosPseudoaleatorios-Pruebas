using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NroPseudoaleatorios_Pruebas_SImulacion
{
    internal class Controller
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

        public void calcularLehmer()
        {

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
