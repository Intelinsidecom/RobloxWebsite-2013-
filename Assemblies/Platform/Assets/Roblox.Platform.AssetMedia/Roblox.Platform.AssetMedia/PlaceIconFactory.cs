using Roblox.Platform.AssetMedia.Entities;
using Roblox.Platform.Core;
using Roblox.Platform.Thumbs;

namespace Roblox.Platform.AssetMedia;

public class PlaceIconFactory : IPlaceIconFactory
{
	private readonly IPlaceIconThumbnailGetter _PlaceIconThumbnailGetter;

	public PlaceIconFactory(ThumbnailDomainFactories thumbnailDomainFactories)
	{
		if (thumbnailDomainFactories == null)
		{
			throw new PlatformArgumentNullException("thumbnailDomainFactories");
		}
		_PlaceIconThumbnailGetter = new PlaceIconThumbnailGetter(thumbnailDomainFactories.Asset);
	}

	public bool ContainsPlaceIcon(long placeId)
	{
		if (Roblox.Platform.AssetMedia.Entities.PlaceIcon.GetByPlaceID(placeId) == null)
		{
			return false;
		}
		return true;
	}

	public IPlaceIcon GetPlaceIconByPlaceId(long placeId)
	{
		Roblox.Platform.AssetMedia.Entities.PlaceIcon placeIconEntity = Roblox.Platform.AssetMedia.Entities.PlaceIcon.GetByPlaceID(placeId);
		if (placeIconEntity != null)
		{
			return new PlaceIcon(placeIconEntity, _PlaceIconThumbnailGetter);
		}
		return new PlaceIcon(placeId, _PlaceIconThumbnailGetter);
	}

	public void DeletePlaceIcon(ref IPlaceIcon placeIcon)
	{
		if (placeIcon == null)
		{
			throw new PlatformArgumentNullException();
		}
		Roblox.Platform.AssetMedia.Entities.PlaceIcon.Get(placeIcon.Id)?.Delete();
		placeIcon = new PlaceIcon(placeIcon.PlaceId, _PlaceIconThumbnailGetter);
	}

	public void SavePlaceIcon(ref IPlaceIcon placeIcon)
	{
		if (placeIcon == null)
		{
			throw new PlatformArgumentNullException();
		}
		if (!placeIcon.ImageId.HasValue)
		{
			throw new PlatformArgumentException("Attempted to save a PlaceIcon with a null ImageId.");
		}
		Roblox.Platform.AssetMedia.Entities.PlaceIcon placeIconEntity = Roblox.Platform.AssetMedia.Entities.PlaceIcon.Get(placeIcon.Id);
		if (placeIconEntity == null)
		{
			placeIconEntity = new Roblox.Platform.AssetMedia.Entities.PlaceIcon();
		}
		placeIconEntity.PlaceID = placeIcon.PlaceId;
		placeIconEntity.ImageID = placeIcon.ImageId.Value;
		placeIconEntity.Save();
		placeIcon = new PlaceIcon(placeIconEntity, _PlaceIconThumbnailGetter);
	}
}
