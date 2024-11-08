using enums;
using interfaces;

namespace devices
{
    public class ThermostatY : IThermostat
    {
        public int Temperature { get; set; } = 15;
        public ModeType Mode { get; set; } = ModeType.HEAT;
        public int FanSpeed { get; set; } = 5;
        public string Brand { get; } = "Brand-Y";
    }
}