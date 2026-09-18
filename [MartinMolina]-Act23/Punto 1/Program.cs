using System;
using System.Collections.Generic;
using System.Threading;


/*1 - En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
llegada.
 Crear la clase Documento que contenga como atributos privados:
nombreArchivo (string) y cantidadPaginas (int). Definir sus
propiedades de solo lectura y un constructor que reciba los parámetros nom
y pag.
 Crear la clase ServidorImpresion que administre una lista dinámica de
documentos (List&lt;Documento&gt;).
 Métodos en ServidorImpresion:
1. AgregarDocumento(): Solicitar por teclado los datos de un
documento y agregarlo al final de la lista utilizando .Add().
2. ImprimirSiguiente(): Si la lista no está vacía, simular la
impresión del primer documento de la lista (mostrar sus datos en
consola) y removerlo de la colección mediante .RemoveAt(0). Si está
vacía, advertir que no hay trabajos pendientes.
3. MostrarColaPendiente(): Listar todos los documentos que
están esperando ser impresos y la cantidad total de páginas
acumuladas en la cola de espera utilizando .Count.*/


namespace Punto1
{

    class Documento
    {
        private string nombreArchivo;
        private int cantidadPaginas;

        public string NombreArchivo { get { return nombreArchivo; } }
        public int CantidadPaginas { get { return cantidadPaginas; } }

        public Documento(string nom, int pag)
        {
            nombreArchivo = nom;
            cantidadPaginas = pag;
        }
    }


    class ServidorImpresion
    {
        List<Documento> Documentos = new List<Documento>();

        public void AgregarDocumento()
        {
            Console.WriteLine("Ingrese el nombre del documento");
            string Nombre = Console.ReadLine();
            Console.WriteLine($"Ingrese la cantidad de paginas de {Nombre}");
            int Cantidad = int.Parse(Console.ReadLine());
            Documento documento = new Documento(Nombre, Cantidad);
            Documentos.Add(documento);
        }

        public void ImprimirSiguiente()
        {
            if (Documentos.Count != 0)
            {
                Documento DocumentoN1 = Documentos[0];
                Console.WriteLine($"Nombre del documento: {DocumentoN1.NombreArchivo}, Cantidad de paginas: {DocumentoN1.CantidadPaginas}");
                Thread.Sleep(1000);
                Console.WriteLine($"Impresion del documento terminada");
                Documentos.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("No hay documentos en lista para imprimir");
            }

        }

        public void MostrarColaPendiente()
        {
            int CantidadTotal = 0;
            foreach (Documento documento in Documentos)
            {
                Console.WriteLine($"Nombre del documento: {documento.NombreArchivo}, Cantidad de paginas: {documento.CantidadPaginas}");
                CantidadTotal = +documento.CantidadPaginas;
            }
            Console.WriteLine($"Cantidad de hojas a imprimir: {CantidadTotal}");
        }

        static void Main(string[] args)
        {
            ServidorImpresion Servidor = new ServidorImpresion();
            Servidor.AgregarDocumento();
            Servidor.ImprimirSiguiente();
            Servidor.MostrarColaPendiente();
            Console.ReadKey();
        }
    }
}