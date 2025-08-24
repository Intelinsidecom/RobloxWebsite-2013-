using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class FrontAccessory : Asset, IFrontAccessory, IAsset, IAssetIdentifier
{
	internal FrontAccessory(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.FrontAccessoryID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType FrontAccessory.");
		}
	}
}
