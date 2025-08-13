using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Hat : Asset, IHat, IAsset, IAssetIdentifier
{
	internal Hat(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.HatID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Hat.");
		}
	}
}
