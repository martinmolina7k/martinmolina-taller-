using System;

namespace Punto_4
{
    //   4. Se realiza una evaluación a 6 docentes por parte de sus alumnos.Se registran
    //sus nombres y puntajes promedio obtenidos (de 1 a 10).

    //Cargar sus datos en vectores paralelos, mostrar docente con calificación más
    //alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
    //calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
    //desaprobaron(tomando como base que se aprueba con una nota mayor o igual
    //a 6)
    internal class Program
    {
        private string[] nombres;
        private float[] puntaje;


        public void cargar()
        {
            nombres = new string[6];
            puntaje = new float[6];
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("ingrese el nombre del docente: ");
                nombres[f] = Console.ReadLine();
                Console.Write("inngrese el puntaje: ");
                string linea;
                linea = Console.ReadLine();
                puntaje[f] = float.Parse(linea);
            }
        }

        public void promedio()
        {
            double suma = 0;

            for (int i = 0; i < puntaje .Length; i++)
            {
                suma += puntaje [i];
            }

            double promedio = suma / puntaje.Length;

            Console.WriteLine("-------------------------");
            Console.WriteLine("el promedio de los docentes es: " + promedio);
            

            for (int i = 0; i < puntaje.Length; i++) ;
            {
                int f = 0;
                if (puntaje[f] < promedio)
                {
                    Console.WriteLine(nombres[f]);
                }

            }
        }

        public void docalto()
        {

           float docalto;
            int pos;

            docalto = puntaje[0];
            pos = 0;
            for (int f = 1; f < nombres.Length; f++)
            {
                if (puntaje[f] > docalto)
                {
                    docalto = puntaje[f];
                    pos = f;
                }
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("el docente: " + nombres[pos]);
            Console.WriteLine("tiene un puntaje alto de: " + docalto);
        }
        public void docbajo()
        {
            float docbajo;
            int pos;

            docbajo = puntaje[0];
            pos = 0;
            for (int f = 1; f < nombres.Length; f++)
            {
                if (puntaje[f] < docbajo)
                {
                    docbajo = puntaje[f];
                    pos = f;
                }
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("el docente: " + nombres[pos]);
            Console.WriteLine("tiene un puntaje bajo de: " + docbajo);
            Console.WriteLine("-------------------------");
        }

        public void desaprob()
        {
            Console.WriteLine("--------desaprobaron--------");
            
            for (int i = 6; i > nombres.Length; i++)
            {
                Console.WriteLine(puntaje[i]);
            }
            Console.WriteLine("");
        }

        public void ordenar()
        {
            for (int i = 0; i < nombres.Length - 1; i++)
            {
                for (int j = i + 1; j < nombres.Length; j++)
                {
                    if (puntaje[i] < puntaje[j])
                    {
                        float auxP = puntaje[i];
                        puntaje[i] = puntaje[j];
                        puntaje[j] = auxP;

                        string auxN = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = auxN;
                    }
                }
            }

            Console.WriteLine("Docentes ordenados de mayor a menor:");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i] + " - " + puntaje[i]);
            }
        }


        public void aprobadosdesaprobados()
        {
            int aprobados = 0;
            int desaprobados = 0;

            for (int i = 0; i < nombres.Length; i++)
            {
                if (puntaje[i] >= 6)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Cantidad de aprobados: " + aprobados);
            Console.WriteLine("Cantidad de desaprobados: " + desaprobados);
            Console.WriteLine("-------------------------");
        }


        static void Main(string[] args)
        {
            Program dc = new Program();
            dc.cargar();
            dc.promedio();
            dc.docalto();
            dc.docbajo();
            dc.ordenar();
            dc.aprobadosdesaprobados();
            Console.ReadKey();
        }
    }
}
