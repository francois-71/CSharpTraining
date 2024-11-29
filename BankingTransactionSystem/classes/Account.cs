using interfaces;

namespace classes
{
    public class Account : IAccount
    {
        private static int _id = 0;
        public int AccountID { get; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (Balance - amount < 0)
            {
                throw new ArgumentOutOfRangeException("Balance is too low ");
            }
            else
            {
                Balance -= amount;
            }
        }

        public Account(string accountHolder, decimal balance)
        {
            AccountID = _id++;
            AccountHolder = accountHolder;
            Balance = balance;
        }
    }
}