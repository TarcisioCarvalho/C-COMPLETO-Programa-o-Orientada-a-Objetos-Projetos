using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez_console.tabuleiro.Enums;

namespace xadrez_console.xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro) { }

        public override string ToString()
        {
            return "C";
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao posicao = new Posicao(0, 0);

            posicao.definirPosicao(Posicao.Linha - 2, Posicao.Coluna + 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
            posicao.definirPosicao(Posicao.Linha - 2, Posicao.Coluna - 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
            posicao.definirPosicao(Posicao.Linha + 2, Posicao.Coluna + 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
            posicao.definirPosicao(Posicao.Linha + 2, Posicao.Coluna - 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
            posicao.definirPosicao(Posicao.Linha - 1, Posicao.Coluna - 2);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
            posicao.definirPosicao(Posicao.Linha + 1, Posicao.Coluna - 2);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
            posicao.definirPosicao(Posicao.Linha - 1, Posicao.Coluna + 2);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
            posicao.definirPosicao(Posicao.Linha + 1, Posicao.Coluna + 2);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao)) mat[posicao.Linha, posicao.Coluna] = true;

            return mat;
        }
    }
}
