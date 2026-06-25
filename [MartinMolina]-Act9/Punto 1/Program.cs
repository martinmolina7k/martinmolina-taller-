using System;

namespace Punto_1
{
    internal class Program
    {
        //1. Se desea desarrollar un programa que permita registrar los nombres y las
        //calificaciones de 6 estudiantes.Luego de cargar los datos, se debe mostrar el
        //nombre del estudiante con la nota más alta, junto con su nota.Al igual que el
        //estudiante con la nota más baja.Informar si hay estudiantes con la misma nota
        //máxima o mínima.
        private string[] nombres;
        private float[] califig;

        public void Cargar()
        {
            nombres = new string[6];
            califig = new float[6];
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("ingrese el nombre del alumno: ");
                nombres[f] = Console.ReadLine();
                Console.Write("inngrese la nota: ");
                string linea;
                linea = Console.ReadLine();
                califig[f] = float.Parse(linea);

            }

        }

        public void mayornota()
        {

            float mayor;
            int pos;

            mayor = califig[0];
            pos = 0;
            for (int f = 1; f < nombres.Length; f++)
            {
                if (califig[f] > mayor)
                {
                    mayor = califig[f];
                    pos = f;
                }


            }

            Console.WriteLine("alumno con mayor nota es: " + nombres[pos]);
            Console.WriteLine("tiene una nota de: " + mayor);

        }
        public void menornota()
        {
            float menor;
            int pos;

            menor = califig[0];
            pos = 0;
            for (int f = 1; f < nombres.Length; f++)
            {
                if (califig[f] < menor)
                {
                    menor = califig[f];
                    pos = f;
                }
            }
            Console.WriteLine("alumno con menor nota es: " + nombres[pos]);
            Console.WriteLine("tiene una nota de: " + menor);

        }

        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.Cargar();
            pv.mayornota();
            pv.menornota();
            Console.ReadKey();


        }
    }
}
