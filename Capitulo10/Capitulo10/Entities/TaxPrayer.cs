using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo10.Entities
{
   abstract class TaxPrayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPrayer() { }

        public TaxPrayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

       public abstract double TaxPayment();
    }
}
