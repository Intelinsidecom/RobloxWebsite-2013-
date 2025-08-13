using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class IdleAnimation : Asset, IIdleAnimation, IAsset, IAssetIdentifier
{
	internal IdleAnimation(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.IdleAnimationID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType IdleAnimation.");
		}
	}
}
