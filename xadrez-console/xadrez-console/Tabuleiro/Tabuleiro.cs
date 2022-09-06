using System;
using System.Collections.Generic;
using tabuleiro.Exceptions;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas { get; set; }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[Linhas, Colunas];
        }

        public Peca peca(int linha,int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao posicao)
        {
            return pecas[posicao.Linha, posicao.Coluna];
        }

        public Peca retiraPeca(Posicao posicao)
        {
            if (!existePeca(posicao)) return null;

            Peca aux = peca(posicao);
            aux.Posicao = null;
            pecas[posicao.Linha, posicao.Coluna] = null;
            return aux;
        }

        public void colocarPeca(Peca peca,Posicao posicao)
        {
            if (existePeca(posicao)) throw new TabuleiroException("Já Existe peça nessa posição");

            pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        public bool existePeca(Posicao posicao)
        {
            validaPosicao(posicao);
            return peca(posicao) != null;
        }

        public void validaPosicao(Posicao posicao)
        {
            if (!posicaoValida(posicao)) throw new TabuleiroException("Posição inválida");
        }

        public bool posicaoValida(Posicao posicao)
        {
            if(posicao.Linha<0 || posicao.Linha>=Linhas || posicao.Coluna<0 || posicao.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }
    }
}
