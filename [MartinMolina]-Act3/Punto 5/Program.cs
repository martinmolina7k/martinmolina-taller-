using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escribir un programa que pida ingresar la coordenada de un punto en el plano, es decir dos valores enteros x e y (distintos a cero).Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto. (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0).

            int valor1, valor2;
            string linea;
            Console.Write("Igresar Coordenada X: ");
            linea = Console.ReadLine();
            valor1 = int.Parse(linea);
            Console.Write("Igresar Coordenada Y: ");
            linea = Console.ReadLine();
            valor2 = int.Parse(linea);

            if (valor1 > 0 && valor2 > 0)
            {

                Console.WriteLine("Estas en el cuadrante 1 ");

            }
            if (valor1 < 0 && valor2 > 0)
            {
                Console.WriteLine("Estas en el cuadrante 2 ");
            }


            Console.ReadKey();

        }


    }
    
}
