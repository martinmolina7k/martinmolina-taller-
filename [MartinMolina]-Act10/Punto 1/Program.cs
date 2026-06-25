using System;

namespace Punto_1
{
    internal class Program
    {
        //1- Crear una matriz de 2 filas y 5 columnas.Realizar la carga de
        //componentes por columna(es decir primero ingresar toda la primer
        //columna, luego la segunda columna y así sucesivamente)
        //Imprimir luego la matriz.

        private int[,] mat;

        public void Cargar()
        {
            mat = new int[2, 5];

            for (int c = 0; c < mat.GetLength(1); c++)
            {
                for (int f = 0; f < mat.GetLength(0); f++)
                {
                    Console.Write("Ingrese componente: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Matriz completa:");

            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.Imprimir();

            Console.ReadKey();
        }
    }
}