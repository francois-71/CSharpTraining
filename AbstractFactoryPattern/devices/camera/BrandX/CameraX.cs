using enums;
using interfaces;

namespace devices
{
    public class CameraX : ICamera
    {
        public ResolutionType Resolution { get; set; } = ResolutionType.R1920X1080;
        public bool NightMode { get; set; } = false;
        public AngleOfViewType AngleOfView { get; set; } = AngleOfViewType.X1;
        public string Brand { get; } = "Brand-X";
    }
}