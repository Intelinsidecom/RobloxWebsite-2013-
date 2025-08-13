using System.Collections.Generic;

namespace Roblox.GameInstances.Client;

public class CreateOrUpdatePostDataModel
{
	public IEnumerable<RawGameSessionModel> GameSessions { get; set; }
}
