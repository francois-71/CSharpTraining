using enums;
using interfaces;

namespace devices
{
    public class CameraY : ICamera
    {
        public ResolutionType Resolution { get; set; } = ResolutionType.R800X600;
        public bool NightMode { get; set; } = true;
        public AngleOfViewType AngleOfView { get; set; } = AngleOfViewType.X2;
        public string Brand { get; } = "Brand-Y";
    }
}