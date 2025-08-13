using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Face : Asset, IFace, IAsset, IAssetIdentifier
{
	internal Face(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.FaceID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Face.");
		}
	}
}
