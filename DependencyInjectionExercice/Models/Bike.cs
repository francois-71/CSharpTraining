using DependencyInjectionExercice.Interfaces;

namespace DependencyInjectionExercice.Models
{
    public class Bike : Vehicle
    {
        public override void Honk()
        {
            System.Console.WriteLine("honk honk I am a Bike");
        }
        public override void PrintWeight()
        {
            System.Console.WriteLine("10 kg");

        }
        public override int GetMaxSpeed()
        {
            return 40;
        }
    }
}