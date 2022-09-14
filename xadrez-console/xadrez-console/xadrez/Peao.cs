using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez_console.tabuleiro.Enums;

namespace xadrez_console.xadrez
{
    class Peao : Peca
    {
        public Peao(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro) { }


        public override string ToString()
        {
            return "P";
        }


        private bool existeInimigo(Posicao posicao)
        {
            Peca peca = Tabuleiro.peca(posicao);
            return peca != null && peca.Cor != Cor;
        }

        private bool posicaoLivre(Posicao posicao)
        {
            return Tabuleiro.peca(posicao) == null;
        }

        public override bool[,] movimentosPossiveis()
        {

            bool[,] mat = new bool[Tabuleiro.Linhas,Tabuleiro.Colunas];
            Posicao posicao = new Posicao(0, 0);

            switch (Cor)
            {
                case Cor.Branca:
                    posicao.definirPosicao(Posicao.Linha - 1, Posicao.Coluna);
                    if ( Tabuleiro.posicaoValida(posicao) && posicaoLivre(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
                    posicao.definirPosicao(Posicao.Linha - 2, Posicao.Coluna);
                    if (Tabuleiro.posicaoValida(posicao) && posicaoLivre(posicao) && QtdMovimentos==0) mat[posicao.Linha, posicao.Coluna] = true;
                    posicao.definirPosicao(Posicao.Linha - 1, Posicao.Coluna-1);
                    if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
                    posicao.definirPosicao(Posicao.Linha - 1, Posicao.Coluna + 1);
                    if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
                    break;
                case Cor.Preta:
                    posicao.definirPosicao(Posicao.Linha + 1, Posicao.Coluna);
                    if (Tabuleiro.posicaoValida(posicao) && posicaoLivre(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
                    posicao.definirPosicao(Posicao.Linha + 2, Posicao.Coluna);
                    if (Tabuleiro.posicaoValida(posicao) && posicaoLivre(posicao) && QtdMovimentos == 0) mat[posicao.Linha, posicao.Coluna] = true;
                    posicao.definirPosicao(Posicao.Linha + 1, Posicao.Coluna - 1);
                    if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
                    posicao.definirPosicao(Posicao.Linha + 1, Posicao.Coluna + 1);
                    if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
                    break;
                default:
                    break;
            }
            return mat;
        }
    }
}
