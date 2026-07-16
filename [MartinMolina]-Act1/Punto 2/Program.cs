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
            //2. Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto.
            int num1, num2, num3, num4, suma, multi;
            string linea;
            Console.Write("ingrese un numero para sumar: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("ingrese un segundo numero para sumar: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("ingrese un numero para multipicar: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            Console.Write("ingrese un segundo numero para multiplar: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            suma = num1 + num2;
            multi = num3 * num4;

            Console.WriteLine("el resultado de la suma es: " + suma);
            Console.WriteLine("el resultado de la multiplicacion es: " + multi);

            Console.ReadKey();

        }
    }
}