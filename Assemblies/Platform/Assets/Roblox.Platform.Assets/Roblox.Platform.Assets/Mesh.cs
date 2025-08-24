using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Mesh : Asset, IMesh, IAsset, IAssetIdentifier
{
	internal Mesh(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.MeshID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Mesh.");
		}
	}
}
