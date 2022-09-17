using Capitulo14.Entities;
using Capitulo14.Service;
using System;
using System.Globalization;

namespace Capitulo14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Contract contract = new Contract(number, contractDate, contractValue);

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService();
            contractService.processContract(contract, months, new PaypalService());

            Console.WriteLine("Installments: ");

            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
