using System.Collections.Generic;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.GameLocalization;

/// <summary>
/// A common interface for an entity that manages GameLocalizationLanguageSettings.
/// </summary>
internal interface IGameLocalizationLanguageSettingsAuthority
{
	/// <summary>
	/// Gets the list of supported languages for a particular universe.
	/// </summary>
	/// <param name="universeId">The universeId.</param>
	/// <returns>A <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />.</returns>
	IReadOnlyCollection<ILanguageFamily> GetSupportedLanguageFamiliesForGame(long universeId);

	/// <summary>
	/// Removes languages from the supported list of languages for a universe.
	/// </summary>
	/// <param name="universeId">The universeId.</param>
	/// <param name="languages">The languages to remove.</param>
	void RemoveSupportedLanguageFamiliesForGame(long universeId, IReadOnlyCollection<ILanguageFamily> languages);

	/// <summary>
	/// Adds languages to the supported list of languages for a universe. 
	/// </summary>
	/// <param name="universeId">The universeId.</param>
	/// <param name="languages">The languages to add.</param>
	void AddSupportedLanguageFamiliesForGame(long universeId, IReadOnlyCollection<ILanguageFamily> languages);
}
