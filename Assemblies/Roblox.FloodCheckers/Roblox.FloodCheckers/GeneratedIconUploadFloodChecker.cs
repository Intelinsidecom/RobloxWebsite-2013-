using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class GeneratedIconUploadFloodChecker : FloodChecker
{
	public GeneratedIconUploadFloodChecker(long placeId)
		: base($"GeneratedIconUploadFloodChecker_PlaceId:{placeId}", Settings.Default.GeneratedIconUploadFloodCheckLimit, Settings.Default.GeneratedIconUploadFloodCheckExpiry)
	{
	}
}
