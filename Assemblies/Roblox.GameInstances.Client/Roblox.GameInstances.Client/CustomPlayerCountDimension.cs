using System.Collections.Generic;

namespace Roblox.GameInstances.Client;

public class CustomPlayerCountDimension
{
	public CustomPlayerDimension Dimension { get; set; }

	public ISet<string> Filter { get; set; }
}
