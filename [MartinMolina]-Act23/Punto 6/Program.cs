using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*6-Una biblioteca pública gestiona de forma digital su catálogo de obras literarias
para organizar la consulta de ejemplares por parte de los lectores.
 Crear la clase Libro que contenga como atributos privados: titulo
(string) y anioPublicacion (int). Definir sus propiedades de solo lectura y
un constructor que reciba tit y anio.
 Crear la clase BibliotecaCentral que administre una lista de objetos
List.
 Métodos en BibliotecaCentral:
1. CargarCatalogo(): Solicitar por teclado títulos y años de
publicación para agregar libros a la lista mediante .Add(). La carga
finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como título.
2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
junto a la cantidad total de obras registradas mediante la propiedad
.Count.
3. FiltrarPorAnio(): Solicitar al usuario un año determinado e
imprimir en consola únicamente aquellos libros cuyo año de
publicación sea menor a dicho valor.
4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
los métodos de búsqueda y remoción de listas, eliminarlo de la
colección si se encuentra presente.*/

namespace Punto6
{
    class Libro
    {
        private string titulo;
        private int anioPublicacion;
        public string Titulo
        {
            get { return titulo; }
        }
        public int AnioPublicacion
        {
            get { return anioPublicacion; }
        }
        public Libro(string tit, int anio)
        {
            titulo = tit;
            anioPublicacion = anio;
        }
    }
    internal class BibliotecaCentral
    {
        List<Libro> catalogo = new List<Libro>();
        public void CargarCatalogo()
        {
            string titulo;
            int anio;
            do
            {
                Console.WriteLine("Ingrese el titulo del libro (ingrese 'FIN' para terminar):");
                titulo = Console.ReadLine();
                if (titulo != "FIN")
                {
                    Console.WriteLine("Ingrese el año de publicación del libro:");
                    anio = int.Parse(Console.ReadLine());
                    Libro libro = new Libro(titulo, anio);
                    catalogo.Add(libro);
                }
            } while (titulo != "FIN");
        }
        public void ListarCatalogo()
        {
            Console.WriteLine("Catalogo de libros:");
            foreach (var libro in catalogo)
            {
                Console.WriteLine($"Titulo: {libro.Titulo}, Año de publicacion: {libro.AnioPublicacion}");
            }
            Console.WriteLine($"Cantidad total de obras registradas: {catalogo.Count}");
        }
        public void FiltrarPorAnio()
        {
            Console.WriteLine("Ingrese un año para filtrar los libros publicados antes de ese año:");
            int anioFiltro = int.Parse(Console.ReadLine());
            var librosFiltrados = catalogo.Where(libro => libro.AnioPublicacion < anioFiltro).ToList();
            Console.WriteLine($"Libros publicados antes de {anioFiltro}:");
            foreach (var libro in librosFiltrados)
            {
                Console.WriteLine($"Titulo: {libro.Titulo}, Año de publicacion: {libro.AnioPublicacion}");
            }
        }
        public void RemoverLibro()
        {
            Console.WriteLine("Ingrese el titulo del libro que desea remover:");
            string tituloRemover = Console.ReadLine();
            var libroARemover = catalogo.FirstOrDefault(libro => libro.Titulo == tituloRemover);
            if (libroARemover != null)
            {
                catalogo.Remove(libroARemover);
                Console.WriteLine($"El libro '{tituloRemover}' ha sido removido del catalogo.");
            }
            else
            {
                Console.WriteLine($"El libro '{tituloRemover}' no se encuentra en el catalogo.");
            }
        }

        static void Main(string[] args)
        {
            BibliotecaCentral biblioteca = new BibliotecaCentral();
            biblioteca.CargarCatalogo();
            biblioteca.ListarCatalogo();
            biblioteca.FiltrarPorAnio();
            biblioteca.RemoverLibro();
            biblioteca.ListarCatalogo();
        }
    }
}