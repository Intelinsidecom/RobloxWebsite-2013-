using System;

namespace Roblox.Billing.GooglePlayStoreExceptions;

public class PurchaseCancelledException : ApplicationException
{
	public PurchaseCancelledException(string token)
		: base("Purchase has been cancelled for token: " + token)
	{
	}
}
