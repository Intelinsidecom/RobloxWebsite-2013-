using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

/// <inheritdoc cref="T:Roblox.Platform.Assets.IBadgeFactory" />
public class BadgeFactory : AssetFactoryBase<IBadgeAsset>, IBadgeFactory, IAssetFactoryBase<IBadgeAsset>
{
	private readonly IBadgeTypeFactory _IBadgeTypeFactory;

	protected override int AssetTypeId => Roblox.AssetType.BadgeID;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Assets.BadgeFactory" />
	/// </summary>
	/// <param name="domainFactories">The <see cref="T:Roblox.Platform.Assets.AssetDomainFactories" />.</param>
	/// <param name="badgeTypeFactory">An <see cref="T:Roblox.Platform.Assets.IBadgeTypeFactory" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null.</exception>
	public BadgeFactory(AssetDomainFactories domainFactories, IBadgeTypeFactory badgeTypeFactory)
		: base(domainFactories)
	{
		_IBadgeTypeFactory = badgeTypeFactory ?? throw new PlatformArgumentNullException("BadgeTypeFactory is null");
	}

	protected override IBadgeAsset BuildChildAsset(IAsset genericAsset)
	{
		return new Badge(base.DomainFactories, genericAsset);
	}

	internal IBadgeAsset GetBadge(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Assets.IBadgeFactory.CreateBadge(Roblox.Platform.MembershipCore.IUserIdentifier,Roblox.Platform.Assets.BadgeType)" />
	public void CreateBadge(IUserIdentifier iUser, BadgeType assetBadgeType)
	{
		if (iUser == null)
		{
			throw new PlatformArgumentNullException("iUser is null");
		}
		Roblox.Badge.CreateNew(_IBadgeTypeFactory.GetBadgeTypeIdByBadgeType(assetBadgeType), iUser.Id);
	}
}
