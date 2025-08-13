using Roblox.Platform.AccountPins;
using Roblox.Platform.Membership;

namespace Roblox.Web.Authentication;

/// <summary>
/// A central location for accessing information about the Account pins.
/// </summary>
public interface IAccountPinAuthenticator
{
	/// <summary>
	/// Determines whether the specified account pin is locked for a passed in <paramref name="user" />.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <returns>
	/// True if the account pin is locked, false otherwise.
	/// </returns>
	bool IsLocked(IUser user);

	/// <summary>
	/// Gets the pin entry for the passed in user.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <returns>
	/// The <see cref="T:Roblox.Platform.AccountPins.IPinEntry" /> which contains information reagrding the unlock until for the account pin.
	/// </returns>
	IPinEntry GetPinEntry(IUser user);

	/// <summary>
	/// Unlocks the pin and returns a new <see cref="T:Roblox.Platform.AccountPins.IPinEntry" /> if the validation is successful. If the validation fails, this returns a null entry.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <param name="pin">The pin.</param>
	/// <returns>
	/// An <see cref="T:Roblox.Platform.AccountPins.IPinEntry" /> is the entered pin is valid, null otherwise
	/// </returns>
	IPinEntry Unlock(IUser user, string pin);
}
