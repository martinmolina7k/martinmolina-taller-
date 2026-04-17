using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
           $500, realizar un programa que lea los sueldos que cobra cada empleado e
           informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
           de $300. Además el programa deberá informar el importe que gasta la empresa
           en sueldos al personal.*/

            int sueldo;
            int empleados;
            int entre100y300 = 0;
            int masDe300 = 0;
            int totalSueldos = 0;

            Console.Write("Ingrese cantidad de empleados: ");
            empleados = int.Parse(Console.ReadLine());

            for (int i = 1; i <= empleados; i++)
            {
                Console.Write("Ingrese sueldo: ");
                sueldo = int.Parse(Console.ReadLine());

                if (sueldo >= 100 && sueldo <= 300)
                {
                    entre100y300++;
                }
                else if (sueldo > 300)
                {
                    masDe300++;
                }

                totalSueldos += sueldo;
            }

            Console.WriteLine("Empleados que cobran entre $100 y $300: " + entre100y300);
            Console.WriteLine("Empleados que cobran más de $300: " + masDe300);
            Console.WriteLine("Gasto total en sueldos: $" + totalSueldos);

            Console.ReadKey();
        }

         
        }
    }
