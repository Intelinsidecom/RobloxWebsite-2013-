using System;

namespace Roblox.Platform.Authentication;

/// <summary>
/// An exception for when a user for the credential value exists, but the password is incorrect.
/// </summary>
/// <remarks>
/// For example, this will be thrown when a user exists with the email "test123@test.com" but the password is wrong.
/// </remarks>
public class InvalidCredentialsException : ArgumentException
{
	public InvalidCredentialsException(CredentialsType credentialsType, string credentialValue)
		: base($"Credentials were invalid for type: {credentialsType} and value: {credentialValue}.")
	{
	}
}
