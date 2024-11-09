using Applications;
using enums;
using interfaces;
using Strategies;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CarApp carApp = new();

            carApp.ApplyStrategy(new CredentialsStrategy());
            carApp.GetStrategy();

            BankApp bankApp = new();
            bankApp.GetStrategy();

            bankApp.ApplyStrategy(new CredentialsStrategy());
            bankApp.GetStrategy();

            bankApp.ApplyStrategy(new TwoFAStrategy());
            bankApp.GetStrategy();


        }
    }
}