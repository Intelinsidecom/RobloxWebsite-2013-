using Roblox.Platform.AccountPins.Entities;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// An interface declaring functions available internally from the <see cref="T:Roblox.Platform.AccountPins.PinEntryFactory" />.
/// </summary>
internal interface IPinEntryFactory_Internal : IPinEntryFactory
{
	/// <summary>
	/// Creates the <see cref="T:Roblox.Platform.AccountPins.IPinEntry" />.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <param name="sessionString">The session string.</param>
	/// <param name="pinHashEntity">The pin hash entity.</param>
	/// <returns>A new created <see cref="T:Roblox.Platform.AccountPins.IPinEntry" /></returns>
	IPinEntry Create(IUser user, string sessionString, IAccountPinHashEntity pinHashEntity);
}
