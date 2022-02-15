using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProposto.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }

        public double Interest(double amount, int months)
        {
            return amount * months * 0.01;
        }
    }
}
