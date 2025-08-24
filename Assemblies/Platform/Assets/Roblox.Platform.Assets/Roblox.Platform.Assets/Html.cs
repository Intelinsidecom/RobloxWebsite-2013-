using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Html : Asset, IHtml, IAsset, IAssetIdentifier
{
	internal Html(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.HtmlID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Html.");
		}
	}
}
