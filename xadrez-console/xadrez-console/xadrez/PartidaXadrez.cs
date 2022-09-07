using System;
using System.Collections.Generic;
using tabuleiro;
using tabuleiro.Exceptions;
using xadrez_console.tabuleiro.Enums;

namespace xadrez
{
    class PartidaXadrez
    {
        public Tabuleiro Tabuleiro { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
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
            Tabuleiro.colocarPeca(new Rei(Cor.Branca, Tabuleiro), new PosicaoXadrez('c', 1).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('b', 1).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('d', 1).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('c', 2).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('b', 2).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('d', 2).toPosicao());

            Tabuleiro.colocarPeca(new Rei(Cor.Preta, Tabuleiro), new PosicaoXadrez('c', 8).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('b', 8).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('d', 8).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('c', 7).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('b', 7).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('d', 7).toPosicao());
            // Tabuleiro.colocarPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('b', 1).toPosicao());
        }

        public void realizaJogada (Posicao origem,Posicao destino)
        {
            movimentaPeca(origem, destino);
            mudaJogador();
            Turno++;
        }
        private void mudaJogador()
        {
            JogadorAtual = JogadorAtual == Cor.Branca ? Cor.Preta : Cor.Branca;
        }
        public void movimentaPeca(Posicao origem,Posicao destino)
        {
           Peca pecaMovimentar = Tabuleiro.retiraPeca(origem);
           pecaMovimentar.incrementaMovimento();
           Peca pecaRetirada = Tabuleiro.retiraPeca(destino);

            Tabuleiro.colocarPeca(pecaMovimentar,destino);
        }

        public void validPosicaoOrigem(Posicao posicao)
        {
            if (Tabuleiro.peca(posicao) == null) throw new TabuleiroException("Não existe peça na posição selecionada");
            if (Tabuleiro.peca(posicao).Cor != JogadorAtual) throw new TabuleiroException("A peça de origem escolhida não é sua");
           
            if (!existeMovimentosPossiveis(posicao)) throw new TabuleiroException("Não há movimentos possiveis para a peça escolhida");
        }

        public void validaPosicaoDestino(Posicao origem,Posicao destino)
        {
            if(!Tabuleiro.peca(origem).podeMoverPara(destino)) throw new TabuleiroException("Posição de destino inválida");
        }

        public bool existeMovimentosPossiveis(Posicao posicao)
        {
            bool[,] mat = Tabuleiro.peca(posicao).movimentosPossiveis();

            for (int i = 0; i < Tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < Tabuleiro.Colunas; j++)
                {
                    if (mat[i, j]) return true;
                }
            }

            return false;
        }
    }
}
