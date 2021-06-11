using System;

namespace Herencia
{
    public class Publicacion
    {
        public string titulo;
        public int precio;
        public Publicacion(string titulo, int precio)
        {
            this.titulo = titulo;
            this.precio = precio;
        }
        public void Escribir()
        {
            Console.WriteLine("Ingrese el titulo:");
            titulo = Console.ReadLine();
            Console.WriteLine("Ingrese el precio:");
            precio = int.Parse(Console.ReadLine());
        }
        public void MostrarPublicacion()
        {
            Console.WriteLine("Titulo: {0}", titulo);
            Console.WriteLine("Precio: {0}", precio);
        }
    }
    class Libro : Publicacion
    {
        public int paginas;
        public Libro(string titulo, int precio, int paginas) : base(titulo, precio)
        {
            this.paginas = paginas;
        }
        public void EscribirLibro()
        {
            Console.WriteLine("Ingrese el numero de paginas:");
            paginas = int.Parse(Console.ReadLine());
        }
        public void Mostrarlibro()
        {
            Console.WriteLine("Paginas: {0}", paginas);
        }
    }
    class CD : Publicacion
    {
        public float tiempo;
        public CD(string titulo, int precio, int tiempo) : base(titulo, precio)
        {
            this.tiempo = tiempo;
        }
        public void EscribirCD()
        {
            Console.WriteLine("Ingrese la duracion del CD:");
            tiempo = float.Parse(Console.ReadLine());
        }
        public void MostrarCD()
        {
            Console.WriteLine("Tiempo de duracion: {0}", tiempo);
        }

    }
    class Program
    {
        static void Main()
        {
            Libro objlibro = new Libro("El viejo verde", 800, 700);
            objlibro.MostrarPublicacion();
            objlibro.Mostrarlibro();
            CD objlibr = new CD("El viejo verde", 800, 700);
            objlibr.MostrarPublicacion();
            objlibr.MostrarCD();
        }
    }
}