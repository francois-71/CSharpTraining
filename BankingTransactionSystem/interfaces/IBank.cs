using classes;

namespace interfaces
{
    public interface IBank
    {
        public int CreateAccount(string accountHolder, decimal initialBalance = 0);
        public Account GetAccountById(int accountID);
        public void Deposit(int accountID, decimal amount);
        public void Withdraw(int accountID, decimal amount);
        public void Transfer(int fromAccountID, int toAccountID, decimal amount);
        public decimal GetAccountBalance(int accountID);
        public void PrintTransactionHistory(int accountID);

    }
}