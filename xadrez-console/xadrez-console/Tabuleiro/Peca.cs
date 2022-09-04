using System;
using xadrez_console.tabuleiro.Enums;

namespace tabuleiro
{
    class Peca
    {
        public Cor Cor { get; set; }
        public Posicao Posicao { get; protected set; }
        public Tabuleiro tabuleiro { get; set; }
    }
}
