using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class DeathAnimation : Asset, IDeathAnimation, IAsset, IAssetIdentifier
{
	internal DeathAnimation(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.DeathAnimationID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType DeathAnimation.");
		}
	}
}
