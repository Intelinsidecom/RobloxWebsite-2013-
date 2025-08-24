using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Badges;

/// <inheritdoc cref="T:Roblox.Platform.Badges.IBadgeAwarderProvider" />
public class BadgeAwarderProvider : IBadgeAwarderProvider
{
	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgeAwarderProvider.GetBadgeAwarderFromPlace(Roblox.Platform.AssetsCore.IAssetIdentifier)" />
	public IBadgeAwarder GetBadgeAwarderFromPlace(IAssetIdentifier place)
	{
		if (place == null)
		{
			throw new ArgumentNullException("place");
		}
		return new BadgeAwarder
		{
			Id = place.Id,
			Type = BadgeAwarderType.Place
		};
	}
}
