using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class LeftLeg : Asset, ILeftLeg, IAsset, IAssetIdentifier
{
	internal LeftLeg(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.LeftLegID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType LeftLeg.");
		}
	}
}
