using System;
using System.IO;
using Serilog;

namespace ConsoleApp
{
    internal class DesarroLlo
    {
      
            static void Main(string[] args)
            {
                string diactual="";
                DateTime diaactual = DateTime.Today;
                diactual = diaactual.ToString("d");
                string[] s = diactual.Split('/');
                Log.Logger = new LoggerConfiguration()
                    .WriteTo.File("Logs/Log_" + s[2] + s[1] + s[0] + ".txt").CreateLogger();

            }
        }
    }

