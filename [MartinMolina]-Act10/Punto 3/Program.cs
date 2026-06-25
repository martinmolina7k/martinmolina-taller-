using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    internal class Program
    {
        //3- Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
        //cuatro valores que se encuentran en los vértices de la misma(mat[0][0]
        //etc.)

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

        public void Vertices()
        {
            Console.WriteLine("Vertice superior izquierdo: " + mat[0, 0]);
            Console.WriteLine("Vertice superior derecho: " + mat[0, mat.GetLength(1) - 1]);
            Console.WriteLine("Vertice inferior izquierdo: " + mat[mat.GetLength(0) - 1, 0]);
            Console.WriteLine("Vertice inferior derecho: " + mat[mat.GetLength(0) - 1, mat.GetLength(1) - 1]);
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            p.Cargar();
            p.Vertices();

            Console.ReadKey();
        }
    }
}