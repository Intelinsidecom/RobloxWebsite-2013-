using System.Collections.Generic;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Universes;

namespace Roblox.Platform.GameLocalization;

/// <summary>
/// An interface for dealting with GameLocalizationSettings.
/// </summary>
public interface IGameLocalizationSettingsAuthority
{
	/// <summary>
	/// Gets the source language family for the game.
	/// </summary>
	/// <param name="universe">The universe.</param>
	/// <returns>An <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" /> which is the source language for the game or null.</returns>
	ILanguageFamily GetSourceLanguageFamily(IUniverse universe);

	/// <summary>
	/// Gets the source language families for games.
	/// </summary>
	/// <param name="universes">The universes.</param>
	/// <returns>A <see cref="T:System.Collections.Generic.IReadOnlyDictionary`2" /> of universe and corresponding <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />.</returns>
	IReadOnlyDictionary<IUniverse, ILanguageFamily> GetSourceLanguageFamiliesForGames(IReadOnlyCollection<IUniverse> universes);

	/// <summary>
	/// Sets the source language family for the game.
	/// </summary>
	/// <param name="universe">The universe.</param>
	/// <param name="languageFamily">The language family.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if the <paramref name="universe" /> or <paramref name="languageFamily" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if the <paramref name="languageFamily" /> is not in the list of available language families for UGC.</exception>
	void SetSourceLanguageFamily(IUniverse universe, ILanguageFamily languageFamily);
}
