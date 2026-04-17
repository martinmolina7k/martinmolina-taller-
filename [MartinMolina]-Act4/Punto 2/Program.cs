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
            int x = 1;
            int n = 11;

            while (x <= 25)
            {
                Console.Write(n + " - ");
                n += 11;
                x++;
            }

            Console.ReadKey();

        }
    }
}
