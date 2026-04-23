using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*. Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
muestre la tabla de multiplicar del mismo (los primeros 13 términos)
Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 
39.*/

            int valor;
            int multiplicacion;
            String linea;

            Console.WriteLine("Ingresa un numero del 1-10");
            linea = Console.ReadLine();
            valor = int.Parse(linea);

            for (int i = valor; i <= 13; i++)
            {
                multiplicacion = i * i;
                Console.WriteLine(multiplicacion);

            }

            Console.ReadKey();


        }
    }
}
