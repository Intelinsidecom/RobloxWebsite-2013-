using Roblox.Billing.GooglePlayStoreExceptions;

namespace Roblox.Billing;

public class GooglePlayStoreProductFactory
{
	public static readonly GooglePlayStoreProductFactory Singleton = new GooglePlayStoreProductFactory();

	private GooglePlayStoreProductFactory()
	{
	}

	public IProduct GetProduct(string googlePlayStoreProductId)
	{
		int productId;
		switch (googlePlayStoreProductId)
		{
		case "com.roblox.client.bc1month":
			productId = Product.BC30DaysID;
			break;
		case "com.roblox.client.tbc1month":
			productId = Product.Get("Turbo Builders Club 1 Month").ID;
			break;
		case "com.roblox.client.obc1month":
			productId = Product.Get("Outrageous Builders Club 1 Month").ID;
			break;
		case "com.roblox.client.bc3month":
			productId = Product.Get("Builders Club 90 Days").ID;
			break;
		case "com.roblox.client.tbc3month":
			productId = Product.Get("Turbo Builders Club 3 Months").ID;
			break;
		case "com.roblox.client.obc3month":
			productId = Product.Get("Outrageous Builders Club 3 Months").ID;
			break;
		case "com.roblox.robloxmobile.robloxpremium450onemonth":
			productId = Product.Get("Roblox Premium 450 One Month").ID;
			break;
		case "com.roblox.robloxmobile.robloxpremium1000onemonth":
			productId = Product.Get("Roblox Premium 1000 One Month").ID;
			break;
		case "com.roblox.robloxmobile.robloxpremium2200onemonth":
			productId = Product.Get("Roblox Premium 2200 One Month").ID;
			break;
		case "com.roblox.robloxmobile.robloxpremium450":
			productId = Product.Get("Roblox Premium 450").ID;
			break;
		case "com.roblox.robloxmobile.robloxpremium1000":
			productId = Product.Get("Roblox Premium 1000").ID;
			break;
		case "com.roblox.robloxmobile.robloxpremium2200":
			productId = Product.Get("Roblox Premium 2200").ID;
			break;
		case "com.roblox.client.robux40":
			productId = Product.Get("40 Robux").ID;
			break;
		case "com.roblox.client.robux80":
		case "com.roblox.client.robux80nonbc":
			productId = Product.Get("80 Robux").ID;
			break;
		case "com.roblox.client.robux90":
		case "com.roblox.client.robux90bc":
			productId = Product.Get("90 Robux").ID;
			break;
		case "com.roblox.client.robux160":
			productId = Product.Get("160 Robux").ID;
			break;
		case "com.roblox.client.robux180bc":
			productId = Product.Get("180 Robux").ID;
			break;
		case "com.roblox.client.robux240":
			productId = Product.Get("240 Robux").ID;
			break;
		case "com.roblox.client.robux270bc":
			productId = Product.Get("270 Robux").ID;
			break;
		case "com.roblox.client.robux320":
			productId = Product.Get("320 Robux").ID;
			break;
		case "com.roblox.client.robux360bc":
			productId = Product.Get("360 Robux").ID;
			break;
		case "com.roblox.client.robux400":
			productId = Product.Get("400 Robux").ID;
			break;
		case "com.roblox.client.robux450bc":
			productId = Product.Get("450 Robux").ID;
			break;
		case "com.roblox.client.robux800":
		case "com.roblox.client.robux800nonbc":
			productId = Product.Get("800 Robux").ID;
			break;
		case "com.roblox.client.robux800promo":
			productId = Product.Get("800 Robux Promo").ID;
			break;
		case "com.roblox.client.robux1000":
		case "com.roblox.client.robux1000bc":
			productId = Product.Get("1000 Robux").ID;
			break;
		case "com.roblox.client.robux1000promobc":
			productId = Product.Get("1000 Robux Promo").ID;
			break;
		case "com.roblox.client.robux2000":
			productId = Product.Get("2000 Robux").ID;
			break;
		case "com.roblox.client.robux2200":
		case "com.roblox.client.robux2200bc":
			productId = Product.Get("2200 Robux").ID;
			break;
		case "com.roblox.client.robux2750bc":
			productId = Product.Get("2750 Robux").ID;
			break;
		case "com.roblox.client.robux4500":
			productId = Product.Get("4500 Robux").ID;
			break;
		case "com.roblox.client.robux6000bc":
			productId = Product.Get("6000 Robux").ID;
			break;
		case "com.roblox.client.robux10000":
			productId = Product.Get("10000 Robux").ID;
			break;
		case "com.roblox.client.robux15000bc":
			productId = Product.Get("15000 Robux").ID;
			break;
		case "com.roblox.client.robux22500":
			productId = Product.Get("22500 Robux").ID;
			break;
		case "com.roblox.client.robux35000bc":
			productId = Product.Get("35000 Robux").ID;
			break;
		case "com.roblox.client.robux900":
		case "com.roblox.client.robux900bc":
			productId = Product.Get("900 Robux").ID;
			break;
		case "com.roblox.client.robux2400":
		case "com.roblox.client.robux240bc":
			productId = Product.Get("2400 Robux").ID;
			break;
		case "com.roblox.client.robux5000":
		case "com.roblox.client.robux5000bc":
			productId = Product.Get("5000 Robux").ID;
			break;
		case "com.roblox.client.robux1100":
		case "com.roblox.client.robux1100bc":
			productId = Product.Get("1100 Robux").ID;
			break;
		case "com.roblox.client.robux25000":
		case "com.roblox.client.robux25000bc":
			productId = Product.Get("25000 Robux").ID;
			break;
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
		case "com.roblox.robloxmobile.premium4500robux":
			productId = Product.Get("Premium 4500 Robux").ID;
			break;
		case "com.roblox.robloxmobile.premium4950subscribed":
			productId = Product.Get("Premium 4950 Subscribed").ID;
			break;
		case "com.roblox.robloxmobile.premium10000robux":
			productId = Product.Get("Premium 10000 Robux").ID;
			break;
		case "com.roblox.robloxmobile.premium11000subscribed":
			productId = Product.Get("Premium 11000 Subscribed").ID;
			break;
		default:
			throw new InvalidProductException(googlePlayStoreProductId);
		}
		return ProductFactory.Singleton.GetProduct(productId);
	}
}
