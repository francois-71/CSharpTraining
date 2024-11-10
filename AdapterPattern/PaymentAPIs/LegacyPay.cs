using enums;

namespace PaymentAPIs
{
    public class LegacyPay
    {
        private Dictionary<int, float> _transactions = new Dictionary<int, float>();
        private int _transactionId { get; set; }

        public void MakePayment(int amount)
        {
            _transactions.Add(_transactionId++, amount);
        }
        public void ReversePayment(int transactionId)
        {
            if (_transactions.ContainsKey(transactionId))
            {
                _transactions.Remove(transactionId);
            }
        }

        // this method is not exact as A transaction should contain the transaction status. But for this implemntation, it is not usefull
        public TransactionStatus GetTransactionStatus(int transactionId)
        {
            if (_transactions.ContainsKey(transactionId))
            {
                return TransactionStatus.SUCCESS;
            }
            else
            {
                return TransactionStatus.FAILED;
            }
        }

        public void PrintTransactions()
        {
            foreach (KeyValuePair<int, float> transaction in _transactions)
            {
                Console.WriteLine($"Transaction ID: {transaction.Key} - Transaction Value: {transaction.Value}");
            }
        }
    }
}