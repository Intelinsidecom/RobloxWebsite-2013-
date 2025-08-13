namespace Roblox.Platform.EventStream.WebEvents;

public class GameNameDescriptionChangeEventArgs : WebEventArgs
{
	/// <summary>
	/// The ID of universe of which name or description was changed.
	/// </summary>
	public long UniverseId { get; set; }

	/// <summary>
	/// The language code of language in which game name or description was changed.
	/// </summary>
	public string LanguageCode { get; set; }

	/// <summary>
	/// The language is source language or not.
	/// </summary>
	public bool IsSourceLanguage { get; set; }

	/// <summary>
	/// The type of the user who made this change: User or Other.
	/// </summary>
	public string UserType { get; set; }

	/// <summary>
	/// The action type: Created, Updated or Deleted
	/// </summary>
	public string ActionType { get; set; }

	/// <summary>
	/// The changed field: Name, Description
	/// </summary>
	public string Field { get; set; }
}
