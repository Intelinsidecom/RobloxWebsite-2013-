using System;

namespace Roblox.Billing.Exceptions;

[Serializable]
public class RixtyPinRedemptionException : ApplicationException
{
	public RixtyPinRedemptionException(string message)
		: base(message)
	{
	}
}
