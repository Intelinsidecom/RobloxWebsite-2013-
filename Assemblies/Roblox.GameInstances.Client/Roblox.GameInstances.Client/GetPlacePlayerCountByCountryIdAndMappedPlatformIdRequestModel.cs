using System.Collections.Generic;

namespace Roblox.GameInstances.Client;

public class GetPlacePlayerCountByCountryIdAndMappedPlatformIdRequestModel
{
	public long PlaceId { get; set; }

	public Dictionary<int, int> PlatformMappings { get; set; }
}
