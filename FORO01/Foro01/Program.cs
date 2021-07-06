using System;

namespace Foro01
{
    public class separarnum
    {
        public string snums;
        public separarnum()
        {
            Console.WriteLine("Ingrese los numeros que desea sumar separados por un espacio en blanco:");
            snums = Console.ReadLine();
        }
        public virtual int separacion()
        {
            return 0; 
        }        
    }
    public class separar : separarnum
    {
        public override int separacion()
        {
            string[] num = snums.Split(" ");
            int ap = 0;
            int i = 0;
            int ind = 0;
            bool negativo = false;
            foreach (string n in num)
            {
                ind++;
            }
            int[] arreglodenumeros = new int[ind];
           
            foreach (string n in num)
            {
                arreglodenumeros[i] = int.Parse(n);
                if (arreglodenumeros[i] < 0)
                {
                    negativo = true;
                }
                ap += arreglodenumeros[i];
                i++;
            }           
            if (negativo == false)
            {
                return ap;                
            }
            else 
            {
                return -1;
            }           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            inputs:
            separar objsep = new separar();
            try 
            {
                objsep.separacion();
            } 
             catch
            {
                Console.WriteLine("El input ingresado no es valido.");
                Console.ReadLine();
                Console.Clear();                
                goto inputs;
            }
            if(objsep.separacion()==-1)
            {
                Console.WriteLine("Se ha ingresado un numero negativo en la cadena.");
                Console.ReadLine();
                Console.Clear();              
                goto inputs;
            }
            Console.WriteLine("La suma total de los numeros de la cadena es:" + objsep.separacion());
        }
    }
}
