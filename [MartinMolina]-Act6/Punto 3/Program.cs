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
            string nombre;
            int sueldo;

            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese sueldo: ");
            sueldo = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Sueldo: " + sueldo);

            if (sueldo > 3000)
                Console.WriteLine("Debe pagar impuestos");
            else
                Console.WriteLine("No paga impuestos");

            Console.ReadKey();


        }
    }
}
