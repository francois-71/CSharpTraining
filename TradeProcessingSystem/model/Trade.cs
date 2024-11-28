using interfaces;

namespace model
{
    public class Trade : ITrade
    {
        public string Instrument { get; }
        public int Quantity { get; }

        public decimal Price { get; }

        public DateTime TimeStamp { get; }

        public Trade(string instrument, int quantity, decimal price)
        {
            Instrument = instrument;
            Quantity = quantity;
            Price = price;
            TimeStamp = DateTime.Now;
        }
    }
}