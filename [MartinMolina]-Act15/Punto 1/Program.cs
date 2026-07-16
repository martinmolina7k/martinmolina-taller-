using System;

namespace Punto_1
//1. Monitoreo Clínico de Pacientes
//En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo
//cardíaco de los pacientes.
//● Plantear una clase llamada Paciente que tenga como atributos privados:
//1. Nombre (de tipo string).
//2. Una matriz llamada ritmoCardiaco de tamaño 3x4 (representando los
//registros de pulsaciones tomados durante 3 días diferentes, en 4 momentos
//clave de cada día: mañana, mediodía, tarde y noche).
//3. El constructor de Paciente debe pedir su nombre y solicitar la carga por
//teclado de las 12 lecturas cardíacas.

//● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3
//objetos de la clase Paciente. Su constructor debe inicializar el vector y solicitar la
//carga de los 3 pacientes. Implementar los siguientes métodos dentro de
//SalaMonitoreo:
//1. Un método que imprima la grilla de lecturas cardíacas completa de cada
//paciente organizada por día y momento.
//2. Un método que calcule e imprima el promedio de pulsaciones de cada
//paciente a lo largo de todo su monitoreo.
//3. Un método que verifique si algún paciente registró un evento de taquicardia
//severa (cualquier lectura individual que sea estrictamente mayor a 120
//pulsaciones), mostrando por consola su nombre y la lectura detectada.


{
    internal class Paciente
    {
        private string Nombre;
        private int[,] RitmoCardiaco;

        public Paciente()
        {
            Console.Write("ingrese el nombre del paciente: ");
            Nombre = Console.ReadLine();
            RitmoCardiaco = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int b = 0; b < 4; b++)
                {
                    Console.Write($"ingrese la lectura de pulsaciones para el dia {i + 1}, a la {(b == 0 ? "mañana" : b == 1 ? "mediodia" : b == 2 ? "tarde" : "noche")}: ");
                    RitmoCardiaco[i, b] = int.Parse(Console.ReadLine());
                }
            }
        }

        public string nombre()
        {
            return Nombre;
        }

        public int[,] ritmoCardiaco()
        {
            return RitmoCardiaco;
        }
    }

    internal class SalaMonitoreo
    {
        private Paciente[] pacientes;
        public SalaMonitoreo()
        {
            pacientes = new Paciente[3];
            for (int i = 0; i < pacientes.Length; i++)
            {
                pacientes[i] = new Paciente();
            }
        }

        public void ImprimirLista()
        {
            for (int i = 0; i < pacientes.Length; i++)
            {
                Console.WriteLine($"paciente: {pacientes[i].nombre()}");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"dia {j + 1}: ");
                    for (int b = 0; b < 4; b++)
                    {
                        Console.Write($"{pacientes[i].ritmoCardiaco()[j, b]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public void CalcularPromedio()
        {
            for (int i = 0; i < pacientes.Length; i++)
            {
                double aux = 0;

                for (int j = 0; j < 3; j++)
                {
                    for (int b = 0; b < 4; b++)
                    {
                        aux += pacientes[i].ritmoCardiaco()[j, b];

                    }
                }
                double promedio = aux / 12;
                Console.WriteLine($"promedio de pulsaciones de {pacientes[i].nombre()}: {promedio}");
            }
        }

        public void VerificarTaquicardia()
        {
            for (int i = 0; i < pacientes.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int b = 0; b < 4; b++)
                    {
                        if (pacientes[i].ritmoCardiaco()[j, b] > 120)
                        {
                            Console.WriteLine($"taquicardia severa detectada en {pacientes[i].nombre()} con lectura: {pacientes[i].ritmoCardiaco()[j, b]}");
                        }
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            SalaMonitoreo sala = new SalaMonitoreo();
            sala.ImprimirLista();
            sala.CalcularPromedio();
            sala.VerificarTaquicardia();
            Console.ReadKey();
        }
    }
}
