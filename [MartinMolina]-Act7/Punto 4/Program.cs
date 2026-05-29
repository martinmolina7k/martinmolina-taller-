using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
            //ordenado de menor a mayor y de mayor a menor.

            int[] vector = new int[10];

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingrese valor: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            bool creciente = true;
            bool decreciente = true;

            for (int i = 0; i < vector.Length - 1; i++)
            {
                if (vector[i] < vector[i + 1] == false)
                {
                    creciente = false;
                }

                if (vector[i] > vector[i + 1] == false)
                {
                    decreciente = false;
                }
            }

            if (creciente)
            {
                Console.WriteLine("El vector está ordenado de menor a mayor.");
            }
            else if (decreciente)
            {
                Console.WriteLine("El vector está ordenado de mayor a menor.");
            }
            else
            {
                Console.WriteLine("El vector no está ordenado.");
                Console.ReadKey();

            }
        }
    }
}
