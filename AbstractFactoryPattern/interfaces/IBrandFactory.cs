namespace interfaces
{
    public interface IBrandFactory
    {
        public ILight CreateLight();
        public ICamera CreateCamera();
        public IThermostat CreateThermostat();
    }
}