using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <summary>
/// Universe display name in a specific language
/// </summary>
public interface IUniverseDisplayNameForLanguage
{
	/// <summary>
	/// The language that the display name is in.
	/// </summary>
	ILanguageFamily Language { get; }

	/// <summary>
	/// The display name of an universe.
	/// </summary>
	string Name { get; }

	/// <summary>
	/// The language is source language or not.
	/// </summary>
	bool IsSourceLanguage { get; }
}
