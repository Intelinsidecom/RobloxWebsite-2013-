using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class LeftArm : Asset, ILeftArm, IAsset, IAssetIdentifier
{
	internal LeftArm(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.LeftArmID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType LeftArm.");
		}
	}
}
