using Decorators;
using interfaces;

namespace Class
{
    public class CoffeeWithMilk : CoffeeDecorator
    {
        public CoffeeWithMilk(ICoffee coffee) : base(coffee)
        {

        }

        public override double GetCost()
        {
            double updatedPrice = _coffee.GetCost() + 0.2;

            return updatedPrice;
        }

        public override string GetDescription()
        {
            return $"{_coffee.GetDescription()} + Milk";
        }
    }
}