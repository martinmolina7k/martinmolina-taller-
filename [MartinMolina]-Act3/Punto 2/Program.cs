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
            //Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.


            int num1, num2, num3, suma, multiplicacion;
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
            suma = num1 + num2;
            multiplicacion = suma * num3;

            if (
                num1 == num2 && num1 == num3


                )
            {
                Console.WriteLine("Los tres numeros son iguales");
                Console.WriteLine("Las sumas de los dos primeros es: " + suma + " El producto de la suma y el num3 es: " + multiplicacion);
            }

            Console.ReadKey();

        }

    }
    

}
