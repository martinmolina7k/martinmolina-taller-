using System;

namespace punto2
{
    /*Actividad 2: Posicionamiento de elementos en consola
Problema:
Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
 Implementar propiedades y un constructor que cargue valores.
 Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
nombre en pantalla y Console.CursorVisible para ocultar el cursor.
 Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
consola.*/

    internal class ElementoPantalla
    {
        private string nombre;
        private int posX;
        private int posY;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int PosX { get { return posX; } set { posX = value; } }
        public int PosY { get { return posY; } set { posY = value; } }

        public ElementoPantalla(string nombre, int posX, int posY)
        {
            this.Nombre = nombre;
            this.PosX = posX;
            this.PosY = posY;
        }

        public void Mostrar()
        {
            Console.Clear();
            Console.SetCursorPosition(PosX, PosY);
            Console.Write(Nombre);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ElementoPantalla[] elementos = new ElementoPantalla[4];

            for (int i = 0; i < elementos.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre a mostrar");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese en que posicion horizontal");
                int posx = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese en que posicion vertical");
                int posy = int.Parse(Console.ReadLine());
                ElementoPantalla elemento = new ElementoPantalla(nombre, posx, posy);
                elementos[i] = elemento;
            }


            foreach (var elemento in elementos)
            {
                elemento.Mostrar();
            }

            Console.ReadKey();
        }
    }
}