using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class YouTubeVideo : Asset, IYouTubeVideo, IAsset, IAssetIdentifier
{
	internal YouTubeVideo(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.YouTubeVideoID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType YouTubeVideo.");
		}
	}
}
