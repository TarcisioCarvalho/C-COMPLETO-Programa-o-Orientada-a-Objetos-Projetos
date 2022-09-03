using Capitulo11.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo11.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }

        public void withDraw(double amount)
        {
            if (Balance<=amount)
            {
                throw new DomainException("Withdraw error: Not enough balance ");
            }

            if (WithDrawLimit <= amount)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit ");
            }

            Balance -= amount;
        }
    }
}
