using Roblox.Platform.Core;

namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// Exception thrown for an invalid birthdate change that requires disconnecting Social Sign On (Facebook),
/// but is unable to because it is the user's only means of authentication.
/// </summary>
public class InsufficientAuthenticationMethodsException : PlatformException
{
	public InsufficientAuthenticationMethodsException()
		: base("Unable to change birthdate because social sign on cannot be disconnected.")
	{
	}

	public InsufficientAuthenticationMethodsException(long userId)
		: base($"Unable to change birthdate for user id {userId} because social sign on cannot be disconnected.")
	{
	}
}
