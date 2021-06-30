using System;

namespace Ejercicio_Citas
{
    class citas
    {
        public string dia, cadena;
        public int hora, minuto;
        public citas(int hora, int minuto, string dia, string cadena)
        {
            try
            {
                this.hora = hora;
                if(hora < 0 || hora > 23)
                {
                    throw new ArgumentException("La hora no es valida.");
                }
            }
            catch(ArgumentException err)
            {
                Console.WriteLine("Excepcion {0}", err.Message);
            }
            try
            {
                this.minuto = minuto;
                if (minuto < 0 || minuto > 59)
                {
                    throw new ArgumentException("El minuto no es valido.");
                }
            }
            catch (ArgumentException err)
            {
                Console.WriteLine("Excepcion {0}", err.Message);
            }
            try
            {
                this.dia = dia;
                if (dia != "Lunes" && dia != "Martes" && dia != "Miercoles" && dia != "Jueves" && dia != "Viernes" && dia != "Sabado" && dia != "Domingo" && dia != "lunes" && dia != "martes" && dia != "miercoles" && dia != "jueves" && dia != "viernes" && dia != "sabado" && dia != "domingo")
                {
                    dia = "(Dia no valido)";
                    throw new ArgumentException("El dia no es valido.");                  
                }
            }
            catch (ArgumentException err)
            {
                Console.WriteLine("Excepcion {0}", err.Message);
            }
            
            this.cadena = cadena;
            Console.WriteLine("La cita es el {0}, a las {1}:{2}, por: {3}", dia, hora, minuto, cadena);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            citas objcita = new citas(22, 50, "Lunes", "AAA");
        }
    }
}
