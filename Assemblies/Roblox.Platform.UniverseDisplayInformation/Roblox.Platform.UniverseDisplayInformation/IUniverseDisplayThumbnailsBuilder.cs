using System.Collections.Generic;
using System.IO;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <summary>
/// A interface that is used for mutating a display media for a <see cref="T:Roblox.Platform.Universes.IUniverse" />.
/// </summary>
public interface IUniverseDisplayThumbnailsBuilder
{
	/// <summary>
	/// Add display thumbnail of an universe in a specific language, the thumbnail will be appended to the end of the thumbnail list.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="languageFamily">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" /> of the thumbnail to set.</param>
	/// <param name="imageData">The data stream for the thumbnail.</param>
	/// <param name="actor">The <see cref="T:Roblox.Platform.Membership.IUser" /> who is settings the display thumbnail.</param>
	/// <returns> The id of the added thumbnail asset </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="universe" />
	///     <paramref name="languageFamily" />
	///     <paramref name="imageData" />
	///     <paramref name="actor" />
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if <paramref name="languageFamily" /> is source language</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFloodedException">Thrown if too many requests were sent by the actor.</exception>
	/// <exception cref="T:System.IO.InvalidDataException">Thrown if <paramref name="imageData" /> was not in a valid format.</exception>
	long AddDisplayThumbnail(IUniverse universe, ILanguageFamily languageFamily, Stream imageData, IUser actor);

	/// <summary>
	/// Delete display thumbnail of an universe in a specific language.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="imageId">The asset id of the thumbnail to be deleted.</param>
	/// <param name="languageFamily">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" /> of the thumbnail to delete.</param>
	/// <param name="actor">The <see cref="T:Roblox.Platform.Membership.IUser" /> who is deleting the display thumbnail.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="universe" />
	///     <paramref name="languageFamily" />
	///     <paramref name="actor" />
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if <paramref name="languageFamily" /> is source language</exception>
	void DeleteDisplayThumbnail(IUniverse universe, long imageId, ILanguageFamily languageFamily, IUser actor);

	/// <summary>
	/// Reorder the display thumbnails of an universe in a specific language.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="imageIds">a <see cref="T:System.Collections.Generic.IList`1" /> of asset of ids of thumbnails that represents the new order.</param>
	/// <param name="languageFamily">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" /> of the thumbnail to delete.</param>
	/// <param name="actor">The <see cref="T:Roblox.Platform.Membership.IUser" /> who is deleting the display thumbnail.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="universe" />
	///     <paramref name="imageIds" />
	///     <paramref name="languageFamily" />
	///     <paramref name="actor" />
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if <paramref name="languageFamily" /> is source language</exception>
	void OrderDisplayThumbnails(IUniverse universe, IList<long> imageIds, ILanguageFamily languageFamily, IUser actor);
}
