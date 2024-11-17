using FinancePortolioTracker.Manager;
using enums;
using AssetProperties;
using System.ComponentModel.Design;

namespace FinancePortolioTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PortfolioManager portfolioManager = new();
            int key;

            do
            {
                string input = GetInputMenu();
                if (int.TryParse(input, out key))
                {
                    switch (key)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Choose a name for your asset");
                            var assetName1 = Console.ReadLine();
                            if (string.IsNullOrEmpty(assetName1))
                            {
                                throw new Exception("Asset name shouldn't be left empty");
                            }

                            Console.WriteLine($"Choose an asset Type between: 1:{AssetType.BOND} and 2:{AssetType.STOCK}");
                            AssetType assetType = AssetType.BOND;
                            var assetInput = Console.ReadLine();
                            if (int.TryParse(assetInput, out int assetKey))
                            {
                                switch (assetKey)
                                {
                                    case 1:
                                        assetType = AssetType.BOND;
                                        break;
                                    case 2:
                                        assetType = AssetType.STOCK;
                                        break;
                                    default:
                                        throw new ArgumentOutOfRangeException("Wrong number was provided");
                                }
                            }

                            Console.WriteLine("Write Quantity");
                            if (int.TryParse(Console.ReadLine(), out int assetQuantity))
                            {
                                Console.WriteLine("Write Price per Unit");
                                if (int.TryParse(Console.ReadLine(), out int assetPricePerUnit))
                                {
                                    try
                                    {
                                        portfolioManager.AddAsset(new Asset(assetName1, assetType, assetQuantity, assetPricePerUnit));
                                    }
                                    catch
                                    {
                                        throw;
                                    }
                                }
                                else
                                {
                                    throw new Exception("The asset Price per Unit input was not correct");
                                }
                            }
                            else
                            {
                                throw new Exception("The Asset Quantity input was not correct");
                            }
                            break;

                        case 2:
                            Console.WriteLine("To delete your asset, please provide a name");


                            try
                            {
                                var assetName2 = Console.ReadLine();
                                if (string.IsNullOrEmpty(assetName2))
                                {
                                    throw new Exception("Asset name shouldn't be left empty");
                                }
                                portfolioManager.RemoveAsset(assetName2);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                            }
                            break;

                        case 3:
                            portfolioManager.ListAllPortfolioAssets();
                            break;

                        case 4:
                            portfolioManager.DisplayPortfolioValue();
                            break;


                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Program exiting");
                    Environment.Exit(0);
                }
            } while (
                key >= 0 && key <= 4
            );
        }

        public static string GetInputMenu()
        {
            Console.WriteLine("Welcome to the main menu. Here is what you can do:");
            Console.WriteLine("1. Add Asset");
            Console.WriteLine("2. Remove Asset");
            Console.WriteLine("3. View Portfolio");
            Console.WriteLine("4. Calculate Total Value");
            Console.WriteLine("Any other key. Exit");

            var input = Console.ReadLine()!;

            return input;
        }
    }
}