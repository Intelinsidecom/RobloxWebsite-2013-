using System;

namespace Roblox.Billing.XboxStoreExceptions;

public class PurchaseFailedException : ApplicationException
{
	public string ConsumableUrl;

	public PurchaseFailedException(string consumableUrl)
		: base("Failed to purchase Xbox Store Consumable Product: " + consumableUrl)
	{
		ConsumableUrl = consumableUrl;
	}
}
