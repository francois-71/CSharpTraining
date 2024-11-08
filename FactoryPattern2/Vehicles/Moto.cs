using FactoryPattern2.Enums.Vehicles;

namespace FactoryPattern2.Vehicles
{
    public class Moto : Vehicle
    {
        public Moto(BrandType brand, ColorType color) : base(brand, color) { }

        public override void Horn()
        {
            System.Console.WriteLine("HONK, I am a Moto");
        }
    }
}