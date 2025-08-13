using System;

namespace Roblox.Billing.AppleAppStoreExceptions;

public class PurchaseFailedException : ApplicationException
{
	public string ProductId;

	public PurchaseFailedException(string productId)
		: base("Failed to purchase Apple AppStore product: " + productId)
	{
		ProductId = productId;
	}
}
