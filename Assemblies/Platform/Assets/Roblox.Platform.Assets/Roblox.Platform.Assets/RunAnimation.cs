using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class RunAnimation : Asset, IRunAnimation, IAsset, IAssetIdentifier
{
	internal RunAnimation(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.RunAnimationID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType RunAnimation.");
		}
	}
}
