using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Capitulo13
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Temp\arquivo.csv";
            string newFolder =  @"C:\Temp\out";
            string targetPath = @"C:\Temp\out\arquivoCopiado.csv";

            List<string[]> vs = new List<string[]>();
            try
            {
                using var file = new StreamReader(sourcePath);
                string? line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] linhaInformacoes = line.Split(";");
                    vs.Add(linhaInformacoes);
                }
                file.Close();

                List<string> vsAux = new List<string>();

                foreach (string[] linhaInformacao in vs)
                {
                    double tot = double.Parse(linhaInformacao[1],CultureInfo.InvariantCulture) * int.Parse(linhaInformacao[2]);
                    string totString = tot.ToString("F2",CultureInfo.InvariantCulture);
                    vsAux.Add($"{linhaInformacao[0]};{totString}");
                    Console.WriteLine($"{linhaInformacao[0]};{totString}");
                }

                Directory.CreateDirectory(newFolder);
                File.WriteAllLines(targetPath, vsAux);

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
                
            }
            
        }
    }
}
