using enums;

namespace classes
{
    public class DepositTransaction : TransactionBase
    {
        public DepositTransaction(int toAccount, decimal amount) : base(amount)
        {
            ToAccount = toAccount;
            Amount = amount;
        }

        public override string ToString()
        {
            return "Transaction Type: Deposit. " + base.ToString() + $" To Account: {ToAccount}";
        }
    }
}