using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Plugin : Asset, IPlugin, IAsset, IAssetIdentifier
{
	internal Plugin(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.PluginID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Plugin.");
		}
	}
}
