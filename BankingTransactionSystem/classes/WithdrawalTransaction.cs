namespace classes
{
    public class WithdrawalTransaction : TransactionBase
    {
        public WithdrawalTransaction(decimal amount, int fromAccount) : base(amount)
        {
            FromAccount = fromAccount;
            Amount = amount;
        }

        public override string ToString()
        {
            return "Transaction Type: Withdrawal. " + base.ToString() + $" From Account: {FromAccount}";;
        }
    }
}