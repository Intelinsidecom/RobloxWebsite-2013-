namespace Roblox.Platform.EventStream.WebEvents;

public class GameSearchV2EventArgs : GameSortSearchBaseEventArgs
{
	/// <summary>
	/// The keyword for the search.
	/// </summary>
	public string Keyword { get; set; }

	/// <summary>
	/// Algorithm used in searching games. 
	/// </summary>
	public string AlgorithmName { get; set; }

	/// <summary>
	/// Get or set AlgorithmQueryType
	/// </summary>
	public string AlgorithmQueryType { get; set; }

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
	/// Get or set filtered keyword.
	/// </summary>
	public string FilteredKeyword { get; set; }
}
