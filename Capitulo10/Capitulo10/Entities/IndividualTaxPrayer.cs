using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo10.Entities
{
    class IndividualTaxPrayer : TaxPrayer
    {
        public double HealthExpenditures { get; set; }


        public IndividualTaxPrayer() { }

        public IndividualTaxPrayer(string name, double anualIncome,double healthExpenditures)
            :base(name,anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxPayment()
        {
            double tax=25;
            if (AnualIncome<20000)
            {
                tax = 15;
            }
            return (AnualIncome * tax/100 - (0.5*HealthExpenditures));
        }
    }
}
