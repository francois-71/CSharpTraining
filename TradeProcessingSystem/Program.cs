using interfaces;
using model;
using processor;

namespace Program
{
    public class TradeProcessingSystem
    {
        public static void Main(string[] args)
        {
            // create an instance of the TradeProcessor.

            TradeProcessor tradeProcessor = new();

            // create a trade:

            Trade trade = new("instrument1", 3, 540.32m);
            Trade trade2 = new("instrument1", 20, 32.45m);
            Trade trade3 = new("instrument1", 45, 201.34m);

            tradeProcessor.AddTrade(trade);
            tradeProcessor.AddTrade(trade2);
            tradeProcessor.AddTrade(trade3);

            List<ITrade> allTrades = tradeProcessor.GetAllTrades("instrument1");

            foreach (var t in allTrades)
            {
                Console.WriteLine(t.Instrument);
            }

            tradeProcessor.PrintLargestTrade();
        }
    }
}