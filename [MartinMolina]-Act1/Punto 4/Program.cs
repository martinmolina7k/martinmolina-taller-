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
            //4. Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.

            int num1, num2, resultado;
            string linea;

            Console.Write("ingrese el precio del producto: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("ingrese la cantidad a llevar: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            resultado = num1 * num2;
            Console.WriteLine("monto a pagar :" + resultado);

            Console.ReadKey();
        }
    }
}

