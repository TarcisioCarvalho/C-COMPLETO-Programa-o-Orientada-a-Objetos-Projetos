using System;
using System.Collections.Generic;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimeTela(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (tabuleiro.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    if (tabuleiro.peca(i,j)!= null)
                    {
                        Console.Write(tabuleiro.peca(i, j));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
