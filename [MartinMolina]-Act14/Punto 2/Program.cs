using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    //2. Control de Vuelos
//Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg). En su constructor, solicitar la carga de estos tres datos.
//Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero. Su constructor debe inicializar el vector y solicitar la carga por teclado de cada uno de los 4 pasajeros.
//Agregar los siguientes métodos en la clase Vuelo:
//Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
//Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI.


    internal class Pasajero
    {
        private string Nombre;
        private int Dni;
        private double EquipajeKilos;

        public Pasajero()
        {
            Console.WriteLine("ingrese el nombre del pasajero");
            Nombre = Console.ReadLine();
            Console.WriteLine("ingrese el dni");
            string linea = Console.ReadLine();
            Dni = int.Parse(linea);
            Console.WriteLine("ingrese el peso de su equipaje");
            linea = Console.ReadLine();
            EquipajeKilos = double.Parse(linea);
        }

        public string NombreP()
        {
            return Nombre;
        }

        public int DniP()
        {
            return Dni;
        }

        public double Peso()
        {
            return EquipajeKilos;
        }
    }

    internal class Vuelo
    {
        private Pasajero[] pasajeros;

        public Vuelo()
        {
            pasajeros = new Pasajero[4];
            for (int i = 0; i < pasajeros.Length; i++)
            {
                pasajeros[i] = new Pasajero();
            }
        }

        public void ImprimirLista()
        {
            for (int i = 0; i < pasajeros.Length; i++)
            {
                Console.WriteLine($"{pasajeros[i].NombreP()} dni:{pasajeros[i].DniP()} peso:{pasajeros[i].Peso()} kg");
            }
        }

        public void PesoTotal()
        {
            double total = 0;
            for (int i = 0; i < pasajeros.Length; i++)
            {
                total += pasajeros[i].Peso();
            }
            Console.WriteLine($"el peso total en el vuelo es de {total} kilos");
        }

        public void ExcesoPeso()
        {
            for (int i = 0; i < pasajeros.Length; i++)
            {
                if (pasajeros[i].Peso() > 23)
                {
                    Console.WriteLine($"el pasajero {pasajeros[i].NombreP()} de dni {pasajeros[i].DniP()} se excedio del peso permitido");
                }
            }
        }



        static void Main(string[] args)
        {
            Vuelo vuelo = new Vuelo();
            vuelo.ImprimirLista();
            vuelo.PesoTotal();
            vuelo.ExcesoPeso();
            Console.ReadKey();
        }
    }
}

