using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{/*Actividad 4: Gestión de vuelos
Problema:

Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada (DateTime).
 Usar la palabra clave this en el constructor para diferenciar los parámetros de
los atributos.
 Crear un método para calcular la duración del vuelo (TimeSpan).
 Cargar un vector con 4 vuelos y mostrar:
1. El código y duración del vuelo más largo.
2. El código del vuelo que salga más temprano.*/
    internal class Vuelo
    {
        private string codigo;
        private DateTime horaSalida;
        private DateTime horaLlegada;
        public string Codigo { get { return codigo; } set { codigo = value; } }
        public DateTime HoraSalida { get { return horaSalida; } set { horaSalida = value; } }
        public DateTime HoraLlegada { get { return horaLlegada; } set { horaLlegada = value; } }
        public Vuelo(string codigo, DateTime horaSalida, DateTime horaLlegada)
        {
            this.Codigo = codigo;
            this.HoraSalida = horaSalida;
            this.HoraLlegada = horaLlegada;
        }
        public TimeSpan DuracionVuelo()
        {
            TimeSpan duracion = HoraLlegada - HoraSalida;
            return duracion;
        }

        static void Main(string[] args)
        {
            Vuelo[] vuelos = new Vuelo[4];

            for (int i = 0; i < vuelos.Length; i++)
            {
                Console.WriteLine("Ingrese el codigo del vuelo:");
                string Codigo = Console.ReadLine();
                Console.WriteLine("Ingrese la hora de salida del vuelo:");
                DateTime HoraSalida = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la hora de llegada del vuelo:");
                DateTime HoraLlegada = DateTime.Parse(Console.ReadLine());
                vuelos[i] = new Vuelo(Codigo, HoraSalida, HoraLlegada);
            }

            Vuelo vueloLargo = vuelos[0];
            Vuelo vueloTemprano = vuelos[0];
            foreach (Vuelo vuelo in vuelos)
            {
                if (vuelo.DuracionVuelo() > vueloLargo.DuracionVuelo())
                {
                    vueloLargo = vuelo;
                }
                if (vuelo.HoraSalida < vueloTemprano.HoraSalida)
                {
                    vueloTemprano = vuelo;
                }
            }

            Console.WriteLine($"El vuelo mas largo es: {vueloLargo.Codigo}, con una duracion de: {vueloLargo.DuracionVuelo()}");
            Console.WriteLine($"El vuelo que sale más temprano es: {vueloTemprano.Codigo}, saliendo a las: {vueloTemprano.HoraSalida}");
            Console.ReadKey();
        }
    }
}