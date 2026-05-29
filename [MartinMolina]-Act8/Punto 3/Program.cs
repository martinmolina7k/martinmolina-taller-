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
            //3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
            //(el orden lo pueden elegir ustedes).

            Console.Write("Ingrese la cantidad de elementos: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese un número: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            // Orden ascendente
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        int aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine("Vector ordenado:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vector[i]);
                Console.ReadKey();

            }
        }
    }
}
