using System;

namespace Roblox.Billing.GooglePlayStoreExceptions;

public class PurchaseAlreadyConsumedException : ApplicationException
{
	public PurchaseAlreadyConsumedException(string token)
		: base("Purchase has already been consumed for token: " + token)
	{
	}
}
