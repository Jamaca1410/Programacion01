using System;

namespace Ejercicio_bono_2
{
    public class fecha
    {
        int mes, dia, año;
        public fecha(int mes, int dia, int año) 
        {
            this.mes = mes;
            this.dia = dia;
            this.año = año;
            if (mes > 12 || mes < 1)
            {
                this.mes = 1;
            }
        }
        public void datos()
        {
            Console.WriteLine("Ingrese el dia:");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia:");
            dia = int.Parse(Console.ReadLine());
            if (mes > 12 || mes < 1)
            {
                dia = 1;
            }
        }
        public void imprimir()
        {
            Console.WriteLine("La fecha es: {0}/{1}/{2}", dia, mes, año);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            fecha obj = new fecha(1, 1, 2001);
            obj.imprimir();
        }
    }
}
