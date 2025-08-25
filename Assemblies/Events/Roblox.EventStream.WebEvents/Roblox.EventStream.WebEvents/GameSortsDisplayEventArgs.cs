using System.Collections.Generic;

namespace Roblox.Platform.EventStream.WebEvents;

public class GameSortsDisplayEventArgs : WebEventArgs
{
	public int? VersionId { get; set; }

	public int? VariationValue { get; set; }

	public IReadOnlyCollection<int> GameSetIds { get; set; }
}
