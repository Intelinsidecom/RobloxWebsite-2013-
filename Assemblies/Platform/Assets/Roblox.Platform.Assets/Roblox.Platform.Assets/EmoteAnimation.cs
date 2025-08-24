using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

public class EmoteAnimation : Asset, IEmoteAnimation, IAsset, IAssetIdentifier
{
	internal EmoteAnimation(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.EmoteAnimationID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType EmoteAnimation.");
		}
	}
}
