using System.Collections.Generic;
using Roblox.Platform.Assets;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Universes;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <summary>
/// This is a helper class to keep the migration logic and the localization logic together.
/// If the localization is not involved in migration, you should use UniverseDisplayInformationAccessor directly.
/// If the migrated game name/description doesn't need to be localized, you don't have to use this.
/// </summary>
public interface IGameDisplayInformationProvider
{
	/// <summary>
	/// Get display name for a game.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="place">The <see cref="T:Roblox.Platform.Assets.IAsset" /></param>
	/// <param name="supportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" /></param>
	/// <returns>The display name.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="place" /> is null.</exception>
	string GetGameDisplayName(IUniverse universe, IAsset place, ISupportedLocale supportedLocale);

	/// <summary>
	/// Get display description for a game.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="place">The <see cref="T:Roblox.Platform.Assets.IAsset" /></param>
	/// <param name="supportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" /></param>
	/// <param name="shouldUseUniverseDescription">If true, display universe description if possible. If false, display place description. If null, check <see cref="P:Roblox.Platform.UniverseDisplayInformation.Properties.Settings.IsUniverseDescriptionInsteadOfPlaceDescriptionEnabled" />.</param>
	/// <returns>The display description.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="place" /> is null.</exception>
	string GetGameDisplayDescription(IUniverse universe, IAsset place, ISupportedLocale supportedLocale, bool? shouldUseUniverseDescription = null);

	IDictionary<IAsset, string> GetGameDisplayNames(IReadOnlyCollection<(IUniverse, IAsset)> universePlaceTuples, ISupportedLocale supportedLocale);

	IDictionary<IAsset, string> GetGameDisplayDescriptions(IReadOnlyCollection<(IUniverse, IAsset)> universePlaceTuples, ISupportedLocale supportedLocale, bool? shouldUseUniverseDescription = null);
}
