using punto5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace punto5
{/*Actividad 5: Gestión de Carreras Deportivas
Consigna:
Crear un sistema para gestionar carreras deportivas. Cada carrera tiene un código,
una hora de inicio y una hora de fin. Cada carrera puede registrar varios corredores.
Se pide:
1. Crear una clase Carrera con:
o Atributos: código, hora de inicio, hora de fin y lista de corredores ya
definidos.
o Dos constructores (uno por defecto y otro con parámetros).
o Método para calcular la duración de la carrera usando TimeSpan.
2. Crear una clase Corredor con:
o Atributos: nombre, número de dorsal y tiempo total.
o Sobrecarga de métodos para registrar el tiempo total (en minutos o en
horas y minutos).

3. Mostrar en consola (usando Console.SetCursorPosition()):
o La carrera con mayor duración.
o El corredor más rápido.
4. Utilizar this en los constructores o métodos donde corresponda.*/
    internal class Carrera
    {
        private string codigo;
        private DateTime horaInicio;
        private DateTime horaFin;
        private List<Corredor> corredores;

        public string Codigo { get { return codigo; } set { codigo = value; } }
        public DateTime HoraInicio { get { return horaInicio; } set { horaInicio = value; } }
        public DateTime HoraFin { get { return horaFin; } set { horaFin = value; } }
        public List<Corredor> Corredores { get { return corredores; } set { corredores = value; } }


        public Carrera()
        {
            this.Corredores = new List<Corredor>();
            Console.WriteLine("Ingrese el codigo de la carrera");
            Codigo = Console.ReadLine();
            Console.WriteLine("ingrese a que horario inicia");
            HoraInicio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese a que horario de termina ");
            horaFin = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Cuantos corredores corren esta carrera");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {

                Console.WriteLine("Ingrese el nombre del corredor");
                string nombre = Console.ReadLine();
                Console.WriteLine("ingrese su dorsal");
                int dorsal = int.Parse(Console.ReadLine());
                Corredor Corredor = new Corredor(nombre, dorsal);
                Console.WriteLine("Ingrese cuanto tiempo estuvo en la carrera");
                Corredor.RegistrarTiempo(int.Parse(Console.ReadLine()));
                Corredores.Add(Corredor);
            }



        }
        public Carrera(string codigo, DateTime horaInicio, DateTime horaFin, List<Corredor> corredores)
        {
            this.Codigo = codigo;
            this.HoraInicio = horaInicio;
            this.HoraFin = horaFin;
            this.Corredores = corredores;
        }
        public TimeSpan DuracionCarrera()
        {
            TimeSpan duracion = HoraFin - HoraInicio;
            return duracion;
        }
    }
}

class Corredor
{
    private string nombre;
    private int numeroDorsal;
    private int tiempoTotal;

    public string Nombre { get { return nombre; } set { nombre = value; } }
    public int NumeroDorsal { get { return numeroDorsal; } set { numeroDorsal = value; } }
    public int TiempoTotal { get { return tiempoTotal; } set { tiempoTotal = value; } }

    public Corredor(string Nombre, int NumeroDorsal)
    {
        this.Nombre = Nombre;
        this.NumeroDorsal = NumeroDorsal;
    }

    public void RegistrarTiempo(int minutos)
    {
        this.TiempoTotal = minutos;
    }
    public void RegistrarTiempo(int horas, int minutos)
    {
        this.TiempoTotal = horas + 60 + minutos;
    }

    static void Main(string[] args)
    {
        List<Carrera> carreras = new List<Carrera>();
        Console.WriteLine("Ingrese cuantas carreras hay");
        int cant = int.Parse(Console.ReadLine());
        for (int i = 0; i < cant; i++)
        {
            Carrera carrera = new Carrera();
            carreras.Add(carrera);
        }

        Carrera masLarga = carreras[0];
        var CorredorRapido = carreras[0].Corredores[0]
        ;
        foreach (var c in carreras)
        {

            for (int i = 0; i < c.Corredores.Count; i++)
            {
                if (CorredorRapido.TiempoTotal > c.Corredores[i].TiempoTotal)
                {
                    CorredorRapido = c.Corredores[i];
                }

            }


            if (masLarga.DuracionCarrera() < c.DuracionCarrera())
            {
                masLarga = c;
            }

        }
        Console.WriteLine($"El corredor mas rapido de todas las carreras es {CorredorRapido.Nombre}, con un tiempo de {CorredorRapido.TiempoTotal} minutos");
        Console.WriteLine($"La carrera mas larga fue la: {masLarga.Codigo}, durando {masLarga.DuracionCarrera()}");
        Console.ReadKey();
    }
}