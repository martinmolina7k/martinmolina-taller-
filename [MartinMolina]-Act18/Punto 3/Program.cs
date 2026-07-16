using System;

namespace Punto_3
{   //3.Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
    //AutonomiaMinutos (int). Definir un constructor que reciba estos dos valores como parámetros y
    //realice su asignación.
    //Luego, definir dos clases derivadas de la clase base:
    //● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
    //soportada en atmósferas).
    //● RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
    //Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir
    //tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
    //clase SondaExploradora mediante el uso explícito de la palabra clave base.
    //En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
    //parámetros unificados por consola.


    internal class SondaExploradora
    {
        private string Modelo;
        private int AutonomiaMinutos;

        public SondaExploradora(string m, int a)
        {
            Modelo = m;
            AutonomiaMinutos = a;
        }
    }

    internal class SondaSubmarina : SondaExploradora
    {
        private int PresionMaximaAtm;
        public SondaSubmarina(string m, int a, int p) : base(m, a)
        {
            {
                PresionMaximaAtm = p;
                Console.WriteLine($"Sonda Submarina  Modelo : {m}, Autonomia en minutos : {a}, Presion maxima : {p}");
            }
        }

        internal class RoverTerrestre : SondaExploradora
        {
            private int CantidadRuedas;

            public RoverTerrestre(string m, int a, int c) : base(m, a)
            {
                CantidadRuedas = c;
                Console.WriteLine($"Rover Terrestre  Modelo : {m}, Autonomia en minutos : {a}, Cantidad de ruedas : {c}");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                SondaSubmarina notebook = new SondaSubmarina("Izanagi", 168, 128);
                RoverTerrestre escritorio = new RoverTerrestre("Hunter", 72, 4);
                Console.ReadKey();
            }
        }
    }
}
