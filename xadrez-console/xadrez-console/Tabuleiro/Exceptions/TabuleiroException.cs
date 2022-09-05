using System;
using System.Collections.Generic;


namespace tabuleiro.Exceptions
{
    class TabuleiroException:Exception
    {
        public TabuleiroException(string message) : base(message) { }
    }
}
