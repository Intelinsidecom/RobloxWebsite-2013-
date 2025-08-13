using System;

namespace Roblox.Billing.AppleAppStoreExceptions;

public class VerificationFailedException : ApplicationException
{
	public VerificationFailedException(string message)
		: base("Apple Receipt Verification Failed: " + message)
	{
	}
}
