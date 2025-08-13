using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Badge : Asset, IBadgeAsset, IAsset, IAssetIdentifier
{
	internal Badge(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.BadgeID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Badge.");
		}
	}
}
