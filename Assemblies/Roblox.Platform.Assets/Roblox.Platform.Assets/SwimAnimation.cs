using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class SwimAnimation : Asset, ISwimAnimation, IAsset, IAssetIdentifier
{
	internal SwimAnimation(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.SwimAnimationID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType SwimAnimation.");
		}
	}
}
