using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2- Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
drones de entrega en vuelo de regreso a la base.
 Crear la clase Dron que contenga los atributos privados: codigo (string) y
nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes.
Su constructor debe recibir cod y bat.
 Crear la clase CentroControl que administre una lista de objetos
List&lt;Dron&gt;.
 Métodos en CentroControl:

1. Un constructor que cargue por teclado una lista inicial de 4 drones
ingresando sus códigos y baterías.
2. ListarFlota(): Mostrar la lista de drones en pantalla.
3. RemoverDronesBajos(): Recorrer la lista y remover por
completo de la flota a todos aquellos drones cuyo nivel de batería
sea menor o igual al 15% (ya que requieren mantenimiento
automático urgente).
4. MostrarDronesRestantes(): Imprimir la flota actualizada y la
cantidad de drones operativos utilizando la propiedad .Count.*/

namespace Punto2
{
    class Dron
    {
        private string codigo;
        private int nivelBateria;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int NivelBateria
        {
            get { return nivelBateria; }
            set
            {
                if (value < 100 || value > 0)
                {
                    nivelBateria = value;
                }
                else
                {
                    Console.WriteLine("el nivel de bateria no puede ser mayor a 100 o menor a 0, ingrese nuevamente");
                    NivelBateria = int.Parse(Console.ReadLine());
                }
            }
        }

        public Dron(string cod, int bat)
        {
            Codigo = cod;
            NivelBateria = bat;
        }

    }
    class CentroControl
    {
        List<Dron> Control = new List<Dron>();

        public CentroControl()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el codigo del dron");
                string code = Console.ReadLine();
                Console.WriteLine("Ingrese la bateria del dorn");
                int bat = int.Parse(Console.ReadLine());
                Dron dron = new Dron(code, bat);
                Control.Add(dron);
            }

        }

        public void ListarFlota()
        {
            foreach (Dron dron in Control)
            {
                Console.WriteLine($"Codigo del dron: {dron.Codigo}, Nivel de bateria: {dron.NivelBateria}");
            }
        }

        public void RemoverDronesBajos()
        {
            for (int i = 0; i < Control.Count; i++)
            {
                if (Control[i].NivelBateria < 15)
                {
                    Control.RemoveAt(i);
                }
            }
        }

        public void MostrarDronesRestantes()
        {
            foreach (Dron dron in Control)
            {
                Console.WriteLine($"Codigo del dron: {dron.Codigo}, Nivel de bateria: {dron.NivelBateria}");
            }
            Console.WriteLine($"Cantidad der drones en la flota{Control.Count}");
        }

        static void Main(string[] args)
        {
            CentroControl control = new CentroControl();
            control.ListarFlota();
            control.RemoverDronesBajos();
            control.MostrarDronesRestantes();
            Console.ReadKey();
        }
    }
}
