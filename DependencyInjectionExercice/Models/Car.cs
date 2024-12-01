using DependencyInjectionExercice.Interfaces;

namespace DependencyInjectionExercice.Models
{
    public class Car : Vehicle
    {
        public override void Honk()
        {
            System.Console.WriteLine("honk honk I am a car ");
        }
        public override void PrintWeight()
        {
            System.Console.WriteLine("1000 kg");
        }
        public override int GetMaxSpeed()
        {
            return 180;
        }
    }
}