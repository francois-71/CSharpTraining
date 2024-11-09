using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace SingletonPattern
{
    public class DbInstance
    {
        public string DbName { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public IPAddress IPAddress { get; set; }

        private static readonly Lock _instanceLock = new();
        private static DbInstance? _instance = null;

        private DbInstance(string dbname, string host, int port, IPAddress ipAddress)
        {
            DbName = dbname;
            Host = host;
            Port = port;
            IPAddress = ipAddress;
        }

        public static DbInstance CreateDBSingleton(string dbname, string host, int port, IPAddress ipAddress)
        {
            // using lock to prevent multiple creation of instance if multiple threads wants to perform this action at the 
            // same time

            lock (_instanceLock)
            {
                if (_instance == null)
                {
                    _instance = new(dbname, host, port, ipAddress);

                }
                else
                {
                    throw new InvalidOperationException("Cannot instantiate a second Db Instance");
                }
                return _instance;
            }
        }
    }
}