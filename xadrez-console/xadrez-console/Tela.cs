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
                    if (tabuleiro.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    if (tabuleiro.peca(i,j)!= null)
                    {
                        imprimirPeca(tabuleiro.peca(i, j));
                    }
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
            if (peca.Cor == Cor.Branca) Console.Write(peca);
            if(peca.Cor == Cor.Preta)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
