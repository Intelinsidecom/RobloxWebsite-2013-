using System;

namespace Roblox.Platform.Authentication;

/// <summary>
/// An exception for when the number of users to analyze per credentials threshold is surpased.
/// </summary>
public class TooManyUsersLinkedToCredentialsException : ArgumentException
{
	public TooManyUsersLinkedToCredentialsException(CredentialsType credentialsType, string credentialValue)
		: base($"Too many users for provided credentials with type: {credentialsType} and value: {credentialValue} where found.")
	{
	}
}
