using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez_console.tabuleiro.Enums;

namespace xadrez
{
    class Rei:Peca
    {
        private PartidaXadrez Partida;
        public Rei(Cor cor, Tabuleiro tabuleiro,PartidaXadrez partida) : base(cor, tabuleiro)
        {
            Partida = partida;
        }
        

        public override string ToString()
        {
            return "R";
        }

       private bool testeTorreParaRoque(Posicao posicao)
        {
            Peca pecaT = Tabuleiro.peca(posicao);

            return pecaT != null && pecaT.QtdMovimentos == 0 && pecaT.Cor == Cor && pecaT is Torre;
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


            //Jogada Especial Roque

            if(QtdMovimentos == 0 && !Partida.Xeque)
            {
                //Jogada Especial Roque Pequeno
                Posicao posicaoT1 = new Posicao(Posicao.Linha,Posicao.Coluna+3);

                if (testeTorreParaRoque(posicaoT1))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);

                    if (Tabuleiro.peca(p1) == null && Tabuleiro.peca(p2) == null) mat[Posicao.Linha, Posicao.Coluna + 2] = true;
                }
                //Jogada Especial Roque Grande
                Posicao posicaoT2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);

                if (testeTorreParaRoque(posicaoT2))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao p3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);

                    if (Tabuleiro.peca(p1) == null && Tabuleiro.peca(p2) == null && Tabuleiro.peca(p3) == null) mat[Posicao.Linha, Posicao.Coluna - 2] = true;
                }
            }

            return mat;
        }
    }
}
