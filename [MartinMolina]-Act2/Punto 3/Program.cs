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
            //Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando si el número tiene uno o dos dígitos.(Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)

            int num1;
            string linea;
            Console.Write("introducir un numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            if (

                num1 > 9




                )
            {

                Console.WriteLine("Es un numero de dos digitos");


            }
            else
            {

                Console.WriteLine("Es de un digito");




            }


            Console.ReadKey();






        }

    }
    
}
