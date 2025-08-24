using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Legs : Asset, ILegs, IAsset, IAssetIdentifier
{
	internal Legs(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.LegsID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Legs.");
		}
	}
}
