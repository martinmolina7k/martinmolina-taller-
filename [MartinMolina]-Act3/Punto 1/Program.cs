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
            //Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.




            int dia, mes;
            string Linea;
            Console.Write("introducir un dia: ");
            Linea = Console.ReadLine();
            dia = int.Parse(Linea);
            Console.Write("introducir un mes: ");
            Linea = Console.ReadLine();
            mes = int.Parse(Linea);
            if (
                dia == 25 && mes == 12

                )

            {
                Console.WriteLine("Es navidad");



            }
            else
            {

                Console.WriteLine("No es navidad");





            }

            Console.ReadKey();

        }


    }
    
}
