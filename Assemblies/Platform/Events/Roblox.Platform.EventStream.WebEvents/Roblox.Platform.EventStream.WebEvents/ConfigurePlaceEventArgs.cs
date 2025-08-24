namespace Roblox.Platform.EventStream.WebEvents;

public class ConfigurePlaceEventArgs : WebEventArgs
{
	/// <summary>
	/// The id of the universe of which root place being configured
	/// </summary>
	public long? UniverseId { get; set; }

	/// <summary>
	/// The id of the place being configured
	/// </summary>
	public long PlaceId { get; set; }

	/// <summary>
	/// The name of the place before configuration
	/// </summary>
	public string OldName { get; set; }

	/// <summary>
	/// The name of the place after configuration
	/// </summary>
	public string NewName { get; set; }

	/// <summary>
	/// The description of the place before configuration
	/// </summary>
	public string OldDescription { get; set; }

	/// <summary>
	/// The description of the place after configuration
	/// </summary>
	public string NewDescription { get; set; }

	/// <summary>
	/// The IconUrl of the place before configuration
	/// </summary>
	public string OldImageIconUrl { get; set; }

	/// <summary>
	/// The IconUrl of the place after configuration
	/// </summary>
	public string NewImageIconUrl { get; set; }

	/// <summary>
	/// Why the attempt to configure the place was unsuccessful
	/// </summary>
	public string FailureReason { get; set; }
}
