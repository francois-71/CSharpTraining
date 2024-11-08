using System.Reflection.Metadata.Ecma335;
using devices;
using interfaces;

namespace factory
{
    public class BrandXFactory : IBrandFactory
    {
        public ILight CreateLight()
        {
            return new LightX();
        }

        public ICamera CreateCamera()
        {
            return new CameraX();
        }

        public IThermostat CreateThermostat()
        {
            return new ThermostatX();
        }
    }
}