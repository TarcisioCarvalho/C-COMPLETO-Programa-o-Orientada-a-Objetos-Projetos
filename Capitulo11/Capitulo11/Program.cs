using Capitulo11.Entities;
using Capitulo11.Entities.Exceptions;
using System;
using System.Globalization;

namespace Capitulo11
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercice1();
        }
        static void Exercice1()
        {
            Console.WriteLine("Enter account data ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Account account = new Account(number,holder,initialBalance,withDrawLimit);
            Console.Write("Enter amount for withdraw: ");
            double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.withDraw(withDraw);
                Console.WriteLine($"New balance: {account.Balance}");
            }
            catch (DomainException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
