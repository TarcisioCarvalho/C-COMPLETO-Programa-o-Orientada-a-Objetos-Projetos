using System;
using System.Globalization;

namespace Capitulo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1;
            Funcionario funcionario2;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Sálario: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("A média dos salários é " + ((funcionario1.Salario + funcionario2.Salario)/2).ToString("F2",CultureInfo.InvariantCulture));
            
            
        }
    }
}
