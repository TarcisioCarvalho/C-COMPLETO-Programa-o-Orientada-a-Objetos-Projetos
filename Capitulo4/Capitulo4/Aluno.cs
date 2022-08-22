using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Capitulo4
{
    class Aluno
    {
        public String Nome;
        public Double Nota1;
        public Double Nota2;
        public Double Nota3;

        public Double Notafinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public String VerificaNota()
        {
            return Notafinal() >= 60 ? " Aprovado" : $"Reprovado \n Faltam  {60.00-Notafinal()} Pontos";
        }

        public override string ToString()
        {
            return $"Nota Final = {Notafinal().ToString("F2",CultureInfo.InvariantCulture)} \n" +
                $"{VerificaNota()}" ;
        }

    }
}
