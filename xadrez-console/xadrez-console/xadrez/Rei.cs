using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez_console.tabuleiro.Enums;

namespace xadrez
{
    class Rei:Peca
    {
        public Rei(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro) { }


        public override string ToString()
        {
            return "R";
        }

       

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas,Tabuleiro.Colunas];
            Posicao p = new Posicao(0, 0);
            //cima
            p.definirPosicao(Posicao.Linha - 1, Posicao.Coluna);
            if (Tabuleiro.posicaoValida(p) && podeMover(p)) mat[p.Linha, p.Coluna] = true;
            //Ne
            p.definirPosicao(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tabuleiro.posicaoValida(p) && podeMover(p)) mat[p.Linha, p.Coluna] = true;
            //Direita
            p.definirPosicao(Posicao.Linha, Posicao.Coluna + 1);
            if(Tabuleiro.posicaoValida(p) && podeMover(p)) mat[p.Linha, p.Coluna] = true;
            //Se
            p.definirPosicao(Posicao.Linha+1, Posicao.Coluna + 1);
            if (Tabuleiro.posicaoValida(p) && podeMover(p)) mat[p.Linha, p.Coluna] = true;
            //Baixo
            p.definirPosicao(Posicao.Linha + 1, Posicao.Coluna);
            if (Tabuleiro.posicaoValida(p) && podeMover(p)) mat[p.Linha, p.Coluna] = true;
            //So
            p.definirPosicao(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tabuleiro.posicaoValida(p) && podeMover(p)) mat[p.Linha, p.Coluna] = true;
            //Esquerda
            p.definirPosicao(Posicao.Linha,Posicao.Coluna-1);
            if (Tabuleiro.posicaoValida(p) && podeMover(p)) mat[p.Linha, p.Coluna] = true;
            //No
            p.definirPosicao(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tabuleiro.posicaoValida(p) && podeMover(p)) mat[p.Linha, p.Coluna] = true;

            return mat;
        }
    }
}
