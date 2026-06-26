using System;

namespace Punto_1
{
    internal class Program
    {
        //1. Sistema de Logística: Envíos por Sucursal
        //Una empresa de correo tiene 3 sucursales principales.Cada sucursal procesa una
        //cantidad diferente de paquetes por día dependiendo de su demanda.
        // ● Definir un vector de tipo string para los nombres de las 3 sucursales.
        // ● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
        //  represente el peso (en kg) de cada paquete enviado.
        //  ● Métodos:
        //1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
        // paquetes se enviaron hoy para definir el tamaño de su fila.
        // 2. Cargar el peso de cada paquete.
        //3. Imprimir el peso de todos los paquetes organizados por sucursal.
        //4. Calcular e informar el peso total despachado por cada sucursal.
        //5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
        //pertenece.

        private string[] sucursales;
        private int[][] paquetes;

        public void    cargar()
        {
            sucursales = new string[3];
            paquetes = new int[3][];

            for (int f = 0; f < sucursales.Length; f++)
            {
                Console.Write("ingrese el nombre de la sucursal: ");
                string linea;
                linea = Console.ReadLine();
                sucursales[f] = linea;

                Console.Write("cuantos paquetes se enviaron hoy en " + sucursales[f] + ": ");
                linea = Console.ReadLine();
                int cantidad = int.Parse(linea);
                paquetes[f] = new int[cantidad];

                for (int c = 0; c < paquetes[f].Length; c++)
                {
                    Console.Write("ingrese el peso del paquete " + (c + 1) + ": ");
                    linea = Console.ReadLine();
                    paquetes[f][c] = int.Parse(linea);
                }
            }
        }

        public void imprimirPaquetes()
        {
            Console.WriteLine("pesos de paquetes por sucursal:");
            for (int f = 0; f < paquetes.Length; f++)
            {
                Console.Write(sucursales[f] + ": ");
                for (int c = 0; c < paquetes[f].Length; c++)
                {
                    Console.Write(paquetes[f][c] + " kg ");
                }
                Console.WriteLine();
            }
        }

        public void pesoTotalPorSucursal()
        {
            Console.WriteLine("peso total despachado:");
            for (int f = 0; f < paquetes.Length; f++)
            {
                int suma = 0;
                for (int c = 0; c < paquetes[f].Length; c++)
                {
                    suma = suma + paquetes[f][c];
                }
                Console.WriteLine(sucursales[f] + ": " + suma + " kg");
            }
        }

        public void paqueteMasPesado()
        {
            int mayorPeso = paquetes[0][0];
            string sucursalMayor = sucursales[0];

            for (int f = 0; f < paquetes.Length; f++)
            {
                for (int c = 0; c < paquetes[f].Length; c++)
                {
                    if (paquetes[f][c] > mayorPeso)
                    {
                        mayorPeso = paquetes[f][c];
                        sucursalMayor = sucursales[f];
                    }
                }
            }
            Console.WriteLine("el paquete mas pesado de toda la empresa pesa " + mayorPeso + " kg y pertenece a la sucursal " + sucursalMayor);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.cargar();
            p.imprimirPaquetes();
            p.pesoTotalPorSucursal();
            p.paqueteMasPesado();

            Console.ReadKey();
        }
    }
}
