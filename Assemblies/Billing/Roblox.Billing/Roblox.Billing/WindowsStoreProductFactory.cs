using System;
using Roblox.Billing.Properties;

namespace Roblox.Billing;

public class WindowsStoreProductFactory
{
	public static readonly WindowsStoreProductFactory Singleton = new WindowsStoreProductFactory();

	private WindowsStoreProductFactory()
	{
	}

	public IProduct GetProduct(string windowsStoreProductId)
	{
		int productId;
		if (windowsStoreProductId == Settings.Default.WindowsStoreProductName1MonthBc)
		{
			productId = Product.BC30DaysID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName1MonthTbc)
		{
			productId = Product.Get("Turbo Builders Club 1 Month").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName1MonthObc)
		{
			productId = Product.Get("Outrageous Builders Club 1 Month").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName3MonthsBc)
		{
			productId = Product.Get("Builders Club 90 Days").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName3MonthsTbc)
		{
			productId = Product.Get("Turbo Builders Club 3 Months").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName3MonthsObc)
		{
			productId = Product.Get("Outrageous Builders Club 3 Months").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName80Robux)
		{
			productId = Product.Get("80 Robux").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName90Robux)
		{
			productId = Product.Get("90 Robux").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName160Robux)
		{
			productId = Product.Get("160 Robux").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName180Robux)
		{
			productId = Product.Get("180 Robux").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName240Robux)
		{
			productId = Product.Get("240 Robux").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName270Robux)
		{
			productId = Product.Get("270 Robux").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName320Robux)
		{
			productId = Product.Get("320 Robux").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName360Robux)
		{
			productId = Product.Get("360 Robux").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName400Robux)
		{
			productId = Product.Get("400 Robux").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName450Robux)
		{
			productId = Product.Get("450 Robux").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName800Robux)
		{
			productId = Product.Get("800 Robux").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName1000Robux)
		{
			productId = Product.Get("1000 Robux").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName2000Robux)
		{
			productId = Product.Get("2000 Robux").ID;
		}
		else if (windowsStoreProductId == Settings.Default.WindowsStoreProductName2750Robux)
		{
			productId = Product.Get("2750 Robux").ID;
		}
		else
		{
			switch (windowsStoreProductId)
			{
			case "com.roblox.robloxmobile.premium80robux":
				productId = Product.Get("Premium 80 Robux").ID;
				break;
			case "com.roblox.robloxmobile.premium88subscribed":
				productId = Product.Get("Premium 88 Subscribed").ID;
				break;
			case "com.roblox.robloxmobile.premium160robux":
				productId = Product.Get("Premium 160 Robux").ID;
				break;
			case "com.roblox.robloxmobile.premium175subscribed":
				productId = Product.Get("Premium 175 Subscribed").ID;
				break;
			case "com.roblox.robloxmobile.premium240robux":
				productId = Product.Get("Premium 240 Robux").ID;
				break;
			case "com.roblox.robloxmobile.premium265subscribed":
				productId = Product.Get("Premium 265 Subscribed").ID;
				break;
			case "com.roblox.robloxmobile.premium320robux":
				productId = Product.Get("Premium 320 Robux").ID;
				break;
			case "com.roblox.robloxmobile.premium350subscribed":
				productId = Product.Get("Premium 350 Subscribed").ID;
				break;
			case "com.roblox.robloxmobile.premium400robux":
				productId = Product.Get("Premium 400 Robux").ID;
				break;
			case "com.roblox.robloxmobile.premium440subscribed2":
				productId = Product.Get("Premium 440 Subscribed").ID;
				break;
			case "com.roblox.robloxmobile.premium800robux":
				productId = Product.Get("Premium 800 Robux").ID;
				break;
			case "com.roblox.robloxmobile.premium880subscribed":
				productId = Product.Get("Premium 880 Subscribed").ID;
				break;
			case "com.roblox.robloxmobile.premium1700robux":
				productId = Product.Get("Premium 1700 Robux").ID;
				break;
			case "com.roblox.robloxmobile.premium1870subscribed":
				productId = Product.Get("Premium 1870 Subscribed").ID;
				break;
			default:
				if (windowsStoreProductId.ToLower() == "com.roblox.robloxmobile.robloxpremium450onemonth")
				{
					productId = Product.Get("Roblox Premium 450 One Month").ID;
					break;
				}
				if (windowsStoreProductId.ToLower() == "com.roblox.robloxmobile.robloxpremium1000onemonth")
				{
					productId = Product.Get("Roblox Premium 1000 One Month").ID;
					break;
				}
				if (windowsStoreProductId.ToLower() == "com.roblox.robloxmobile.robloxpremium2200onemonth")
				{
					productId = Product.Get("Roblox Premium 2200 One Month").ID;
					break;
				}
				throw new ApplicationException(windowsStoreProductId);
			}
		}
		return ProductFactory.Singleton.GetProduct(productId);
	}
}
