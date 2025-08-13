using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class BackAccessory : Asset, IBackAccessory, IAsset, IAssetIdentifier
{
	internal BackAccessory(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.BackAccessoryID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType BackAccessory.");
		}
	}
}
