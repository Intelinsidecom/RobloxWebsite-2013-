using System;

namespace Roblox.Platform.Authentication;

/// <summary>
/// Unverified credentials exception with credentials linked to multiple users.
/// </summary>
public class UnverifiedCredentialsMultipleUsersException : ArgumentException
{
	public UnverifiedCredentialsMultipleUsersException(CredentialsType credentialsType, string credentialValue)
		: base($"Unverified credentials with type: {credentialsType} and value: {credentialValue}.")
	{
	}
}
