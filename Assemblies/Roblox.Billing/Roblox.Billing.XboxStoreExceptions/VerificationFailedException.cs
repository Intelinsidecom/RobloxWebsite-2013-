using System;

namespace Roblox.Billing.XboxStoreExceptions;

public class VerificationFailedException : ApplicationException
{
	public VerificationFailedException(string message)
		: base("Xbox Receipt Verification Failed: " + message)
	{
	}
}
