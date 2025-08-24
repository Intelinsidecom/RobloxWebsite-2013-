using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class HairAccessory : Asset, IHairAccessory, IAsset, IAssetIdentifier
{
	internal HairAccessory(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.HairAccessoryID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType HairAccessory.");
		}
	}
}
