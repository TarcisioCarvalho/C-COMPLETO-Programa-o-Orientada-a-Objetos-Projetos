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
                PartidaXadrez partidaXadrez = new PartidaXadrez();
                while (!partidaXadrez.Terminada)
                {
                    Console.Clear();
                    Tela.imprimeTela(partidaXadrez.Tabuleiro);

                    Console.WriteLine("\n");

                    Console.Write("Digite uma posição de origem ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Digite uma posição de destino");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partidaXadrez.movimentaPeca(origem, destino);
                    Console.WriteLine();
                }
                

            }catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            
        }
    }
}
