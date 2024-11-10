using enums;
using Interface;
using PaymentAPIs;
using transactions;

namespace Adapters
{
    public class LegacyPayAdaptor : IPayAdapter
    {
        private LegacyPay _legacyPay = new();
        public void MakePayment(PaymentRequest paymentRequest)
        {
            try
            {
                int amount = (int)paymentRequest.Amount;
                _legacyPay.MakePayment(amount);
            }
            catch (OverflowException)
            {
                System.Console.WriteLine("Amount is too large for LegacyPay to handle");
            }
        }

        public void IssueRefund(int transactionId)
        {
            Console.WriteLine("It is not possible to issue a refund with this payment method");
        }

        public TransactionStatus GetTransactionStatus(int transactionId)
        {
            return _legacyPay.GetTransactionStatus(transactionId);
        }

        public void PrintTransactions()
        {
            _legacyPay.PrintTransactions();
        }

    }
}