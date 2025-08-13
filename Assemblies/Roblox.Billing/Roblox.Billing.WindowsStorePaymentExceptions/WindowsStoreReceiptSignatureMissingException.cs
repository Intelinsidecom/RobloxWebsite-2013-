using System;

namespace Roblox.Billing.WindowsStorePaymentExceptions;

public class WindowsStoreReceiptSignatureMissingException : ApplicationException
{
	public WindowsStoreReceiptSignatureMissingException()
		: base("Supplied receipt was missing a signature.")
	{
	}
}
