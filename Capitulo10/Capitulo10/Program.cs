using Capitulo10.Entities;
using Capitulo10.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Capitulo10
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercice4();
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
        static void Exercice2()
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeOfProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                switch (typeOfProduct)
                {
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, customsFee));
                    break;
                    case 'c':
                        products.Add(new Product(name, price));
                    break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY) : ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, date));
                    break;
                    default:
                        break;
                }
            }

            Console.WriteLine("PRICE TAGS");

            foreach (Product product in products)
            {
                Console.WriteLine(product.priceTag());
            }
        }
        static void Exercice3()
        {
            List<Shape> shapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");

                Console.Write("Rectangle or Circle (r/c)? ");
                char choice = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color;
                Enum.TryParse(Console.ReadLine(), out color);
                switch (choice)
                {
                    case 'r':
                        Console.Write("Width: ");
                        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Height: ");
                        double height = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        shapes.Add(new Rectangle(height, width, color));
                        break;
                    case 'c':
                        Console.Write("Radius: ");
                        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        shapes.Add(new Circle(radius, color));
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine("SHAPE AREAS");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area());
            }
        } 
        static void Exercice4()
        {
            List<TaxPrayer> taxPrayers = new List<TaxPrayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (i/c)? ");
                char choice = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (choice)
                {
                    case 'i':
                        Console.Write("Health expenditures:");
                        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        taxPrayers.Add(new IndividualTaxPrayer(name, anualIncome, healthExpenditures));
                        break;
                    case 'c':
                        Console.Write("Number of employees: ");
                        int numberOfEmployees = int.Parse(Console.ReadLine());
                        taxPrayers.Add(new CompannyTaxPrayer(name, anualIncome, numberOfEmployees));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("TAXES PAID");
            double sum = 0;
            foreach (TaxPrayer taxPrayer in taxPrayers)
            {
                Console.Write($"{taxPrayer.Name}: $ {taxPrayer.TaxPayment().ToString("F2")} ");
                sum += taxPrayer.TaxPayment();
            }

            Console.WriteLine();
            Console.Write($"TAX TOTAL : {sum.ToString("F2")}");
        }
    }
}
