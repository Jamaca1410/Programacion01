using System;

namespace Herencia
{
    public class Publicacion
    {
        public string titulo;
        public int precio;


        Console.WriteLine("Ingrese el titulo:");
        titulo = Console.ReadLine();
        Console.WriteLine("Ingrese el precio:");
        precio = int.Parse(Console.ReadLine());
        
        public void MostrarPublicacion()
        {
            Console.WriteLine("Titulo: ", titulo);
            Console.WriteLine("Precio: ", precio);
        }
    }
    class Libro : Publicacion
    {
        public int paginas;

        public void EscribirLibro()
        {
            Console.WriteLine("Ingrese el numero de paginas:");
            paginas = int.Parse(Console.ReadLine());
        }
        public void Mostrarlibro()
        {
            Console.WriteLine("Paginas: ", paginas);
        }
    }
    class CD : Publicacion
    {
        public float tiempo;
 
        public void EscribirCD()
        {
            Console.WriteLine("Ingrese la duracion del CD:");
            tiempo = float.Parse(Console.ReadLine());
        }
        public void MostrarCD()
        {
            Console.WriteLine("Tiempo de duracion:", tiempo);
        }

    }
    class Program
    {
        static void Main()
        {
            Publicacion obj = new Publicacion();
            Libro objlibro = new Libro();
            CD objcd = new CD();

            obj.Escribir();
            objlibro.EscribirLibro();
            objcd.EscribirCD();
            obj.MostrarPublicacion();
            objlibro.Mostrarlibro();
            objcd.MostrarCD();
            Console.ReadLine();
        }                              
    }
}