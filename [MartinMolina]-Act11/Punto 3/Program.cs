using System;

namespace Punto_3
{
    internal class Program
    {
        //3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
        //empresa.
        //Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
        //irregular para cargar los días que han faltado cada empleado(cargar el número de día que
        //faltó)
        //Cada fila de la matriz representa los días de cada empleado.
        //a.Mostrar los empleados con la cantidad de inasistencias.
        //b.Cuál empleado faltó menos días.

        private string[] empleados;
        private int[][] inasistencias;

        public void cargar()
        {
            empleados = new string[3];
            inasistencias = new int[3][];

            for (int f = 0; f < empleados.Length; f++)
            {
                Console.Write("ingrese el nombre del empleado: ");
                string linea;
                linea = Console.ReadLine();
                empleados[f] = linea;

                Console.Write("cuantos dias falto el empleado " + empleados[f] + ": ");
                linea = Console.ReadLine();
                int faltas = int.Parse(linea);
                inasistencias[f] = new int[faltas];

                for (int c = 0; c < inasistencias[f].Length; c++)
                {
                    Console.Write("ingrese el numero de dia que falto: ");
                    linea = Console.ReadLine();
                    inasistencias[f][c] = int.Parse(linea);
                }
            }
        }

        public void mostrarInasistencias()
        {
            Console.WriteLine("inasistencias de los empleados:");
            for (int f = 0; f < empleados.Length; f++)
            {
                Console.WriteLine(empleados[f] + " tiene " + inasistencias[f].Length + " inasistencias.");
            }
        }

        public void empleadoMenosFaltas()
        {
            int menosFaltas = inasistencias[0].Length;
            string empleadoMenos = empleados[0];

            for (int f = 1; f < inasistencias.Length; f++)
            {
                if (inasistencias[f].Length < menosFaltas)
                {
                    menosFaltas = inasistencias[f].Length;
                    empleadoMenos = empleados[f];
                }
            }
            Console.WriteLine("el empleado que falto menos dias es: " + empleadoMenos);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.cargar();
            p.mostrarInasistencias();
            p.empleadoMenosFaltas();

            Console.ReadKey();
        }
    }
}
