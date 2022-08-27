using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo9.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerhour { get; set; }
        public int Hours { get; set; }

        public HourContract() { }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerhour = valuePerHour;
            Hours = hours;
        }

        public double totalValue() 
        {
            return ValuePerhour * Hours;
        }
    }
}
