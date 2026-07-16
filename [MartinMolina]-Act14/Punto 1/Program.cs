using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    namespace ejercicio1
    {
        //1. El Sistema de Peaje.
    //Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
    //La clase Vehiculo debe tener los siguientes atributos privados:
    //Patente (de tipo string).
    //Tipo (puede ser "Auto", "Camion" o "Moto").
    //Tarifa (un valor decimal que representa el costo de su pase).
    //El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
    //La clase CabinaPeaje debe tener como atributos privados:
    //El número o identificador de la cabina.
    //Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
    //Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos. Además, implementar los siguientes métodos dentro de CabinaPeaje:
    //Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
    //Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
    //Un método que muestre la patente del vehículo que pagó la tarifa más cara.
    

        internal class Vehiculo
        {
            private string patente;
            private string tipo;
            private float tarifa;

            public Vehiculo()
            {

                Console.WriteLine("ingrese su patente");
                patente = Console.ReadLine();
                Console.WriteLine("ingrese que tipo de vehiculo es");
                tipo = Console.ReadLine();
                Console.WriteLine("ingrese el valor de la tarifa a pagar");
                string linea = Console.ReadLine();
                tarifa = float.Parse(linea);

            }

            public void Imprimir()
            {
                Console.WriteLine($"patente: {patente}");
                Console.WriteLine($"tipo de vehiculo: {tipo}");
            }

            public float ReturnTarifa()
            {
                return tarifa;
            }

            public string ReturnPatente()
            {
                return patente;
            }

        }
        internal class CabinaPeaje
        {

            private int indeficador;
            private Vehiculo vehiculo1, vehiculo2, vehiculo3;

            public CabinaPeaje()
            {
                indeficador = 87;
                Console.WriteLine($"Cabina N°{indeficador}");
                vehiculo1 = new Vehiculo();
                vehiculo2 = new Vehiculo();
                vehiculo3 = new Vehiculo();
            }

            public void ImprimirLista()
            {
                vehiculo1.Imprimir();
                vehiculo2.Imprimir();
                vehiculo3.Imprimir();
            }

            public void Recaudacion()
            {
                float recaudacion = vehiculo1.ReturnTarifa() + vehiculo2.ReturnTarifa() + vehiculo3.ReturnTarifa();
                Console.WriteLine($"la recaudacion total del peaje es de: {recaudacion}");
            }

            public void TarifaCara()
            {
                float tarifa1 = vehiculo1.ReturnTarifa();
                float tarifa2 = vehiculo2.ReturnTarifa();
                float tarifa3 = vehiculo3.ReturnTarifa();

                if (tarifa1 > tarifa2 && tarifa1 > tarifa3)
                {
                    Console.WriteLine($"el vehiculo con la patente {vehiculo1.ReturnPatente()} pago la tarifa mas cara");
                }
                else if (tarifa2 > tarifa1 && tarifa2 > tarifa3)
                {
                    Console.WriteLine($"el vehiculo con la patente {vehiculo2.ReturnPatente()} pago la tarifa mas cara");
                }
                else
                {
                    Console.WriteLine($"el vehiculo con la patente {vehiculo3.ReturnPatente()} pago la tarifa mas cara");
                }

            }

            static void Main(string[] args)
            {
                CabinaPeaje cabina = new CabinaPeaje();
                cabina.ImprimirLista();
                cabina.Recaudacion();
                cabina.TarifaCara();
                Console.ReadKey();
            }
        }
    }
}
