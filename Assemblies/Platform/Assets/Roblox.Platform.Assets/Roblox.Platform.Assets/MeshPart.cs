using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class MeshPart : Asset, IMeshPart, IAsset, IAssetIdentifier
{
	internal MeshPart(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.MeshPartID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType MeshPart.");
		}
	}
}
