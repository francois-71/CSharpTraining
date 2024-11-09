using interfaces;

namespace Class
{
    public class Coffee : ICoffee
    {
        private double _price { get; } = 2;

        private string _name { get; set; } = "Coffee";

        public string GetDescription()
        {
            return $"Your coffee: {_name}";
        }

        public double GetCost()
        {
            return _price;
        }
    }
}