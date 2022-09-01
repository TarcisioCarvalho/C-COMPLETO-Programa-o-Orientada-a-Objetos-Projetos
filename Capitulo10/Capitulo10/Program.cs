using Capitulo10.Entities;
using System;
using System.Collections.Generic;

namespace Capitulo10
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercice1();
        }

        static void Exercice1()
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{1} data:");
                Console.Write("Outsourced (y/n)? ");
                char yN = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                if (yN == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    Employee employee = new OutsourcedEmployee(name,hours,valuePerHour,additionalCharge);
                    employees.Add(employee);
                    
                }else if(yN == 'n')
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees.Add(employee);
                }

                
            }

            foreach (Employee employee in employees)
            {
                Console.Write($"{employee.Name} - $ {employee.payment()} ");
            }
        }
    }
}
