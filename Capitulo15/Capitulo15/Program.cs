using System;
using System.Collections.Generic;
using System.IO;

namespace Capitulo15
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercice2();
        }

        static void Exercice1()
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int an = int.Parse(Console.ReadLine());
            AdicionaHashSet(an, A);
            Console.Write("How many students for course B? ");
            int bn = int.Parse(Console.ReadLine());
            AdicionaHashSet(bn, B);
            Console.Write("How many students for course C? ");
            int cn = int.Parse(Console.ReadLine());
            AdicionaHashSet(cn, C);

            HashSet<int> ABC = new HashSet<int>();
            ABC.UnionWith(A);
            ABC.UnionWith(B);
            ABC.UnionWith(C);

            Console.WriteLine("Total Students " + ABC.Count);
        }

        static void AdicionaHashSet(int an, HashSet<int> collection)
        {
            for (int i = 0; i < an; i++)
            {
                int matricula = int.Parse(Console.ReadLine());
                collection.Add(matricula);
            }
        }

        static void Exercice2()
        {
            Dictionary<string, int> Candidato = new Dictionary<string, int>();

            string path = @"C:\Temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                        if (Candidato.ContainsKey(line[0])) Candidato[line[0]] += int.Parse(line[1]);
                        if (!Candidato.ContainsKey(line[0])) Candidato.Add(line[0], int.Parse(line[1])); ;
                        
                    }

                    foreach (var candidato in Candidato)
                    {
                        Console.WriteLine($"{candidato.Key} : {candidato.Value}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
