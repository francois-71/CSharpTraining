using enums;
using transactions;

namespace Interface
{
    public interface IPayAdapter
    {
        public void MakePayment(PaymentRequest paymentRequest);

        public void IssueRefund(int transactionId);

        public TransactionStatus GetTransactionStatus(int transactionId);

        public void PrintTransactions();
    }
}