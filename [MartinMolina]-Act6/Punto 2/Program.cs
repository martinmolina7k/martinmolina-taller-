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
            //2. Desarrollar una clase que represente un Cuadrado y tenga los siguientes
        //métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.


            int lado;

            Console.Write("Ingrese lado: ");
            lado = int.Parse(Console.ReadLine());

            int perimetro = lado * 4;
            int superficie = lado * lado;

            Console.WriteLine("Perímetro: " + perimetro);
            Console.WriteLine("Superficie: " + superficie);

            Console.ReadKey();


        }
    }
}
