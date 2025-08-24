using System.Collections.Generic;

namespace Roblox.GameInstances.Client;

public class GetUniversePlayerCountByCountryIdAndMappedPlatformIdRequestModel
{
	public long UniverseId { get; set; }

	public Dictionary<int, int> PlatformMappings { get; set; }
}
