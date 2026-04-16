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
            //Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, imprimir en pantalla la leyenda "Todos los números son menores a diez"

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

            if (num1 < 10 && num2 < 10 && num3 < 10)
            {
                Console.WriteLine("Todos los numeros son menores a 10 ");
            }


            Console.ReadKey();

        }


    }
    
}
