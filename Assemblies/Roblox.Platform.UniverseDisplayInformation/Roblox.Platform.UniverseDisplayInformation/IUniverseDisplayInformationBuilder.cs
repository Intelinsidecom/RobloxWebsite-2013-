using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <summary>
/// The class to modify the display name/description of an universe.
/// </summary>
public interface IUniverseDisplayInformationBuilder
{
	/// <summary>
	/// Set display name of an universe in a specific language.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="language">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />. If it's null, this method will update name for source language.</param>
	/// <param name="newName">The name to be set.</param>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> of who wants to set display name.</param>
	/// <param name="allowPartiallyModerated">Whether to save <paramref name="newName" /> if partially moderated.</param>
	/// <param name="nameSaved">The name saved. This might be different from <paramref name="newName" /> because the string might be partially moderated.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="universe" />
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="newName" /> is null or whitespaces or the length is too long.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if the <paramref name="language" /> used to set the name in is not available.</exception>
	/// <exception cref="T:Roblox.Platform.Universes.PlatformUniverseTextFullyModeratedException">Thrown if <paramref name="newName" /> is fully moderated.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if text filter or translation storage service operation is unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Core.FeatureDisabledException">Thrown if user is trying to update name for non-source language but ModifyingOrDeletingTranslations is disabled.</exception>
	/// <exception cref="T:Roblox.Platform.Universes.UniverseTextPartiallyModeratedException">Throw when <paramref name="allowPartiallyModerated" /> is <c>false</c> and <paramref name="newName" /> is partially moderated.</exception>
	void SetDisplayName(IUniverse universe, ILanguageFamily language, string newName, IUser user, bool allowPartiallyModerated, out string nameSaved);

	/// <summary>
	/// Skip text filtering and directly set display name of an universe in a specific language.
	/// [Warning!] This text does not get filtered. Use with extreme care.
	/// [Warning!] This should only be used through the internal (CS, Admin, or Moderation) websites.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="language">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />. If it's null, this method will update name for source language.</param>
	/// <param name="trustedName">The name to be set.</param>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> of who wants to set display name.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="universe" /></exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="trustedName" /> is null or whitespaces or the length is too long.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if translation storage service operation is unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Core.FeatureDisabledException">Thrown if user is trying to update name for non-source language but ModifyingOrDeletingTranslations is disabled.</exception>
	void SetDisplayNameTrusted(IUniverse universe, ILanguageFamily language, string trustedName, IUser user);

	/// <summary>
	/// Set display description of an universe in a specific language.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="language">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />. If it's null, this method will update description for source language.</param>
	/// <param name="newDescription">The description to be set.</param>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> of who wants to set display description.</param>
	/// <param name="allowPartiallyModerated">Whether to save <paramref name="newDescription" /> if partially moderated.</param>
	/// <param name="descriptionSaved">
	/// The derscription saved. This might be different from <paramref name="newDescription" /> because the string might be partially moderated.
	/// If <paramref name="newDescription" /> is null or whitespaces, it would be empty string.
	/// </param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="universe" />
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="newDescription" /> is too long.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if the <paramref name="language" /> used to set the name in is not available.</exception>
	/// <exception cref="T:Roblox.Platform.Universes.PlatformUniverseTextFullyModeratedException">Thrown if <paramref name="newDescription" /> is fully moderated.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if text filter or translation storage service operation is unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Core.FeatureDisabledException">Thrown if user is trying to update description for non-source language but ModifyingOrDeletingTranslations is disabled.</exception>
	/// <exception cref="T:Roblox.Platform.Universes.UniverseTextPartiallyModeratedException">Throw when <paramref name="allowPartiallyModerated" /> is <c>false</c> and <paramref name="newDescription" /> is partially moderated.</exception>
	void SetDisplayDescription(IUniverse universe, ILanguageFamily language, string newDescription, IUser user, bool allowPartiallyModerated, out string descriptionSaved);

	/// <summary>
	/// Skip text filtering and directly set display description of an universe in a specific language.
	/// [Warning!] This text does not get filtered. Use with extreme care.
	/// [Warning!] This should only be used through the internal (CS, Admin, or Moderation) websites.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="language">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />. If it's null, this method will update description for source language.</param>
	/// <param name="trustedDescription">The description to be set.</param>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> of who wants to set display description.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="trustedDescription" /> is too long.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="universe" /></exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if translation storage service operation is unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Core.FeatureDisabledException">Thrown if user is trying to update description for non-source language but ModifyingOrDeletingTranslations is disabled.</exception>
	void SetDisplayDescriptionTrusted(IUniverse universe, ILanguageFamily language, string trustedDescription, IUser user);

	/// <summary>
	/// Set display name and description of an universe in a specific language. If any of them are fully moderated, both values would not be updated.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="language">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />. If it's null, this method will update name and description for source language.</param>
	/// <param name="newName">The name to be set.</param>
	/// <param name="newDescription">The description to be set.</param>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> of who wants to set display name and description.</param>
	/// <param name="allowPartiallyModerated">Whether to save <paramref name="newName" /> or <paramref name="newDescription" /> if partially moderated.</param>
	/// <param name="nameSaved">The name saved. This might be different from <paramref name="newName" /> because the string might be partially moderated.</param>
	/// <param name="descriptionSaved">
	/// The derscription saved. This might be different from <paramref name="newDescription" /> because the string might be partially moderated.
	/// If <paramref name="newDescription" /> is null or whitespaces, it would be empty string.
	/// </param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="universe" />
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="newName" /> is null or whitespaces or <paramref name="newName" />/<paramref name="newDescription" /> is too long.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if the <paramref name="language" /> used to set the name in is not available.</exception>
	/// <exception cref="T:Roblox.Platform.Universes.PlatformUniverseTextFullyModeratedException">Thrown if <paramref name="newName" /> or <paramref name="newDescription" /> is fully moderated.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if text filter or translation storage service operation is unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Core.FeatureDisabledException">Thrown if user is trying to update name and description for non-source language but ModifyingOrDeletingTranslations is disabled.</exception>
	/// <exception cref="T:Roblox.Platform.Universes.UniverseTextPartiallyModeratedException">Throw when <paramref name="allowPartiallyModerated" /> is <c>false</c> and <paramref name="newName" /> or <paramref name="newDescription" /> is partially moderated.</exception>
	void SetDisplayNameAndDescription(IUniverse universe, ILanguageFamily language, string newName, string newDescription, IUser user, bool allowPartiallyModerated, out string nameSaved, out string descriptionSaved);

	/// <summary>
	/// Delete display name of an universe in a specific language.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="language">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />.</param>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> of who wants to delete display name.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if any null argument.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if translation storage service operation is unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Core.FeatureDisabledException">Thrown if ModifyingOrDeletingTranslations is disabled.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if <paramref name="language" /> is source language.</exception>
	void DeleteDisplayName(IUniverse universe, ILanguageFamily language, IUser user);

	/// <summary>
	/// Delete display description of an universe in a specific language.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="language">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />.</param>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> of who wants to delete display description.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if any null argument.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if translation storage service operation is unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Core.FeatureDisabledException">Thrown if ModifyingOrDeletingTranslations is disabled.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if <paramref name="language" /> is source language.</exception>
	void DeleteDisplayDescription(IUniverse universe, ILanguageFamily language, IUser user);

	/// <summary>
	/// Delete display name and description of an universe in a specific language.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="language">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />.</param>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> of who wants to delete display name and description.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if any null argument.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if translation storage service operation is unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Core.FeatureDisabledException">Thrown if ModifyingOrDeletingTranslations is disabled.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if <paramref name="language" /> is source language.</exception>
	void DeleteDisplayNameAndDescription(IUniverse universe, ILanguageFamily language, IUser user);
}
