namespace interfaces
{
    public interface ILight
    {
        public int Brightness { get; set; }
        public string Color { get; set; }
        public string Brand { get; }

        void TurnOn();
        void TurnOff();

        bool IsOn();
    }
}