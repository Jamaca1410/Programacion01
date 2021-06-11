using System;

namespace Ejercicio_bono_1
{
    public class telefono
    {
        string modelo, fabricante, proprietario;
        float precio;
        string[] bateria = {"","",""};
        string[] pantalla = {"", ""};
        public telefono() 
        {
            Console.WriteLine("Ingrese el modelo del telefono:");
            modelo = Console.ReadLine();
            Console.WriteLine("Ingrese el fabricante del telefono:");
            fabricante = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del telefono:");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el propietario del telefono:");
            proprietario = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo de la bateria:");
            bateria[0] = Console.ReadLine();
            Console.WriteLine("Ingrese el tiempo de inactividad de la bateria:");
            bateria[1] = Console.ReadLine();
            Console.WriteLine("Ingrese horas de conversacion del telefono:");
            bateria[2] = Console.ReadLine();
            Console.WriteLine("Ingrese el tamaño de la pantalla:");
            pantalla[0] = Console.ReadLine();
            Console.WriteLine("Ingrese los colores de la pantalla:");
            pantalla[1] = Console.ReadLine();
        }
        public void mostrar()
        {
            Console.Clear();
            Console.WriteLine("El modelo del telefono es: {0}", modelo);
            Console.WriteLine("El fabricanta del telefono es: {0}", fabricante);
            Console.WriteLine("El precio del telefono es: {0}", precio);
            Console.WriteLine("El propietario del telefono es: {0}", proprietario);
            Console.WriteLine("El modelo de la bateria es: {0}", bateria[0]);
            Console.WriteLine("El tiempo de inactividad de la bateria es: {0}", bateria[1]);
            Console.WriteLine("Las horas de conversacion del telefono son: {0}", bateria[2]);
            Console.WriteLine("El tamaño de la pantalla es: {0}", pantalla[0]);
            Console.WriteLine("Los colores de la pantalla son: {0}", pantalla[1]);

        } 

    }
    class Program
    {
        static void Main(string[] args)
        {
            telefono obj = new telefono();
            obj.mostrar();
        }
    }
}
