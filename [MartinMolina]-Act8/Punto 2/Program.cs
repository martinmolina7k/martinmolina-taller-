using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
            //algoritmo de ordenamiento alfabético.

            string[] paises = new string[5];

            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write("Ingrese un país: ");
                paises[i] = Console.ReadLine();
            }

            // Ordenamiento alfabético
            for (int i = 0; i < paises.Length - 1; i++)
            {
                for (int j = 0; j < paises.Length - 1 - i; j++)
                {
                    if (string.Compare(paises[j], paises[j + 1]) > 0)
                    {
                        string aux = paises[j];
                        paises[j] = paises[j + 1];
                        paises[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine("Países ordenados:");

            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i]);
                Console.ReadKey();

            }
        }
    }
}
