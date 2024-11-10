using Interfaces;

namespace ObservatorPattern
{
    public class Publisher : INotification
    {
        protected List<INotification> subscribers = new List<INotification>();

        public void Update(string updateMessage)
        {
            foreach (INotification subscriber in subscribers)
            {
                subscriber.Update(updateMessage);
            }
        }

        public void Subscribe(INotification subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void UnSubscribe(INotification subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void printSubscribersCount()
        {
            System.Console.WriteLine($"Subscriber count {subscribers.Count}");
        }
    }
}