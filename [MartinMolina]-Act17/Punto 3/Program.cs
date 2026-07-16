using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
//3. Fábrica de Computadoras (Herencia y Constructores con base)
//Crear una clase base llamada Computadora que contenga los atributos Marca y
//MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
//Luego, definir dos clases derivadas de la clase base:
// Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
// Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
//Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
//tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
//clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
//de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.

{
    internal class Computadora
    {
        private string marca;
        private int memoriaRAM;

        public Computadora(string m, int r)
        {
            marca = m;
            memoriaRAM = r;
        }
    }

    internal class Notebook : Computadora
    {
        private float pulgadas;
        public Notebook(string m, int r, float p) : base(m, r)
        {
            {
                pulgadas = p;
                Console.WriteLine($"Notebook  Marca : {m}, Memoria RAM :{r} GB, Pulgadas : {p}");
            }
        }

        internal class Escritorio : Computadora
        {
            private int potenciaFuente;

            public Escritorio(string m, int r, int f) : base(m, r)
            {
                potenciaFuente = f;
                Console.WriteLine($"Escritorio  Marca : {m}, Memoria RAM :{r} GB, Potencia Fuente : {f}");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Notebook notebook = new Notebook("Lenovo", 16, 22);
                Escritorio escritorio = new Escritorio("AMD", 32, 220);
                Console.ReadKey();
            }
        }
    }
}