using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesaCambios
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> lineas = new List<string>();

            Console.WriteLine("procesando...");
            using (var stream = File.Open(@"C:\SourceCode\CambiosLista.txt", FileMode.Open))
            {
                using (var stream2 = File.Open(@"C:\SourceCode\CambiosLista_Files.txt", FileMode.Create))
                {
                    StreamWriter writer = new StreamWriter(stream2);
                    using (var reader = new StreamReader(stream))
                    {
                        string linea = null;
                        while ((linea = reader.ReadLine()) != null)
                        {
                            if (linea.StartsWith("Modified:") || linea.StartsWith("Added:") || linea.StartsWith("Rename:"))
                            {
                                int dosPuntos = linea.IndexOf(':') + 1;
                                linea = linea.Substring(dosPuntos, linea.Length - dosPuntos).Trim();

                                if (!lineas.Contains(linea))
                                {
                                    writer.WriteLine(linea);
                                    lineas.Add(linea);
                                }
                            }
                        }

                        writer.Flush();
                        writer.Close();
                    }
                }  
            }
            Console.WriteLine("Listo");
            Console.ReadLine();
        }
    }
}
