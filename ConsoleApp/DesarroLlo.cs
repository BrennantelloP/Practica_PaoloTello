using System;
using System.IO;
using Serilog;

namespace ConsoleApp
{
    internal class DesarroLlo
    {
      
            static void Main(string[] args)
        {
            int edad = 1;
            string genero;
            bool sexo = false;
            String nombre = "";
            string diactual="";
                DateTime diaactual = DateTime.Today;
                diactual = diaactual.ToString("d");
                string[] s = diactual.Split('/');
                Log.Logger = new LoggerConfiguration()
                    .WriteTo.File("Logs/Log_" + s[2] + s[1] + s[0] + ".txt").CreateLogger();
           
            Console.WriteLine("Agregar Nombre:");

            try
            {
                Log.Information("insertar nombre");
                nombre = Console.ReadLine();

              
            }
            catch (OutOfMemoryException ex)
            {
                Log.Error("Error en:" + ex.Message);
                Console.WriteLine("Error:" + ex.Message);
            }

            catch (Exception ex)
            {
                 Log.Error("Error en:" + ex.Message);
                Console.WriteLine("Error:" + ex.Message);
            }


            Console.WriteLine("Agregar edad");
            try
            {
               
                edad = int.Parse(Console.ReadLine());
               
                Log.Information("se agrego edad");
            }
           
            catch (FormatException ex)
            {
                Log.Error("Error en:" + ex.Message);
                Console.WriteLine("Error:" + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Log.Error("Error en:" + ex.Message);
                Console.WriteLine("Error:" + ex.Message);
            }
            catch (OverflowException ex)
            {
                Log.Error("Error en:" + ex.Message);
                Console.WriteLine("Error:" + ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Log.Error("Error en:" + ex.Message);
                Console.WriteLine("Error:" + ex.Message);
            }
            catch (IOException ex)
            {
                Log.Error("Error en:" + ex.Message);
                Console.WriteLine("Error:" + ex.Message);
            }

            Console.WriteLine("Agregar sexo:");
            try
            {
                sexo = bool.Parse(Console.ReadLine());
                Log.Information("sexo ingresado");
            }
            catch (ArgumentNullException ex)
            {
                Log.Error("Error en:" + ex.Message);
                Console.WriteLine("Error:" + ex.Message);
            }
            catch (FormatException ex)
            {
                Log.Error("Error en:" + ex.Message);
                Console.WriteLine("Error:" + ex.Message);
            }
            Console.Write("Hola " + nombre + ", " + edad + " años");
            if (sexo)
            {
                genero = "masculino";
            }
            else
            {
                genero = "femenino";
            }

            Console.Write("  género " + genero);
            Console.Read();

        }
        }
    }

