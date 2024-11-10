using ObserverPattern;
using Subscriber;

namespace Program
{
    public class ObserverPattern
    {
        public static void Main(string[] args)
        {
            // Create a Publisher.
            Publisher publisher = new Publisher();
            publisher.printSubscribersCount();


            // Create 3 subscribers.
            Subscriber1 subscriber1 = new();
            Subscriber2 subscriber2 = new();
            Subscriber3 subscriber3 = new();

            publisher.Subscribe(subscriber1);
            publisher.Subscribe(subscriber3);
            publisher.printSubscribersCount();

            publisher.Update("What's up");

            Console.WriteLine($"Message from the Publisher for {subscriber1} - {subscriber1.GetMessage()}");
            Console.WriteLine($"Message from the Publisher for {subscriber2} - {subscriber2.GetMessage()}");
            Console.WriteLine($"Message from the Publisher for {subscriber3} - {subscriber3.GetMessage()}");

            publisher.UnSubscribe(subscriber1);
            publisher.printSubscribersCount();

            publisher.Update("You're special ! ");

            Console.WriteLine($"Message from the Publisher for {subscriber1} - {subscriber1.GetMessage()}");
            Console.WriteLine($"Message from the Publisher for {subscriber2} - {subscriber2.GetMessage()}");
            Console.WriteLine($"Message from the Publisher for {subscriber3} - {subscriber3.GetMessage()}");
        }
    }
}