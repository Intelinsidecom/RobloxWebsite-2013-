using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public interface IBadgeFactory : IAssetFactoryBase<IBadgeAsset>
{
	/// <summary>
	/// Awards a platform badge for user
	/// </summary>
	/// <param name="iUser">User identifier</param>
	/// <param name="assetBadgeType">platform badge type</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">if iUser is null</exception>
	void CreateBadge(IUserIdentifier iUser, BadgeType assetBadgeType);
}
