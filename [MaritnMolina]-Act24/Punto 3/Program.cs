using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*9- Un instituto de enseñanza registra de forma dinámica a sus estudiantes para
realizar el seguimiento académico de sus materias.
 Crear la clase Estudiante que contenga como atributos privados:
nombreCompleto (string) y calificacion (double). Definir sus propiedades
de solo lectura y un constructor que reciba nom y cal.
 Crear la clase GestionAcademica que administre una lista de objetos
List.
 Métodos en GestionAcademica:
o CargarEstudiantes(): Solicitar por teclado nombres y
calificaciones para agregar estudiantes a la lista mediante .Add(). La
carga finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como
nombre.
o ListarEstudiantes(): Mostrar en pantalla todos los alumnos
junto a la cantidad total de inscriptos mediante la propiedad .Count.
o FiltrarAprobados(): Recorrer la lista e imprimir en consola
únicamente aquellos estudiantes cuya calificación sea mayor o igual
a 6.0.
o DarDeBaja(): Pedir al operador el nombre de un estudiante y,
utilizando los métodos de búsqueda y remoción de listas, eliminarlo
de la colección si se encuentra presente.*/

namespace Punto3
{
    class Estudiante
    {
        private string nombreCompleto;
        private int calificacion;
        public string NombreCompleto
        {
            get { return nombreCompleto; }
        }
        public int Calificacion
        {
            get { return calificacion; }
        }
        public Estudiante(string nom, int cal)
        {
            nombreCompleto = nom;
            calificacion = cal;
        }
    }
    internal class GestionAcademica
    {
        List<Estudiante> Lista = new List<Estudiante>();
        public void CargarEstudiantes()
        {
            string nombre;
            int calif;
            do
            {
                Console.WriteLine("Ingrese el titulo del estudiante (ingrese 'FIN' para terminar):");
                nombre = Console.ReadLine();
                if (nombre != "FIN")
                {
                    Console.WriteLine("Ingrese la calificacion del estudiante:");
                    calif = int.Parse(Console.ReadLine());
                    Estudiante estudiante = new Estudiante(nombre, calif);
                    Lista.Add(estudiante);
                }
            } while (nombre != "FIN");
        }
        public void ListarEstudiante()
        {
            Console.WriteLine("Lista de estudiantes:");
            foreach (var estudiante in Lista)
            {
                Console.WriteLine($"Nombre: {estudiante.NombreCompleto}, Calificacion: {estudiante.Calificacion}");
            }
            Console.WriteLine($"Cantidad total de estudiantes inscriptos: {Lista.Count}");
        }

        public void FiltrarAprobados()
        {
            Console.WriteLine($"Estudiantes Aprobados:");
            foreach (var estudiante in Lista)
            {
                if (estudiante.Calificacion >= 6)
                {
                    Console.WriteLine($"Nombre: {estudiante.NombreCompleto}, Calificacion: {estudiante.Calificacion}");
                }
            }
        }

        public void DarDeBaja()
        {
            Console.WriteLine("Ingrese el titulo del libro que desea remover:");
            string nombreBaja = Console.ReadLine();
            var EstudianteABaja = Lista.FirstOrDefault(estudiante => estudiante.NombreCompleto == nombreBaja);
            if (EstudianteABaja != null)
            {
                Lista.Remove(EstudianteABaja);
                Console.WriteLine($"El libro '{nombreBaja}' ha sido removido del catalogo.");
            }
            else
            {
                Console.WriteLine($"El libro '{nombreBaja}' no se encuentra en el catalogo.");
            }
        }
        static void Main(string[] args)
        {
            GestionAcademica academia = new GestionAcademica();
            academia.CargarEstudiantes();
            academia.ListarEstudiante();
            academia.FiltrarAprobados();
            academia.DarDeBaja();
            Console.ReadKey();
        }
    }
}
