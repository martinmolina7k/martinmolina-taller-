using System;

namespace Punto_1
{   
    //1. Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
     //CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
     //generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
     //generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
     //imprimir estos datos básicos.
     //Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
     //un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
     //en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero).
     //Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
     //En el programa principal (Main):
     //● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
     //● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
     //puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
     //muestra de información.

    class DispositivoEnergia
    {
        private string codigoIndentificador;
        private double generacionKwh;

        public DispositivoEnergia()
        {
            Console.WriteLine("Ingrese el codigo indentificador :");
            codigoIndentificador = Console.ReadLine();
            Console.WriteLine("Ingrese la generacion de kilowatts por hora");
            generacionKwh = int.Parse(Console.ReadLine());
            if (GeneracionKwh < 0)
            {
                GeneracionKwh = 0;
            }
        }

        public string CodigoIndentificador
        {
            get { return codigoIndentificador; }
            set { codigoIndentificador = value; }
        }
        public double GeneracionKwh
        {
            get { return generacionKwh; }
            set { generacionKwh = value; }
        }

        public void ImprimirDispositivo()
        {
            Console.WriteLine($"Codigo indentificador : {CodigoIndentificador}, Generacion de kilowatts por hora : {GeneracionKwh}/h");
        }
    }

    class PanelSolar : DispositivoEnergia
    {
        private double areaMetros;

        public PanelSolar()
        {
            Console.WriteLine("Ingrese la superficie del panel en metros cuadrados");
            AreaMetros = int.Parse(Console.ReadLine());
            while (AreaMetros < 0)
            {
                Console.WriteLine("La superficie no puede ser menor a 0");
                AreaMetros = int.Parse(Console.ReadLine());
            }
        }

        public double AreaMetros
        {
            get { return areaMetros; }
            set { areaMetros = value; }
        }

        public void ImprimirPanel()
        {
            Console.WriteLine($"Codigo indentificador : {CodigoIndentificador}, Generacion de kilowatts por hora : {GeneracionKwh}/h, Superficie del panel : {AreaMetros}m2");
        }

        static void Main(string[] args)
        {
            DispositivoEnergia dispositivo = new DispositivoEnergia();
            PanelSolar panel = new PanelSolar();
            dispositivo.ImprimirDispositivo();
            panel.ImprimirPanel();
            Console.ReadKey();
        }
    }
}

