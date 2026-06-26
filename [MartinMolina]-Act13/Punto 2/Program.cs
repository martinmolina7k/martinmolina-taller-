using System;

namespace Punto_2
{
    internal class operaciones
    {
        //2. Implementar la clase operaciones.Se deben cargar dos valores enteros en el
        //constructor, calcular su suma, resta, multiplicación y división, cada una en un
        //método, imprimir dichos resultados.

        private int valor1;
        private int valor2;

        public operaciones()
        {
            Console.Write("ingrese primer valor: ");
            string linea;
            linea = Console.ReadLine();
            valor1 = int.Parse(linea);

            Console.Write("ingrese segundo valor: ");
            linea = Console.ReadLine();
            valor2 = int.Parse(linea);
        }

        public void sumar()
        {
            int suma = valor1 + valor2;
            Console.WriteLine("la suma es: " + suma);
        }

        public void restar()
        {
            int resta = valor1 - valor2;
            Console.WriteLine("la resta es: " + resta);
        }

        public void multiplicar()
        {
            int multiplicacion = valor1 * valor2;
            Console.WriteLine("la multiplicacion es: " + multiplicacion);
        }

        public void dividir()
        {
            if (valor2 != 0)
            {
                int division = valor1 / valor2;
                Console.WriteLine("la division es: " + division);
            }
            else
            {
                Console.WriteLine("no se puede dividir por cero.");
            }
        }

        static void Main(string[] args)
        {
            operaciones op = new operaciones();
            op.sumar();
            op.restar();
            op.multiplicar();
            op.dividir();

            Console.ReadKey();
        }
    }
}
