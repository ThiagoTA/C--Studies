using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExProposto.Entities;

namespace ExProposto.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract myContract, int months)
        {
            double PartQuota = myContract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = myContract.Date.AddMonths(i);
                double monthyQuota =  PartQuota + _onlinePaymentService.Interest(PartQuota, i);
                double fullQuota = monthyQuota + _onlinePaymentService.PaymentFee(monthyQuota);
                myContract.addInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
