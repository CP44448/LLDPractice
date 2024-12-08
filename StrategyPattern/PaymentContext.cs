using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class PaymentContext(IPaymentProcessor paymentProcessor)
    {
        private readonly IPaymentProcessor _paymentProcessor = paymentProcessor ?? throw new ArgumentNullException(nameof(paymentProcessor));

        public void ProcessPayments(double amount)
        {
            _paymentProcessor.ProcessPayments(amount);
        }
    }
}
