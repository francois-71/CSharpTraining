using System.Net;
using enums;
using interfaces;

namespace Applications
{
    public abstract class AuthApplications
    {
        private IAuthStrategy _authStrategy { get; set; }

        public AuthApplications(IAuthStrategy authStrategy)
        {
            _authStrategy = authStrategy;
        }

        public void ApplyStrategy(IAuthStrategy authStrategy)
        {
            _authStrategy = authStrategy;
        }

        public void GetStrategy()
        {
            _authStrategy.UseAuthStrategy();
        }
    }
}