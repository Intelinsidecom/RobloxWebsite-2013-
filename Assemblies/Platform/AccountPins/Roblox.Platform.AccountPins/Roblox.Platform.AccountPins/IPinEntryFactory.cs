using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// Factory for loading <see cref="T:Roblox.Platform.AccountPins.IPinEntry" /> for Users and Sessions
/// </summary>
public interface IPinEntryFactory
{
	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.AccountPins.IPinEntry" /> if it exists else null.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <param name="sessionString">The session string.</param>
	/// <returns>
	/// Gets the <see cref="T:Roblox.Platform.AccountPins.IPinEntry" /> if it exists else null
	/// </returns>
	IPinEntry Get(IUser user, string sessionString);
}
