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
            //3. Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.
            int num1, num2, num3, num4, suma;
            decimal avg;
            string linea;
            Console.Write("ingrese el primer numero ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("ingrese el segundo numero ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("ingrese el tercer numero ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            Console.Write("ingrese el cuarto numero ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            suma = num1 + num2 + num3 + num4;

            avg = (decimal)suma / 4;

            Console.WriteLine("el resultado de la suma es: " + suma);
            Console.WriteLine("el promedio de los 4 es: " + avg);

            Console.ReadKey();

        }
    }
}