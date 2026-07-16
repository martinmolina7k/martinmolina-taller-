using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{

    // 4. Inventario de Sucursales 
    //Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual. El constructor de la clase debe cargar estos atributos por teclado.
    //Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo. El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
    //Implementar en la clase Sucursal los siguientes métodos:
    //Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio * Stock).
    //Un método que busque y muestre el nombre del artículo más caro del local.
    //Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).


    internal class Articulo
    {
        private string NombreArticulo;
        private double Precio;
        private int StockActual;
        public Articulo()
        {
            Console.WriteLine("ingrese el nombre del articulo");
            NombreArticulo = Console.ReadLine();
            Console.WriteLine("ingrese el precio del articulo");
            string linea = Console.ReadLine();
            Precio = double.Parse(linea);
            Console.WriteLine("ingrese el stock actual del articulo");
            linea = Console.ReadLine();
            StockActual = int.Parse(linea);
        }
        public string NombreA()
        {
            return NombreArticulo;
        }
        public double PrecioA()
        {
            return Precio;
        }
        public int StockA()
        {
            return StockActual;
        }
    }

    internal class Sucursal
    {
        private string NombreSucursal;
        private Articulo[] articulos;
        public Sucursal()
        {
            Console.WriteLine("ingrese el nombre de la sucursal");
            NombreSucursal = Console.ReadLine();
            articulos = new Articulo[3];
            for (int i = 0; i < articulos.Length; i++)
            {
                articulos[i] = new Articulo();
            }
        }
        public void ImprimirLista()
        {
            for (int i = 0; i < articulos.Length; i++)
            {
                double valorTotal = articulos[i].PrecioA() * articulos[i].StockA();
                Console.WriteLine($"{articulos[i].NombreA()}: valor total: {valorTotal}");
            }
        }
        public void ArticuloCaro()
        {
            Articulo articuloMasCaro = articulos[0];
            for (int i = 1; i < articulos.Length; i++)
            {
                if (articulos[i].PrecioA() > articuloMasCaro.PrecioA())
                {
                    articuloMasCaro = articulos[i];
                }
            }
            Console.WriteLine($"el articulo mas caro es: {articuloMasCaro.NombreA()} con un precio de {articuloMasCaro.PrecioA()}");
        }
        public void Reposicion()
        {

            for (int i = 0; i < articulos.Length; i++)
            {
                if (articulos[i].StockA() <= 5)
                {
                    Console.WriteLine($"{articulos[i].NombreA()} con {articulos[i].StockA()} unidades, necesita reposicion");
                }
            }
        }

        static void Main(string[] args)
        {
            Sucursal sucursal = new Sucursal();
            sucursal.ImprimirLista();
            sucursal.ArticuloCaro();
            sucursal.Reposicion();
            Console.ReadKey();
        }
    }
}
