namespace Roblox.GoogleAPI.Interfaces;

public interface IAndroidPublisher
{
	IInAppPurchase GetInAppPurchase(string packageName, string productId, string token);

	ISubscriptionPurchase GetPurchaseSubscription(string packageName, string productId, string token);
}
