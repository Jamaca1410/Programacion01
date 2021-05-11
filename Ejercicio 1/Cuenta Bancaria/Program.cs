using System;

namespace Cuenta_Bancaria
{
    public class CuentaB
    {
        public double Balance = 9000000;
        public int NoCuenta = 708117810;
        public string Nombre = "Juan";
        public string Apellido = "Perez";
        public string FechVencimiento = "5/27";

    }
 
    public class empleado
    {
        public string nombre = "Marco";
        public string apellido = "Vargas";
        public double Sueldo = 15000.00;
        public char sexo = 'M';
        public string cargo = "Analista de datos";
        public long cedula = 40212345868;

    }
    public class program
    {
        public static void Main()
        {
            Console.WriteLine("Clases Cuanta Bancaria: ");
            CuentaB objcuentaB = new CuentaB();
            Console.WriteLine("Nombre =" + objcuentaB.Nombre);
            Console.WriteLine("Apellido =" + objcuentaB.Apellido);
            Console.WriteLine("No. Cuenta =" + objcuentaB.NoCuenta);
            Console.WriteLine("Balance =" + objcuentaB.Balance);
            Console.WriteLine("Fecha de Vencimiento =" + objcuentaB.FechVencimiento);
            Console.WriteLine("\n Clases Empleado: ");
            empleado objempleado = new empleado();
            Console.WriteLine("Nombre = " + objempleado.nombre);
            Console.WriteLine("Apellido = " + objempleado.apellido);
            Console.WriteLine("Sueldo = " + objempleado.Sueldo);
            Console.WriteLine("Sexo = " + objempleado.sexo);
            Console.WriteLine("Cargo = " + objempleado.cargo);
            Console.WriteLine("Cédula = " + objempleado.cedula);
        }
    }

}
