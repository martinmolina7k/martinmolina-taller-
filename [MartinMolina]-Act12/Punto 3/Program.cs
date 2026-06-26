using System;

namespace Punto_3
{
    internal class Program
    {
        //3. Academia de Gastronomía: Recetario Dinámico
        //Un chef instructor evalúa a 3 alumnos en un examen final.Cada alumno debe presentar
        //una cantidad distinta de platos(uno presenta 2 platos, otro 4 y otro 3).
        //● Definir un vector para los nombres de los alumnos.
        //● Definir una matriz irregular para cargar el puntaje obtenido(0 a 100) en cada plato
        //presentado.
        //● Métodos:
        //1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
        //de cada alumno.
        //2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
        //3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
        //4. Calcular el puntaje promedio de cada alumno e informar si está &quot; Aprobado&quot;
        //(promedio &gt;= 70) o &quot;Reprobado&quot;.
        //5. Determinar quién obtuvo el puntaje individual más alto en un solo plato(el
        //valor máximo de la matriz).

        private string[] alumnos;
        private int[][] puntajes;

        public void cargar()
        {
            alumnos = new string[3];
            puntajes = new int[3][];

            for (int f = 0; f < alumnos.Length; f++)
            {
                Console.Write("ingrese el nombre del alumno: ");
                string linea;
                linea = Console.ReadLine();
                alumnos[f] = linea;

                Console.Write("cuantos platos presentara " + alumnos[f] + ": ");
                linea = Console.ReadLine();
                int cantidadPlatos = int.Parse(linea);
                puntajes[f] = new int[cantidadPlatos];

                for (int c = 0; c < puntajes[f].Length; c++)
                {
                    Console.Write("ingrese puntaje para el plato " + (c + 1) + " (0-100): ");
                    linea = Console.ReadLine();
                    int nota = int.Parse(linea);

                    while (nota < 0 || nota > 100)
                    {
                        Console.Write("puntaje invalido. Ingrese nuevamente (0-100): ");
                        linea = Console.ReadLine();
                        nota = int.Parse(linea);
                    }
                    puntajes[f][c] = nota;
                }
            }
        }

        public void listadoalumnos()
        {
            Console.WriteLine("listado de alumnos y sus puntajes:");
            for (int f = 0; f < puntajes.Length; f++)
            {
                Console.Write(alumnos[f] + ": ");
                for (int c = 0; c < puntajes[f].Length; c++)
                {
                    Console.Write(puntajes[f][c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void calcularpromedioyestado()
        {
            Console.WriteLine("condicion de los alumnos:");
            for (int f = 0; f < puntajes.Length; f++)
            {
                int suma = 0;
                for (int c = 0; c < puntajes[f].Length; c++)
                {
                    suma = suma + puntajes[f][c];
                }
                float promedio = (float)suma / puntajes[f].Length;

                if (promedio >= 70)
                {
                    Console.WriteLine(alumnos[f] + " - promedio: " + promedio + " - aprobado");
                }
                else
                {
                    Console.WriteLine(alumnos[f] + " - promedio: " + promedio + " - reprobado");
                }
            }
        }

        public void puntajemasalto()
        {
            int notaMaxima = puntajes[0][0];
            string alumnoMaximo = alumnos[0];

            for (int f = 0; f < puntajes.Length; f++)
            {
                for (int c = 0; c < puntajes[f].Length; c++)
                {
                    if (puntajes[f][c] > notaMaxima)
                    {
                        notaMaxima = puntajes[f][c];
                        alumnoMaximo = alumnos[f];
                    }
                }
            }
            Console.WriteLine("el puntaje individual mas alto fue de " + notaMaxima + " puntos y pertenece a " + alumnoMaximo);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.cargar();
            p.listadoalumnos();
            p.calcularpromedioyestado();
            p.puntajemasalto();

            Console.ReadKey();
        }
    }
}
