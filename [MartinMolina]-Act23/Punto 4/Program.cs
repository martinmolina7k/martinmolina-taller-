using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*4-Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
vinculados a una red hogareña.
 Crear la clase DispositivoInteligente que contenga como atributos
privados: nombreDispositivo (string) y consumoWatts (double). Definir
sus propiedades y un constructor que reciba nom y watts.
 Crear la clase colaboradora PanelDomotico que administre un objeto
List&lt;DispositivoInteligente&gt;.
 Métodos en PanelDomotico:
1. Un constructor que permita al usuario cargar dinámicamente
dispositivos por teclado. El sistema preguntará después de cada
carga si se desea agregar otro dispositivo.
2. MostrarDispositivos(): Listar todos los dispositivos
configurados junto a sus consumos.
3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
Watts totales que consume la casa sumando los valores de la lista.
4. DesconectarDispositivo(): Solicitar al usuario el nombre de
un dispositivo y, si existe en la lista, removerlo de forma dinámica
para simular su apagado remoto.*/

namespace Punto4
{
    class DispositivoInteligente
    {
        private string nombreDispositivo;
        private double consumoWatts;

        public string NombreDispositivo { get { return nombreDispositivo; } set { nombreDispositivo = value; } }
        public double ConsumoWatts { get { return consumoWatts; } set { consumoWatts = value; } }

        public DispositivoInteligente(string nom, int watts)
        {
            NombreDispositivo = nom;
            ConsumoWatts = watts;
        }
    }


    class PanelDomotico
    {
        List<DispositivoInteligente> Panel = new List<DispositivoInteligente>();

        public PanelDomotico()
        {
            Console.WriteLine("Ingrese el nombre del Dispositivo");
            string Nombre = Console.ReadLine();
            Console.WriteLine($"Ingrese la cantidad de watts que consume {Nombre}");
            int Cantidad = int.Parse(Console.ReadLine());
            DispositivoInteligente dispositivo = new DispositivoInteligente(Nombre, Cantidad);
            Panel.Add(dispositivo);
        }

        public void MostrarDispositivos()
        {
            foreach (DispositivoInteligente dispositivo in Panel)
            {
                Console.WriteLine($"Nombre del documento: {dispositivo.NombreDispositivo}, Cantidad de paginas: {dispositivo.ConsumoWatts}");
            }
        }

        public void CalcularConsumoTotal()
        {
            double CantidadTotal = 0;
            foreach (DispositivoInteligente dispositivo in Panel)
            {
                CantidadTotal = +dispositivo.ConsumoWatts;
            }
            Console.WriteLine($"Cantidad de consumo de watts: {CantidadTotal}");
        }

        public void DesconectarDispositivo()
        {
            Console.WriteLine("Ingrese el nombre del dispositvo a desconectar:");
            string NombreDesconectar = Console.ReadLine();
            foreach (DispositivoInteligente dispositivo in Panel)
            {
                if (NombreDesconectar == dispositivo.NombreDispositivo)
                {
                    Panel.Remove(dispositivo);
                }
            }
        }

        static void Main(string[] args)
        {
            PanelDomotico panel = new PanelDomotico();
            panel.MostrarDispositivos();
            panel.CalcularConsumoTotal();
            panel.DesconectarDispositivo();
            Console.ReadKey();
        }
    }
}
