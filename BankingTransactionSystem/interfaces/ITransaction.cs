using System.Transactions;
using enums;

namespace interfaces
{
    public interface ITransaction
    {
        public int TransactionID { get; }
        public int? FromAccount { get; }
        public int? ToAccount { get; }
        public decimal Amount { get; }
        public DateTime Timestamp { get; }
        public abstract string ToString();
    }
}