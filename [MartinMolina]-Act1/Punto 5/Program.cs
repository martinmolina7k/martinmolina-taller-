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
            //5. Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y el área del mismo (La circunferencia se calcula multiplicando el doble del radio por π (pi), y el área se calcula multiplicando π por el cuadrado del radio).

            int num1;
            double circunferencia, area;
            string linea;

            Console.Write("ingrese el radio del circulo: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            circunferencia = (num1 * 2) * Math.PI;
            area = Math.PI * (num1 * num1);

            Console.WriteLine("la circunferencia del circulo es: " + circunferencia);
            Console.WriteLine("el area del circulo es: " + area);

            Console.ReadKey();
        }
    }
}
