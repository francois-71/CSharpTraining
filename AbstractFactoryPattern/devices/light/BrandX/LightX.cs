using interfaces;

namespace devices
{
    public class LightX : ILight
    {
        public int Brightness { get; set; } = 50;
        public string Color { get; set; } = "RED";
        private bool OnOffState { get; set; } = false;

        public string Brand { get; } = "Brand-X";

        public void TurnOn()
        {
            OnOffState = true;
        }

        public void TurnOff()
        {
            OnOffState = false;
        }

        public bool IsOn()
        {
            return OnOffState;
        }
    }
}