using System;
using System.Collections.Generic;

namespace punto3
{/*Actividad 3: Registro de entrenamientos
Problema:
Plantear una clase Entrenamiento con atributos: deportista y duración (en minutos).
 Incluir dos métodos RegistrarDuracion (sobrecarga de métodos):
1. Uno que reciba horas y minutos y los convierta a minutos.
2. Otro que reciba directamente los minutos.
 Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
más corto.*/
    internal class Entrenamiento
    {
        private string deportista;
        private int duracion;

        public string Deportista { get { return deportista; } set { deportista = value; } }
        public int Duracion { get { return duracion; } set { duracion = value; } }

        public Entrenamiento(string deportista)
        {
            this.Deportista = deportista;
        }

        public void RegistrarDuracion(int horas, int minutos)
        {
            this.Duracion = horas * 60 + minutos;
        }

        public void RegistrarDuracion(int minutos)
        {
            this.Duracion = minutos;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Entrenamiento> entrenamientos = new List<Entrenamiento>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el nombre del deportista:");
                string nombre = Console.ReadLine();
                Entrenamiento entrenamiento = new Entrenamiento(nombre);
                Console.WriteLine($"Ingrese las horas del entrenamiento:");
                int horas = int.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese los minutos del entrenamiento:");
                int minutos = int.Parse(Console.ReadLine());
                if (horas < 0)
                {
                    entrenamiento.RegistrarDuracion(minutos);
                }
                else
                {
                    entrenamiento.RegistrarDuracion(horas, minutos);
                }

                entrenamientos.Add(entrenamiento);
            }

            Entrenamiento masLargo = entrenamientos[0];
            Entrenamiento masCorto = entrenamientos[0];
            foreach (var e in entrenamientos)
            {
                if (e.Duracion > masLargo.Duracion)
                {
                    masLargo = e;
                }
                if (e.Duracion < masCorto.Duracion)
                {
                    masCorto = e;
                }
            }

            Console.WriteLine($"El entrenamiento mas largo es: {masLargo.Deportista} con {masLargo.Duracion} minutos");
            Console.WriteLine($"El entrenamiento mas corto es: {masCorto.Deportista} con {masCorto.Duracion} minutos");
            Console.ReadKey();
        }
    }
}