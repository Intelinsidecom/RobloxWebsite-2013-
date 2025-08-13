using System;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Authentication;

/// <summary>
/// Unverified credentials exception with credentials linked to single user.
/// </summary>
public class UnverifiedCredentialsException : ArgumentException
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> if one user is linked to the credentials.
	/// </summary>
	/// <remarks>The user id may be null in the case of multiple users linked to the unverified credentials.</remarks>
	public IUserIdentifier UserId;

	public UnverifiedCredentialsException(CredentialsType credentialsType, string credentialValue, IUserIdentifier userId = null)
		: base($"Unverified credentials with type: {credentialsType} and value: {credentialValue}.")
	{
		UserId = userId;
	}
}
