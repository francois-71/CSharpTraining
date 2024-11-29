using System.Transactions;
using enums;
using interfaces;

namespace classes
{
    public abstract class TransactionBase : ITransaction
    {
        private static int _transactionID = 0;
        public int TransactionID { get; }
        public int? FromAccount { get; set; }
        public int? ToAccount { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; }

        public TransactionBase(decimal amount)
        {
            Amount = amount;
            TransactionID = _transactionID++;
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Transaction: {TransactionID} - Date: {Timestamp} - Amount: {Amount}";
        }
    }
}