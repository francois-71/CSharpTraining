using System.Security.Cryptography;

namespace classes
{
    public class TransferTransaction : TransactionBase
    {

        public TransferTransaction(decimal amount, int fromAccount, int toAccount) : base(amount)
        {
            Amount = amount;
            FromAccount = fromAccount;
            ToAccount = toAccount;
        }

        public override string ToString()
        {
            return "Transaction Type: Transfer. " + base.ToString() + $" From Account: {FromAccount} - To Account: {ToAccount}";
        }
    }
}