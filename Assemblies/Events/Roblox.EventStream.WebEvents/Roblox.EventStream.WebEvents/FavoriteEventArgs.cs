namespace Roblox.Platform.EventStream.WebEvents;

public class FavoriteEventArgs : WebEventArgs
{
	/// <summary>
	/// The id of the asset being favorited
	/// </summary>
	public long AssetId { get; set; }

	/// <summary>
	/// Type of the asset being favorited
	/// </summary>
	public string AssetType { get; set; }

	/// <summary>
	/// True if a user is adding a favorite, false if a user is removing the favorite
	/// Not supplied if the attempt failed
	/// </summary>
	public bool? Favorite { get; set; }

	/// <summary>
	/// True if the favorite event is recorded
	/// </summary>
	public bool Success { get; set; }

	/// <summary>
	/// Why the attempt to favorite the asset was unsuccessful
	/// </summary>
	public string FailureReason { get; set; }

	/// <summary>
	/// The favorites count for the asset reported to the page PRIOR to this action
	/// </summary>
	public long FavoriteCount { get; set; }
}
