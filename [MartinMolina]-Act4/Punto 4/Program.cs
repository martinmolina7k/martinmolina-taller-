using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCuenta;
            double saldo;
            double sumaAcreedores = 0;

            while (true)
            {
                Console.Write("Ingrese número de cuenta: ");
                numCuenta = int.Parse(Console.ReadLine());

                if (numCuenta < 0)
                {
                    break; // corta el ingreso
                }

                Console.Write("Ingrese saldo: ");
                saldo = double.Parse(Console.ReadLine());

                // Mostrar estado
                if (saldo > 0)
                {
                    Console.WriteLine("Cuenta " + numCuenta + ": Acreedor");
                    sumaAcreedores += saldo;
                }
                else if (saldo < 0)
                {
                    Console.WriteLine("Cuenta " + numCuenta + ": Deudor");
                }
                else
                {
                    Console.WriteLine("Cuenta " + numCuenta + ": Nulo");
                }
            }

            Console.WriteLine("Total de saldos acreedores: " + sumaAcreedores);

            Console.ReadKey();
        }
    }
}
