using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Badges;

/// <inheritdoc cref="T:Roblox.Platform.Badges.IRecipientFactory" />
internal class RecipientFactory : IRecipientFactory
{
	/// <inheritdoc cref="M:Roblox.Platform.Badges.IRecipientFactory.Get(Roblox.Platform.MembershipCore.IUserIdentifier)" />
	public IRecipient Get(IUserIdentifier userIdentifier)
	{
		if (userIdentifier == null)
		{
			throw new PlatformArgumentNullException("userIdentifier");
		}
		if (userIdentifier.Id == 0L)
		{
			throw new PlatformArgumentException(string.Format("{0}.{1} can't be equal to zero.", "userIdentifier", "Id"));
		}
		return new Recipient
		{
			TargetId = userIdentifier.Id,
			TargetType = "User"
		};
	}
}
