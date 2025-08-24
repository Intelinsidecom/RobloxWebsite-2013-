using System.Collections.Generic;

namespace Roblox.Games.Client;

public class ReservePostDataModel
{
	public IEnumerable<long> PreferredPlayerIds { get; set; }

	public IEnumerable<Player> Players { get; set; }
}
