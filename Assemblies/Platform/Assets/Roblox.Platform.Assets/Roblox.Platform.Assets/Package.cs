using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Package : Asset, IPackage, IAsset, IAssetIdentifier
{
	internal Package(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.PackageID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Package.");
		}
	}
}
