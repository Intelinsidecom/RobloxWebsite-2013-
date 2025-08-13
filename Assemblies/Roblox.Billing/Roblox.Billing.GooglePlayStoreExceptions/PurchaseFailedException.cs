using System;

namespace Roblox.Billing.GooglePlayStoreExceptions;

public class PurchaseFailedException : ApplicationException
{
	public string ProductId;

	public PurchaseFailedException(string productId)
		: base("Failed to purchase Google PlayStore product: " + productId)
	{
		ProductId = productId;
	}
}
