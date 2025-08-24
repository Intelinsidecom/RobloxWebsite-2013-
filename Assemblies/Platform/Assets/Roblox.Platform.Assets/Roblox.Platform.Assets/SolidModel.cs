using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class SolidModel : Asset, ISolidModel, IAsset, IAssetIdentifier
{
	internal SolidModel(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.SolidModelID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType SolidModel.");
		}
	}
}
