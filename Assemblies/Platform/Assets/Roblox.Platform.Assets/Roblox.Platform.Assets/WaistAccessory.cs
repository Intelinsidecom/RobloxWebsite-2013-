using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class WaistAccessory : Asset, IWaistAccessory, IAsset, IAssetIdentifier
{
	internal WaistAccessory(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.WaistAccessoryID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType WaistAccessory.");
		}
	}
}
