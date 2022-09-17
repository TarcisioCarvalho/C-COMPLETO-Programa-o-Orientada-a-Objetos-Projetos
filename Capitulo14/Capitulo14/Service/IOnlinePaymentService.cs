using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo14.Service
{
    interface IOnlinePaymentService
    {
        public double paymentFee(double amount);
        public double interest(double amount, int months);
    }
}
