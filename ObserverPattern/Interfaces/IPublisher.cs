namespace Interfaces
{
    // interface all subscriber should implement so the publisher can send a message to all it's subscribers.
    public interface INotification
    {
        public void Update(string updateMessage);
    }
}