using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Image : Asset, IImage, IAsset, IAssetIdentifier
{
	internal Image(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.ImageID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Image.");
		}
	}
}
