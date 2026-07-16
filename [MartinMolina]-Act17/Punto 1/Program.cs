using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1

//1. Personal de un Gimnasio (Herencia Simple y Propiedades)
//Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
//Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un
//método para imprimir estos datos básicos.
//Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
//un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
//para imprimir todos los datos del profesor (incluyendo los heredados).
//En el programa principal (Main):
// Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
//llamar a su método de impresión.
// Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
//que puede acceder tanto a sus métodos propios como a los de la clase base.

{
    internal class PersonaGimnasio
    {
        private string nombre;
        private int dni;

        public PersonaGimnasio()
        {
            Console.WriteLine("ingrese el nombre de la persona : ");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese el dni de la persona : ");
            dni = int.Parse(Console.ReadLine());
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Dni { get { return dni; } set { dni = value; } }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre : {nombre}, Dni : {dni}");
        }

    }

    internal class Profesor : PersonaGimnasio
    {
        private string especialidad;

        public Profesor()
        {
            Console.WriteLine("ingrese la especialidad del profesor : ");
            especialidad = Console.ReadLine();
        }
        public string Especialidad { get { return especialidad; } set { especialidad = value; } }

        public void ImprimirProfesor()
        {
            Console.WriteLine($"Nombre : {Nombre}, Dni : {Dni}, Especialidad : {especialidad}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonaGimnasio persona = new PersonaGimnasio();
            Profesor profesor = new Profesor();
            persona.Imprimir();
            profesor.ImprimirProfesor();
            Console.ReadKey();
        }
    }
}
