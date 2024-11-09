using enums;
using interfaces;

namespace Strategies
{
    public class CredentialsStrategy : IAuthStrategy
    {

        public void UseAuthStrategy()
        {
            System.Console.WriteLine("Using CredentialStrategy");
        }
    }
}