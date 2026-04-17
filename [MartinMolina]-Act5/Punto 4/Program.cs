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
            /*.Se cuenta con la siguiente información:
            ● Las edades de 20 estudiantes del turno mañana.
            ● Las edades de 30 estudiantes del turno tarde.
            ● Las edades de 15 estudiantes del turno noche.
            Las edades de cada estudiante deben ingresarse por teclado.
            a) Obtener el promedio de las edades de cada turno (tres promedios)
            b) Imprimir dichos promedios (promedio de cada turno)
            c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
            promedio de edades menor.*/

            int numCuenta;
            int saldo;
            int sumaAcreedores = 0;

            while (true)
            {
                Console.Write("Ingrese número de cuenta: ");
                numCuenta = int.Parse(Console.ReadLine());

                if (numCuenta < 0)
                {
                    break;
                }

                Console.Write("Ingrese saldo: ");
                saldo = int.Parse(Console.ReadLine());

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
