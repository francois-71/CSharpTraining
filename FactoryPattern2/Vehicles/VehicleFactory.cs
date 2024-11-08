using FactoryPattern2.Enums.Vehicles;

namespace FactoryPattern2.Vehicles
{
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(VehicleType vehicle, BrandType brand, ColorType color)
        {
            switch (vehicle)
            {
                case VehicleType.CAR:
                    return new Car(brand, color);

                case VehicleType.MOTO:
                    return new Moto(brand, color);

                case VehicleType.TRUCK:
                    return new Truck(brand, color);

                default: throw new Exception("Wrong vehicle type");
            }

        }
    }
}