using enums;

namespace interfaces
{
    public interface IThermostat
    {
        public int Temperature { get; set; }
        public ModeType Mode { get; set; }
        public int FanSpeed { get; set; }
        public string Brand { get; }
    }
}