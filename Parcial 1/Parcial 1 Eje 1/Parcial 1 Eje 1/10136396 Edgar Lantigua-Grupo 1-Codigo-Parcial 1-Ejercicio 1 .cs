using System;
using System.Text.RegularExpressions;

namespace Parcial_1_Eje_1
{
    public class Persona
    {
        long cedula;
        int edad;
        char sexo;
        string nombre;
        bool flag1 = true;

        public Persona() // Constructor por defecto
        {
            do //NOMBRE
            {
                Console.WriteLine("Ingrese la nombre:");
                nombre = Console.ReadLine();
                if (Regex.IsMatch(nombre, "[0-9!~`@#$%^&*()_+=]"))
                {
                    Console.WriteLine("Nombre introducido no valido.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (Regex.IsMatch(nombre, "[0-9!~`@#$%^&*()_+=]"));

        //EDAD
            do
            {
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Ingrese la edad:");
                try
                {
                    edad = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Input Invalido");
                }
                if (edad < 1 || edad > 200)
                {
                    Console.WriteLine("La edad no es valida.");
                }
            } while (edad < 1 || edad > 200);

            //CEDULA
            if (edad > 15)
            {
            do
                {
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Ingrese los 11 digitos de la cedula:");
                    try
                    {
                        cedula = long.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Input Invalido");
                        
                    }
                    if (cedula < 9999999999 || cedula >= 99999999999)
                    {
                        Console.WriteLine("La cedula no es valida.");
                    }
                } while (cedula < 9999999999 || cedula >= 99999999999);
            }

        //SEXO
        do
            {
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Ingrese el sexo, Masculino(M) o Femenino(F):");
                try
                {
                    sexo = char.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Input Invalido");
                }
                if (sexo != 'M' && sexo != 'F' && sexo != 'f' && sexo != 'm')
                {
                    Console.WriteLine("Solo se puede ingresar M o F.");
                }
            } while (sexo != 'M' && sexo != 'F' && sexo != 'f' && sexo != 'm');

            Console.Clear();     
        }
        public void mostrar() // Metodo mostrar
        {
            if (edad > 15)
            {
                Console.WriteLine("La cedula del ciudadano es: {0}", cedula);
            }
            Console.WriteLine("La nombre del ciudadano es: {0}", nombre);
            Console.WriteLine("La edad del ciudadano es: {0}", edad);
            Console.WriteLine("La sexo del ciudadano es: {0}", sexo);
        }
        public void MayorEdad() // Metodo mayor de edad
        {
            Console.WriteLine("\nEs mayor de edad:");
            if (edad > 17)
            {
                flag1 = true;
                Console.WriteLine("Ël ciudadano es mayor de edad: {0}", flag1);
            }
            else
            {
                flag1 = false;
                Console.WriteLine("Ël ciudadano es mayor de edad: {0}", flag1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona objmostrar = new Persona();
            objmostrar.mostrar();
            objmostrar.MayorEdad();
        }
    }
}
