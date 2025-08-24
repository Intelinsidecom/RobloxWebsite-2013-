using System;

namespace Roblox.Billing;

public class AppleAppStoreProductFactory
{
	public static readonly AppleAppStoreProductFactory Singleton = new AppleAppStoreProductFactory();

	private AppleAppStoreProductFactory()
	{
	}

	public IProduct GetProduct(string appStoreProductId)
	{
		int productId;
		switch (appStoreProductId)
		{
		case "com.roblox.robloxmobile.1monthBC":
			productId = Product.BC30DaysID;
			break;
		case "com.roblox.robloxmobile.1monthTBC":
			productId = Product.Get("Turbo Builders Club 1 Month").ID;
			break;
		case "com.roblox.robloxmobile.1monthOBC":
			productId = Product.Get("Outrageous Builders Club 1 Month").ID;
			break;
		case "com.roblox.robloxmobile.3monthBC":
			productId = Product.Get("Builders Club 90 Days").ID;
			break;
		case "com.roblox.robloxmobile.3monthTBC":
			productId = Product.Get("Turbo Builders Club 3 Months").ID;
			break;
		case "com.roblox.robloxmobile.3monthOBC":
			productId = Product.Get("Outrageous Builders Club 3 Months").ID;
			break;
		case "com.roblox.robloxmobile.RobloxPremium450":
			productId = Product.Get("Roblox Premium 450").ID;
			break;
		case "com.roblox.robloxmobile.RobloxPremium1000":
			productId = Product.Get("Roblox Premium 1000").ID;
			break;
		case "com.roblox.robloxmobile.RobloxPremium2200":
			productId = Product.Get("Roblox Premium 2200").ID;
			break;
		case "com.roblox.robloxmobile.RobloxPremium450OneMonth":
			productId = Product.Get("Roblox Premium 450 One Month").ID;
			break;
		case "com.roblox.robloxmobile.RobloxPremium1000OneMonth":
			productId = Product.Get("Roblox Premium 1000 One Month").ID;
			break;
		case "com.roblox.robloxmobile.RobloxPremium2200OneMonth":
			productId = Product.Get("Roblox Premium 2200 One Month").ID;
			break;
		case "com.roblox.robloxmobile.80Robux":
		case "com.roblox.robloxmobile.80RobuxNonBC":
			productId = Product.Get("80 Robux").ID;
			break;
		case "com.roblox.robloxmobile.90Robux":
		case "com.roblox.robloxmobile.90RobuxBC":
			productId = Product.Get("90 Robux").ID;
			break;
		case "com.roblox.robloxmobile.160RobuxNonBC":
			productId = Product.Get("160 Robux").ID;
			break;
		case "com.roblox.robloxmobile.180RobuxBC":
			productId = Product.Get("180 Robux").ID;
			break;
		case "com.roblox.robloxmobile.240RobuxNonBC":
			productId = Product.Get("240 Robux").ID;
			break;
		case "com.roblox.robloxmobile.270RobuxBC":
			productId = Product.Get("270 Robux").ID;
			break;
		case "com.roblox.robloxmobile.320RobuxNonBC":
			productId = Product.Get("320 Robux").ID;
			break;
		case "com.roblox.robloxmobile.360RobuxBC":
			productId = Product.Get("360 Robux").ID;
			break;
		case "com.roblox.robloxmobile.400RobuxNonBC":
			productId = Product.Get("400 Robux").ID;
			break;
		case "com.roblox.robloxmobile.450RobuxBC":
			productId = Product.Get("450 Robux").ID;
			break;
		case "com.roblox.robloxmobile.800Robux":
		case "com.roblox.robloxmobile.800RobuxNonBC":
			productId = Product.Get("800 Robux").ID;
			break;
		case "com.roblox.robloxmobile.1000Robux":
		case "com.roblox.robloxmobile.1000RobuxBC":
			productId = Product.Get("1000 Robux").ID;
			break;
		case "com.roblox.robloxmobile.2000RobuxNonBC":
			productId = Product.Get("2000 Robux").ID;
			break;
		case "com.roblox.robloxmobile.2750RobuxBC":
			productId = Product.Get("2750 Robux").ID;
			break;
		case "com.roblox.robloxmobile.IPadOnlyItem1":
			productId = Product.Get("IPad Item 1").ID;
			break;
		case "com.roblox.robloxmobile.IPadOnlyItem2":
			productId = Product.Get("IPad Item 2").ID;
			break;
		case "com.roblox.robloxmobile.IPadOnlyItem3":
			productId = Product.Get("IPad Item 3").ID;
			break;
		case "com.roblox.robloxmobile.IPadOnlyItem4":
			productId = Product.Get("IPad Item 4").ID;
			break;
		case "com.roblox.robloxmobile.IPadOnlyItem5":
			productId = Product.Get("IPad Item 5").ID;
			break;
		case "com.roblox.robloxmobile.IPadOnlyItem6":
			productId = Product.Get("IPad Item 6").ID;
			break;
		case "com.roblox.robloxmobile.IPadOnlyItem7":
			productId = Product.Get("IPad Item 7").ID;
			break;
		case "com.roblox.robloxmobile.Premium80Robux":
			productId = Product.Get("Premium 80 Robux").ID;
			break;
		case "com.roblox.robloxmobile.Premium88Subscribed":
			productId = Product.Get("Premium 88 Subscribed").ID;
			break;
		case "com.roblox.robloxmobile.Premium160Robux":
			productId = Product.Get("Premium 160 Robux").ID;
			break;
		case "com.roblox.robloxmobile.Premium175Subscribed":
			productId = Product.Get("Premium 175 Subscribed").ID;
			break;
		case "com.roblox.robloxmobile.Premium240Robux":
			productId = Product.Get("Premium 240 Robux").ID;
			break;
		case "com.roblox.robloxmobile.Premium265Subscribed":
			productId = Product.Get("Premium 265 Subscribed").ID;
			break;
		case "com.roblox.robloxmobile.Premium320Robux":
			productId = Product.Get("Premium 320 Robux").ID;
			break;
		case "com.roblox.robloxmobile.Premium350Subscribed":
			productId = Product.Get("Premium 350 Subscribed").ID;
			break;
		case "com.roblox.robloxmobile.Premium400Robux":
			productId = Product.Get("Premium 400 Robux").ID;
			break;
		case "com.roblox.robloxmobile.Premium440Subscribed2":
			productId = Product.Get("Premium 440 Subscribed").ID;
			break;
		case "com.roblox.robloxmobile.Premium800Robux":
			productId = Product.Get("Premium 800 Robux").ID;
			break;
		case "com.roblox.robloxmobile.Premium880Subscribed":
			productId = Product.Get("Premium 880 Subscribed").ID;
			break;
		case "com.roblox.robloxmobile.Premium1700Robux":
			productId = Product.Get("Premium 1700 Robux").ID;
			break;
		case "com.roblox.robloxmobile.Premium1870Subscribed":
			productId = Product.Get("Premium 1870 Subscribed").ID;
			break;
		case "com.roblox.robloxmobile.Premium4500Robux":
			productId = Product.Get("Premium 4500 Robux").ID;
			break;
		case "com.roblox.robloxmobile.Premium4950Subscribed":
			productId = Product.Get("Premium 4950 Subscribed").ID;
			break;
		case "com.roblox.robloxmobile.Premium10000Robux":
			productId = Product.Get("Premium 10000 Robux").ID;
			break;
		case "com.roblox.robloxmobile.Premium11000Subscribed":
			productId = Product.Get("Premium 11000 Subscribed").ID;
			break;
		case "com.roblox.SpaceKnights.80Robux":
			productId = Product.Get("80 Robux").ID;
			break;
		case "com.roblox.SpaceKnights.90Robux":
			productId = Product.Get("90 Robux").ID;
			break;
		case "com.roblox.SpaceKnights.800Robux":
			productId = Product.Get("800 Robux").ID;
			break;
		case "com.roblox.SpaceKnights.1000Robux":
			productId = Product.Get("1000 Robux").ID;
			break;
		case "com.roblox.HangOutInADiscoAndChat.80Robux":
			productId = Product.Get("80 Robux").ID;
			break;
		case "com.roblox.HangOutInADiscoAndChat.90Robux":
			productId = Product.Get("90 Robux").ID;
			break;
		case "com.roblox.HangOutInADiscoAndChat.800Robux":
			productId = Product.Get("800 Robux").ID;
			break;
		case "com.roblox.HangOutInADiscoAndChat.1000Robux":
			productId = Product.Get("1000 Robux").ID;
			break;
		case "com.roblox.SurviveTheDisasters.80Robux":
			productId = Product.Get("80 Robux").ID;
			break;
		case "com.roblox.SurviveTheDisasters.90Robux":
			productId = Product.Get("90 Robux").ID;
			break;
		case "com.roblox.SurviveTheDisasters.800Robux":
			productId = Product.Get("800 Robux").ID;
			break;
		case "com.roblox.SurviveTheDisasters.1000Robux":
			productId = Product.Get("1000 Robux").ID;
			break;
		case "com.roblox.TheDisasterGames.80Robux":
			productId = Product.Get("80 Robux").ID;
			break;
		case "com.roblox.TheDisasterGames.90Robux":
			productId = Product.Get("90 Robux").ID;
			break;
		case "com.roblox.TheDisasterGames.800Robux":
			productId = Product.Get("800 Robux").ID;
			break;
		case "com.roblox.TheDisasterGames.1000Robux":
			productId = Product.Get("1000 Robux").ID;
			break;
		default:
			throw new ApplicationException("Invalid AppleAppStore Product: " + appStoreProductId);
		}
		return ProductFactory.Singleton.GetProduct(productId);
	}
}
