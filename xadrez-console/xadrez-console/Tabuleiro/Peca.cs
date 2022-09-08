using System;
using xadrez_console.tabuleiro.Enums;

namespace tabuleiro
{
    abstract class Peca
    {
        public Cor Cor { get; protected set; }
        public Posicao Posicao { get;  set; }
        public Tabuleiro Tabuleiro { get; set; }
        public int QtdMovimentos { get; set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            Cor = cor;
            Posicao = null;
            Tabuleiro = tabuleiro;
            QtdMovimentos = 0;
        }

        protected bool podeMover(Posicao posicao)
        {
            Peca p = Tabuleiro.peca(posicao);
            return p == null || Cor != p.Cor;
        }

        public void decrementarMovimento()
        {
            QtdMovimentos--;
        }

        public void incrementaMovimento()
        {
            QtdMovimentos++;
        }

        public bool podeMoverPara(Posicao posicao)
        {
            return movimentosPossiveis()[posicao.Linha, posicao.Coluna];
        }

        public abstract bool[,] movimentosPossiveis(); 
    }
}
