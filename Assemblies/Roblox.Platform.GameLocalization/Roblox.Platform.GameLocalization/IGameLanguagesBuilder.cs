using System.Collections.Generic;
using Roblox.Platform.GameLocalization.Authorization;

namespace Roblox.Platform.GameLocalization;

public interface IGameLanguagesBuilder
{
	/// <summary>
	/// Add languages to a game's list of supported languages.
	/// </summary>
	/// <param name="universeId">The game to add the languages to.</param>
	/// <param name="languageCodes">The languages to add.</param>
	/// <param name="actor">The actor making the change.</param>
	void AddGameLanguages(long universeId, IReadOnlyCollection<string> languageCodes, IActor actor);

	/// <summary>
	/// Remove languages from a game's list of supported languages.
	/// </summary>
	/// <param name="universeId">The game to remove the languages from.</param>
	/// <param name="languageCodes">The languages to remove.</param>
	/// <param name="actor">The actor making the change.</param>
	void RemoveGameLanguages(long universeId, IReadOnlyCollection<string> languageCodes, IActor actor);
}
