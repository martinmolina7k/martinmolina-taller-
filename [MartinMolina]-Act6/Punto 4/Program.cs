using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Implementar la clase operaciones. Se deben cargar dos valores enteros,
            //calcular su suma, resta, multiplicación y división, cada una en un método,
            //imprimir dichos resultados.

            int v1, v2;

            Console.Write("Ingrese primer valor: ");
            v1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese segundo valor: ");
            v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Suma: " + (v1 + v2));
            Console.WriteLine("Resta: " + (v1 - v2));
            Console.WriteLine("Multiplicación: " + (v1 * v2));

            if (v2 != 0)
                Console.WriteLine("División: " + (v1 / v2));
            else
                Console.WriteLine("No se puede dividir por cero");

            Console.ReadKey();
        }
    }
}
