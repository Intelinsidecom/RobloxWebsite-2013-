using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Model : Asset, IModel, IAsset, IAssetIdentifier
{
	internal Model(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.ModelID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Model.");
		}
	}
}
