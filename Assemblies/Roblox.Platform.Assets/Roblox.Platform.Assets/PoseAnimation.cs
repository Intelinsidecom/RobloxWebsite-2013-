using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class PoseAnimation : Asset, IPoseAnimation, IAsset, IAssetIdentifier
{
	internal PoseAnimation(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.PoseAnimationID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType PoseAnimation.");
		}
	}
}
