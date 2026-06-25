using System;

namespace Punto_3
{
    internal class Program
    {
        //3. Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
        //carrera de 100 metros.El programa debe cargar los datos en dos vectores
        //paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
        //atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
        //promedio.

        private string[] nombres;
        private double[] tiempo;
        

        public void cargar()
        {
            nombres = new string[5];
            tiempo = new double[100];
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("ingrese el nombre del atleta: ");
                nombres[f] = Console.ReadLine();
                Console.Write("inngrese el tiempo: ");
                string linea;
                linea = Console.ReadLine();
                tiempo[f] = double.Parse(linea);
            }
        }
        public void promedio()
        {
            double suma = 0;

            for (int i = 0; i < tiempo.Length; i++)
            {
                suma += tiempo[i];
            }

            double promedio = suma / tiempo.Length;

            Console.WriteLine("el promedio es: " + promedio);
            Console.WriteLine("Superaron el promedio: ");
            for (int i = 0; i < tiempo.Length; i++) ;
            {
                int f = 0;

                if (tiempo[f] < promedio)
                {
                    Console.WriteLine(nombres[f]);
                }

            }
        }


        public void atmejor()
        {

            double atmejor;
            int pos;

            atmejor = tiempo[0];
            pos = 0;
            for (int f = 1; f < nombres.Length; f++)
            {
                if (tiempo[f] < atmejor)
                {
                    atmejor = tiempo[f];
                    pos = f;
                }


            }
            Console.WriteLine();
            Console.WriteLine("el atleta: " + nombres[pos]);
            Console.WriteLine("tiene una puntuacion mejor: " + atmejor);
        }
        public void atpeor()
        {
            double atpeor;
            int pos;

            atpeor = tiempo[0];
            pos = 0;
            for (int f = 1; f < nombres.Length; f++)
            {
                if (tiempo[f] > atpeor)
                {
                    atpeor = tiempo[f];
                    pos = f;
                }


            }
            Console.WriteLine();
            Console.WriteLine("el atleta: " + nombres[pos]);
            Console.WriteLine("tiene una puntuacion peor: " + atpeor);
            Console.WriteLine();
        }



        static void Main(string[] args)
        {
            Program ats = new Program();
            ats.cargar();
            ats.atmejor();
            ats.atpeor();
            ats.promedio();
            Console.ReadKey();
        }
    }
}




