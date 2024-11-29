using enums;
using factories;
using interfaces;

namespace classes
{
    public class Bank : IBank
    {
        private List<Account> _accounts = new List<Account>();
        private List<ITransaction> _transactions = new List<ITransaction>();
        public int CreateAccount(string accountHolder, decimal initialBalance = 0)
        {
            Account account = new(accountHolder, initialBalance);
            _accounts.Add(account);
            return account.AccountID;
        }
        public Account GetAccountById(int accountID)
        {
            Account account = _accounts.First(acc => acc.AccountID == accountID);
            return account;
        }
        public void Deposit(int accountID, decimal amount)
        {
            try
            {
                Account account = GetAccountById(accountID) ?? throw new ArgumentNullException("This account does not exist");
                account.Deposit(amount);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            ITransaction transaction = TransactionFactory.MakeTransaction(TransactionType.DEPOSIT, accountID: accountID, amount: amount);
            _transactions.Add(transaction);
        }
        public void Withdraw(int accountID, decimal amount)
        {
            try
            {
                Account account = GetAccountById(accountID) ?? throw new ArgumentNullException("This account does not exist");
                account.Withdraw(amount);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            ITransaction transaction = TransactionFactory.MakeTransaction(TransactionType.WITHDRAWAL, accountID: accountID, amount: amount);
            _transactions.Add(transaction);
        }
        public void Transfer(int fromAccountID, int toAccountID, decimal amount)
        {
            try
            {
                Account fromAccount = GetAccountById(fromAccountID) ?? throw new ArgumentNullException("Sender account doesn't exist");
                fromAccount.Withdraw(amount);
                Account toAccount = GetAccountById(toAccountID) ?? throw new ArgumentNullException("Receiver account does not exist");
                toAccount.Deposit(amount);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            ITransaction transaction = TransactionFactory.MakeTransaction(TransactionType.TRANSFER, amount, toAccountID: toAccountID, fromAccountID: fromAccountID);
            _transactions.Add(transaction);
        }
        public decimal GetAccountBalance(int accountID)
        {
            var account = _accounts.Find(acc => acc.AccountID == accountID);

            if (account != null)
            {
                return account.Balance;
            }

            throw new Exception($"Account with ID {accountID} not found.");
        }

        public void PrintTransactionHistory(int accountID)
        {
            List<ITransaction> accountTransactions = new List<ITransaction>();
            accountTransactions = _transactions.FindAll(transaction => transaction?.FromAccount == accountID || transaction?.ToAccount == accountID);
            if (accountTransactions.Count > 0)
            {
                Console.WriteLine(accountTransactions);
                foreach (var t in accountTransactions)
                {
                    Console.WriteLine($"{t}");
                }
            }
        }
    }
}