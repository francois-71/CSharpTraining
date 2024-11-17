using enums;
using interfaces;

namespace AssetProperties
{
    public class Asset(string name, AssetType type, int quantity, int pricePerUnit) : IAsset
    {
        public string Name { get; } = name;
        public AssetType Type { get; } = type;

        public int Quantity { get; } = quantity;

        public int PricePerUnit { get; } = pricePerUnit;
    }
}