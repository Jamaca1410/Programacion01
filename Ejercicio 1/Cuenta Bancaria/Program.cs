using System;

namespace Cuenta_Bancaria
{
    public class Cuenta 
    {
        public Double Balance = 9000000;
        public int NoCuenta = 708117810;
        public string Nombre = "Juan";
        public string Apellido = "Perez";
        public string FechVencimiento = "5/27";

    }
    public class Program
    {
       public static void Main()
        {
            Cuenta objcuenta = new Cuenta();
            Console.WriteLine("Nombre =" + objcuenta.Nombre);
            Console.WriteLine("Apellido =" + objcuenta.Apellido);
            Console.WriteLine("No. Cuenta =" + objcuenta.NoCuenta);
            Console.WriteLine("Balance =" + objcuenta.Balance);
            Console.WriteLine("Fecha de Vencimiento =" + objcuenta.FechVencimiento);
        }
    }
    
}
