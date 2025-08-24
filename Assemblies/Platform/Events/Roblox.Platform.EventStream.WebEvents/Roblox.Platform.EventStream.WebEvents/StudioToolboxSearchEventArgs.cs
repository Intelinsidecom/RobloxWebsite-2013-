namespace Roblox.Platform.EventStream.WebEvents;

public class StudioToolboxSearchEventArgs : WebEventArgs
{
	/// <summary>
	/// The keyword for the search.
	/// </summary>
	public string Keyword { get; set; }

	/// <summary>
	/// The Category for the search. eg: "Models", "Decals" etc
	/// </summary>
	public string Category { get; set; }

	/// <summary>
	/// The sort used for the search. eg: "Relevance", "Favorites", "Updated" etc
	/// </summary>
	public string Sort { get; set; }

	/// <summary>
	/// The assets returned in CSV format
	/// </summary>
	public string AssetsReturned { get; set; }

	/// <summary>
	/// The name of algorithm used to sort the result.
	/// </summary>
	public string AlgorithmName { get; set; }

	/// <summary>
	/// The page number of the result.
	/// </summary>
	public string PageNumber { get; set; }
}
