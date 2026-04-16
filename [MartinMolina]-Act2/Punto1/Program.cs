using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar su suma y diferencia, en caso contrario informar el producto y la división del primero respecto al segundo.

            int num1, num2, suma, resta, producto, division;
            string linea;
            Console.Write("introducir primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("introducir segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            suma = num1 + num2;
            resta = num1 - num2;
            producto = num1 * num2;
            division = num1 / num2;

            if (num1 > num2



            )

            {

                Console.WriteLine(suma);
                Console.WriteLine(resta);
            }

            else
            {


                Console.WriteLine(producto);
                Console.WriteLine(division);
            }

            Console.ReadKey();

        }

    }
    
}
