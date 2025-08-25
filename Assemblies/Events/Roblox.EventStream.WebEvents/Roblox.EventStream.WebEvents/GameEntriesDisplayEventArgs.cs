using System.Collections.Generic;

namespace Roblox.Platform.EventStream.WebEvents;

public class GameEntriesDisplayEventArgs : WebEventArgs
{
	public byte? SortFilter { get; set; }

	public int? StartRows { get; set; }

	public int? MaxRows { get; set; }

	public int? VersionId { get; set; }

	public int? VariationValue { get; set; }

	public IReadOnlyCollection<long> PlaceIds { get; set; }
}
