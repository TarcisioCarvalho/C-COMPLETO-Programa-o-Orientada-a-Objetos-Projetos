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
        public bool Xeque { get; private set; }
        public List<Peca> PecasEmJogo { get; set; } = new List<Peca>();
        public List<Peca> PecasCapturadas { get; set; } = new List<Peca>();

        public PartidaXadrez()
        {
            Tabuleiro = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            colocaPecas();
            Terminada = false;
            Xeque = false;
        }

        public void colocaNovaPeca(Peca peca,Posicao posicao)
        {
            Tabuleiro.colocarPeca(peca, posicao);
            PecasEmJogo.Add(peca);
        }

        public void colocaPecas()
        {
            colocaNovaPeca(new Rei(Cor.Branca, Tabuleiro), new PosicaoXadrez('d', 1).toPosicao());

            colocaNovaPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('c', 1).toPosicao());
            colocaNovaPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('h', 1).toPosicao());

            colocaNovaPeca(new Rei(Cor.Preta, Tabuleiro), new PosicaoXadrez('a', 8).toPosicao());
           


            /* colocaNovaPeca(new Rei(Cor.Branca,Tabuleiro), new PosicaoXadrez('a',1).toPosicao());

             colocaNovaPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('b', 1).toPosicao());
             colocaNovaPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('d', 1).toPosicao());
             colocaNovaPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('c', 2).toPosicao());
             colocaNovaPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('b', 2).toPosicao());
             colocaNovaPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('d', 2).toPosicao());

             colocaNovaPeca(new Rei(Cor.Preta, Tabuleiro), new PosicaoXadrez('c', 8).toPosicao());
             colocaNovaPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('b', 8).toPosicao());
             colocaNovaPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('d', 8).toPosicao());
             colocaNovaPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('c', 7).toPosicao());
             colocaNovaPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('b', 7).toPosicao());
             colocaNovaPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('d', 7).toPosicao());
            */
            // Tabuleiro.colocarPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('b', 1).toPosicao());
        }

        private Cor corAdversaria(Cor cor)
        {
            if (cor == Cor.Branca) return Cor.Preta;
            return Cor.Branca;
        }

        public Peca rei(Cor cor)
        {
            foreach (Peca peca in pecasEmJogo(cor))
            {
                if (peca is Rei) return peca;
            }
            return null;
        }

        public bool estaEmXeque(Cor cor)
        {
            Peca Rei = rei(cor);

            if (Rei == null) throw new TabuleiroException("Não existe rei dessa cor");

            foreach (Peca peca in pecasEmJogo(corAdversaria(cor)))
            {
                bool[,] mat = peca.movimentosPossiveis();
                if (mat[Rei.Posicao.Linha, Rei.Posicao.Coluna]) return true;
            }

            return false;
        }

        public bool testeXequemate(Cor cor)
        {
            if (!estaEmXeque(cor)) return false;

            foreach (Peca pecaEmJogo in pecasEmJogo(cor))
            {
                bool[,] mat = pecaEmJogo.movimentosPossiveis();
                for (int i = 0; i < Tabuleiro.Linhas; i++)
                {
                    for (int j = 0; j < Tabuleiro.Colunas; j++)
                    {
                        if (mat[i, j])
                        {
                            Posicao origem = pecaEmJogo.Posicao;
                            Posicao destino = new Posicao(i, j);
                            Peca pecaCapturada = movimentaPeca(origem, destino);
                            bool testeXeque = estaEmXeque(cor);
                            desfazJogada(origem, destino, pecaCapturada);

                            if (!testeXeque) return false;
                        }
                    }
                }
            }
            return true;
        }

        public List<Peca> pecasCapturadas(Cor cor)
        {
            List<Peca> aux = new List<Peca>();

            foreach (Peca peca in PecasCapturadas)
            {
                if (peca.Cor == cor) aux.Add(peca);
            }

            return aux;
        }

        public List<Peca> pecasEmJogo(Cor cor)
        {
            List<Peca> aux = new List<Peca>();

            foreach (Peca peca in PecasEmJogo)
            {
                if (peca.Cor == cor) aux.Add(peca);
            }

         

            return aux;
        }

        public void desfazJogada(Posicao origem,Posicao destino, Peca pecaRetirada)
        {
            Peca pecaMovimentada = Tabuleiro.retiraPeca(destino);
            pecaMovimentada.decrementarMovimento();
            if(pecaRetirada != null)
            {
                Tabuleiro.colocarPeca(pecaRetirada, destino);
                PecasCapturadas.Remove(pecaRetirada);
                PecasEmJogo.Add(pecaRetirada);
            }
            Tabuleiro.colocarPeca(pecaMovimentada, origem);
        }

        public void realizaJogada (Posicao origem,Posicao destino)
        {
            Peca pecaRetirada = movimentaPeca(origem, destino);

            if (estaEmXeque(JogadorAtual)) {

                desfazJogada(origem, destino, pecaRetirada);
                throw new TabuleiroException("Você não pode se colocar em xeque!");
                    }

            if (estaEmXeque(corAdversaria(JogadorAtual))) Xeque = true;
            else Xeque = false;

            if (testeXequemate(corAdversaria(JogadorAtual))) Terminada = true;

            mudaJogador();
            Turno++;
        }
        private void mudaJogador()
        {
            JogadorAtual = JogadorAtual == Cor.Branca ? Cor.Preta : Cor.Branca;
        }
        public Peca movimentaPeca(Posicao origem,Posicao destino)
        {
           Peca pecaMovimentar = Tabuleiro.retiraPeca(origem);
           pecaMovimentar.incrementaMovimento();
           Peca pecaRetirada = Tabuleiro.retiraPeca(destino);
            if (pecaRetirada != null) {
                PecasCapturadas.Add(pecaRetirada);
                PecasEmJogo.Remove(pecaRetirada);
                    };
            Tabuleiro.colocarPeca(pecaMovimentar,destino);
            return pecaRetirada;
        }

        public void validPosicaoOrigem(Posicao posicao)
        {
            if (Tabuleiro.peca(posicao) == null) throw new TabuleiroException("Não existe peça na posição selecionada");
            if (Tabuleiro.peca(posicao).Cor != JogadorAtual) throw new TabuleiroException("A peça de origem escolhida não é sua");
           
            if (!existeMovimentosPossiveis(posicao)) throw new TabuleiroException("Não há movimentos possiveis para a peça escolhida");
        }

        public void validaPosicaoDestino(Posicao origem,Posicao destino)
        {
            if(!Tabuleiro.peca(origem).movimentoPossivel(destino)) throw new TabuleiroException("Posição de destino inválida");
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
