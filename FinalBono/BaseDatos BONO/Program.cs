using System;
// Hay que tener instalado este paquete para que el cod. funcione
using MySql.Data.MySqlClient;

namespace FinalBono
{
    class Program
    {
        static string connection = "SERVER=localhost; PORT = 3306; uid = root; DATABASE=estudiantes; charset = utf8; sslMode = none";
        static MySqlConnection sqlcon = new MySqlConnection(connection);
        static void Main(string[] args)
        {
            
            using (sqlcon)
            {
                inicio: try

                {
                    Console.WriteLine("Connectando a MySql");
                    //entrada de datos
                    Console.WriteLine("ID estudiante:");
                    int Estudianteid = int.Parse(Console.ReadLine());


                    Console.WriteLine("Nombre estudiante:");
                    string Nombre = Console.ReadLine();
                    if (Nombre == string.Empty || Nombre.Length > 25)
                        goto inicio;
                   
                    Console.WriteLine("Apellido estudiante:");
                    string Apellido = Console.ReadLine();
                    if (Apellido == string.Empty || Apellido.Length > 25)
                        goto inicio;

                    Console.WriteLine("Sexo estudiante:");
                    string Sexo = Console.ReadLine();
                    if (Sexo == string.Empty || Sexo.Length > 1 || (Sexo != "M" && Sexo != "F" && Sexo != "m" && Sexo != "f"))
                        goto inicio;

                    Console.WriteLine("Direccion estudiante:");
                    string Direccion = Console.ReadLine();
                    if (Direccion == string.Empty || Direccion.Length > 15)
                        goto inicio;

                    string query = "insert into Estudiante values(" + Estudianteid + ", '" + Nombre + "', '" + Apellido + "', '" + Sexo + "', '" + Direccion + "') ";
                    Console.WriteLine(query);
                    //iniciar coneccion a base de datso
                    sqlcon.Open();
                    Console.WriteLine("Connection done " + sqlcon.State.ToString() + Environment.NewLine);
                    //
                    MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                    int result = cmd.ExecuteNonQuery();
                    Console.WriteLine(result + "record/s inserted in Estudiante table");
                    //
                    MySqlCommand command = sqlcon.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "Select * from Estudiante";

                    MySqlDataReader reader = command.ExecuteReader();
                    var data = "[Id]\t[Nombre]\t[Apellido]\t[Sexo]\t[Direccion]\n";


                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            data += reader.GetInt32(0) + "\t" + reader.GetString(1) + "\t\t" + reader.GetString(2) + "\t\t" + reader.GetString(3) + "\t" + reader.GetString(4) + Environment.NewLine;
                        }
                        Console.WriteLine(data);
                    }
                    else
                    {
                        Console.WriteLine("TABLA VACIA");
                    }
                    reader.Close();

                    sqlcon.Close();
                    Console.WriteLine("Connection done " + sqlcon.State.ToString() + Environment.NewLine);
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message.ToString());
                }
                catch(FormatException ee)
                {
                    Console.WriteLine("Error: " + ee.Message);
                    goto inicio;
                }
                finally
                {
                    Console.WriteLine("Presiona cualquier tecla...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}