using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Decal : Asset, IDecal, IAsset, IAssetIdentifier
{
	internal Decal(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.DecalID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Decal.");
		}
	}

	public IImage GetImage()
	{
		IAssetVersion currentVersion = this.GetCurrentVersion();
		if (currentVersion == null)
		{
			return null;
		}
		Roblox.IAsset imageAssetEntity = Roblox.Decal.GetImageAsset(Roblox.AssetVersion.MustGet(currentVersion.Id));
		return base.DomainFactories.ImageFactory.Get(imageAssetEntity.CurrentVersion.AssetID);
	}
}
