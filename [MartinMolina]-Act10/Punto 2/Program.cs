using System;

namespace Punto_2
{
    internal class Program
    {
        // 2- Crear una matriz de n * m filas(cargar n y m por teclado) Intercambiar la
        //primer fila con la segunda.Imprimir luego la matriz.
        private int[,] mat;

        public void Cargar()
        {
            Console.Write("Ingrese cantidad de filas: ");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);

            Console.Write("Ingrese cantidad de columnas: ");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);

            mat = new int[filas, columnas];

            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write("Ingrese componente: ");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void Intercambiar()
        {
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                int aux = mat[0, c];
                mat[0, c] = mat[1, c];
                mat[1, c] = aux;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Matriz:");

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
            p.Intercambiar();
            p.Imprimir();

            Console.ReadKey();
        }
    }
}
