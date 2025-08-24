using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Torso : Asset, ITorso, IAsset, IAssetIdentifier
{
	internal Torso(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.TorsoID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Torso.");
		}
	}
}
