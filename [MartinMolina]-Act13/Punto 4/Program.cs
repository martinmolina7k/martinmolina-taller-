using System;

namespace Punto_4
{
    internal class Alumno
    {
        //4. Plantear una clase Alumno que tenga los atributos privados: nombre y un
        //vector de 4 notas.Definir un constructor que solicite el ingreso del nombre del
        //alumno y sus 4 calificaciones.
        //Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
        //Alumno.
        //Agregar los siguientes métodos:
        //a) Un método que imprima el nombre de cada alumno y su promedio.
        //b) Un método que muestre el nombre del alumno con el promedio más
        //alto.
        //c) Un método que indique qué alumnos tienen al menos una nota
        //desaprobada(nota menor a 6)

        private string nombre;
        private int[] notas;

        public Alumno()
        {
            Console.Write("Ingrese el nombre del alumno: ");
            string linea;
            linea = Console.ReadLine();
            nombre = linea;

            notas = new int[4];
            for (int f = 0; f < notas.Length; f++)
            {
                Console.Write("Ingrese la nota " + (f + 1) + ": ");
                linea = Console.ReadLine();
                notas[f] = int.Parse(linea);
            }
        }

        public string retornarnombre()
        {
            return nombre;
        }

        public float calcularpromedio()
        {
            int suma = 0;
            for (int f = 0; f < notas.Length; f++)
            {
                suma = suma + notas[f];
            }
            return (float)suma / notas.Length;
        }

        public bool tienedesaprobadas()
        {
            for (int f = 0; f < notas.Length; f++)
            {
                if (notas[f] < 6)
                {
                    return true;
                }
            }
            return false;
        }
    }

    internal class Curso
    {
        private Alumno[] alumnos;

        public Curso()
        {
            alumnos = new Alumno[3];
            for (int f = 0; f < alumnos.Length; f++)
            {
                alumnos[f] = new Alumno();
            }
        }

        public void imprimirpromedios()
        {
            Console.WriteLine("Promedios de los alumnos:");
            for (int f = 0; f < alumnos.Length; f++)
            {
                Console.WriteLine(alumnos[f].retornarnombre() + " - Promedio: " + alumnos[f].calcularpromedio());
            }
        }

        public void alumnomayorpromedio()
        {
            float mayorPromedio = alumnos[0].calcularpromedio();
            string nombreMayor = alumnos[0].retornarnombre();

            for (int f = 1; f < alumnos.Length; f++)
            {
                if (alumnos[f].calcularpromedio() > mayorPromedio)
                {
                    mayorPromedio = alumnos[f].calcularpromedio();
                    nombreMayor = alumnos[f].retornarnombre();
                }
            }
            Console.WriteLine("El alumno con el promedio mas alto es: " + nombreMayor);
        }

        public void alumnoscondesaprobadas()
        {
            Console.WriteLine("Alumnos con al menos una nota desaprobada (< 6):");
            for (int f = 0; f < alumnos.Length; f++)
            {
                if (alumnos[f].tienedesaprobadas())
                {
                    Console.WriteLine(alumnos[f].retornarnombre());
                }
            }
        }

        static void Main(string[] args)
        {
            Curso curso = new Curso();
            curso.imprimirpromedios();
            curso.alumnomayorpromedio();
            curso.alumnoscondesaprobadas();

            Console.ReadKey();
        }
    }
}

