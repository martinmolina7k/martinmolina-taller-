using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
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

  

    class vehiculo
    {

        private string patente;
        private string tipo;
        private float tarifa;

        public vehiculo()
        {
            string linea;

            Console.WriteLine("Ingrese la patente del auto : ");
            linea = Console.ReadLine();
            patente = linea;

            do
            {
                Console.WriteLine("Ingrese el tipo de vehiculo que tiene: ");
                linea = Console.ReadLine();
                tipo = linea.ToLower();

                if (tipo != "camion" && tipo != "auto" && tipo != "moto")
                    Console.WriteLine("Tipo inválido, solo puede ser camion, auto o moto .");

            } while (tipo != "camion" && tipo != "auto" && tipo != "moto");

            Console.WriteLine("Ingrese el valor de su tarifa : ");
            linea = Console.ReadLine();
            tarifa = float.Parse(linea);
        }

        public string obtenerPatente()
        {
            return patente;
        }

        public string obtenerTipo()
        {
            return tipo;
        }

        public float obtenerTarifa()
        {
            return tarifa;
        }
    }

    class cabinaPeaje
    {
        private string identificador;

        private vehiculo vehiculo1, vehiculo2, vehiculo3;

        public cabinaPeaje()
        {
            string linea;

            Console.WriteLine("Ingrese el numero de su cabina");
            linea = Console.ReadLine();
            identificador = linea;

            vehiculo1 = new vehiculo();
            vehiculo2 = new vehiculo();
            vehiculo3 = new vehiculo();

        }

        public void obtenerPatente()
        {
            Console.WriteLine("Las patentes y el tipo de los 3 vehiculos de la cabina" + identificador + "son: ");
            Console.WriteLine(vehiculo1.obtenerPatente() + " " + vehiculo1.obtenerTipo());
            Console.WriteLine(vehiculo2.obtenerPatente() + " " + vehiculo2.obtenerTipo());
            Console.WriteLine(vehiculo3.obtenerPatente() + " " + vehiculo3.obtenerTipo());
        }

        public void obtenerTotalTarifa()
        {
            float total = 0;

            total = vehiculo1.obtenerTarifa() + vehiculo2.obtenerTarifa() + vehiculo3.obtenerTarifa();

            Console.WriteLine("La tarifa total recaudada es " + total);

        }

        public void obtenerPagaMasCara()
        {
            if (vehiculo1.obtenerTarifa() > vehiculo2.obtenerTarifa() && vehiculo1.obtenerTarifa() > vehiculo3.obtenerTarifa())
            {
                Console.WriteLine("El vehiculo que mas pago fue " + vehiculo1.obtenerPatente());

            }
            else if (vehiculo2.obtenerTarifa() > vehiculo1.obtenerTarifa() && vehiculo2.obtenerTarifa() > vehiculo3.obtenerTarifa())
            {
                Console.WriteLine("El vehiculo que mas pago fue " + vehiculo2.obtenerPatente());

            }
            else if (vehiculo3.obtenerTarifa() > vehiculo1.obtenerTarifa() && vehiculo3.obtenerTarifa() > vehiculo2.obtenerTarifa())
            {

                Console.WriteLine("El vehiculo que mas pago fue " + vehiculo3.obtenerPatente());
            }
            else
            {
                Console.WriteLine("No hay una tarifa mayor");
            }
        }

        static void Main(string[] args)
        {
            cabinaPeaje cp = new cabinaPeaje();
            cp.obtenerPatente();
            cp.obtenerTotalTarifa();
            cp.obtenerPagaMasCara();
            Console.ReadKey();
        }
    }
}

