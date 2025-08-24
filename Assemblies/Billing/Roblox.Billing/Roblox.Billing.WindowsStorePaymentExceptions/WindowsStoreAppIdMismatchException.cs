using System;

namespace Roblox.Billing.WindowsStorePaymentExceptions;

public class WindowsStoreAppIdMismatchException : ApplicationException
{
	public WindowsStoreAppIdMismatchException()
		: base("Supplied receipt was for the wrong app.")
	{
	}
}
