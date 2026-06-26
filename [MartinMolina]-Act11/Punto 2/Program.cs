using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class Program
    {
        //2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
        // primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
        // (crearla sin la intervención del operador)
        //Realizar la carga por teclado e imprimir posteriormente.


        private int[][] mat;

        public void cargar()
        {
            mat = new int[5][];

            for (int f = 0; f < mat.Length; f++)
            {
                mat[f] = new int[f + 1];
            }

            for (int f = 0; f < mat.Length; f++)
            {
                for (int c = 0; c < mat[f].Length; c++)
                {
                    Console.Write("ingrese componente para fila " + f + " columna " + c + ": ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f][c] = int.Parse(linea);
                }
            }
        }

        public void imprimir()
        {
            Console.WriteLine("matriz Irregular:");
            for (int f = 0; f < mat.Length; f++)
            {
                for (int c = 0; c < mat[f].Length; c++)
                {
                    Console.Write(mat[f][c] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.cargar();
            p.imprimir();

            Console.ReadKey();
        }
    }
}
}
