using System;

namespace ConsoleApp2
{
    public class Gasolina
    {
        double galones;
        double litros;
        double precio;
        double precioL;
        public Gasolina() 
        {         
            Console.WriteLine("Digite el precio por litro:");
        Precio1: do
            {
                try
                {
                    precio = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Input invalido");
                    goto Precio1;
                }
                if(precio < 0) 
                {
                    Console.WriteLine("Valor invalido");
                }
                
            } while (precio < 0);
        }
        public void ConvGL() 
        {
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de galones a suministrar:");
        Galon1: do
            {
                try
                {
                    galones = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Input invalido");
                    goto Galon1;
                }
                if (galones < 0)
                {
                    Console.WriteLine("Valor invalido");
                }
            } while (galones < 0);
            litros = galones * 3.7854;
            precioL = litros * precio;
            Console.WriteLine("\nEl precio por litro es de: {0:f3}", precio);
            Console.WriteLine("La conversion a litros es: {0:f3}", litros);
            Console.WriteLine("El precio a pagar es de: {0:f3}", precioL);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gasolina objCONV = new Gasolina();
            objCONV.ConvGL();
        }
    }
}
