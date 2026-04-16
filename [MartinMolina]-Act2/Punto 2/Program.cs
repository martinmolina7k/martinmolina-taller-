using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se ingresan seis notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado"

            int nota1, nota2, nota3, nota4, nota5, nota6;
            string Linea;
            Console.Write("introducir primer nota: ");
            Linea = Console.ReadLine();
            nota1 = int.Parse(Linea);
            Console.Write("introducir segunda nota: ");
            Linea = Console.ReadLine();
            nota2 = int.Parse(Linea);
            Console.Write("introducir tercera nota: ");
            Linea = Console.ReadLine();
            nota3 = int.Parse(Linea);
            Console.Write("introducir cuarta nota: ");
            Linea = Console.ReadLine();
            nota4 = int.Parse(Linea);
            Console.Write("introducir quinta nota: ");
            Linea = Console.ReadLine();
            nota5 = int.Parse(Linea);
            Console.Write("introducir sexta nota: ");
            Linea = Console.ReadLine();
            nota6 = int.Parse(Linea);
            int promedio = (nota1 + nota2 + nota3 + nota4 + nota5 + nota6) / 6;


            if (promedio >= 7)
            {


                Console.Write("Promocionado");


            }

            Console.ReadKey();
        }

    }
    
}
