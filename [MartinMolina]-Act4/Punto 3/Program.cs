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
            /*3. Realizar un programa que acumule (sume) valores ingresados por teclado hasta
           ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el
           valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.*/

            int num = 0;
            int sum = 0;
            string linea;

            while (true)
            {
                Console.Write("Ingresa un numero: ");
                linea = Console.ReadLine();
                num = int.Parse(linea);

                if (num == 9999)
                {
                    break; 
                }

                sum += num;
            }

            Console.WriteLine("Valor acumulado: " + sum);

            if (sum > 0)
            {
                Console.WriteLine("El valor es mayor a cero");
            }
            else if (sum < 0)
            {
                Console.WriteLine("El valor es menor a cero");
            }
            else
            {
                Console.WriteLine("El valor es cero");
            }

            Console.ReadKey();
        }
        }
    }



      
