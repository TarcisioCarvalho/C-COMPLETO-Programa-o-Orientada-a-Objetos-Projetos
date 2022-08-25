using System;
using System.Collections.Generic;
using System.Globalization;

namespace Capitulo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercice2();
        }

        static void Exercice1()
        {
            Estudante[] estudantes = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdQuartos; i++)
            {
                Console.WriteLine($"Aluguel #{i+1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                estudantes[quarto] = new Estudante {
                    Nome = nome, 
                    Email= email,
                };
            }

            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < estudantes.Length; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine($"{i}: {estudantes[i].Nome}, {estudantes[i].Email}");
                }
            }



        }
        static void Exercice2()
        {
            Console.Write("How many employees will be registered? ");
            int employees = int.Parse(Console.ReadLine());
            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < employees; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

                funcionarios.Add(new Funcionario (id,name,salary));

                
            }

            Console.Write("Enter the employee id that will have salary increase :");
            int id2 = int.Parse(Console.ReadLine());
            Funcionario x = funcionarios.Find(funcionario => funcionario.Id == id2);
            if (x != null)
            {
                Console.Write("Enter the percentage:");
                double percentage = double.Parse(Console.ReadLine());
                x.IncreaseSalary(percentage);

            }

            if (x == null)
            {
                Console.WriteLine("This id does not exist! ");
            }
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario funcionario in funcionarios)
            {
                
                Console.WriteLine(funcionario);
            }
           
            
           

            
               
            
           

           

        }
    }
}
