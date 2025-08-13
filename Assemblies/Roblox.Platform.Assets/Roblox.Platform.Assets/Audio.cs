using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Audio : Asset, IAudio, IAsset, IAssetIdentifier
{
	internal Audio(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.AudioID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Audio.");
		}
	}
}
