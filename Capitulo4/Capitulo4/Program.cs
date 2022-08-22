using System;
using System.Globalization;

namespace Capitulo4
{
    class Program
    {
        static void Main(string[] args)
        {

            Exercice5();
            
        }

        static void Exercice1()
        {
            Funcionario funcionario1;
            Funcionario funcionario2;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Sálario: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("A média dos salários é " + ((funcionario1.Salario + funcionario2.Salario) / 2).ToString("F2", CultureInfo.InvariantCulture));
        }
        static void Exercice2()
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangulo.Largura = Double.Parse(Console.ReadLine());
            retangulo.Altura = Double.Parse(Console.ReadLine());

            Console.WriteLine(retangulo);
        }
        static void Exercice3()
        {
            Funcionario funcionario = new Funcionario();
            Console.Write("Nome :");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salario : ");
            funcionario.Salario = Double.Parse(Console.ReadLine());
            Console.Write("Imposto : ");
            funcionario.Imposto = Double.Parse(Console.ReadLine());

            Console.WriteLine(funcionario);

            Console.Write("Digite a porcentagem para aumentar o salário:");

            funcionario.AumentaSalario(Double.Parse(Console.ReadLine()));

            Console.WriteLine(funcionario);

        }
        static void Exercice4()
        {
            Aluno aluno = new Aluno();

            Console.Write("Digite o Nome do Aluno");
            aluno.Nome =  Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
          
                Console.Write($"Nota 1 :");
                aluno.Nota1 = Double.Parse(Console.ReadLine());
                Console.Write($"Nota 2 :");
                aluno.Nota2 = Double.Parse(Console.ReadLine());
                Console.Write($"Nota 3 :");
                aluno.Nota3 = Double.Parse(Console.ReadLine());


            Console.WriteLine(aluno);
        }
        static void Exercice5()
        {
            double cotacaoDolar,valorDolar;

            Console.Write("Qual a cotação em dolar: ");
            cotacaoDolar = Double.Parse(Console.ReadLine());
            Console.Write("Qual o valor em dolar: ");
            valorDolar = Double.Parse(Console.ReadLine());


            Console.WriteLine($"Valor a ser pago em Reais: {ConvertFormat(ConversorDeMoeda.ConverteMoeda(cotacaoDolar, valorDolar))}");
        }
        static String ConvertFormat(Double value)
        {
            return value.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
