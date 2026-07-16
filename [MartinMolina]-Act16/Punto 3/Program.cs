using System;

namespace Punto_3
{
    //3. Crear una clase base Vehículo que contenga atributos marca y
    //velocidadMaxima.
    //Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
    //una debe tener un constructor que reciba los valores de los atributos base
    //mediante la palabra clave base, y un atributo propio (cantidadPuertas en
    //Auto, cilindrada en Moto).
    //Crear un objeto de cada clase y mostrar todos sus datos por consola.

    internal class Vehiculo
    {
        private string marca;
        private int velocidadMaxima;

        public Vehiculo(string a, int v)
        {
            marca = a;
            velocidadMaxima = v;
        }
    }

    internal class Auto : Vehiculo
    {
        private int cantidadPuertas;

        public Auto(int c, string a, int v) : base(a, v)
        {
            cantidadPuertas = c;
            Console.WriteLine($"Auto  Marca: {a}, Velocidad maxima: {v}, Cantidad de puertas: {c}");
        }

    }

    internal class Moto : Vehiculo
    {
        private int cilindrada;

        public Moto(int c, string a, int v) : base(a, v)
        {
            cilindrada = c;
            Console.WriteLine($"Moto  Marca: {a}, Velocidad maxima: {v}, Cilindrada: {c}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto(4, "Toyota", 180);
            Moto moto = new Moto(250, "Honda", 160);
            Console.ReadKey();
        }
    }
}
