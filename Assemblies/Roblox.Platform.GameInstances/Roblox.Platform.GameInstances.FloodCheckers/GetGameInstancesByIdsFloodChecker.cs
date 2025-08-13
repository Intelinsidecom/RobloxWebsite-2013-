using Roblox.FloodCheckers;
using Roblox.Platform.GameInstances.Properties;

namespace Roblox.Platform.GameInstances.FloodCheckers;

public class GetGameInstancesByIdsFloodChecker : FloodChecker
{
	public GetGameInstancesByIdsFloodChecker(long userId, long placeId)
		: base($"GetGameInstancesByIdsFloodChecker_UserID:{userId}", Settings.Default.GetGameInstancesByIdsFloodCheckLimit, Settings.Default.GetGameInstancesByIdsFloodCheckTimeSpan)
	{
	}
}
