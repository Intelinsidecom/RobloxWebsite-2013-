using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class RightArm : Asset, IRightArm, IAsset, IAssetIdentifier
{
	internal RightArm(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.RightArmID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType RightArm.");
		}
	}
}
