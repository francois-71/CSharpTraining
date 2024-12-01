using DependencyInjectionExercice.Interfaces;
using DependencyInjectionExercice.Models;
using DependencyInjectionExercice.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionExercice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();

            // Here, we are using the DI container.

            services.AddTransient<IVehicle, Bike>(); // Register Bike as IVehicle
            services.AddTransient<VehicleService>();


            // Instantiate all the Instances that are present in the DI Container.
            var serviceProvider = services.BuildServiceProvider();

            // this is the same as doing => VehicleService vehicleService = new VehicleService(new Bike()); but here, we don't need to instantiate Bike by ourselves.
            var vehicleService = serviceProvider.GetService<VehicleService>();

            vehicleService?.Honk();
        }
    }
}