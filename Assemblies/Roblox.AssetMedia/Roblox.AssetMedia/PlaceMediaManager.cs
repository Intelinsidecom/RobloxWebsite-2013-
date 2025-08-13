using System.Collections.Generic;
using System.Linq;
using Roblox.AssetMedia.Properties;
using Roblox.Platform.Assets.Places;

namespace Roblox.AssetMedia;

public static class PlaceMediaManager
{
	private static IPlaceAttributeFactory _placeAttributeFactory;

	public static IPlaceAttributeFactory PlaceAttributeFactory
	{
		get
		{
			if (_placeAttributeFactory == null)
			{
				_placeAttributeFactory = new PlaceAttributesDomainFactories().PlaceAttributeFactory;
			}
			return _placeAttributeFactory;
		}
		set
		{
			_placeAttributeFactory = value;
		}
	}

	public static int MaximumPlaceMediaItems => Settings.Default.MaximumPlaceMediaItemsPerPlace;

	/// <summary>
	/// Update PlaceAttributes to UsePlaceMediaForThumb.  This is an optimization for lookups -- most places wont have placemediaitems (or so we suspect), so let's look to something
	/// that's already likely in cache (PlaceAttributes) to see if we should use them or not.
	/// </summary>
	/// <param name="placeId"></param>
	/// <param name="usePlaceMedia"></param>
	private static void _SetUsePlaceMediaForThumbs(long placeId, bool usePlaceMedia)
	{
		PlaceAttributeFactory.GetOrCreate(placeId).SetUsePlaceMediaForThumb(usePlaceMedia);
	}

	private static bool _UsesPlaceMediaForThumbs(long placeId)
	{
		return PlaceAttributeFactory.GetByPlaceId(placeId)?.UsePlaceMediaForThumb ?? false;
	}

	public static PlaceMediaItem GetCurrent(long placeId)
	{
		if (_UsesPlaceMediaForThumbs(placeId))
		{
			return GetPlaceMediaItemsByPlaceID(placeId).FirstOrDefault();
		}
		return null;
	}

	public static PlaceMediaItem AddPlaceMedia(long placeId, long uploadedMediaAssetId, long uploaderUserId)
	{
		List<PlaceMediaItem> mediaItems = (List<PlaceMediaItem>)GetPlaceMediaItemsByPlaceID(placeId);
		PlaceMediaItem newPrimary = PlaceMediaItem.CreateNew(placeId, uploadedMediaAssetId, uploaderUserId);
		for (int i = MaximumPlaceMediaItems - 1; i < mediaItems.Count; i++)
		{
			mediaItems[i].Delete();
		}
		foreach (PlaceMediaItem item in mediaItems)
		{
			item.SortOrder++;
			item.Save();
		}
		_SetUsePlaceMediaForThumbs(placeId, usePlaceMedia: true);
		return newPrimary;
	}

	public static ICollection<PlaceMediaItem> GetPlaceMediaItemsByPlaceID(long placeId)
	{
		if (_UsesPlaceMediaForThumbs(placeId))
		{
			return PlaceMediaItem.GetPlaceMediaItemsByPlaceID_Paged(placeId, 0, MaximumPlaceMediaItems);
		}
		return new List<PlaceMediaItem>();
	}

	public static int GetTotalNumberOfPlaceMediaItemsByPlaceID(long placeId)
	{
		if (_UsesPlaceMediaForThumbs(placeId))
		{
			return PlaceMediaItem.GetTotalNumberOfPlaceMediaItemsByPlaceID(placeId);
		}
		return 0;
	}

	public static void DeletePlaceMediaItem(int placeMediaItemId)
	{
		PlaceMediaItem mediaItem = PlaceMediaItem.Get(placeMediaItemId);
		mediaItem.Delete();
		if (PlaceMediaItem.GetTotalNumberOfPlaceMediaItemsByPlaceID(mediaItem.PlaceID) == 0)
		{
			_SetUsePlaceMediaForThumbs(mediaItem.PlaceID, usePlaceMedia: false);
		}
	}

	public static void SetSortOrder(int placeMediaItemId, int sortOrder)
	{
		PlaceMediaItem mediaItem = PlaceMediaItem.Get(placeMediaItemId);
		if (mediaItem.SortOrder != sortOrder)
		{
			mediaItem.SortOrder = sortOrder;
			mediaItem.Save();
		}
	}
}
