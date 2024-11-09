using enums;
using interfaces;

namespace Strategies
{
    public class TwoFAStrategy : IAuthStrategy
    {

        public void UseAuthStrategy()
        {
            System.Console.WriteLine("Using TwoFAStrategy");
        }
    }
}