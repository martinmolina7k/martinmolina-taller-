using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
            //elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
            //tercer vector del mismo tamaño. Sumar componente a componente.

            int[] vector1 = new int[4];
            int[] vector2 = new int[4];
            int[] suma = new int[4];

            Console.WriteLine("Carga del primer vector:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese valor: ");
                vector1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Carga del segundo vector:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese valor: ");
                vector2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 4; i++)
            {
                suma[i] = vector1[i] + vector2[i];
            }

            Console.WriteLine("Vector suma:");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(suma[i]);
                Console.ReadKey();

            }
         }
    }
}
       
