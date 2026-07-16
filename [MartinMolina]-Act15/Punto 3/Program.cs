using System;

namespace Punto_3
{

    //3. Geolocalización de Reservas Naturales
    //Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
    //especies protegidas en cuadrículas de territorio.
    //● Confeccionar la clase ReservaNatural que tenga como atributos privados el
    //NombreReserva y una matriz llamada avistamientos de 3x3 (que representa un
    //mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
    //cantidad de animales avistados en cada sector). El constructor de la clase debe
    //cargar por teclado el nombre y rellenar el mapa de avistamientos.
    //● Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
    //objetos de la clase ReservaNatural.
    //La clase CentroEcologico debe implementar los siguientes métodos:
    //1. Un constructor que solicite la carga secuencial de las 3 reservas.
    //2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
    //registró en toda su superficie (la suma de toda su matriz rectangular).
    //3. Un método que determine e informe cuál fue la coordenada o sector específico ([fila,
    //columna]) que registró la mayor concentración de avistamientos de toda la red de
    //reservas, indicando a qué reserva pertenece.


    internal class ReservaNatural
    {
        private string NombreReserva;
        private int[,] Avistamientos;
        public ReservaNatural()
        {
            Console.Write("ingrese el nombre de la reserva: ");
            NombreReserva = Console.ReadLine();
            Avistamientos = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int b = 0; b < 3; b++)
                {
                    Console.Write($"ingrese la cantidad de avistamientos para el sector [{i}, {b}]: ");
                    Avistamientos[i, b] = int.Parse(Console.ReadLine());
                }
            }
        }
        public string nombreReserva()
        {
            return NombreReserva;
        }
        public int[,] avistamientos()
        {
            return Avistamientos;
        }
    }

    internal class CentroEcologico
    {
        private ReservaNatural[] Reservas;
        public CentroEcologico()
        {
            Reservas = new ReservaNatural[3];
            for (int i = 0; i < 3; i++)
            {
                Reservas[i] = new ReservaNatural();
            }
        }

        private void ListarReservas()
        {
            for (int i = 0; i < 3; i++)
            {
                int totalAvistamientos = 0;
                int[,] avistamientos = Reservas[i].avistamientos();
                for (int b = 0; b < 3; b++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        totalAvistamientos += avistamientos[b, c];
                    }
                }
                Console.WriteLine($"reserva: {Reservas[i].nombreReserva()} avistamientos: {totalAvistamientos}");
            }
        }

        private void MayorConcentracion()
        {
            int maxAvist = 0;
            string reserva = "";
            int fila = 0;
            int columna = 0;
            for (int i = 0; i < 3; i++)
            {
                int[,] avistamientos = Reservas[i].avistamientos();
                for (int b = 0; b < 3; b++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (avistamientos[b, c] > maxAvist)
                        {
                            maxAvist = avistamientos[b, c];
                            reserva = Reservas[i].nombreReserva();
                            fila = b;
                            columna = c;
                        }
                    }
                }
            }
            Console.WriteLine($"mayor concentración de avistamientos: {maxAvist} en la reserva {reserva} en el sector [{fila}, {columna}]");
        }

        static void Main(string[] args)
        {
            CentroEcologico reserva = new CentroEcologico();
            reserva.ListarReservas();
            reserva.MayorConcentracion();
            Console.ReadKey();
        }
    }
}
