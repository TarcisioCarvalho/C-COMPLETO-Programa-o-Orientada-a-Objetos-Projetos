using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo9.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return $"{Text}";
        }
    }
}
