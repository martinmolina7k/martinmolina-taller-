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
            //3. Confeccionar una clase que represente un empleado. Definir como atributos su
            //nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
            //sus datos y por último uno que imprima un mensaje si debe pagar impuestos
            //(si el sueldo supera a 3000).


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
