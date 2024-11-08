using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using devices;
using interfaces;

namespace factory
{
    public class BrandYFactory : IBrandFactory
    {
        public ILight CreateLight()
        {
            return new LightY();
        }

        public ICamera CreateCamera()
        {
            return new CameraY();
        }

        public IThermostat CreateThermostat()
        {
            return new ThermostatY();
        }
    }
}