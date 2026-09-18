using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*5-Un taller mecánico automatizado administra la recepción y egreso de automóviles
que se encuentran en el sector de reparaciones.
 Crear la clase Vehiculo que contenga como atributos privados: patente
(string) y costoReparacion (double). Definir sus propiedades
correspondientes y un constructor que reciba pat y costo.
 Crear la clase GestionTaller que administre una lista de objetos List.
 Métodos en GestionTaller:
o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
reparación de un vehículo para agregarlo a la lista mediante .Add().
o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
recorriendo la lista, informar si el vehículo está en el taller y mostrar
su costo asociado.
o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
vehículo en la lista y, si existe, removerlo de la colección mediante
.Remove() confirmando la entrega del automóvil.

o CalcularRecaudacionPendiente(): Listar los vehículos
actualmente en reparación, la cantidad total de unidades alojadas en
el taller mediante la propiedad .Count y la suma total acumulada por
cobrar.*/


namespace Punto5
{
    class Vehiculo
    {
        private string patente;
        private double costoReparacion;
        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }
        public double CostoReparacion
        {
            get { return costoReparacion; }
            set { costoReparacion = value; }
        }
        public Vehiculo(string pat, double costo)
        {
            patente = pat;
            costoReparacion = costo;
        }
    }
    internal class gestionTaller
    {

        List<Vehiculo> vehiculos = new List<Vehiculo>();

        public void IngresarVehiculo()
        {
            Console.WriteLine("Ingrese la patente del vehiculo:");
            string pat = Console.ReadLine();
            Console.WriteLine("Ingrese el costo de reparación del vehiculo:");
            double costo = double.Parse(Console.ReadLine());
            Vehiculo vehiculo = new Vehiculo(pat, costo);
            vehiculos.Add(vehiculo);
        }

        public void BuscarVehiculo()
        {
            Console.WriteLine("Ingrese la patente del vehiculo a buscar:");
            string pat = Console.ReadLine();

            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo.Patente == pat)
                {
                    Console.WriteLine($"El vehiculo con patente {pat} esta en el taller. Costo de reparación: {vehiculo.CostoReparacion}");

                    break;
                }

                else
                {
                    Console.WriteLine($"El vehiculo con patente {pat} no se encuentra en el taller.");
                }
            }
        }
        public void EntregarVehiculo()
        {
            Console.WriteLine("Ingrese la patente del vehiculo a entregar:");
            string pat = Console.ReadLine();

            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo.Patente == pat)
                {
                    vehiculos.Remove(vehiculo);
                    Console.WriteLine($"El vehiculo con patente {pat} ha sido entregado.");

                    break;
                }

                else
                {
                    Console.WriteLine($"El vehiculo con patente {pat} no se encuentra en el taller.");
                }
            }
        }

        public void CalcularRecaudacionPendiente()
        {
            double total = 0;
            Console.WriteLine("Vehiculos actualmente en reparacion:");
            foreach (var vehiculo in vehiculos)
            {
                Console.WriteLine($"Patente: {vehiculo.Patente}, Costo de reparacion: {vehiculo.CostoReparacion}");
                total += vehiculo.CostoReparacion;
            }
            Console.WriteLine($"Cantidad total de vehiculos en el taller: {vehiculos.Count}");
            Console.WriteLine($"Suma total acumulada por cobrar: {total}");
        }

        static void Main(string[] args)
        {
            gestionTaller taller = new gestionTaller();
            taller.IngresarVehiculo();
            taller.BuscarVehiculo();
            taller.CalcularRecaudacionPendiente();
        }
    }
}