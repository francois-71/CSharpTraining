using DependencyInjectionExercice.Interfaces;

namespace DependencyInjectionExercice.Models
{
    public class Bus : Vehicle
    {
        public override void Honk()
        {
            System.Console.WriteLine("honk honk I am a bus ");
        }
        public override void PrintWeight()
        {
            System.Console.WriteLine("5000 kg");

        }
        public override int GetMaxSpeed()
        {
            return 110;
        }
    }
}