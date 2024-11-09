using interfaces;
using Strategies;

namespace Applications
{
    public class BankApp : AuthApplications
    {

        public BankApp() : base(new TwoFAStrategy())
        {
        }
    }
}