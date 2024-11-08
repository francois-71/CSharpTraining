using enums;

namespace interfaces
{
    public interface ICamera
    {
        public ResolutionType Resolution { get; set; }
        public bool NightMode { get; set; }
        public AngleOfViewType AngleOfView { get; set; }
        public string Brand { get; }
    }
}