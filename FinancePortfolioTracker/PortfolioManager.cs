using AssetProperties;
using interfaces;

namespace FinancePortolioTracker.Manager
{
    public class PortfolioManager
    {
        public List<Asset> AssetsList { get; set; } = [];

        public void AddAsset(Asset asset)
        {
            if (AssetsList.Any(a => a.Name == asset.Name))
            {
                throw new Exception("Couldn't not create the Asset. An asset with this name already exist.");
            }
            else
            {
                AssetsList.Add(asset);
            }
        }

        public void RemoveAsset(string assetName)
        {
            Asset? value = AssetsList.Find(a => a.Name == assetName);

            if (value != null)
            {
                AssetsList.Remove(value);
            }

            else
            {
                throw new Exception("Couldn't delete the asset as it doesn't not exist");
            }
        }

        private int GetPortfolioValue()
        {
            int portfolioSum = 0;

            foreach (Asset asset in AssetsList)
            {
                portfolioSum += asset.Quantity * asset.PricePerUnit;
            }

            return portfolioSum;
        }

        public void DisplayPortfolioValue()
        {
            Console.WriteLine($"The Total value of the portfolio is equal to {GetPortfolioValue()}");
        }

        public void ListAllPortfolioAssets()
        {
            if (!AssetsList.Any()) {
                Console.WriteLine("Empty.");
            }
            foreach (Asset asset in AssetsList)
            {
                Console.WriteLine($"Asset: {asset.Name} - Asset Type: {asset.Type} - Asset Quantity: {asset.Quantity} - Asset Price per Unit: {asset.PricePerUnit}");
            }
        }
    }
}