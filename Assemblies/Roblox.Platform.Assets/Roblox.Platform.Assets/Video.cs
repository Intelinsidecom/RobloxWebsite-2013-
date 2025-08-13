using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Video : Asset, IVideo, IAsset, IAssetIdentifier
{
	internal Video(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.VideoID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Video.");
		}
	}
}
