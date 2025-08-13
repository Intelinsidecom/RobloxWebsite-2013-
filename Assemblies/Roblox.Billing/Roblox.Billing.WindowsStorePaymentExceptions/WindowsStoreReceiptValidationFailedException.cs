using System;

namespace Roblox.Billing.WindowsStorePaymentExceptions;

public class WindowsStoreReceiptValidationFailedException : ApplicationException
{
	public WindowsStoreReceiptValidationFailedException()
		: base("Supplied receipt did not pass validation with the specified certificate.")
	{
	}
}
