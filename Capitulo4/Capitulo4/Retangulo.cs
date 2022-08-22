using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo4
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return (2 * Largura + 2 * Altura);
        }
        public double Diagonal()
        {
            return (Math.Sqrt(Largura * Largura + Altura * Altura));
        }


        public override string ToString()
        {
            return "AREA = " + Area() +"\n"+
                    "Perimetro = " + Perimetro() + "\n" +
                    "Diagonal = " + Diagonal() + "\n"
                ; 
        }

    }
}
