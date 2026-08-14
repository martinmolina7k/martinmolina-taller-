using System;
using System.Collections.Generic;

namespace Punto2

{
    /*Actividad 2: Administración de entregas logísticas
    Problema:
    Una empresa de envíos desea registrar sus entregas mediante colaboración de
    clases.
    Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
    Despachador que contenga una lista de paquetes y un método para registrar nuevos
    paquetes.
    Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
     Todos los paquetes registrados.
     Cuántos superan los 10 kg de peso.
     Cuántos tienen destino nacional (por ejemplo, “Argentina”).*/
    class paquete
    {
        private string codigo;
        private float peso;
        private string destino;

        public paquete(string cod, float peso, string des)
        {
            Codigo = cod;
            Peso = peso;
            Destino = des;
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public string Destino
        {
            get { return destino; }
            set { destino = value; }
        }
    }

    class despachador
    {
        public List<paquete> lista = new List<paquete>();

        public void registrar(paquete peso)
        {
            lista.Add(peso);
        }

        public void mostrar()
        {
            foreach (paquete peso in lista)
            {
                Console.WriteLine("codigo: " + peso.Codigo);
                Console.WriteLine("peso: " + peso.Peso);
                Console.WriteLine("destino: " + peso.Destino);
                Console.WriteLine();
            }
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            despachador des = new despachador();

            for (int t = 0; t < 5; t++)
            {
                Console.WriteLine("paquete " + (t + 1));

                Console.Write("codigo: ");
                string cod = Console.ReadLine();

                Console.Write("peso: ");
                float peso = float.Parse(Console.ReadLine());

                Console.Write("destino: ");
                string despe = Console.ReadLine();

                des.registrar(new paquete(cod, peso, despe));
            }

            int mayores10 = 0;
            int argentina = 0;

            foreach (var peso in des.lista)
            {
                if (peso.Peso > 10) { mayores10++; }
                if (peso.Destino == "argentina") { argentina++; }
            }
            Console.WriteLine("los mayores a 10kg son: " + mayores10);
            Console.WriteLine("destino argentina: " + argentina);
            Console.ReadKey();
        }
    }
}
