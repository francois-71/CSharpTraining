using System.Dynamic;
using enums;

namespace interfaces
{
    public interface IAsset
    {
        public string Name { get; }
        public AssetType Type { get; }
        public int Quantity { get; }
        public int PricePerUnit { get; }
    }
}