using System.Collections.Generic;
using System.Linq;
using Roblox.Assets;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public class PlaceFactory : AssetFactoryBase<IPlace>, IPlaceFactory, IAssetFactoryBase<IPlace>
{
	protected override int AssetTypeId => Roblox.AssetType.PlaceID;

	internal PlaceFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IPlace BuildChildAsset(IAsset genericAsset)
	{
		return new Place(base.DomainFactories, genericAsset);
	}

	internal IPlace GetPlace(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}

	public IPlace GetPlaceFromGamePassId(long gamePassId)
	{
		ICollection<PlaceGamePass> gamePassOptions = PlaceGamePass.GetPlaceGamePassesByPassID(gamePassId, 1, 1);
		if (gamePassOptions != null && gamePassOptions.Any())
		{
			PlaceGamePass gpOption = gamePassOptions.First();
			return Get(gpOption.PlaceID);
		}
		return null;
	}

	/// <inheritdoc />
	public void OverridePlaceWithBaseTemplate(IAsset place)
	{
		if (place != null)
		{
			IPlace defaultPlace = CheckedGet(Roblox.Assets.Asset.StartPlaceId);
			IRawContent defaultRawContent = base.DomainFactories.RawContentFactory.Get(defaultPlace.GetAssetHashId());
			IAssetVersion defaultPlaceCurrentVersion = base.DomainFactories.AssetVersionFactory.GetCurrentPlaceSavedVersion(defaultPlace);
			base.DomainFactories.AssetVersionFactory.Create(place, defaultPlace.CreatorType, defaultPlace.CreatorTargetId, defaultRawContent, defaultPlaceCurrentVersion, defaultPlaceCurrentVersion.CreatingUniverseId);
		}
	}

	/// <summary>
	/// Create an <see cref="T:Roblox.Platform.Assets.IPlace" /> asset while skipping the text filtering for the name and description.
	/// [Warning!] This text does not get filtered. Use with extreme care.
	/// [Warning!] This should only be used to generate assets with trusted/filtered name and description.
	/// </summary>
	public IPlace CreateWithTrustedAssetText(ITrustedAssetTextInfo trustedAssetTextInfo, AssetCreatorInfo assetCreatorInfo, IRawContent rawContent, IUserIdentifier actorUserIdentity)
	{
		return Create(trustedAssetTextInfo, assetCreatorInfo, rawContent, actorUserIdentity);
	}
}
