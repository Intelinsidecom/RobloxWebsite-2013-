using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// A validator to validate the user pin.
/// </summary>
public interface IPinValidator
{
	/// <summary>
	/// Validates a pin entry for the specified user without unlocking the account.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <param name="pin">The pin.</param>
	/// <param name="sessionStringHash">The session string.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if user is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the pin or sessionString Hash is null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFloodedException">Thrown if the platform is flooded with pin inputs.</exception>
	/// <returns></returns>
	bool Validate(IUser user, string pin, string sessionStringHash);

	/// <summary>
	/// Unlocks the specified user account. If the validation fails, returns null else returns the newly created <see cref="T:Roblox.Platform.AccountPins.IPinEntry" />.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <param name="pin">The pin.</param>
	/// <param name="sessionStringHash">The session string.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if user is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the pin or sessionString Hash is null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFloodedException">Thrown if the platform is flooded with pin inputs.</exception>
	/// <returns></returns>
	IPinEntry Unlock(IUser user, string pin, string sessionStringHash);
}
