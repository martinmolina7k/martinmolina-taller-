using System;
using System.Collections.Generic;

namespace Punto1
{
    /*Una aerolínea administra los vuelos programados mediante un sistema orientado a objetos.
    Vuelo (base): número, destino, duración
    VueloInternacional: país destino
    Lista de 5 vuelos, mostrar datos, mayor duración y orden de constructores*/

    class vuelo
    {
        protected int numero;
        protected string destino;
        protected float duracion;

        public vuelo(int num, string des, float du)
        {
            Numero = num;
            Destino = des;
            Duracion = du;

            Console.WriteLine("constructor vuelo ejecutado");
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        public float Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public void mostrar()
        {
            Console.WriteLine("numero: " + Numero);
            Console.WriteLine("destino: " + Destino);
            Console.WriteLine("duracion: " + Duracion);
        }
    }

    class vuelointernacional : vuelo
    {
        private string paisdestino;

        public vuelointernacional(int num, string des, float du, string paisdes)
            : base(num, des, du)
        {
            Paisdestino = paisdes;

            Console.WriteLine("constructor vuelointernacional ejecutado");
        }

        public string Paisdestino
        {
            get { return paisdestino; }
            set { paisdestino = value; }
        }

        public void mostrarvuelo()
        {
            mostrar();
            Console.WriteLine("pais destino: " + Paisdestino);
            Console.WriteLine();
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            List<vuelointernacional> vuelos = new List<vuelointernacional>();

            for (int t = 0; t < 5; t++)
            {
                Console.WriteLine("Vuelo " + (t + 1));

                Console.Write("numero: ");
                int num = int.Parse(Console.ReadLine());

                Console.Write("destino: ");
                string des = Console.ReadLine();

                Console.Write("duracion: ");
                float du = float.Parse(Console.ReadLine());

                Console.Write("pais destino: ");
                string paisdes = Console.ReadLine();

                vuelos.Add(new vuelointernacional(num, des, du, paisdes));
            }

            vuelointernacional mayor = null;
            float max = -1;

            foreach (var v in vuelos)
            {
                v.mostrarvuelo();

                if (v.Duracion > max)
                {
                    max = v.Duracion;
                    mayor = v;
                }
            }
            Console.WriteLine("vuelo con mayor duracion:");
            mayor.mostrarvuelo();
            Console.ReadKey();
        }
    }
}