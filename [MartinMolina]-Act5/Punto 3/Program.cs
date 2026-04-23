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
            /*. Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
          a) La cantidad de valores ingresados negativos.
          b) La cantidad de valores ingresados positivos.
          c) La cantidad de múltiplos de 15.
          d) El valor acumulado de los números ingresados que son pares.*/

            int numeros;
            int numN = 0;
            int numP = 0;
            int pares;
            int multiplos;
            string linea;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingresa un numero");
                linea = Console.ReadLine();
                numeros = int.Parse(linea);

                if (numeros < numN)
                {
                    Console.WriteLine("Ingresaste numeros negativos");
                }
                else if (numeros > numP)
                {
                    Console.WriteLine("Se ingreso numeros positivos");

                }

                multiplos = numeros & 15;
                Console.WriteLine("los numeros ´multiplos de 15 son:" + multiplos);
                pares = numeros % 2;
                Console.WriteLine("los numeros pares son:" + pares);

            }
            Console.ReadKey();


        }
    }
}
