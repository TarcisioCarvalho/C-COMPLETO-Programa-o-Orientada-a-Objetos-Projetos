using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;
using xadrez_console.tabuleiro.Enums;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimeTela(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write((8 - i)+" ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {

                    imprimirPeca(tabuleiro.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.Write("  A B C D E F G H");
        }

        public static void imprimeTela(Tabuleiro tabuleiro,bool [,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write((8 - i) + " ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (posicoesPossiveis[i, j]) Console.BackgroundColor = fundoAlterado;
                    imprimirPeca(tabuleiro.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.Write("  A B C D E F G H");
        }


        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1]+"");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca == null) {
                Console.Write("- ");
                return;
            };

            if (peca.Cor == Cor.Branca) Console.Write(peca);
            if(peca.Cor == Cor.Preta)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            Console.Write(" ");
            
        }
    }
}
