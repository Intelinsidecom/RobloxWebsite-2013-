using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public class BadgeAwarder : IBadgeAwarder
{
	private readonly IBadgeTypeFactory _IBadgeTypeFactory;

	private readonly IBadgeFactory _IBadgeFactory;

	public BadgeAwarder(IBadgeFactory badgeFactory, IBadgeTypeFactory badgeTypeFactory)
	{
		_IBadgeTypeFactory = badgeTypeFactory;
		_IBadgeFactory = badgeFactory;
	}

	public bool UserOwnsBadge(IUserIdentifier iUser, BadgeType assetBadgeType)
	{
		if (iUser == null)
		{
			throw new PlatformArgumentNullException("iUser is null");
		}
		User user = User.Get(iUser.Id);
		if (user == null)
		{
			return false;
		}
		int badgeTypeId = _IBadgeTypeFactory.GetBadgeTypeIdByBadgeType(assetBadgeType);
		return user.Badges.Exists((Roblox.Badge b) => b.BadgeTypeID == badgeTypeId);
	}

	public void AwardBadge(IUserIdentifier iUser, BadgeType assetBadgeType)
	{
		if (iUser == null)
		{
			throw new PlatformArgumentNullException("iUser is null");
		}
		_IBadgeFactory.CreateBadge(iUser, assetBadgeType);
	}
}
