using FactoryPattern2.Enums.Vehicles;

namespace FactoryPattern2.Vehicles
{
    public abstract class Vehicle : IVehicle
    {

        public BrandType Brand { get; }
        public ColorType Color { get; }
        public abstract void Horn();

        public Vehicle(BrandType brand, ColorType color)
        {
            Brand = brand;
            Color = color;
        }

        public override string ToString()
        {
            string description = $"Brand: {Brand} - Color: {Color}";
            return description;
        }
    }
}