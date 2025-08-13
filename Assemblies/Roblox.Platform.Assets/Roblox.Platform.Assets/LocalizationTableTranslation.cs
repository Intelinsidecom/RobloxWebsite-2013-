using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class LocalizationTableTranslation : Asset, ILocalizationTableTranslation, IAsset, IAssetIdentifier
{
	internal LocalizationTableTranslation(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.LocalizationTableTranslationID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType LocalizationTableTranslation.");
		}
	}
}
