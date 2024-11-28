using System.ComponentModel.DataAnnotations;
using interfaces;
using model;

namespace processor
{
    public class TradeProcessor
    {
        private List<ITrade> _trades = new List<ITrade>();

        public void AddTrade(ITrade trade)
        {
            _trades.Add(trade);
        }

        public void CalculateTotalValue(string instrument)
        {
            // return the total price of each Trade that match the instrument
            var trades = _trades.Where(trade => trade.Instrument == instrument);
            decimal sum = 0;
            foreach (var trade in trades)
            {
                sum += trade.Price * trade.Quantity;
            }

            Console.WriteLine($"Sum for {instrument} is {sum}");
        }

        public List<ITrade> GetAllTrades(string instrument)
        {
            List<ITrade> trades = _trades.Where(trade => trade.Instrument == instrument).OrderBy(trade => trade.TimeStamp).ToList();

            return trades;
        }

        public void PrintLargestTrade()
        {

            var biggestTrade = _trades.OrderByDescending(trade => trade.Price * trade.Quantity).FirstOrDefault();

            if (biggestTrade != null)
            {
                System.Console.WriteLine($"Biggest trade: {biggestTrade.TimeStamp} - {biggestTrade.Instrument} - {biggestTrade.Price} - {biggestTrade.Quantity}");
            }

        }
    }
}