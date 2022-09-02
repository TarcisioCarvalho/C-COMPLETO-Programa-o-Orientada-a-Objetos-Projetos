using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo10.Entities
{
    class CompannyTaxPrayer : TaxPrayer
    {
        public int NumberOfEmployees { get; set; }

        public CompannyTaxPrayer() { }

        public CompannyTaxPrayer(string name, double anualIncome, int numberOfEmployees)
            :base(name,anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double TaxPayment()
        {
            double tax = 16;
            if (NumberOfEmployees>10)
            {
                tax = 14;
            }

            return AnualIncome * tax/100;
        }
    }
}
