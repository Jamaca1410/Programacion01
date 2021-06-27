using System;

namespace Ejercicio_2
{
    public abstract class cuadrilatero
    {
       public double base1;
        public cuadrilatero()
        {
            lado11:  try
            { 
                 do
                 {
                    Console.WriteLine("Ingrese la longitud de la base:");
                    base1 = double.Parse(Console.ReadLine());
                     if (base1 < 1)
                     {
                          Console.WriteLine("El numero debe ser positivo.");
                     }
                 }while (base1 < 1);
            }
            catch 
            {
                Console.WriteLine("input invalido.");
                goto lado11;
            }
       }
        public virtual void calculararea(){}
    }
    public class cuadrado : cuadrilatero
    {
        public double square;
        public override void calculararea()
        {
            square = Math.Pow(base1, 2);
            Console.WriteLine("Area del cuadrado: {0}", square);
        }
    }
    public class rectangulo : cuadrado
    {
        public double altura1;
        public double rectang;
        public rectangulo()
        {
        altura11: try
            {
                do
                {
                    Console.WriteLine("Ingrese la longitud de la altura:");
                    altura1 = double.Parse(Console.ReadLine());
                    if (altura1 < 1)
                    {
                        Console.WriteLine("El numero debe ser positivo.");
                    }
                } while (altura1 < 1);
            }
            catch
            {
                Console.WriteLine("input invalido.");
                goto altura11;
            }
        }
        public override void calculararea()
        {
            rectang = base1 * altura1;
            Console.WriteLine("Area del rectángulo: {0}", rectang);
        }
    }
    public class trapecio : rectangulo
    {
        public double ladosup;
        public double trap;
        public trapecio(double ladosup)
        {
            this.ladosup = ladosup;
        }
        public override void calculararea()
        {
            trap = ((base1 + ladosup) /2)*altura1;
            Console.WriteLine("Area del trapecio: {0}", trap);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double ladosup;
            Console.WriteLine("Area del CUADRADO");
            cuadrado objcuadrado = new cuadrado();
            objcuadrado.calculararea();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Area del RECTANGULO");
            rectangulo objrectangulo = new rectangulo();
            objrectangulo.calculararea();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Area del TRAPECIO");
            ladosuo11: try
             {
                do
                {
                    Console.WriteLine("Ingrese la longitud del lado superior:");
                    ladosup = double.Parse(Console.ReadLine());
                    if (ladosup < 1)
                    {
                        Console.WriteLine("El numero debe ser positivo.");
                    }
                } while (ladosup < 1);
            }
             catch
             {
                Console.WriteLine("input invalido.");
                goto ladosuo11;
             }       
            trapecio objtrapecio = new trapecio(ladosup);
            objtrapecio.calculararea();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
