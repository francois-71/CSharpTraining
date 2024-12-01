using DependencyInjectionExercice.Interfaces;

namespace DependencyInjectionExercice.Models
{
    public abstract class Vehicle : IVehicle
    {
        public abstract void Honk();
        public abstract void PrintWeight();
        public abstract int GetMaxSpeed();
    }
}