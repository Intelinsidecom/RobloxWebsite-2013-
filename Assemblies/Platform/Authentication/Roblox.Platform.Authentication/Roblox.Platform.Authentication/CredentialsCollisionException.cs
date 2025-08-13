using System;

namespace Roblox.Platform.Authentication;

/// <summary>
/// Credentials collision exception.
/// </summary>
public class CredentialsCollisionException : ArgumentException
{
	public CredentialsCollisionException(CredentialsType credentialsType, string credentialValue, CredentialsType collisionCredentialsType)
		: base($"Provided credentials with type: {credentialsType} and value: {credentialValue} collided with credentials with type: {collisionCredentialsType}.")
	{
	}
}
