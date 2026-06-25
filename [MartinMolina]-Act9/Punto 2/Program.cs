using System;

namespace Punto_2
{
    internal class Program
    {
        //2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
        //realizadas por cada uno en un mes.Cargar los nombres y ventas en dos
        //vectores paralelos, ordenar los datos de mayor a menor según las ventas,
        //imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
        //el que menos vendió de los 5 empleados.
        private string[] nombres;
        private double[] ventas;

        public void cargar()
        {
            nombres = new string[5];
            ventas = new double[5];
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("ingrese el nombre del empleado:");
                nombres[f] = Console.ReadLine();
                Console.Write("ingrese sueldo:");
                string linea;
                linea = Console.ReadLine();
                ventas[f] = double.Parse(linea);
            }
        }
        public void ordenar()
        {
            for (int i = 0; i < ventas.Length - 1; i++)
            {
                for (int k = i; k < ventas.Length; k++)
                {
                    if (ventas[i] < ventas[k])
                    {
                        double auxventa = ventas[i];
                        ventas[i] = ventas[k];
                        ventas[k] = auxventa;

                        string auxnom = nombres[i];
                        nombres[i] = nombres[k];
                        nombres[k] = auxnom;
                    }
                }
            }

        }

        public void imprimir()
        {
            Console.WriteLine();
            Console.WriteLine("lista ordenada:");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i] + " = " + ventas[i]);
            }

            Console.WriteLine("menor vendedor: " + nombres[nombres.Length - 1]);

        }


        static void Main(string[] args)
        {
            Program gg = new Program();
            gg.cargar();
            gg.ordenar();
            gg.imprimir();
            Console.ReadKey();

        }
    }
}
