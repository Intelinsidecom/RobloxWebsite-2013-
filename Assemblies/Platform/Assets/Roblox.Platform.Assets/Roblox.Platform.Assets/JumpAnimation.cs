using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class JumpAnimation : Asset, IJumpAnimation, IAsset, IAssetIdentifier
{
	internal JumpAnimation(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.JumpAnimationID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType JumpAnimation.");
		}
	}
}
