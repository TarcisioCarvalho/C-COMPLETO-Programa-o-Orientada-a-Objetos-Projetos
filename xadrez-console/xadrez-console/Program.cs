using System;
using tabuleiro;
using tabuleiro.Exceptions;
using xadrez;
using xadrez_console.tabuleiro.Enums;

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
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                tabuleiro.colocarPeca(new Rei(Cor.Preta, tabuleiro), new Posicao(0, 0));
                
                Tela.imprimeTela(tabuleiro);
            }catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            
        }
    }
}
