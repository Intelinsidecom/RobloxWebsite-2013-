using System.IO;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <summary>
/// The class to modify the display icon of an universe.
/// </summary>
public interface IUniverseDisplayIconBuilder
{
	/// <summary>
	/// Set display icon of an universe in a specific language.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="languageFamily">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" /> of the icon to set.</param>
	/// <param name="imageData">The data stream for the icon.</param>
	/// <param name="actor">The <see cref="T:Roblox.Platform.Membership.IUser" /> who is settings the display icon.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="universe" />
	///     <paramref name="languageFamily" />
	///     <paramref name="imageData" />
	///     <paramref name="actor" />
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if <paramref name="languageFamily" /> is source language</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFloodedException">Thrown if too many requests were sent by the actor.</exception>
	/// <exception cref="T:System.IO.InvalidDataException">Thrown if <paramref name="imageData" /> was not in a valid format.</exception>
	void SetDisplayIcon(IUniverse universe, ILanguageFamily languageFamily, Stream imageData, IUser actor);

	/// <summary>
	/// Delete display icon of an universe in a specific language.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="languageFamily">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" /> of the icon to delete.</param>
	/// <param name="actor">The <see cref="T:Roblox.Platform.Membership.IUser" /> who is deleting the display icon.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="universe" />
	///     <paramref name="languageFamily" />
	///     <paramref name="actor" />
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if <paramref name="languageFamily" /> is source language</exception>
	void DeleteDisplayIcon(IUniverse universe, ILanguageFamily languageFamily, IUser actor);
}
