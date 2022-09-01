using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo10.Entities
{
    class OutsourcedEmployee:Employee
    {
        public double AdicionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour,double adicionalCharge)
            :base(name,hours,valuePerHour)
        {
            AdicionalCharge = adicionalCharge;
        }

        public override double payment()
        {
            return base.payment() + (AdicionalCharge * 1.1);
        }
    }
}
