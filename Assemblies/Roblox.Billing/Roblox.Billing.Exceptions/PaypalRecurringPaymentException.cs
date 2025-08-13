using System;

namespace Roblox.Billing.Exceptions;

/// <summary>
/// Custom exception class for handling recurring payment issues like 
/// cc expiration and where Paypal returns error code "12".
/// </summary>
[Serializable]
public class PaypalRecurringPaymentException : ApplicationException
{
	public PaypalRecurringPaymentException(string message)
		: base(message)
	{
	}
}
