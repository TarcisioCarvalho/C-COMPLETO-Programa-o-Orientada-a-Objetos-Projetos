using System;
using System.Collections.Generic;
using System.Globalization;

namespace Capitulo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercice3();
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
        static void Exercice3()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(" ");
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);

                }
                Console.WriteLine();
            }

            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < m; j++)
                {
                    if (matriz[i,j]==valor)
                    {
                        Console.WriteLine($"Position {i}, {j} : ");
                        if (j-1>=0)
                        {
                            Console.WriteLine($"Left {matriz[i,j-1]}");
                        }
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine($"Up {matriz[i-1 , j ]}");
                        }
                        if (j + 1 < m)
                        {
                            Console.WriteLine($"Right {matriz[i, j + 1]}");
                        }
                        if (i + 1 < n)
                        {
                            Console.WriteLine($"Down {matriz[i + 1, j]}");
                        }
                    }

                }
                
            }
        }
    }
}
