using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class RightLeg : Asset, IRightLeg, IAsset, IAssetIdentifier
{
	internal RightLeg(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.RightLegID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType RightLeg.");
		}
	}
}
