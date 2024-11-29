using classes;

namespace program
{
    public class BankingTransactionSystem
    {
        public static void Main(string[] args)
        {
            // Open a bank account
            Bank bank = new();

            int francoisBankID = bank.CreateAccount("Francois", 25);
            int geoffreyBankID = bank.CreateAccount("Geoffrey");
            
            bank.Deposit(francoisBankID, 30);
            bank.Withdraw(francoisBankID, 60);

            Console.WriteLine(bank.GetAccountBalance(francoisBankID));
            Console.WriteLine(bank.GetAccountBalance(geoffreyBankID));

            bank.PrintTransactionHistory(francoisBankID);

            bank.Deposit(geoffreyBankID, 100);
            bank.Withdraw(geoffreyBankID, 20);

            bank.PrintTransactionHistory(geoffreyBankID);

            bank.Transfer(0, 1, 20);
            bank.Transfer(1, 0, 120);

            Console.WriteLine(bank.GetAccountBalance(francoisBankID));
            Console.WriteLine(bank.GetAccountBalance(geoffreyBankID));


        }
    }
}