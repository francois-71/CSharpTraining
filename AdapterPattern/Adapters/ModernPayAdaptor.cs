using System.Runtime.InteropServices;
using enums;
using Interface;
using PaymentAPIs;
using transactions;

namespace Adapters
{
    public class ModernPayAdaptor : IPayAdapter
    {
        private ModernPay _modernPay = new();

        public void MakePayment(PaymentRequest paymentRequest)
        {
            _modernPay.ExecutePayment(paymentRequest);
        }

        public void IssueRefund(int transactionId)
        {
            _modernPay.IssueRefund(transactionId);
        }

        public TransactionStatus GetTransactionStatus(int transactionId)
        {
            return _modernPay.GetTransactionStatus(transactionId);
        }

        public void PrintTransactions()
        {
            List<PaymentRequest> transactions = _modernPay.GetTransactions();
            foreach (PaymentRequest transaction in transactions)
            {
                Console.WriteLine(transaction.ToString());
            }
        }
    }
}