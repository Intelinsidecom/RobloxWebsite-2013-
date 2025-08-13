namespace Roblox.Platform.Studio;

/// <summary>
/// This interface provides all the statistics associated with a keyword.
/// </summary>
public interface IKeywordStatistic
{
	/// <summary>
	/// Get or set the asset id.
	/// </summary>
	long AssetId { get; }

	/// <summary>
	/// Get or set the search keyword.
	/// </summary>
	string Keyword { get; }

	/// <summary>
	/// Get or set the wilson score
	/// </summary>
	double WilsonScore { get; }

	/// <summary>
	/// Get or set the total search.
	/// </summary>
	int TotalSearch { get; }

	/// <summary>
	/// Get or set the total insert.
	/// </summary>
	int TotalInsert { get; }
}
