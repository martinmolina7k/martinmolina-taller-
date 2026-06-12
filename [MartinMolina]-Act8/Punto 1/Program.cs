using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
            //del vector.

            Console.Write("Ingrese la cantidad de elementos: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese un valor: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            int menor = vector[0];

            for (int i = 1; i < n; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
            }

            int contador = 0;

            for (int i = 0; i < n; i++)
            {
                if (vector[i] == menor)
                {
                    contador++;
                }
            }

            Console.WriteLine("El menor valor es: " + menor);

            if (contador > 1)
            {
                Console.WriteLine("El menor valor se repite.");
            }
            else
            {
                Console.WriteLine("El menor valor no se repite.");
                Console.ReadKey();

            }
        }
    }
}
