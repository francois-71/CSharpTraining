using interfaces;
using Strategies;

namespace Applications
{
    public class CarApp : AuthApplications
    {
        public CarApp() : base(new CredentialsStrategy()) { }
    }
}