namespace interfaces
{
    public interface IAccount
    {
        public int AccountID { get; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }
        public void Deposit(decimal amount);
        public void Withdraw(decimal amount);
    }
}