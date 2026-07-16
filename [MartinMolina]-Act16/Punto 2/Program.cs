using System;

namespace Punto_2
{
    //2. Plantear una clase Producto y otra clase Inventario.
    //La clase Producto debe tener como atributos privados el nombre, precio y
    //stock. Definir propiedades para acceder a estos atributos, asegurando que el
    //stock no pueda ser negativo y el precio sea mayor a cero.
    //La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
    //método para mostrar todos los productos ordenados de menor a mayor en
    //base al precio, además, mostrar el producto más caro y más barato del
    //inventario.

    internal class Producto
    {
        private string nombre;
        private double precio;
        private int stock;


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Precio
        {
            get { return precio; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("el precio no puede ser negativo");
                    string linea = Console.ReadLine();
                    Precio = int.Parse(linea);
                }
                else
                {
                    precio = value;
                }
            }
        }
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("el stock no puede ser negativo");
                    string linea = Console.ReadLine();
                    Stock = int.Parse(linea);
                }
                else
                {
                    stock = value;
                }
            }
        }

    }

    internal class Inventario
    {
        private Producto[] productos;

        public Inventario()
        {
            productos = new Producto[3];
            for (int i = 0; i < 3; i++)
            {
                productos[i] = new Producto();
                Console.WriteLine("Ingrese el nombre del producto ");
                productos[i].Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del producto");
                string linea = Console.ReadLine();
                productos[i].Precio = int.Parse(linea);
                Console.WriteLine("Ingrese el stock del producto");
                linea = Console.ReadLine();
                productos[i].Stock = int.Parse(linea);
            }
        }

        public void MostrarProductos()
        {
            for (int i = 0; i < productos.Length - 1; i++)
            {
                for (int j = 0; j < productos.Length - 1 - i; j++)
                {
                    if (productos[j].Precio > productos[j + 1].Precio)
                    {
                        Producto temp = productos[j];
                        productos[j] = productos[j + 1];
                        productos[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine($"Producto: {productos[i].Nombre}, Precio: {productos[i].Precio}, Stock: {productos[i].Stock}");
            }

            Console.WriteLine($"Producto mas barato: {productos[0].Nombre}, Precio: {productos[0].Precio}");
            Console.WriteLine($"Producto mas caro: {productos[productos.Length - 1].Nombre}, Precio: {productos[productos.Length - 1].Precio}");

        }

        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();

            inventario.MostrarProductos();

            Console.ReadKey();
        }
    }
}
