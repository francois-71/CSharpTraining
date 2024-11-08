using enums;
using interfaces;

namespace devices
{
    public class ThermostatX : IThermostat
    {
        public int Temperature { get; set; } = 30;
        public ModeType Mode { get; set; } = ModeType.COOL;
        public int FanSpeed { get; set; } = 2;

        public string Brand { get; } = "Brand-X";

    }
}