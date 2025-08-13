using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Arms : Asset, IArms, IAsset, IAssetIdentifier
{
	internal Arms(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.ArmsID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Arms.");
		}
	}
}
