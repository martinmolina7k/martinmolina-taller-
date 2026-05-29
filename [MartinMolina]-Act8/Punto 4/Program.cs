using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
            //habitantes de este.Ordenar alfabéticamente e imprimir los resultados. Por último
            //ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
            //nuevamente.


            string[] paises = new string[5];
            int[] habitantes = new int[5];

            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write("Ingrese el nombre del país: ");
                paises[i] = Console.ReadLine();

                Console.Write("Ingrese la cantidad de habitantes: ");
                habitantes[i] = int.Parse(Console.ReadLine());
            }

            // Ordenar alfabéticamente
            for (int i = 0; i < paises.Length - 1; i++)
            {
                for (int j = 0; j < paises.Length - 1 - i; j++)
                {
                    if (string.Compare(paises[j], paises[j + 1]) > 0)
                    {
                        // Intercambiar países
                        string auxPais = paises[j];
                        paises[j] = paises[j + 1];
                        paises[j + 1] = auxPais;

                        // Intercambiar habitantes
                        int auxHab = habitantes[j];
                        habitantes[j] = habitantes[j + 1];
                        habitantes[j + 1] = auxHab;
                    }
                }
            }

            Console.WriteLine("\nOrden alfabético:");

            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i] + " - " + habitantes[i]);
            }

            // Ordenar por habitantes de mayor a menor
            for (int i = 0; i < habitantes.Length - 1; i++)
            {
                for (int j = 0; j < habitantes.Length - 1 - i; j++)
                {
                    if (habitantes[j] < habitantes[j + 1])
                    {
                        // Intercambiar habitantes
                        int auxHab = habitantes[j];
                        habitantes[j] = habitantes[j + 1];
                        habitantes[j + 1] = auxHab;

                        // Intercambiar países
                        string auxPais = paises[j];
                        paises[j] = paises[j + 1];
                        paises[j + 1] = auxPais;
                    }
                }
            }

            Console.WriteLine("\nOrden por habitantes (mayor a menor):");

            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i] + " - " + habitantes[i]);
                Console.ReadKey();
            }
        }
    }
}
   