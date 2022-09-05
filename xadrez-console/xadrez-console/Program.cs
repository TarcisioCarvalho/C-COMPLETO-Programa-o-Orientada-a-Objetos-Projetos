using System;
using tabuleiro;

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
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            Tela.imprimeTela(tabuleiro);
        }
    }
}
