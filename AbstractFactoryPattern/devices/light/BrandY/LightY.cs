using interfaces;

namespace devices
{
    public class LightY : ILight
    {
        public int Brightness { get; set; } = 60;
        public string Color { get; set; } = "GREEN";
        private bool OnOffState { get; set; } = false;

        public string Brand { get; } = "Brand-Y";

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