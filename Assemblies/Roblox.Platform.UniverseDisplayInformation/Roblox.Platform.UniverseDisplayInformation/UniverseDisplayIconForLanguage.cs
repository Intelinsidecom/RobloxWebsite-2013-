using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <summary>
/// The class that contains information of a universe icon.
/// </summary>
public class UniverseDisplayIconForLanguage
{
	/// <summary>
	/// What language the icon image is in.
	/// </summary>
	public ILanguageFamily Language { get; set; }

	/// <summary>
	/// The image id of the icon.
	/// </summary>
	public long? IconImageId { get; set; }

	/// <summary>
	/// The language is source language or not.
	/// </summary>
	public bool IsSourceLanguage { get; set; }
}
