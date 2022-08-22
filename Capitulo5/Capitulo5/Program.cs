using System;

namespace Capitulo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Double valorInicial=0;
            Console.Write("Entre com o número da conta: ");
            String numeroConta = Console.ReadLine();
            Console.Write("Entre o titular da conta: ");
            String nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial ? (s/n) ");
            Char resposta = Char.Parse(Console.ReadLine());

            if(resposta == 's')
            {
                Console.Write("Entre com o valor de depósito inicial");
                valorInicial = Double.Parse(Console.ReadLine());
            }

            ContaBancaria contaBancaria = new ContaBancaria(numeroConta, nome, valorInicial);
            Console.WriteLine(contaBancaria);


            Console.Write("Entre com o valor para  depósito ");
            Double deposito = Double.Parse(Console.ReadLine());

            contaBancaria.deposito(deposito);
            Console.WriteLine(contaBancaria);

            Console.Write("Entre com o valor para  saque ");
            Double saque = Double.Parse(Console.ReadLine());

            contaBancaria.saque(saque);
            Console.WriteLine(contaBancaria);
        }
    }
}
