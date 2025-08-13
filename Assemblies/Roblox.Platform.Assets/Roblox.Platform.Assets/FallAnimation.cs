using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class FallAnimation : Asset, IFallAnimation, IAsset, IAssetIdentifier
{
	internal FallAnimation(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.FallAnimationID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType FallAnimation.");
		}
	}
}
