using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class FaceAccessory : Asset, IFaceAccessory, IAsset, IAssetIdentifier
{
	internal FaceAccessory(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.FaceAccessoryID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType FaceAccessory.");
		}
	}
}
