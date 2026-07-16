using System;

namespace Punto_2
{

    //2. Logística de Puerto Espacial
    //Una estación de acoplamiento registra el peso de los contenedores transportados en las
    //bodegas de carga de las naves espaciales que llegan al puerto.
    //● Crear la clase NaveEspacial que contenga únicamente el atributo privado
    //NombreNave y su constructor para cargarlo.
    //● Crear la clase colaboradora PuertoControl que contenga:
    //○ Un vector de 3 objetos de la clase NaveEspacial.
    //○ Una matriz irregular de tipo double llamado pesoContenedores, donde
    //cada fila representa a una nave, el tamaño de la fila es la cantidad de
    //bodegas que posee esa nave, y los valores almacenados son los pesos (en
    //toneladas) de los contenedores que transporta cada bodega.

    //En PuertoControl, definir los siguientes métodos:

    //1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
    //cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz
    //irregular) y cargue el peso del contenedor asignado a cada bodega.
    //2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave
    //espacial.
    //3. Un método que identifique e informe qué nave transporta el contenedor individual
    //más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz
    //irregular).
    //4. Un método que indique el nombre de la nave que transporta menor peso acumulado
    //total(la suma de todos sus contenedores).


    internal class NaveEspacial
    {
        private string NombreNave;
        public NaveEspacial()
        {
            Console.Write("ingrese el nombre de la nave: ");
            NombreNave = Console.ReadLine();
        }
        public string nombreNave()
        {
            return NombreNave;
        }
    }

    internal class PuertoControl
    {
        private NaveEspacial[] Naves;
        private int[][] PesoCont;
        public PuertoControl()
        {
            Naves = new NaveEspacial[3];
            PesoCont = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                Naves[i] = new NaveEspacial();
                Console.Write($"ingrese la cantidad de bodegas activas para la nave {Naves[i].nombreNave()}: ");
                int cantidadBodegas = int.Parse(Console.ReadLine());
                PesoCont[i] = new int[cantidadBodegas];
                for (int b = 0; b < cantidadBodegas; b++)
                {
                    Console.Write($"ingrese el peso del contenedor de la bodega {b + 1} de la nave {Naves[i].nombreNave()}: ");
                    PesoCont[i][b] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void ImprimirLista()
        {
            for (int i = 0; i < Naves.Length; i++)
            {
                Console.WriteLine($"nave: {Naves[i].nombreNave()}");
                for (int b = 0; b < PesoCont[i].Length; b++)
                {
                    Console.WriteLine($"bodega {b + 1}: {PesoCont[i][b]} toneladas");
                }
            }
        }
        public void ContenedorMasPesado()
        {
            int mayorPeso = PesoCont[0][0];
            string navePeso = "";
            for (int i = 0; i < PesoCont.Length; i++)
            {
                for (int b = 0; b < PesoCont[i].Length; b++)
                {
                    if (PesoCont[i][b] > mayorPeso)
                    {
                        mayorPeso = PesoCont[i][b];
                        navePeso = Naves[i].nombreNave();
                    }
                }
            }
            Console.WriteLine($"el contenedor mas pesado es de la nave {navePeso} con un peso de {mayorPeso} toneladas.");
        }
        public void MenorPesoAcumulado()
        {
            int aux = 0;
            int minPeso = 0;
            string navePeso = "";
            for (int i = 0; i < PesoCont.Length; i++)
            {
                int pesoAcumulado = 0;
                for (int b = 0; b < PesoCont[i].Length; b++)
                {
                    pesoAcumulado += PesoCont[i][b];
                }
                if (pesoAcumulado < aux)
                {
                    minPeso = pesoAcumulado;
                    navePeso = Naves[i].nombreNave();
                }
                aux = pesoAcumulado;
            }
            Console.WriteLine($"la nave con menor peso acumulado es {navePeso} con un peso total de {minPeso} toneladas.");
        }
        static void Main(string[] args)
        {
            PuertoControl puerto = new PuertoControl();
            puerto.ImprimirLista();
            puerto.ContenedorMasPesado();
            puerto.MenorPesoAcumulado();
            Console.ReadKey();
        }
    }
}
