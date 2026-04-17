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
            /*. Realizar un programa que lea los lados de n triángulos, e informar:
            a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
            iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
            b) Cantidad de triángulos de cada tipo.
            c) Tipo de triángulo que posee menor cantidad.*/

            int cant_Triangulos;
            int lado1, lado2, lado3;
            string linea;

            Console.WriteLine("ingresa una cantidad de trinagulos");
            linea = Console.ReadLine();
            cant_Triangulos = int.Parse(linea);

            for (int i = 0; i < cant_Triangulos; i++)
            {

                Console.WriteLine("ingresa un valor para el primer lado:");
                linea = Console.ReadLine();
                lado1 = int.Parse(linea);
                Console.WriteLine("ingresa un valor por el segundo lado:");
                linea = Console.ReadLine();
                lado2 = int.Parse(linea);
                Console.WriteLine("ingresa un valor para el tercer y ultimo lado:");
                linea = Console.ReadLine();
                lado3 = int.Parse(linea);

                if (lado1 == lado2 && lado1 != lado3 && lado2 != lado3)
                {
                    Console.WriteLine("Es un triangulo ISOCELES");

                }
                else if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
                {
                    Console.WriteLine("Es un triangulo EQUILATERO");
                }
                else
                {
                    Console.WriteLine("Es un triangulo ESCALENO");
                }

            }
            Console.ReadKey();


        }
    }
}
