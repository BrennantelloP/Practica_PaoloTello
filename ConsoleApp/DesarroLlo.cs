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
                Console.Read();

              
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
            catch (OutOfMemoryException ex)
            {
                Log.Error("Error en:" + ex.Message);
                Console.WriteLine("Error:" + ex.Message);
            }
            catch (IOException ex)
            {
                Log.Error("Error en:" + ex.Message);
                Console.WriteLine("Error:" + ex.Message);
            }
            catch (Exception ex)
            {
                Log.Error("Error en:" + ex.Message);
                Console.WriteLine("Error:" + ex.Message);
            }


        }
        }
    }

