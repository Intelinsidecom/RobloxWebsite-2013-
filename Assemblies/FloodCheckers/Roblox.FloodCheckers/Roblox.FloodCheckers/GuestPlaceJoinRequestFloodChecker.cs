using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class GuestPlaceJoinRequestFloodChecker : FloodChecker
{
	public GuestPlaceJoinRequestFloodChecker(string ipAddress, long placeId)
		: base($"GuestPlaceJoinRequestFloodChecker_IPAddress:{ipAddress}_PlaceID:{placeId}", Settings.Default.GuestPlaceJoinRequestFloodCheckLimit, Settings.Default.GuestPlaceJoinRequestFloodCheckExpiry)
	{
	}
}
