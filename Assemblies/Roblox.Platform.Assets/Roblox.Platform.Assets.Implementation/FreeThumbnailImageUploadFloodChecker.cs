using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Properties;

namespace Roblox.Platform.Assets.Implementation;

internal class FreeThumbnailImageUploadFloodChecker : FloodChecker
{
	public FreeThumbnailImageUploadFloodChecker(long userId)
		: base($"FreeThumbnailImageUploadFloodChecker_UserId:{userId}", Settings.Default.FreeThumbnailImageUploadFloodCheckLimit, Settings.Default.FreeThumbnailImageUploadFloodCheckExpiry)
	{
	}
}
