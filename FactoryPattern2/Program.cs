using System.Runtime.InteropServices;
using FactoryPattern2.Vehicles;

namespace FactoryPattern2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a car
            IVehicle car = VehicleFactory.CreateVehicle(vehicle: Enums.Vehicles.VehicleType.TRUCK, brand: Enums.Vehicles.BrandType.VOLVO, color: Enums.Vehicles.ColorType.RED);

            car.Horn();
        }
    }
}