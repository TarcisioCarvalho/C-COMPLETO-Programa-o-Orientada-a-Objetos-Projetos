using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;
using xadrez_console.tabuleiro.Enums;

namespace xadrez_console.xadrez
{
    class Peao : Peca
    {
        private PartidaXadrez Partida;
        public Peao(Cor cor, Tabuleiro tabuleiro, PartidaXadrez partida) : base(cor, tabuleiro)
        {
            Partida = partida;
        }


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

           if(Cor == Cor.Branca)
            {
                posicao.definirPosicao(Posicao.Linha - 1, Posicao.Coluna);
                if (Tabuleiro.posicaoValida(posicao) && posicaoLivre(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
                posicao.definirPosicao(Posicao.Linha - 2, Posicao.Coluna);
                if (Tabuleiro.posicaoValida(posicao) && posicaoLivre(posicao) && QtdMovimentos == 0) mat[posicao.Linha, posicao.Coluna] = true;
                posicao.definirPosicao(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
                posicao.definirPosicao(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
                // Jogada Especial En Passant
                Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                if (Posicao.Linha == 3 && Tabuleiro.posicaoValida(esquerda) && existeInimigo(esquerda) && Tabuleiro.peca(esquerda) == Partida.vuneravelEnPassant) mat[esquerda.Linha - 1, esquerda.Coluna] = true;
                Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                if (Posicao.Linha == 3 && Tabuleiro.posicaoValida(direita) && existeInimigo(direita) && Tabuleiro.peca(direita) == Partida.vuneravelEnPassant) mat[direita.Linha - 1, direita.Coluna] = true;
            }
            else
            {
                posicao.definirPosicao(Posicao.Linha + 1, Posicao.Coluna);
                if (Tabuleiro.posicaoValida(posicao) && posicaoLivre(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
                posicao.definirPosicao(Posicao.Linha + 2, Posicao.Coluna);
                if (Tabuleiro.posicaoValida(posicao) && posicaoLivre(posicao) && QtdMovimentos == 0) mat[posicao.Linha, posicao.Coluna] = true;
                posicao.definirPosicao(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
                posicao.definirPosicao(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao)) mat[posicao.Linha, posicao.Coluna] = true;
                // Jogada Especial En Passant
                Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                if (Posicao.Linha == 4 && Tabuleiro.posicaoValida(esquerda) && existeInimigo(esquerda) && Tabuleiro.peca(esquerda) == Partida.vuneravelEnPassant) mat[esquerda.Linha + 1, esquerda.Coluna] = true;
                Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                if (Posicao.Linha == 4 && Tabuleiro.posicaoValida(direita) && existeInimigo(direita) && Tabuleiro.peca(direita) == Partida.vuneravelEnPassant) mat[direita.Linha + 1, direita.Coluna] = true;
            }
                    
                    
                
                    
              
            
            return mat;
        }
    }
}
