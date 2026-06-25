using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class Program
    {
            private string[] paises;
            private int[,] temperaturas;
            private float[] mediasTrimestrales;

            public void cargar()
            {
                paises = new string[4];
                temperaturas = new int[4, 3];

                for (int f = 0; f < paises.Length; f++)
                {
                    Console.Write("ingrese el nombre del pais: ");
                    string linea;
                    linea = Console.ReadLine();
                    paises[f] = linea;

                    for (int c = 0; c < temperaturas.GetLength(1); c++)
                    {
                        Console.Write("ingrese temperatura mensual " + (c + 1) + ": ");
                        linea = Console.ReadLine();
                        temperaturas[f, c] = int.Parse(linea);
                    }
                }
            }

            public void imprimirTemperaturas()
            {
                Console.WriteLine("paises y sus temperaturas mensuales:");
                for (int f = 0; f < temperaturas.GetLength(0); f++)
                {
                    Console.Write(paises[f] + ": ");
                    for (int c = 0; c < temperaturas.GetLength(1); c++)
                    {
                        Console.Write(temperaturas[f, c] + " ");
                    }
                    Console.WriteLine();
                }
            }

            public void calcularMediaTrimestral()
            {
                mediasTrimestrales = new float[4];
                for (int f = 0; f < temperaturas.GetLength(0); f++)
                {
                    int suma = 0;
                    for (int c = 0; c < temperaturas.GetLength(1); c++)
                    {
                        suma = suma + temperaturas[f, c];
                    }
                    mediasTrimestrales[f] = (float)suma / 3;
                }
            }

            public void imprimirMediasTrimestrales()
            {
                Console.WriteLine("paises y sus medias trimestrales:");
                for (int f = 0; f < mediasTrimestrales.Length; f++)
                {
                    Console.WriteLine(paises[f] + ": " + mediasTrimestrales[f]);
                }
            }

            public void paisMayorMedia()
            {
                float mayor = mediasTrimestrales[0];
                string paisMayor = paises[0];

                for (int f = 1; f < mediasTrimestrales.Length; f++)
                {
                    if (mediasTrimestrales[f] > mayor)
                    {
                        mayor = mediasTrimestrales[f];
                        paisMayor = paises[f];
                    }
                }
                Console.WriteLine("el pais con la mayor temperatura media trimestral es: " + paisMayor);
            }

            static void Main(string[] args)
            {
                Program p = new Program();
                p.cargar();
                p.imprimirTemperaturas();
                p.calcularMediaTrimestral();
                p.imprimirMediasTrimestrales();
                p.paisMayorMedia();

                Console.ReadKey();
            }
        }
    }
