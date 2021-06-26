using System;

namespace JavierCarrillo_10138957_grupo_1
{
    public class Publicacion
    {
        public string titulo;
        public int precio;
        public Publicacion()
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
    sealed class Libro : Publicacion
    {
        public int paginas;
        public Libro() 
        {
            this.paginas = paginas;
            Console.WriteLine("Ingrese el numero de paginas:");
            paginas = int.Parse(Console.ReadLine());
        }
  
        public void Mostrarlibro()
        {            
            Console.WriteLine("Paginas: {0} \n", paginas);
        }
    }
     sealed class CD : Publicacion
    {
        public float tiempo;
        public CD() 
        {
            Console.WriteLine("Ingrese la duracion del CD en minutos:");
            tiempo = float.Parse(Console.ReadLine());
        }

        public void MostrarCD()
        {
            Console.WriteLine("Tiempo de duracion: {0} \n", tiempo);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            char flag;
            do
            {
                Libro objlibro = new Libro();
                objlibro.MostrarPublicacion();
                objlibro.Mostrarlibro();
                CD objCD = new CD();
                objCD.MostrarPublicacion();
                objCD.MostrarCD();

            flag:
                Console.WriteLine("Desea ingresar mas datos? (y/n)");
                try
                {
                    if()
                    {
                        flag = char.Parse(Console.ReadLine());
                    }   
                }
                
                catch
                {
                    Console.WriteLine("Input invalido");
                    goto flag;
                }
                Console.Clear();
            } while (flag != 'n' && flag != 'N');
            
           
        }
    }
}
