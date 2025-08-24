using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Animation : Asset, IAnimation, IAsset, IAssetIdentifier
{
	internal Animation(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.AnimationID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Animation.");
		}
	}
}
