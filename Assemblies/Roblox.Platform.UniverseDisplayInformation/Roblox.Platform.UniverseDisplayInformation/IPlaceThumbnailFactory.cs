using System.Collections.Generic;
using Roblox.Platform.AssetMedia;

namespace Roblox.Platform.UniverseDisplayInformation;

internal interface IPlaceThumbnailFactory
{
	/// <summary>
	/// Gets the place media items by place id.
	/// </summary>
	/// <param name="placeId">The place identifier.</param>
	/// <returns>A <see cref="T:System.Collections.Generic.IReadOnlyList`1" /> of <see cref="T:Roblox.Platform.AssetMedia.IPlaceThumbnail" />.</returns>
	IReadOnlyList<IPlaceThumbnail> GetPlaceThumbnailsByPlaceId(long placeId);
}
