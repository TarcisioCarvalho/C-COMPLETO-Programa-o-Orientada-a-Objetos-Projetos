using Capitulo14.Entities;
using System;


namespace Capitulo14.Service
{
    class ContractService
    {
        public void processContract(Contract contract, int months,IOnlinePaymentService onlinePaymentService)
        {
            double amount = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime duoDate = contract.Date.AddMonths(i);
                double monthlySimpleInterest = onlinePaymentService.interest(amount, i);
                double amountInstallment = onlinePaymentService.paymentFee(monthlySimpleInterest);
                contract.addInstallment(new Installment(duoDate, amountInstallment));
            }
        }
    }
}
