using System;

namespace JavierCarrillo_10138957_grupo_1
{
    public class Publicacion
    {
        public string titulo;
        public float precio;
        public Publicacion()
        {
            titulo:
            titulo = string.Empty;
            Console.WriteLine("Ingrese el titulo:");
            titulo = Console.ReadLine();
            if(titulo==string.Empty)
            {
                Console.WriteLine("Introduzca un nombre valido.\n");
                Console.ReadKey();
                goto titulo;
            }
        precio11: try
            {
                do
                {
                    Console.WriteLine("Ingrese el precio:");
                    precio = float.Parse(Console.ReadLine());
                    if (precio < 0)
                    {
                        Console.WriteLine("El precio debe ser un numero positivo.");
                    }
                } while (precio < 0);
            }
            catch
            {
                Console.WriteLine("input invalido.");
                goto precio11;
            }

        }
 
        public void MostrarPublicacion()
        {
            Console.WriteLine("Titulo: {0}.", titulo);
            Console.WriteLine("Precio: ${0} PESOS DOMINICANOS.", precio);
        }
    }
    sealed class Libro : Publicacion
    {
        public int paginas;
        public Libro() 
        {     
            pag: try
            {
                do
                {
                    Console.WriteLine("Ingrese el numero de paginas:");
                    paginas = int.Parse(Console.ReadLine());
                    if (paginas < 1)
                    {
                        Console.WriteLine("El numero de paginas debe ser mayor de 0.");
                    }
                } while (paginas < 1);
            }
            catch
            {
                Console.WriteLine("input invalido.");
                goto pag;
            }
        }
  
        public void Mostrarlibro()
        {            
            Console.WriteLine("Paginas: {0}. \n", paginas);
        }
    }
     sealed class CD : Publicacion
    {
        public float tiempo;
        public CD() 
        {
        time: try
            {
                do
                {
                    Console.WriteLine("Ingrese la duracion del CD en minutos:");
                    tiempo = float.Parse(Console.ReadLine());
                    if (tiempo < 1)
                    {
                        Console.WriteLine("El tiempo debe ser mayor que 0.");
                    }
                } while (tiempo < 1);
            }
            catch
            {
                Console.WriteLine("input invalido.");
                goto time;
            }            
        }
        public void MostrarCD()
        {
            Console.WriteLine("Tiempo de duracion: {0} minutos.\n", tiempo);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            char flag;
            do
            {
                Console.WriteLine("INGRESE LOS DATOS DEL LIBRO FÍSICO: \n");
                Libro objlibro = new Libro();
                Console.Clear();
                Console.WriteLine("LIBRO FÍSICO: \n");
                objlibro.MostrarPublicacion();
                objlibro.Mostrarlibro();
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("INGRESE LOS DATOS DEL LIBRO AUDIO: \n");
                CD objCD = new CD();
                Console.Clear();
                Console.WriteLine("LIBRO CD: \n");
                objCD.MostrarPublicacion();
                objCD.MostrarCD();
                Console.ReadKey();
                Console.Clear();

            flag1: try
                {
                    do
                    {
                        Console.WriteLine("Desea ingresar mas datos? (S/N)");
                        flag = char.Parse(Console.ReadLine());
                        if (flag != 'n' && flag != 'N' && flag != 's' && flag != 'S')
                        {
                            Console.WriteLine("El caracter ingresado no es valido.");
                        }
                    } while (flag != 'n' && flag != 'N' && flag != 's' && flag != 'S');
                }
                catch
                {
                    Console.WriteLine("input invalido.");
                    goto flag1;
                }                                        
                Console.Clear();
                Console.WriteLine("Gracias por utilizar nuestros servicios.");
            } while (flag != 'n' && flag != 'N');                       
        }
    }
}
