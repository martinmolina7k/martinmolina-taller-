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
            //Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos.

            int num1, num2, num3;
            string Linea;
            Console.Write("introducir un numero: ");
            Linea = Console.ReadLine();
            num1 = int.Parse(Linea);
            Console.Write("introducir un numero: ");
            Linea = Console.ReadLine();
            num2 = int.Parse(Linea);
            Console.Write("introducir un numero: ");
            Linea = Console.ReadLine();
            num3 = int.Parse(Linea);

            if (
                num1 > num2 && num1 > num3
                )
            {
                Console.WriteLine("El numero mayor es: " + num1);
            }
            if (
            num2 > num1 && num2 > num3
            )
            {
                Console.WriteLine("El numero mayor es: " + num2);
            }
            if (
            num3 > num2 && num3 > num1
            )
            {
                Console.WriteLine("El numero mayor es: " + num3);
            }

            Console.ReadKey();





        }

    }
    
}
