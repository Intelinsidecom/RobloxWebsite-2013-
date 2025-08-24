using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class WalkAnimation : Asset, IWalkAnimation, IAsset, IAssetIdentifier
{
	internal WalkAnimation(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.WalkAnimationID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType WalkAnimation.");
		}
	}
}
