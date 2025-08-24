using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Head : Asset, IHead, IAsset, IAssetIdentifier
{
	internal Head(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.HeadID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Head.");
		}
	}
}
