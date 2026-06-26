using System;

namespace Punto_2
{
    internal class Program
    {
        //2. Gestión de Complejo de Cine
        //Un cine tiene 4 salas con diferentes capacidades de espectadores(la Sala 1 tiene 10
        //asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
        //● Definir una matriz irregular de 4 filas para representar los asientos.
        //● Métodos:
        //1. Inicializar la matriz con los tamaños de las salas mencionadas(sin
        //intervención del operador).
        //2. Crear un método de &quot; Venta de Entradas & quot; que permita cargar la edad del
        //espectador en un asiento específico(fila y columna).
        //3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
        //en cada asiento.
        //4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
        //5. Informar cuál es el promedio de edad de los espectadores de todo el
        //complejo.


        private int[][] salas;

        public void inicializar()
        {
            salas = new int[4][];
            salas[0] = new int[10];
            salas[1] = new int[15];
            salas[2] = new int[8];
            salas[3] = new int[12];
        }

        public void ventaEntradas()
        {
            Console.Write("desea vender una entrada? (si/no): ");
            string linea;
            linea = Console.ReadLine();

            while (linea == "si")
            {
                Console.Write("ingrese el numero de sala (1 a 4): ");
                linea = Console.ReadLine();
                int nroSala = int.Parse(linea) - 1;

                Console.Write("ingrese el numero de asiento (1 a " + salas[nroSala].Length + "): ");
                linea = Console.ReadLine();
                int nroAsiento = int.Parse(linea) - 1;

                Console.Write("ingrese la edad del espectador: ");
                linea = Console.ReadLine();
                int edad = int.Parse(linea);

                salas[nroSala][nroAsiento] = edad;

                Console.Write("desea vender otra entrada? (si/no): ");
                linea = Console.ReadLine();
            }
        }

        public void imprimirOcupacion()
        {
            Console.WriteLine("mapa de ocupacion de las salas (edades):");
            for (int f = 0; f < salas.Length; f++)
            {
                Console.Write("sala " + (f + 1) + ": ");
                for (int c = 0; c < salas[f].Length; c++)
                {
                    Console.Write(salas[f][c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void contarMenores()
        {
            Console.WriteLine("cantidad de menores de edad por sala:");
            for (int f = 0; f < salas.Length; f++)
            {
                int cantMenores = 0;
                for (int c = 0; c < salas[f].Length; c++)
                {
                    if (salas[f][c] > 0 && salas[f][c] < 18)
                    {
                        cantMenores++;
                    }
                }
                Console.WriteLine("sala " + (f + 1) + ": " + cantMenores);
            }
        }

        public void promedioEdadComplejo()
        {
            int sumaEdades = 0;
            int totalEspectadores = 0;

            for (int f = 0; f < salas.Length; f++)
            {
                for (int c = 0; c < salas[f].Length; c++)
                {
                    if (salas[f][c] > 0)
                    {
                        sumaEdades = sumaEdades + salas[f][c];
                        totalEspectadores++;
                    }
                }
            }

            if (totalEspectadores > 0)
            {
                float promedio = (float)sumaEdades / totalEspectadores;
                Console.WriteLine("el promedio de edad de todo el complejo es: " + promedio);
            }
            else
            {
                Console.WriteLine("no hay espectadores en el complejo.");
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.inicializar();
            p.ventaEntradas();
            p.imprimirOcupacion();
            p.contarMenores();
            p.promedioEdadComplejo();

            Console.ReadKey();
        }
    }
}