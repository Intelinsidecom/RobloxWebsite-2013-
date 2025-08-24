using System;

namespace Roblox.Billing.Exceptions;

[Serializable]
public class InCommPaymentException : ApplicationException
{
	public InCommPaymentException(string message)
		: base(message)
	{
	}
}
