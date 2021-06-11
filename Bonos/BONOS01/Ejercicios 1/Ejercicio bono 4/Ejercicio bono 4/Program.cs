using System;

public class Herencia2
{
    public class Auto
    {
        int NumeroSerie, year;
        string marca;
        float precio;

        public Auto()
        {
            Console.WriteLine("Ingrese numero de serie:");
            NumeroSerie = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese año del vehiculo:");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese marca del vehiculo:");
            marca = Console.ReadLine();

            Console.WriteLine("Ingrese precio del vehiculo:");
            precio = float.Parse(Console.ReadLine());
        }
        public void mostrarauto()
        {
            Console.WriteLine("Numero de serie: {0}", NumeroSerie);
            Console.WriteLine("Año del vehiculo: {0}", year);
            Console.WriteLine("Marca: {0}", marca);
            Console.WriteLine("Precio: {0}", precio);
        }
    }
    public class AutosyVagonetas : Auto
    {
        int cantpasajeros;
        
        public AutosyVagonetas()
        {
            Console.WriteLine("Ingrese cantidad de pasajeros:");
            cantpasajeros = int.Parse(Console.ReadLine());            
        }
        public void mostrarsubclass1()
        {
            Console.WriteLine("Cantidad de Pasajeros: {0}", cantpasajeros);
          
        }
    }
    public class Camionetas : Auto
    {
        float carga; //Este valor es en Kg
        int cantidaddeejer;
        int rodadas;

        public Camionetas()
        {
            Console.WriteLine("Ingrese capacidad de carga:");
            carga = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de ejes:");
            cantidaddeejer = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de rodadas:");
            rodadas = int.Parse(Console.ReadLine());
        }
        public void mostrarsubclass2()
        {
            Console.WriteLine("Capacidad de carga: {0}", carga);
            Console.WriteLine("Cantidad de ejes: {0}", cantidaddeejer);
            Console.WriteLine("Cantidad de rodadas: {0}", rodadas);
        }

    }
    class Program
    {
        static void Main()
        {
            Camionetas objcamioneta = new Camionetas();
            AutosyVagonetas objau = new AutosyVagonetas();
            objcamioneta.mostrarauto();
            objcamioneta.mostrarsubclass2();
            objau.mostrarsubclass1();
        }
    }
}