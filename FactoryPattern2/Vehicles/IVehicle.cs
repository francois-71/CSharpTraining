using FactoryPattern2.Enums.Vehicles;
namespace FactoryPattern2.Vehicles
{
    public interface IVehicle
    {

        public BrandType Brand { get; }
        public ColorType Color { get; }
        public void Horn();

    }
}