using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez_console.tabuleiro.Enums;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro) { }

        public override string ToString()
        {
            return "T";
        }
    }
}
