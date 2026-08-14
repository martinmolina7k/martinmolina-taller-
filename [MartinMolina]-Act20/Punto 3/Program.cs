using System;
using System.Collections.Generic;

namespace Punto3
{
    /*Actividad 3: Estadísticas de visitas a zonas arqueológicas
    Problema:
    Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
    arqueológicas durante 4 semanas.
    Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
    días. Luego:
     Calcular el total de visitas por zona y almacenarlo en un vector.
     Mostrar los datos en forma tabular.
     Agregar estos resultados a una lista llamada zonasVisitadas que contenga
    nombres de zonas y total de visitas.
     Determinar cuál fue la zona más visitada.*/
    class Visitas
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 4];
            int[] totales = new int[3];
            string[] zonas = { "zona 1", "zona 2", "zona 3" };

            List<string> zonasvisitadas = new List<string>();

            for (int t = 0; t < 3; t++)
            {
                int suma = 0;

                for (int v = 0; v < 4; v++)
                {
                    Console.Write("visitas zona " + (t + 1) + " semana " + (v + 1) + ": ");
                    matriz[t, v] = int.Parse(Console.ReadLine());
                    suma += matriz[t, v];
                }

                totales[t] = suma;
                zonasvisitadas.Add(zonas[t] + " - " + suma);
            }

            int max = -1;
            string zonaMax = "";

            for (int t = 0; t < 3; t++)
            {
                if (totales[t] > max)
                {
                    max = totales[t];
                    zonaMax = zonas[t];
                }
            }
            Console.WriteLine("zona mas visitada: " + zonaMax);
            Console.ReadKey();
        }
    }
}