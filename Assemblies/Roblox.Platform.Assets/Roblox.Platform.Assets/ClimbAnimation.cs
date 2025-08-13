using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class ClimbAnimation : Asset, IClimbAnimation, IAsset, IAssetIdentifier
{
	internal ClimbAnimation(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.ClimbAnimationID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType ClimbAnimation.");
		}
	}
}
