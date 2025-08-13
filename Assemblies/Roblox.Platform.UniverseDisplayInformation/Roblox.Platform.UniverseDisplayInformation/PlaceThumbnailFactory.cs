using System.Collections.Generic;
using System.Linq;
using Roblox.AssetMedia;
using Roblox.Platform.AssetMedia;

namespace Roblox.Platform.UniverseDisplayInformation;

internal class PlaceThumbnailFactory : IPlaceThumbnailFactory
{
	public IReadOnlyList<IPlaceThumbnail> GetPlaceThumbnailsByPlaceId(long placeId)
	{
		return (from x in PlaceMediaManager.GetPlaceMediaItemsByPlaceID(placeId)
			select new PlaceThumbnail
			{
				Id = x.ID,
				PlaceId = x.PlaceID,
				ImageId = x.MediaAssetID
			}).ToList();
	}
}
