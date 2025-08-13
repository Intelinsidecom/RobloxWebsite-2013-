using System;

namespace Roblox.Billing.GooglePlayStoreExceptions;

public class InvalidProductException : ApplicationException
{
	public string ProductId;

	public InvalidProductException(string productId)
		: base("Invalid Google Play Store Product: " + productId)
	{
		ProductId = productId;
	}
}
