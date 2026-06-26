using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    internal class Socio
    {
        //3. Plantear una clase Club y otra clase Socio.
        // La clase Socio debe tener los siguientes atributos privados: nombre y la
        //antigüedad en el club(en años). En el constructor pedir la carga del nombre y
        //su antigüedad.La clase Club debe tener como atributos 3 objetos de la clase
        // Socio.Definir una responsabilidad para imprimir el nombre del socio con mayor
        //antigüedad en el club.

        private string nombre;
        private int antiguedad;

        public Socio()
        {
            Console.Write("Ingrese el nombre del socio: ");
            string linea;
            linea = Console.ReadLine();
            nombre = linea;

            Console.Write("Ingrese la antiguedad (en anos): ");
            linea = Console.ReadLine();
            antiguedad = int.Parse(linea);
        }

        public string retornarnombre()
        {
            return nombre;
        }

        public int retornarantiguedad()
        {
            return antiguedad;
        }
    }

    internal class Club
    {
        private Socio socio1;
        private Socio socio2;
        private Socio socio3;

        public Club()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }

        public void mayorantiguedad()
        {
            Console.Write("Socio con mayor antiguedad: ");
            if (socio1.retornarantiguedad() > socio2.retornarantiguedad() && socio1.retornarantiguedad() > socio3.retornarantiguedad())
            {
                Console.WriteLine(socio1.retornarnombre());
            }
            else
            {
                if (socio2.retornarantiguedad() > socio3.retornarantiguedad())
                {
                    Console.WriteLine(socio2.retornarnombre());
                }
                else
                {
                    Console.WriteLine(socio3.retornarnombre());
                }
            }
        }

        static void Main(string[] args)
        {
            Club club = new Club();
            club.mayorantiguedad();

            Console.ReadKey();
        }
    }
}


