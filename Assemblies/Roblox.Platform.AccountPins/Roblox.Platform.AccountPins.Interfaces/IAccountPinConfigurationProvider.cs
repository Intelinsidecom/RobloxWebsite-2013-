using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins.Interfaces;

/// <summary>
/// An interface for telling if the feature is enabled for the user.
/// </summary>
public interface IAccountPinConfigurationProvider
{
	/// <summary>
	/// Determines whether [is user eligible for acccount pin] [the specified user].
	/// </summary>
	/// <param name="user">The user.</param>
	/// <returns>True if the user is eligible for turning on accountPin, false other wise</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if the <paramref name="user" /> is null.</exception>
	bool IsAccountPinFeatureEnabledForUser(IUser user);
}
