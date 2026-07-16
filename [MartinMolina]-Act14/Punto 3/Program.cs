using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{

    //3. Competencia de Atletismo
    //Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
    //Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
    //Definir los siguientes métodos en la clase Carrera:
    //Un constructor que cargue los datos de los 3 atletas de la carrera.
    //Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
    //Un método que calcule e imprima el tiempo promedio de la carrera.
    //Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
    //Un método que muestre a los atletas que superaron el promedio.

    internal class Atleta
    {
        private string Nombre;
        private double TiempoSegundos;
        public Atleta(string n, double ts)
        {
            Nombre = n;
            TiempoSegundos = ts;
        }
        public string nombreA()
        {
            return Nombre;
        }
        public double tiempoSegundosA()
        {
            return TiempoSegundos;
        }
    }

    internal class Carrera
    {
        private Atleta atleta1, atleta2, atleta3;

        public Carrera()
        {
            atleta1 = new Atleta("Atleta 1", 12.5);
            atleta2 = new Atleta("Atleta 2", 11.8);
            atleta3 = new Atleta("Atleta 3", 13.2);
        }
        public void ImprimirLista()
        {
            Console.WriteLine($"{atleta1.nombreA()}: {atleta1.tiempoSegundosA()} segundos");
            Console.WriteLine($"{atleta2.nombreA()}: {atleta2.tiempoSegundosA()} segundos");
            Console.WriteLine($"{atleta3.nombreA()}: {atleta3.tiempoSegundosA()} segundos");
        }
        public void Promedio()
        {
            double promedio = (atleta1.tiempoSegundosA() + atleta2.tiempoSegundosA() + atleta3.tiempoSegundosA()) / 3;
            Console.WriteLine($"tiempo promedio: {promedio} ");
        }
        public void Ganador()
        {
            Atleta ganador = atleta1;
            if (atleta2.tiempoSegundosA() < ganador.tiempoSegundosA())
                ganador = atleta2;
            if (atleta3.tiempoSegundosA() < ganador.tiempoSegundosA())
                ganador = atleta3;
            Console.WriteLine($"el ganador es: {ganador.nombreA()} con un tiempo de {ganador.tiempoSegundosA()} segundos");
        }
        public void SuperaronPromedio()
        {
            double promedio = (atleta1.tiempoSegundosA() + atleta2.tiempoSegundosA() + atleta3.tiempoSegundosA()) / 3;
            Console.WriteLine("atletas que superaron el promedio:");
            if (atleta1.tiempoSegundosA() < promedio)
                Console.WriteLine(atleta1.nombreA());
            if (atleta2.tiempoSegundosA() < promedio)
                Console.WriteLine(atleta2.nombreA());
            if (atleta3.tiempoSegundosA() < promedio)
                Console.WriteLine(atleta3.nombreA());
        }


        static void Main(string[] args)
        {
            Carrera carrera = new Carrera();
            carrera.ImprimirLista();
            carrera.Promedio();
            carrera.Ganador();
            carrera.SuperaronPromedio();
            Console.ReadKey();

        }
    }
}
