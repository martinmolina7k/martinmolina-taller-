using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*8-Una farmacia controla el nivel de stock de sus medicamentos para evitar el
desabastecimiento de insumos esenciales.
 Crear la clase Medicamento que contenga los atributos privados: nombre
(string) y stock (int). Definir sus propiedades correspondientes. Su
constructor debe recibir nom y stk.
 Crear la clase ControlFarmacia que administre una lista de objetos List.
 Métodos en ControlFarmacia:
o Un constructor que cargue por teclado una lista inicial de 4
medicamentos ingresando sus nombres y stock.
o ListarStock(): Mostrar la lista de medicamentos en pantalla.

o RemoverAgotados(): Recorrer la lista y remover por completo de
la colección a todos aquellos medicamentos cuyo stock sea igual a 0.
o MostrarMedicamentosDisponibles(): Imprimir la lista
actualizada y la cantidad de productos disponibles en el inventario
utilizando la propiedad .Count.*/

namespace Punto2
{
    class Medicamento
    {
        private string nombre;
        private double stock;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public Medicamento(string nom, double pre)
        {
            Nombre = nom;
            Stock = pre;
        }
    }
    class ControlFarmacia
    {
        List<Medicamento> Lista = new List<Medicamento>();
        public ControlFarmacia()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el nombre del Dispositivo");
                string Nombre = Console.ReadLine();
                Console.WriteLine($"Ingrese la cantidad de watts que consume {Nombre}");
                int Cantidad = int.Parse(Console.ReadLine());
                Medicamento medicamento = new Medicamento(Nombre, Cantidad);
                Lista.Add(medicamento);
            }
        }

        public void ListarStock()
        {
            foreach (Medicamento medi in Lista)
            {
                Console.WriteLine($"Nombre del medicamento: {medi.Nombre}, Stock: {medi.Stock}");
            }

        }

        public void RemoverAgotados()
        {
            foreach (Medicamento medi in Lista)
            {
                if (medi.Stock == 0)
                {
                    Lista.Remove(medi);
                }
            }

        }

        public void MostrarMedicamentosDisponibles()
        {
            foreach (Medicamento medi in Lista)
            {
                Console.WriteLine($"Nombre del Medicamentos: {medi.Nombre}, Precio: {medi.Stock}");
            }
            Console.WriteLine($"Numeros de Medicamentos: {Lista.Count}");
        }


        static void Main(string[] args)
        {
            ControlFarmacia control = new ControlFarmacia();
            control.ListarStock();
            control.RemoverAgotados();
            control.MostrarMedicamentosDisponibles();
            Console.ReadKey();
        }
    }
}
