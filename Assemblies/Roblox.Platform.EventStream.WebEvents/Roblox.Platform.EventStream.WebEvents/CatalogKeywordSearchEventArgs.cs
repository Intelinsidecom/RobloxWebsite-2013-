namespace Roblox.Platform.EventStream.WebEvents;

public class CatalogKeywordSearchEventArgs : CatalogSearchEventArgs
{
	/// <summary>
	/// The keyword for the search.
	/// </summary>
	public string Keyword { get; set; }
}
