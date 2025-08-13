using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Text : Asset, IText, IAsset, IAssetIdentifier
{
	internal Text(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.TextID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Text.");
		}
	}
}
