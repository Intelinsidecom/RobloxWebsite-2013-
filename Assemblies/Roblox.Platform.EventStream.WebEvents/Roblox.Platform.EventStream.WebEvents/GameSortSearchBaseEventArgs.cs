namespace Roblox.Platform.EventStream.WebEvents;

public abstract class GameSortSearchBaseEventArgs : WebEventArgs
{
	/// <summary>
	/// Start index of games to search.
	/// </summary>
	public int GamesStartIndex { get; set; }

	/// <summary>
	/// Max number of games to return.
	/// </summary>
	public int MaxGames { get; set; }

	/// <summary>Page of results determined by StartRow / MaxRows</summary>
	public int Page { get; set; }

	/// <summary>
	/// Get or set FeaturedPlaceId
	/// </summary>
	public long? FeaturedPlaceId { get; set; }

	/// <summary>The assets returned. It will be Ids for the GameSortEvent and Id and name for GameSearchEvent.</summary>
	public string AssetsReturned { get; set; }
}
