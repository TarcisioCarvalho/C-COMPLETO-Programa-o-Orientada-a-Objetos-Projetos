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

        public Peca(Cor cor, Posicao posicao, Tabuleiro tabuleiro)
        {
            Cor = cor;
            Posicao = posicao;
            Tabuleiro = tabuleiro;
            QtdMovimentos = 0;
        }
    }
}
