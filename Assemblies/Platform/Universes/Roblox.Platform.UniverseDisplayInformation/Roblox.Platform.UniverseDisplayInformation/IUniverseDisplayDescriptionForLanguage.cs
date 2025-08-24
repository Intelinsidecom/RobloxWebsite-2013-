using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <summary>
/// Universe display description in a specific language
/// </summary>
public interface IUniverseDisplayDescriptionForLanguage
{
	/// <summary>
	/// The language that the display description is in.
	/// </summary>
	ILanguageFamily Language { get; }

	/// <summary>
	/// The display description of an universe.
	/// </summary>
	string Description { get; }

	/// <summary>
	/// The language is source language or not.
	/// </summary>
	bool IsSourceLanguage { get; }
}
