using System.Net;

namespace SingletonPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DbInstance dbInstance = DbInstance.CreateDBSingleton("DB", "localhost", 5432, IPAddress.Parse("127.0.0.1"));

            if (dbInstance != null)
            {
                System.Console.WriteLine($"DB INSTANCE: {dbInstance.DbName} - {dbInstance.Host} - {dbInstance.Port} - {dbInstance.IPAddress}");
            }

            try
            {
                DbInstance dbInstance2 = DbInstance.CreateDBSingleton("DB", "localhost", 5432, IPAddress.Parse("127.0.0.1"));
                if (dbInstance2 != null)
                {
                    System.Console.WriteLine($"DB INSTANCE: {dbInstance2.DbName} - {dbInstance2.Host} - {dbInstance2.Port} - {dbInstance2.IPAddress}");
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
        }
    }
}