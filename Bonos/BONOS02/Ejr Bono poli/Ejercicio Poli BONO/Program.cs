using System;

namespace Ejercicio_Poli_BONO
{
    public class Cuenta
    {
        int cuenta;
        string nombre;
        double saldo;

        public void consulta()
        {

        }

        public double Deposito(double dep)
        {

            return dep;
        }
        public double Retiro(double ret)
        {

            return ret;
        }

    }

    public class Cahorro : Cuenta
    {
        int dia, mes, año;
        float intmensual;

        if (dia==1)
            {
            }

• Solamente se puede retirar dinero el día de la fecha de vencimiento

    }

    public class Ccheques : Cuenta
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
