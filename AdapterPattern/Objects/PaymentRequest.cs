using System.Dynamic;
using System.Runtime.InteropServices;
using enums;

namespace transactions
{
    public class PaymentRequest
    {
        private static int _transactionId { get; set; } = 0;
        public float Amount { get; }
        public Currency Currency { get; }
        public PaymentRequest(float amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
            _transactionId++;
        }

        public int GetTransactionId()
        {
            return _transactionId;
        }

        public override string ToString()
        {
            return $"Transaction ID: {_transactionId} - Amount: {Amount} - Currency: {Currency}";
        }
    }
}