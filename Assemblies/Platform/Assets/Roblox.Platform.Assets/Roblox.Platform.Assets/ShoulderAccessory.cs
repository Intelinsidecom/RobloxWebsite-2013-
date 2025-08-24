using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class ShoulderAccessory : Asset, IShoulderAccessory, IAsset, IAssetIdentifier
{
	internal ShoulderAccessory(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.ShoulderAccessoryID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType ShoulderAccessory.");
		}
	}
}
