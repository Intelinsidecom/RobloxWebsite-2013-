using System;

namespace Roblox.Billing.WindowsStorePaymentExceptions;

public class WindowsStoreReceiptMissingTransactionFailedException : ApplicationException
{
	public WindowsStoreReceiptMissingTransactionFailedException()
		: base("Supplied receipt did not contain the supplied transaction ID.")
	{
	}
}
