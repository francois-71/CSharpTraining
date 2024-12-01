using System.Security.Cryptography;

namespace DependencyInjectionExercice.Interfaces
{
    public interface IVehicle
    {   
        public void Honk();
        public void PrintWeight();
        public int GetMaxSpeed();
    }
}