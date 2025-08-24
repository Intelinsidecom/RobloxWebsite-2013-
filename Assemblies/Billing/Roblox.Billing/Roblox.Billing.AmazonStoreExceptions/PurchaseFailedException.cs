using System;

namespace Roblox.Billing.AmazonStoreExceptions;

public class PurchaseFailedException : ApplicationException
{
	public string ProductId;

	public PurchaseFailedException(string productId)
		: base("Failed to purchase Amazon Store product: " + productId)
	{
		ProductId = productId;
	}
}
