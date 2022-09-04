using System;
using Tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            teste();
        }

        static void teste()
        {
            Posicao posicao = new Posicao(3, 4);
            Console.WriteLine(posicao);
            Console.ReadLine();
        }
    }
}
