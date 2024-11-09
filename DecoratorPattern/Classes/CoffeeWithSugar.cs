using Decorators;
using interfaces;

namespace Class
{
    public class CoffeWithSugar : CoffeeDecorator
    {
        public CoffeWithSugar(ICoffee coffee) : base(coffee) { }

        public override double GetCost()
        {
            double updatedPrice = _coffee.GetCost() + 0.1;

            return updatedPrice;
        }

        public override string GetDescription()
        {
            return $"{_coffee.GetDescription()} + Sugar";
        }
    }
}