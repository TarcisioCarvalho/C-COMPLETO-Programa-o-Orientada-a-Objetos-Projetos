using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo14.Service
{
    class PaypalService : IOnlinePaymentService
    {
        public double interest(double amount, int months)
        {
            return amount + amount * months / 100;

        }

        public double paymentFee(double amount)
        {
            return amount + amount * 2 / 100;
        }
    }
}
