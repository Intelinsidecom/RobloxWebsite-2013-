using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class NeckAccessory : Asset, INeckAccessory, IAsset, IAssetIdentifier
{
	internal NeckAccessory(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.NeckAccessoryID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType NeckAccessory.");
		}
	}
}
