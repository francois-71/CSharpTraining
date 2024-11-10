using enums;
using transactions;

namespace PaymentAPIs
{
    public class ModernPay

    {
        private List<PaymentRequest> _paymentRequests = new List<PaymentRequest>();
        public void ExecutePayment(PaymentRequest request)
        {
            _paymentRequests.Add(request);
        }

        public void IssueRefund(int transactionIdentifier)
        {
            //check if a transaction with the id provided exist.
            PaymentRequest? transaction = _paymentRequests.Find(t => t.GetTransactionId() == transactionIdentifier);

            if (transaction != null)
            {
                if (!(transaction.Amount >= 0 && transaction.Amount <= 10_000))
                {
                    throw new ArgumentOutOfRangeException("The amount should be equal or above 0 and less than 10 000");
                }

                try
                {
                    PaymentRequest refund = new(-transaction.Amount, transaction.Currency);
                    _paymentRequests.Add(refund);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public TransactionStatus GetTransactionStatus(int transactionIdentifier)
        {
            PaymentRequest? transaction = _paymentRequests.Find(t => t.GetTransactionId() == transactionIdentifier);
            if (transaction != null)
            {
                return TransactionStatus.SUCCESS;
            }
            else
            {
                return TransactionStatus.FAILED;
            }
        }

        public List<PaymentRequest> GetTransactions()
        {
            return _paymentRequests;
        }
    }
}