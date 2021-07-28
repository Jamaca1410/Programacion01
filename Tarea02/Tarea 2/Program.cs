using System;
using System.IO;
using System.Text.RegularExpressions;

public class exepcionP : Exception
{
    public exepcionP(string str)
    {
       
    }
}

namespace Tarea02
{

    public class Datos
    {
        public string asignatura, aula, instructor;
        public int creditos;
        public bool xd = true, zd =true;
        public Datos()
        {
            Console.WriteLine("Ingrese el nombre de la asignatura:");
            asignatura = Console.ReadLine();      
            Console.WriteLine("Ingrese el aula de la asignatura:");
            aula = Console.ReadLine();   

            credi: try
            {
                Console.WriteLine("Ingrese los creditos de la asignatura:");
                creditos = int.Parse(Console.ReadLine());
                if (creditos < 0)
                {
                    throw new exepcionP("");
                }
                zd = true;
            }
            catch (exepcionP)
            {
                Console.WriteLine("Los creditos no pueden ser menor que 0.");
                zd = false;
                goto credi;
            }
            catch(FormatException)
            {
                Console.WriteLine("El input es invalido.");
                zd = false;
                goto credi;
            }
          
            finally
            {
                if(creditos > -1 && zd == true)
                Console.WriteLine("El dato fue regristrado");        
            }
            nom: try
            {
                Console.WriteLine("Ingrese el nombre del instructor:");
                instructor = Console.ReadLine();
                if (Regex.IsMatch(instructor, @"^[0-9]+$"))
                {
                    throw new exepcionP("");
                }
                xd = true;
            }
            catch(exepcionP)
            {
                Console.WriteLine("Los nombres no pueden ser numeros.");
                xd = false;
                goto nom;               
            }
            finally
            {
                if (xd == true)
                {
                    Console.Clear();
                }       
            }
        }
        public virtual void mostrarDatos()
        {
            Console.WriteLine("La asignatura es:" + asignatura);
            Console.WriteLine("El aula es:" + aula);
            Console.WriteLine("Los creditos de la asignatura son:" + creditos);
        }
    }
    public class evaluacion : Datos
    {
        public override void mostrarDatos()
        {
            string path = @"C:\Users\Javier Carrillo\Desktop\tarea.txt"; // EL PATH DEL ARCHIVO VARIA EN CADA EQUIPO
            if (!File.Exists(path))
            {
                string inicio = "Datos de la asignatura:" + Environment.NewLine;
                File.WriteAllText(path, inicio);
            }
            var ne = Environment.NewLine;
            string appendt = ne + "La asignatura es: " + asignatura + ne + "El aula es: " + aula + ne + "Los creditos de la asignatura son: " + creditos + ne + "El instructr asignatura es: " + instructor + ne;
            File.AppendAllText(path, appendt);

            try 
            {
                Console.WriteLine("Los datos del archivo son: \n");
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("La ubicacion del archivo no fue encontrada.");
                Console.WriteLine("Ingrese la ubicacion correcta.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            evaluacion lol = new evaluacion();
            lol.mostrarDatos();
        }
    }
}
