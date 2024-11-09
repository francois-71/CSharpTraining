using Class;
using interfaces;

namespace DecoratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICoffee coffee = new Coffee();
            Console.WriteLine($"{coffee.GetDescription()} | Price: {coffee.GetCost()}");

            // Now, modify the coffee and add milk to it without having to recreate an instance of coffee;

            coffee = new CoffeeWithMilk(coffee);
            Console.WriteLine($"{coffee.GetDescription()} | Price: {coffee.GetCost()}");

            // add milk again.

            coffee = new CoffeeWithMilk(coffee);
            Console.WriteLine($"{coffee.GetDescription()} | Price: {coffee.GetCost()}");

            // add sugar

            coffee = new CoffeWithSugar(coffee);
            Console.WriteLine($"{coffee.GetDescription()} | Price: {coffee.GetCost()}");

        }
    }
}