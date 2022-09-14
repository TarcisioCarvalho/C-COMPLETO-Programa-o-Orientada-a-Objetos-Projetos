using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez_console.tabuleiro.Enums;

namespace xadrez_console.xadrez
{
    class Bispo : Peca
    {
        public Bispo(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro) { }

        public override string ToString()
        {
            return "B";
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao p = new Posicao(0, 0);

            //No
            p.definirPosicao(Posicao.Linha - 1, Posicao.Coluna -1);

            while (Tabuleiro.posicaoValida(p) && podeMover(p))
            {
                mat[p.Linha, p.Coluna] = true;
                if (Tabuleiro.peca(p) != null && Tabuleiro.peca(p).Cor != Cor) break;
                p.Linha = p.Linha - 1;
                p.Coluna = p.Coluna - 1;
            }

            //Ne
            p.definirPosicao(Posicao.Linha - 1, Posicao.Coluna + 1);

            while (Tabuleiro.posicaoValida(p) && podeMover(p))
            {
                mat[p.Linha, p.Coluna] = true;
                if (Tabuleiro.peca(p) != null && Tabuleiro.peca(p).Cor != Cor) break;
                p.Linha = p.Linha - 1;
                p.Coluna = p.Coluna + 1;
            }

            //So
            p.definirPosicao(Posicao.Linha + 1, Posicao.Coluna + 1);

            while (Tabuleiro.posicaoValida(p) && podeMover(p))
            {
                mat[p.Linha, p.Coluna] = true;
                if (Tabuleiro.peca(p) != null && Tabuleiro.peca(p).Cor != Cor) break;
                p.Linha = p.Linha - 1;
                p.Coluna = p.Coluna + 1;
            }

            //Se
            p.definirPosicao(Posicao.Linha + 1, Posicao.Coluna + 1);

            while (Tabuleiro.posicaoValida(p) && podeMover(p))
            {
                mat[p.Linha, p.Coluna] = true;
                if (Tabuleiro.peca(p) != null && Tabuleiro.peca(p).Cor != Cor) break;
                p.Linha = p.Linha - 1;
                p.Coluna = p.Coluna + 1;
            }

            return mat;
        }
    }
}
