namespace Roblox.Platform.EventStream.WebEvents;

public class GameSearchEventArgs : WebEventArgs
{
	/// <summary>
	/// The keyword for the search.
	/// </summary>
	public string Keyword { get; set; }

	/// <summary>The assets returned in CSV format</summary>
	public string AssetsReturned { get; set; }

	/// <summary>Page of results determined by StartRow / MaxRows</summary>
	public int Page { get; set; }

	/// <summary>
	/// Algorithm used in searching games. 
	/// </summary>
	public string AlgorithmName { get; set; }

	/// <summary>
	/// Get or set suggestion correction.
	/// </summary>
	public string SuggestionCorrection { get; set; }

	/// <summary>
	/// Get or set suggestion shown.
	/// </summary>
	public string SuggestionKeyword { get; set; }

	/// <summary>
	/// Get or set suggestion algorithm.
	/// </summary>
	public string SuggestionAlgorithm { get; set; }

	/// <summary>
	/// Get or set suggestion replaced keyword.
	/// </summary>
	public string SuggestionReplacedKwd { get; set; }

	/// <summary>
	/// Get or set illegal keyword.
	/// </summary>
	public string IllegalKeyword { get; set; }

	/// <summary>
	/// Get or set AlgorithmQueryType
	/// </summary>
	public string AlgorithmQueryType { get; set; }

	/// <summary>
	/// Get or set FeaturedPlaceId
	/// </summary>
	public long? FeaturedPlaceId { get; set; }
}
