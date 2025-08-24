using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Place : Asset, IPlace, IAsset, IAssetIdentifier
{
	internal Place(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.PlaceID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Place.");
		}
	}
}
