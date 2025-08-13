using System;

namespace Roblox.Billing.GooglePlayStoreExceptions;

public class VerificationFailedException : ApplicationException
{
	public VerificationFailedException(string message, string packageName, string playstoreProductId, string token)
		: base($"Unable to verify with message: {message}. PackageName: {packageName} PlayStoreProductId: {playstoreProductId} Token: {token} ")
	{
	}
}
