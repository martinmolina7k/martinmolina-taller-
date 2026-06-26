using System;

namespace Punto_1
{
    internal class empleado 
    {
        //1. Confeccionar una clase que represente un empleado.Definir como atributos su
        //nombre y su sueldo.En el constructor cargar los atributos y luego en otro
        //método imprimir sus datos y por último uno que imprima un mensaje si debe
        //pagar impuestos(si el sueldo supera a 3000)

        private string nombre;
        private int sueldo;

        public empleado()
        {
            Console.Write("ingrese el nombre del empleado: ");
            string linea;
            linea = Console.ReadLine();
            nombre = linea;

            Console.Write("ingrese el sueldo: ");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }

        public void imprimir()
        {
            Console.WriteLine("nombre: " + nombre);
            Console.WriteLine("sueldo: " + sueldo);
        }

        public void pagaimpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Debe pagar impuestos.");
            }
            else
            {
                Console.WriteLine("No paga impuestos.");
            }
        }

        static void Main(string[] args)
        {
            empleado emp = new empleado();
            emp.imprimir();
            emp.pagaimpuestos();

            Console.ReadKey();
        }
    }
}
