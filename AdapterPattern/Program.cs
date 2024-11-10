using Adapters;
using enums;
using transactions;

namespace AdapterPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LegacyPayAdaptor legacyPayAdaptor = new LegacyPayAdaptor();
            ModernPayAdaptor modernPayAdaptor = new ModernPayAdaptor();

            // make payment using the same method, with different payment adaptors. Since Adaptor implements the IPayAdapter that defines the MakePayment method:
            // We can do as below:

            legacyPayAdaptor.MakePayment(new PaymentRequest(5.2F, Currency.EUR));
            legacyPayAdaptor.MakePayment(new PaymentRequest(5.2F, Currency.EUR));

            modernPayAdaptor.MakePayment(new PaymentRequest(10.3F, Currency.USD));

            // Print transaction:
            legacyPayAdaptor.PrintTransactions();
            modernPayAdaptor.PrintTransactions();

            legacyPayAdaptor.IssueRefund(0);
            legacyPayAdaptor.IssueRefund(5);

            modernPayAdaptor.IssueRefund(3);
            modernPayAdaptor.IssueRefund(2);



        }
    }
}