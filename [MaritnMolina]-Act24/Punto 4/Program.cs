using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

/*10 - Un estacionamiento medido administra el ingreso y la salida de los vehículos que
utilizan su playa por orden de llegada.
 Crear la clase Ticket que contenga como atributos privados: patente
(string) y horasEstadia(int). Definir sus propiedades de solo lectura y un
constructor que reciba pat y hs.
 Crear la clase GestionEstacionamiento que administre una lista
dinámica de tickets (List).
 Métodos en GestionEstacionamiento:
o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y
agregarlo al final de la lista utilizando .Add().
o ProcesarSalida(): Si la lista no está vacía, simular la salida del
primer vehículo de la lista (mostrar sus datos en consola) y
removerlo de la colección mediante .RemoveAt(0). Si está vacía,
advertir que no hay vehículos esperando salida.
o MostrarVehiculosEstacionados(): Listar todos los vehículos
alojados en la playa y la cantidad total de unidades presentes
utilizando la propiedad .Count.*/

namespace Punto4
{
    class Ticket
    {
        private string patente;
        private int horasEstadia;

        public string Patente { get { return patente; } }
        public int HorasEstadia { get { return horasEstadia; } }

        public Ticket(string pat, int hs)
        {
            patente = pat;
            horasEstadia = hs;
        }
    }


    class GestionEstacionamiento
    {
        List<Ticket> Lista = new List<Ticket>();

        public void RegistrarIngreso()
        {
            Console.WriteLine("Ingrese la patente del auto");
            string patente = Console.ReadLine();
            Console.WriteLine($"Ingrese la cantidad de horas de {patente}");
            int horas = int.Parse(Console.ReadLine());
            Ticket documento = new Ticket(patente, horas);
            Lista.Add(documento);
        }

        public void ProcesarSalida()
        {
            if (Lista.Count != 0)
            {
                Ticket DocumentoN1 = Lista[0];
                Console.WriteLine($"Patente del auto: {DocumentoN1.Patente}, Cantidad de Horas: {DocumentoN1.HorasEstadia}");
                Thread.Sleep(1000);
                Console.WriteLine($"Salida del auto terminada");
                Lista.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("No hay autos para salir");
            }

        }

        public void MostrarAutosEstacionados()
        {

            foreach (Ticket auto in Lista)
            {
                Console.WriteLine($"Patente del auto: {auto.Patente}, Cantidad de Horas: {auto.HorasEstadia}");
            }
            Console.WriteLine($"Cantidad de auto estacionados: {Lista.Count}");

        }

        static void Main(string[] args)
        {
            GestionEstacionamiento estacionamiento = new GestionEstacionamiento();
            estacionamiento.RegistrarIngreso();
            estacionamiento.RegistrarIngreso();
            estacionamiento.ProcesarSalida();
            estacionamiento.MostrarAutosEstacionados();
            Console.ReadKey();
        }
    }
}