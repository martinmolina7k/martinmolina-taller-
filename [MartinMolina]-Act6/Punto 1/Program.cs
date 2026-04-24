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
            int x, y;

            Console.Write("Ingrese x: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese y: ");
            y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine("Primer cuadrante");
            else if (x < 0 && y > 0)
                Console.WriteLine("Segundo cuadrante");
            else if (x < 0 && y < 0)
                Console.WriteLine("Tercer cuadrante");
            else if (x > 0 && y < 0)
                Console.WriteLine("Cuarto cuadrante");
            else
                Console.WriteLine("Sobre un eje");

            Console.ReadKey();

        }
    }
}
