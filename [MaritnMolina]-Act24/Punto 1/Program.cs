using System;
using System.Collections.Generic;

/*7- Un restaurante automatizado procesa la comanda de una mesa para controlar la
preparación y el cobro de los platos pedidos.
 Crear la clase Plato que contenga como atributos privados: nombrePlato
(string) y precio (double). Definir sus propiedades correspondientes y un
constructor que reciba nom y pre.
 Crear la clase GestionComandas que administre una lista de objetos List.
 Métodos en GestionComandas:
o AgregarPlato():Solicitar por teclado los datos de un plato y
agregarlo a la lista utilizando .Add().
o MostrarComanda(): Listar todos los platos agregados hasta el
momento junto a la cantidad total de ítems pedidos utilizando la
propiedad .Count.
o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto
total a cobrar sumando los precios de la lista.
o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
se encuentra en la lista, removerlo mediante .Remove() para
actualizar la comanda.*/

namespace Punto1
{
    class Plato
    {
        private string nombrePlato;
        private double precio;

        public string NombrePlato
        {
            get { return nombrePlato; }
            set { nombrePlato = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public Plato(string nom, double pre)
        {
            NombrePlato = nom;
            Precio = pre;
        }
    }

    internal class GestionComandas
    {
        List<Plato> Lista = new List<Plato>();

        public void AgregarPlato()
        {
            Console.WriteLine("Ingrese el nombre del plato");
            string Nombre = Console.ReadLine();
            Console.WriteLine($"Ingrese el precio que vale {Nombre}");
            double Precio = double.Parse(Console.ReadLine());
            Plato plato = new Plato(Nombre, Precio);
            Lista.Add(plato);
        }

        public void MostrarComanda()
        {
            foreach (Plato plato in Lista)
            {
                Console.WriteLine($"Nombre del plato: {plato.NombrePlato}, Precio: {plato.Precio}");
            }
            Console.WriteLine($"Numeros de comandas: {Lista.Count}");
        }

        public void CalcularTotalMesa()
        {
            double TotalPrecio = 0;
            foreach (Plato plato in Lista)
            {
                TotalPrecio = +plato.Precio;
            }
            Console.WriteLine($"El monto total a cobrar son de: ${TotalPrecio}");
        }

        public void CancelarPlato()
        {
            Console.WriteLine("Ingrese el nombre del dispositvo a desconectar:");
            string platoCancelar = Console.ReadLine();
            foreach (Plato plato in Lista)
            {
                if (platoCancelar == plato.NombrePlato)
                {
                    Lista.Remove(plato);
                }
            }
        }

        static void Main(string[] args)
        {
            GestionComandas gestion = new GestionComandas();
            gestion.AgregarPlato();
            gestion.MostrarComanda();
            gestion.CalcularTotalMesa();
            gestion.CancelarPlato();
            Console.ReadKey();
        }
    }
}