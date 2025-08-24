using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class GeneratedThumbnailUploadFloodChecker : FloodChecker
{
	public GeneratedThumbnailUploadFloodChecker(long placeId)
		: base($"GeneratedThumbnailUploadFloodChecker_PlaceId:{placeId}", Settings.Default.GeneratedThumbnailUploadFloodCheckLimit, Settings.Default.GeneratedThumbnailUploadFloodCheckExpiry)
	{
	}
}
