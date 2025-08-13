using System;

namespace Roblox.Billing.AmazonStoreExceptions;

public class VerificationFailedException : ApplicationException
{
	public VerificationFailedException(string message)
		: base("Amazon Receipt Verification Failed: " + message)
	{
	}
}
