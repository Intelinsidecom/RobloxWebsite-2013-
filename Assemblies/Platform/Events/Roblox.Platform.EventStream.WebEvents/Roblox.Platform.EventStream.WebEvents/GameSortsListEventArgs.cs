namespace Roblox.Platform.EventStream.WebEvents;

public class GameSortsListEventArgs : WebEventArgs
{
	/// <summary>
	/// Version Id
	/// </summary>
	public int? VersionId { get; set; }

	/// <summary>
	/// Variation Value
	/// </summary>
	public int? VariationValue { get; set; }

	public string GameSortsContext { get; set; }

	/// <summary>
	/// Game sorts to be shown on the page.
	/// </summary>
	public string GameSorts { get; set; }
}
