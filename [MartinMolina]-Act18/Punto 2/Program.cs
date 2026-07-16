using System;

namespace Punto_2
{
    //2.
    //Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
    //La clase CriaturaMarina debe tener como atributos privados: Especie (string),
    //ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
    //propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
    //● La profundidad óptima sea estrictamente mayor a cero (0).
    //● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
    //asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
    //La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
    //de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico para cargar las 3
    //criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
    //a su profundidad óptima. Además, el programa debe informar la especie que requiere el mayor
    //nivel de salinidad para sobrevivir.


    class CriaturaMarina
    {
        private string especie;
        private int profundidadOptima;
        private int nivelSalinidad;

        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public int ProfundidadOptima
        {
            get { return profundidadOptima; }
            set
            {
                if (value > 0)
                {
                    profundidadOptima = value;
                }
                else
                {
                    Console.WriteLine("La profundidad tiene que ser mayor a 0");
                    ProfundidadOptima = int.Parse(Console.ReadLine());
                }
            }
        }

        public int NivelSalinidad
        {
            get { return nivelSalinidad; }
            set
            {
                if (NivelSalinidad < 0 || nivelSalinidad > 100)
                {
                    NivelSalinidad = 35;
                }
                else
                {
                    nivelSalinidad = value;
                }
            }
        }
        class HabitatAcuatico
        {
            CriaturaMarina[] criaturas = new CriaturaMarina[3];

            public HabitatAcuatico()
            {
                for (int i = 0; i < criaturas.Length; i++)
                {
                    criaturas[i] = new CriaturaMarina();
                    Console.WriteLine("Ingrese la especie de la criatura");
                    criaturas[i].Especie = Console.ReadLine();
                    Console.WriteLine("Ingrese la profundidad optima de la criatura");
                    criaturas[i].ProfundidadOptima = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nivel de sanilidad del 1 al 100");
                    criaturas[i].NivelSalinidad = int.Parse(Console.ReadLine());
                }
            }

            public void ImprimirCriaturas()
            {
                for (int i = 0; i < criaturas.Length - 1; i++)
                {
                    for (int j = 0; j < criaturas.Length - i - 1; j++)
                    {
                        if (criaturas[j].ProfundidadOptima < criaturas[j + 1].ProfundidadOptima)
                        {
                            var temp = criaturas[j];
                            criaturas[j] = criaturas[j + 1];
                            criaturas[j + 1] = temp;
                        }
                    }
                }

                foreach (var criatura in criaturas)
                {
                    Console.WriteLine($"Especie de criatura : {criatura.Especie}, Profundidad optima : {criatura.ProfundidadOptima}, Nivel de sanilidad : {criatura.NivelSalinidad}");
                }

                var mayorSalinidad = criaturas[0];

                for (int i = 0; i < criaturas.Length - 1; i++)
                {
                    if (criaturas[i].ProfundidadOptima > criaturas[i + 1].ProfundidadOptima)
                    {
                        mayorSalinidad = criaturas[i];
                    }
                }

                Console.WriteLine($"Criatura con mayor nivel de salidad {mayorSalinidad.Especie}");
            }
            static void Main(string[] args)
            {
                HabitatAcuatico habitat = new HabitatAcuatico();
                habitat.ImprimirCriaturas();
                Console.ReadKey();
            }

        }
    }
}
