using System;
using xadrez_console.tabuleiro.Enums;

namespace tabuleiro
{
    class Peca
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

        public void incrementaMovimento()
        {
            QtdMovimentos++;
        }
    }
}
