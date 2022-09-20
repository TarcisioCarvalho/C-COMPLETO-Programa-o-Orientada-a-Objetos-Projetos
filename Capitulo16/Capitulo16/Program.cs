using System;
using System.IO;
using System.Collections.Generic;
using Capitulo16.Entities;
using System.Linq;
using System.Globalization;

namespace Capitulo16
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercice2();
        }

        static void Exercice1()
        {
            string path = @"C:\Temp\in.csv";
            List<Product> products = new List<Product>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(";");

                        products.Add(new Product(line[0], double.Parse(line[1],CultureInfo.InvariantCulture)));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            var media = products.Select(p => p.Price).Average();
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));

           var names = products.Where(p=> p.Price < media).OrderByDescending(p=> p.Name).Select(p=>p.Name);

            foreach (string product in names)
            {
                Console.WriteLine(product);
            }
        }

        static void Exercice2()
        {
            List<Employee> employees = new List<Employee>();
            string path = @"C:\Temp\in.csv";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(";");

                        employees.Add(new Employee(line[0],line[1] ,double.Parse(line[2], CultureInfo.InvariantCulture)));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            double salaryReference = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var emails = employees.Where(e => e.Salary > 2000.00).Select(e => e.Email);

            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            var totalSalary = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            Console.WriteLine(totalSalary.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
