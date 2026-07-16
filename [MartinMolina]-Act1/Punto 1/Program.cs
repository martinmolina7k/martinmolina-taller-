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
            //1. Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo (El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).

            int num1, resultado;
            string linea;

            Console.Write("ingrese un lado del cubo: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            resultado = num1 * 4;
            Console.WriteLine("perimetro del cubo" + resultado);

            Console.ReadKey();
        }
    }
}