using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez_console.tabuleiro.Enums;

namespace xadrez_console.xadrez
{
    class Dama : Peca
    {
        public Dama(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro) { }

        public override string ToString()
        {
            return "D";
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao p = new Posicao(0, 0);


            // Cima 

            p.definirPosicao(Posicao.Linha - 1, Posicao.Coluna);

            while (Tabuleiro.posicaoValida(p) && podeMover(p))
            {
                mat[p.Linha, p.Coluna] = true;
                if (Tabuleiro.peca(p) != null && Tabuleiro.peca(p).Cor != Cor) break;
                p.Linha = p.Linha - 1;

            }

            // Direita

            p.definirPosicao(Posicao.Linha, Posicao.Coluna + 1);

            while (Tabuleiro.posicaoValida(p) && podeMover(p))
            {
                mat[p.Linha, p.Coluna] = true;
                if (Tabuleiro.peca(p) != null && Tabuleiro.peca(p).Cor != Cor) break;
                p.Coluna = p.Coluna + 1;
            }

            //Baixo

            p.definirPosicao(Posicao.Linha + 1, Posicao.Coluna);

            while (Tabuleiro.posicaoValida(p) && podeMover(p))
            {
                mat[p.Linha, p.Coluna] = true;
                if (Tabuleiro.peca(p) != null && Tabuleiro.peca(p).Cor != Cor) break;
                p.Linha = p.Linha + 1;
            }

            //Esquerda

            p.definirPosicao(Posicao.Linha, Posicao.Coluna - 1);

            while (Tabuleiro.posicaoValida(p) && podeMover(p))
            {
                mat[p.Linha, p.Coluna] = true;
                if (Tabuleiro.peca(p) != null && Tabuleiro.peca(p).Cor != Cor) break;
                p.Coluna = p.Coluna - 1;
            }

            //No
            p.definirPosicao(Posicao.Linha - 1, Posicao.Coluna - 1);

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
