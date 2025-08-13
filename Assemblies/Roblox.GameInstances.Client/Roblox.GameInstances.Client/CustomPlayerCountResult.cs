using System.Collections.Generic;

namespace Roblox.GameInstances.Client;

public class CustomPlayerCountResult
{
	public IReadOnlyCollection<string> DimensionValues { get; set; }

	public IReadOnlyCollection<int> Counts { get; set; }
}
