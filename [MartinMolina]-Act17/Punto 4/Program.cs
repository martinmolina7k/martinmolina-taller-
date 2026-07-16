using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
//4. Cadena de Herramientas (Herencia Multinivel y Orden de Constructores)
//Armar una estructura jerárquica compuesta por tres clases consecutivas en una línea de
//herencia: Material, Herramienta y Martillo.
// La clase Material (base) debe tener un atributo TipoMaterial (ej: Madera, Acero,
//Plástico).
// La clase Herramienta (que hereda de Material) debe añadir el atributo
//FuncionPrincipal.
// La clase Martillo (que hereda de Herramienta) debe añadir el atributo PesoGramos.
//Cada una de las tres clases debe contar con un constructor encargado de recibir sus datos
//correspondientes. Al momento de ejecutarse, cada constructor debe realizar la asignación y,
//acto seguido, imprimir un mensaje en consola indicando a qué clase pertenece
//(ejemplo: &quot;Constructor de la clase Material ejecutado&quot;).
//En el método Main, crear únicamente un objeto de la clase final Martillo pasándole todos los
//parámetros requeridos. Observar y verificar en la consola el orden secuencial de ejecución
//en cadena de los constructores (desde la raíz hasta la clase derivada).


{
    internal class Material
    {
        private string TipoMaterial;

        public Material(string t)
        {
            TipoMaterial = t;
            Console.WriteLine($"Constructor de la clase Material ejecutado");
        }

    }

    internal class Herramienta : Material
    {
        private string FuncionPrincipal;

        public Herramienta(string f, string t) : base(t)
        {
            FuncionPrincipal = f;
            Console.WriteLine($"Constructor de la clase Herramienta ejecutado");
        }

    }

    internal class Martillo : Herramienta
    {
        private int PesoGramo;

        public Martillo(int p, string f, string t) : base(f, t)
        {
            PesoGramo = p;
            Console.WriteLine($"Constructor de la clase Martillo ejecutado");
            Console.WriteLine($" Tipo Material : {t}, Funcion Principal : {f}, Peso : {p}");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Martillo martillo = new Martillo(2000, "martillar", "madera");

            Console.ReadKey();
        }
    }
}
