using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.AssetsCore;
using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

internal class GamePass : Asset, IGamePass, IAsset, IAssetIdentifier
{
	internal GamePass(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.GamePassID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType GamePass.");
		}
	}

	public long GetPlaceId()
	{
		ICollection<PlaceGamePass> placeGamePassEntities = PlaceGamePass.GetPlaceGamePassesByPassID(base.Id, 1, 1);
		if (placeGamePassEntities != null && placeGamePassEntities.Count > 0)
		{
			return placeGamePassEntities.First().PlaceID;
		}
		throw new PlatformDataIntegrityException($"Game Pass with ID:{base.Id} has no associated place.");
	}

	public IImage GetImage()
	{
		ICollection<PlaceGamePass> placeGamePassEntities = PlaceGamePass.GetPlaceGamePassesByPassID(base.Id, 1, 1);
		if (placeGamePassEntities != null && placeGamePassEntities.Count > 0)
		{
			return base.DomainFactories.ImageFactory.Get(placeGamePassEntities.First().ImageID);
		}
		throw new PlatformDataIntegrityException($"Game Pass with ID:{base.Id} has no associated image.");
	}
}
