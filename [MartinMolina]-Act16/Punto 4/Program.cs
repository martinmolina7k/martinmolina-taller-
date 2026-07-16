using System;

namespace Punto_4
{
    //4. Armar tres clases: Animal, Mamífero y Perro.
    //La clase Animal debe tener un atributo especie.
    //La clase Mamífero, que hereda de Animal, debe tener un atributo
    //tipoAlimentacion.
    //La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
    //Cada clase debe tener un constructor que reciba los datos correspondientes
    //y los imprima indicando a qué clase pertenecen. Los datos deben ser
    //asignados previamente
    //Crear un objeto de la clase Perro y verificar la ejecución en cadena de los
    //constructores.

    internal class Animal
    {
        private string especie;

        public Animal(string e)
        {
            especie = e;
            Console.WriteLine($"Especie :{especie}");
        }

    }

    internal class Mamifero : Animal
    {
        private string tipoAlimentacion;

        public Mamifero(string e, string t) : base(t)
        {
            tipoAlimentacion = t;
            Console.WriteLine($"Tipo de alimentacion :{tipoAlimentacion}");
        }

    }

    internal class Perro : Mamifero
    {
        private string nombre;

        public Perro(string n, string e, string t) : base(e, t)
        {
            nombre = n;
            Console.WriteLine($"Nombre :{nombre}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro("Queque", "Canino", "Carnivoro");
            Console.ReadKey();
        }
    }
}
