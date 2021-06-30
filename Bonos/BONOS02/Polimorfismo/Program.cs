using System;

namespace Polimorfismo
{
    public abstract class Animal
    {
        public int peso;
        public Animal()
        {
            do
            {
            an: try
                {
                    Console.WriteLine("Ingrese el peso del animal en kilos:");
                    peso = int.Parse(Console.ReadLine());
                    if (peso < 1)
                    {
                        Console.WriteLine("El peso del animal debe ser un numero positivo.");
                    }
                }
                catch
                {
                    Console.WriteLine("El input ingresado es invalido.");
                    goto an;
                }                
            } while(peso<1);
            Console.WriteLine("El animal pesa: {0} Kilos.", peso);
        }
        public virtual string Dice(){ return ""; }
    }

    public class Vaca : Animal
    {
        public override string Dice() 
        {
            return "mu";
        }
    }

    public class Serpiente : Animal
    {
        public override string Dice()
        {
            return "sss";
        }
    }

    public class Cerdo : Animal
    {
        public override string Dice()
        {
            return "oinc";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vaca mascotaVaca = new Vaca(); 
            Console.WriteLine(mascotaVaca.Dice());
            Serpiente mascotaSerpiente = new Serpiente();      
            Console.WriteLine(mascotaSerpiente.Dice());
            Cerdo mascotaCerdo = new Cerdo();           
            Console.WriteLine(mascotaCerdo.Dice());
        }
    }
}
