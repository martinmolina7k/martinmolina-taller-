using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
//2. Catálogo de Películas (Encapsulación, Validación y Composición)
//Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
//La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
//(un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
//asegurando mediante validaciones lógicas que:
// La duración en minutos sea estrictamente mayor a cero (0).
// La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
//un valor por defecto de 1).
//La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
//la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
//películas ordenadas de mayor a menor en base a su duración. Además, el método debe
//informar el título de la película con mejor calificación y cuál es la película más corta del
//catálogo.

{
    class Pelicula
    {
        private string titulo;
        private int duracionMinutos;
        private int calificacion;

        public Pelicula()
        {
            Console.WriteLine("Ingrese el titulo de la pelicula : ");
            titulo = Console.ReadLine();

            do
            {
                Console.WriteLine("Ingrese la duracion de la pelicula en minutos : ");
                duracionMinutos = int.Parse(Console.ReadLine());
            } while (duracionMinutos <= 0);

            Console.WriteLine("Ingrese la calificacion de la pelicula : ");
            calificacion = int.Parse(Console.ReadLine());
            if (calificacion <= 0 || calificacion > 5)
            {
                calificacion = 1;
            }
        }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public int DuracionMinutos { get { return duracionMinutos; } set { if (value > 0) { duracionMinutos = value; } } }
        public int Calificacion { get { return calificacion; } set { if (value > 0 && value <= 5) { calificacion = value; } else { calificacion = 1; } } }
    }

    class Catalogo
    {
        Pelicula[] peliculas = new Pelicula[3];

        public Catalogo()
        {
            for (int i = 0; i < peliculas.Length; i++)
            {
                peliculas[i] = new Pelicula();
            }
        }

        public void MostrarPeliculas()
        {
            for (int i = 0; i < peliculas.Length - 1; i++)
            {
                for (int j = 0; j < peliculas.Length - i - 1; j++)
                {
                    if (peliculas[j].DuracionMinutos < peliculas[j + 1].DuracionMinutos)
                    {
                        var temp = peliculas[j];
                        peliculas[j] = peliculas[j + 1];
                        peliculas[j + 1] = temp;
                    }
                }
            }

            foreach (var pelicula in peliculas)
            {
                Console.WriteLine($"Titulo: {pelicula.Titulo}, Duracion: {pelicula.DuracionMinutos} minutos, Calificacion: {pelicula.Calificacion}");
            }

            var merjorCalificada = peliculas[0];
            var masCorta = peliculas[0];

            for (int i = 0; i < peliculas.Length - 1; i++)
            {

                if (peliculas[i].Calificacion > merjorCalificada.Calificacion)
                {
                    merjorCalificada = peliculas[i];
                }

                if (peliculas[i].DuracionMinutos < masCorta.DuracionMinutos)
                {
                    masCorta = peliculas[i];
                }

            }

            Console.WriteLine($"La pelicula con mejor calificacion es : {merjorCalificada.Titulo} con una calificacion de {merjorCalificada.Calificacion}");
            Console.WriteLine($"La pelicula mas corta es : {masCorta.Titulo} con una duracion de {masCorta.DuracionMinutos} minutos");
        }

        static void Main(string[] args)
        {
            Catalogo catalogo = new Catalogo();
            catalogo.MostrarPeliculas();
        }
    }
}
