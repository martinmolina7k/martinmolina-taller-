using System;

namespace Punto_4
{
    class Program
    {
        //4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
        //habitantes de este.Ordenar alfabéticamente e imprimir los resultados.Por último
        //ordenar con respecto a la cantidad de habitantes(de mayor a menor) e imprimir
        //nuevamente.

        private string[] paises;
        private int[] canthab;
        private int k;

        public void cargar()
        {
            paises = new string[5];
            canthab = new int[5];
            for (int f = 0; f < paises.Length; f++)
            {
                Console.Write("ingrese nombre:");
                paises[f] = Console.ReadLine();
                Console.Write("ingrese habitantes:");
                string linea;
                linea = Console.ReadLine();
                canthab[f] = int.Parse(linea);
            }
        }

        public void orden()
        {
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
            Console.WriteLine("--------Países ordenados--------");

            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i]);
            }

        }

        public void mayormenor()
        {
            Console.WriteLine("--------Ordenado por cantidad de habitantes--------");
            Array.Sort(canthab);
            for (int i = 0; i < paises.Length; i++)
            {
                
                Console.WriteLine(canthab[i]);

            }
            Console.WriteLine("");
            

        }


        static void Main(string[] args)
        {
            Program m = new Program();
            m.cargar();
            m.orden();
            m.mayormenor();
            Console.ReadKey();



        }
    }
}
