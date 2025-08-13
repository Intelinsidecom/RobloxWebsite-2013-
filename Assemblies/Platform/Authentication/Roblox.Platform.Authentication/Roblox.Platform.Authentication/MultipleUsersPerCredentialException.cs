using System;

namespace Roblox.Platform.Authentication;

/// <summary>
/// Multiple users where found for provided credentials. 
/// </summary>
public class MultipleUsersPerCredentialException : ArgumentException
{
	public MultipleUsersPerCredentialException(CredentialsType credentialsType, string credentialValue)
		: base($"More than one user was found for credentials with type {credentialsType} and value {credentialValue}.")
	{
	}
}
