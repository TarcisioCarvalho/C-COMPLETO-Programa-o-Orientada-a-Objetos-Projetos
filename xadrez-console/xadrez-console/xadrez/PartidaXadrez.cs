using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez_console.tabuleiro.Enums;

namespace xadrez
{
    class PartidaXadrez
    {
        public Tabuleiro Tabuleiro { get; private set; }
        public int Turno { get; set; }
        public Cor JogadorAtual { get; set; }
        public bool Terminada { get; set; }

        public PartidaXadrez()
        {
            Tabuleiro = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            colocaPecas();
            Terminada = false;
        }

        public void colocaPecas()
        {
            Tabuleiro.colocarPeca(new Rei(Cor.Preta, Tabuleiro), new PosicaoXadrez('a', 1).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('b', 1).toPosicao());
           // Tabuleiro.colocarPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('b', 1).toPosicao());
        }

        public void movimentaPeca(Posicao origem,Posicao destino)
        {
           Peca pecaMovimentar = Tabuleiro.retiraPeca(origem);
           pecaMovimentar.incrementaMovimento();
           Peca pecaRetirada = Tabuleiro.retiraPeca(destino);

            Tabuleiro.colocarPeca(pecaMovimentar,destino);
        }

    }
}
