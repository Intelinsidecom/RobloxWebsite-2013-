namespace Roblox.Platform.EventStream.WebEvents;

public class GameSortEventArgs : GameSortSearchBaseEventArgs
{
	/// <summary>
	/// Position of sort on the page.
	/// </summary>
	public int? SortPosition { get; set; }

	/// <summary>
	/// Sort filter identifies the sort.
	/// </summary>
	public byte? SortFilter { get; set; }

	/// <summary>
	/// GameSetTargetId is applicable for curated sorts. It identifies the sort.
	/// </summary>
	public long? GameSetTargetId { get; set; }

	public bool? IsSeeAllPage { get; set; }
}
