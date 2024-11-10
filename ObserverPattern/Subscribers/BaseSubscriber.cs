using Interfaces;

namespace Subscriber
{
    public abstract class BaseSubscriber : INotification
    {
        public abstract void Update(string _updateMessage);
        public abstract string GetMessage();
        public abstract override string ToString();
    }
}