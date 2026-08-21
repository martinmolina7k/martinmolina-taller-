using System;

namespace Punto1
{ /*Actividad 1: Control de horarios en un gimnasio
Problema:
Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin (usar
DateTime).
 Implementar un constructor que permita cargar los datos desde consola y otro
que cargue valores por defecto (sobrecarga de constructores).
 Incluir un método para calcular la duración de la clase usando TimeSpan.
 Crear un vector de 3 clases de gimnasio y mostrar:
1. La clase que tenga la mayor duración.
2. El nombre y el horario de inicio de la clase más temprana.*/

    internal class ClaseGimnasio
    {
        private string nombreClase;
        private DateTime horaInicio;
        private DateTime horaFin;

        public string NombreClase { get { return nombreClase; } set { nombreClase = value; } }
        public DateTime HoraInicio { get { return horaInicio; } set { horaInicio = value; } }
        public DateTime HoraFin { get { return horaFin; } set { horaFin = value; } }

        public ClaseGimnasio()
        {
            Console.WriteLine("Ingrese el nombre de la clase");
            NombreClase = Console.ReadLine();
            Console.WriteLine("Ingrese la hora de inicio");
            HoraInicio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la hora de salida");
            HoraFin = DateTime.Parse(Console.ReadLine());
        }


        public ClaseGimnasio(string nombreClase, DateTime horaInicio, DateTime horaFin)
        {

            this.NombreClase = nombreClase;
            this.HoraInicio = horaInicio;
            this.HoraFin = horaFin;
        }

        public TimeSpan DuracionClase()
        {
            TimeSpan Duracion = HoraFin - HoraInicio;
            return Duracion;

        }

        static void Main(string[] args)
        {
            ClaseGimnasio[] Clase = new ClaseGimnasio[3];

            for (int i = 0; i < Clase.Length; i++)
            {
                Clase[i] = new ClaseGimnasio();

            }

            ClaseGimnasio claseMasLarga = Clase[0];
            ClaseGimnasio claseMasTemprana = Clase[0];
            foreach (var clase in Clase)
            {
                if (clase.DuracionClase() > claseMasLarga.DuracionClase())
                {
                    claseMasLarga = clase;

                }
                if (clase.HoraInicio < claseMasTemprana.HoraInicio)
                {
                    claseMasTemprana = clase;
                }
            }
            Console.WriteLine($"La clase con mayor duracion es: {claseMasLarga.NombreClase}, con una duracion de {claseMasLarga.DuracionClase()}");
            Console.WriteLine($"La clase mas temprana es: {claseMasTemprana.NombreClase}, iniciando a las {claseMasTemprana.HoraInicio}");
            Console.ReadKey();
        }
    }
}
