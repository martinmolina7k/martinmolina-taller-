using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
            //un videojuego. El programa debe:
            // Mostrar la puntuación más alta y la más baja.
            // Calcular el promedio de puntuación.
            // Contar cuántas veces superó los 500 puntos.

            int[] puntos = new int[6];

            int mayor;
            int menor;
            int suma = 0;
            int supera500 = 0;

            for (int i = 0; i < puntos.Length; i++)
            {
                Console.Write("Ingrese puntuación: ");
                puntos[i] = int.Parse(Console.ReadLine());
            }

            mayor = puntos[0];
            menor = puntos[0];

            for (int i = 0; i < puntos.Length; i++)
            {
                if (puntos[i] > mayor)
                {
                    mayor = puntos[i];
                }

                if (puntos[i] < menor)
                {
                    menor = puntos[i];
                }

                suma += puntos[i];

                if (puntos[i] > 500)
                {
                    supera500++;
                }
            }

            double promedio = (double)suma / puntos.Length;

            Console.WriteLine("Puntuación más alta: " + mayor);
            Console.WriteLine("Puntuación más baja: " + menor);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Veces que superó 500 puntos: " + supera500);
            Console.ReadKey();

        }
    }
}
