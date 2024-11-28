namespace interfaces
{
    public interface ITrade
    {
        public string Instrument { get; }
        public int Quantity { get; }

        public decimal Price { get; }

        public DateTime TimeStamp { get; }
    }
}