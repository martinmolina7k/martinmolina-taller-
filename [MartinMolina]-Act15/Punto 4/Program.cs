using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{

    // 4. Línea de Ensamblaje Robótico
    //En una planta de fabricación automatizada, cada robot industrial realiza tareas de
    //ensamblaje complejas divididas en operaciones secundarias de duración variable.
    //● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
    //1. ModeloRobot.
    //2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
    //fila representa una de las 4 fases principales del proceso (Estructura,
    //Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
    //completar las distintas subtareas de esa fase (por ejemplo, en la fase de
    //Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
    //1).
    //3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
    //cada una de las 4 fases de fabricación cuántas sub-tareas requirió realizar

    //(definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
    //una de ellas.

    //● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
    //RobotEnsamblador. Implementar en PlantaIndustrial:
    //1. Un constructor que cargue la información de los 3 robots instalados en la
    //planta.
    //2. Un método que muestre un reporte detallado con los tiempos de operación
    //de cada robot fase por fase.
    //3. Un método que calcule el promedio general de tiempo por tarea de cada
    //robot y declare al &quot;Robot más Eficiente&quot; (aquel que registre el promedio de
    //tiempo por operación más bajo de la planta).


    internal class RobotEnsamblador
    {
        private string ModeloRobot;
        private double[][] TiemposOp;
        public RobotEnsamblador()
        {
            Console.Write("ingrese el modelo del robot: ");
            ModeloRobot = Console.ReadLine();
            TiemposOp = new double[4][];
            string[] fases = { "Estructura", "Cableado", "Pintura", "Testeo" };
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"ingrese la cantidad de subtareas para la fase {fases[i]}: ");
                int cantSubTareas = int.Parse(Console.ReadLine());
                TiemposOp[i] = new double[cantSubTareas];
                for (int b = 0; b < cantSubTareas; b++)
                {
                    Console.Write($"ingrese el tiempo en segundos para la subtarea {b + 1} de la fase {fases[i]}: ");
                    TiemposOp[i][b] = double.Parse(Console.ReadLine());
                }
            }
        }
        public string modeloRobot()
        {
            return ModeloRobot;
        }
        public double[][] tiemposOp()
        {
            return TiemposOp;
        }
    }

    internal class PlantaIndustrial
    {
        private RobotEnsamblador[] Robots;
        public PlantaIndustrial()
        {
            Robots = new RobotEnsamblador[3];
            for (int i = 0; i < 3; i++)
            {
                Robots[i] = new RobotEnsamblador();
            }
        }
        private void ImprimirTiempos()
        {
            string[] fases = { "Estructura", "Cableado", "Pintura", "Testeo" };
            for (int i = 0; i < Robots.Length; i++)
            {
                Console.WriteLine($"tiempos de operacion del robot {Robots[i].modeloRobot()}:");
                double[][] tiempos = Robots[i].tiemposOp();
                for (int b = 0; b < tiempos.Length; b++)
                {
                    Console.WriteLine($"fase {fases[b]}:");
                    for (int c = 0; c < tiempos[b].Length; c++)
                    {
                        Console.WriteLine($"subtarea {c + 1}: {tiempos[b][c]} segundos");
                    }
                }
            }
        }

        private void PromedioEficiente()
        {
            double[] promedios = new double[Robots.Length];
            for (int i = 0; i < Robots.Length; i++)
            {
                double[][] tiempos = Robots[i].tiemposOp();
                double sumaTiempos = 0;
                int cantidadTareas = 0;
                for (int b = 0; b < tiempos.Length; b++)
                {
                    for (int c = 0; c < tiempos[b].Length; c++)
                    {
                        sumaTiempos += tiempos[b][c];
                        cantidadTareas++;
                    }
                }
                promedios[i] = sumaTiempos / cantidadTareas;
            }
            int aux = 0;
            for (int i = 1; i < promedios.Length; i++)
            {
                if (promedios[i] < promedios[aux])
                {
                    aux = i;
                }
            }
            Console.WriteLine($"El robot más eficiente es el modelo {Robots[aux].modeloRobot()} con un promedio de tiempo por tarea de {promedios[aux]} segundos.");
        }
        static void Main(string[] args)
        {
            PlantaIndustrial planta = new PlantaIndustrial();
            planta.ImprimirTiempos();
            planta.PromedioEficiente();
            Console.ReadKey();
        }
    }
}
