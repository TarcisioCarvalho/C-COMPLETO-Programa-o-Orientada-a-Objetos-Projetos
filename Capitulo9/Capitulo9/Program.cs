using Capitulo9.Entities;
using Capitulo9.Entities.Enums;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Capitulo9
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercice3();
        }

        static void Exercice1()
        {
            Console.Write("Enter department's name: ");
            string department = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior):");
            WorkerLevel workerLevel;
            string workerLevelString = Console.ReadLine();
            Enum.TryParse(workerLevelString, out workerLevel);
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Worker worker = new Worker(name, workerLevel, baseSalary, department);
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract hourContract = new HourContract(date, valuePerHour, hours);
                worker.addContract(hourContract);
            }

            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string[] mesAno = Console.ReadLine().Split("/");

            Console.WriteLine(worker);
            Console.WriteLine(worker.income(int.Parse(mesAno[1]),int.Parse(mesAno[0])));
        }
        static void Exercice2()
        {
            Post post = new Post("Traveling to New Zealand", "I'm going to visit this wonderful country!",
                12,new List<Comment>() { new Comment("Text1") , new Comment("Text2") }
                );
            Console.WriteLine(post);
        }
        static void Exercice3()
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status:");
            OrderStatus os;
            Enum.TryParse(Console.ReadLine(), out os);
            Console.Write("How many items to this order? ");
            Order order = new Order(os,client);
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.WriteLine("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);

                order.addItem(orderItem);
            }

            Console.WriteLine(order);
        }
    }
}
