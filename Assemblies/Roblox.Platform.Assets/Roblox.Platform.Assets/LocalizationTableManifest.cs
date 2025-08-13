using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class LocalizationTableManifest : Asset, ILocalizationTableManifest, IAsset, IAssetIdentifier
{
	internal LocalizationTableManifest(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.LocalizationTableManifestID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType LocalizationTableManifest.");
		}
	}
}
