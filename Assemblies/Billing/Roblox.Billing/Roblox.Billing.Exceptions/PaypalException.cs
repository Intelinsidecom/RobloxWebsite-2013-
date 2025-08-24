using System;

namespace Roblox.Billing.Exceptions;

[Serializable]
public class PaypalException : ApplicationException
{
	public PaypalException(string message)
		: base(message)
	{
	}
}
