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
            
                PartidaXadrez partidaXadrez = new PartidaXadrez();
                while (!partidaXadrez.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimeTela(partidaXadrez.Tabuleiro);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"Turno: {partidaXadrez.Turno}");
                        Console.WriteLine($"Aguardando jogada do jogador: {partidaXadrez.JogadorAtual}");
                        Console.WriteLine("\n");

                        Console.Write("Digite uma posição de origem ");
                        
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partidaXadrez.validPosicaoOrigem(origem);
                        bool[,] posicoesPossiveis = partidaXadrez.Tabuleiro.peca(origem).movimentosPossiveis();
                        Console.Clear();

                        Tela.imprimeTela(partidaXadrez.Tabuleiro, posicoesPossiveis);
                        Console.WriteLine();
                        Console.Write("Digite uma posição de destino");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partidaXadrez.validaPosicaoDestino(origem,destino);
                        partidaXadrez.realizaJogada(origem, destino);
                        Console.WriteLine();
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e);
                    Console.ReadLine();
                    }
                    
                }
                

           
            Console.ReadLine();
            
        }
    }
}
