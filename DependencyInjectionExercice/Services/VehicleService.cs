using DependencyInjectionExercice.Interfaces;

namespace DependencyInjectionExercice.Services
{
    public class VehicleService
    {
        private readonly IVehicle _vehicle;

        public VehicleService(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Honk()
        {
            _vehicle.Honk();
        }
    }
}