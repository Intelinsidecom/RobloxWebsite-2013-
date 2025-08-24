using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Gear : Asset, IGear, IAsset, IAssetIdentifier
{
	internal Gear(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.GearID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Gear.");
		}
	}
}
