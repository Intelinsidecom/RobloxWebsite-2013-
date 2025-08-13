using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Badges;

/// <summary>
/// Recipient factory
/// </summary>
internal interface IRecipientFactory
{
	/// <summary>
	/// Gets the recipient of User type.
	/// </summary>
	/// <param name="userIdentifier">The user identifier.</param>
	///             <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// userIdentifier
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">
	/// userIdentifier.Id equals to zero
	/// </exception>
	/// <returns><see cref="T:Roblox.Platform.Badges.IRecipient" /></returns>
	IRecipient Get(IUserIdentifier userIdentifier);
}
