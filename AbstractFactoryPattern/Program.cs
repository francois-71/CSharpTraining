using factory;
using interfaces;

namespace AbstractFactoryPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            // create an instance of brandX
            BrandXFactory xFactory = new BrandXFactory();

            ICamera xCamera = xFactory.CreateCamera();
            ILight xLight = xFactory.CreateLight();
            IThermostat xThermostat = xFactory.CreateThermostat();

            // create an instance of brandY
            BrandYFactory yFactory = new BrandYFactory();

            ICamera yCamera = yFactory.CreateCamera();
            ILight yLight = yFactory.CreateLight();
            IThermostat yThermostat = yFactory.CreateThermostat();

            System.Console.WriteLine($"yCamera: {yCamera.Brand} - AngleOfView: {yCamera.AngleOfView} - Night Mode: {yCamera.NightMode} - Resolution: {yCamera.Resolution}");
            System.Console.WriteLine($"xCamera: {xCamera.Brand} - AngleOfView: {xCamera.AngleOfView} - Night Mode: {xCamera.NightMode} - Resolution: {xCamera.Resolution}");
        }
    }
}