using System;

namespace Punto_1
{
    //1. Confeccionar una clase Persona que tenga como atributos el nombre y la
    //edad (definir las propiedades para poder acceder a dichos atributos). Definir
    //un método para imprimirlos. Plantear una segunda clase Empleado que
    //herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
    //método para imprimir su sueldo. Definir un objeto de la clase Persona y
    //llamar a sus métodos y propiedades. También crear un objeto de la clase
    //Empleado y llamar a sus métodos y propiedades.

    internal class Persona
    {
        private string nombre;
        private int edad;

        public Persona()
        {
            Console.WriteLine("Ingrese el nombre de la persona: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de la persona: ");
            edad = int.Parse(Console.ReadLine());
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
        }
    }

    internal class Empleado : Persona
    {
        private double sueldo;

        public Empleado()
        {
            Console.WriteLine("Ingrese el sueldo del empleado: ");
            sueldo = double.Parse(Console.ReadLine());
        }

        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
        public void ImprimirSueldo()
        {
            Console.WriteLine($"Sueldo: {sueldo}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Empleado empleado = new Empleado();
            persona.Imprimir();
            empleado.Imprimir();
            empleado.ImprimirSueldo();
        }
    }
}
