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
            //1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
            //l valor acumulado de todos los elementos del vector.
            // valor acumulado de los elementos del vector que sean mayores a 36.
            //Cantidad de valores mayores a 50.

            int[] vector = new int[8];

            int sumaTotal = 0;
            int sumaMayores36 = 0;
            int cantidadMayores50 = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingrese un valor: ");
                vector[i] = int.Parse(Console.ReadLine());

                sumaTotal += vector[i];

                if (vector[i] > 36)
                {
                    sumaMayores36 += vector[i];
                }

                if (vector[i] > 50)
                {
                    cantidadMayores50++;
                }
            }

            Console.WriteLine("Suma total: " + sumaTotal);
            Console.WriteLine("Suma de mayores a 36: " + sumaMayores36);
            Console.WriteLine("Cantidad de mayores a 50: " + cantidadMayores50);
            Console.ReadKey();

        }
    }
}
