using Interfaces;

namespace Subscriber
{
    public class Subscriber3 : BaseSubscriber
    {
        private string _updateMessage = "";
        public override void Update(string updateMessage)
        {
            _updateMessage = updateMessage;
        }

        public override string GetMessage()
        {
            return _updateMessage;
        }

        public override string ToString()
        {
            return "Subscriber 3";
        }
    }
}