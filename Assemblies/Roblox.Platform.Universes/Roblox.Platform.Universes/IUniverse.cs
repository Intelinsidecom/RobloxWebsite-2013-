using System;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Universes;

/// <summary>
/// Provides a common interface for an object that represents a Universe
/// </summary>
public interface IUniverse
{
	/// <summary>
	/// Gets the identifier
	/// </summary>
	long Id { get; }

	/// <summary>
	/// Gets the name of the universe
	/// NOTE: Do not use this as a display name for <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// If you intend to use the universe name for display purposes or in a localized context, use Roblox.Platform.UniverseDisplayInformation instead.
	/// </summary>
	string Name { get; }

	/// <summary>
	/// Gets the description of the universe
	/// NOTE: Do not use this as a display description for <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// If you intend to use the universe description for display purposes or in a localized context, use Roblox.Platform.UniverseDisplayInformation instead.
	/// </summary>
	string Description { get; }

	/// <summary>
	/// Whether or not the universe is archived
	/// </summary>
	bool IsArchived { get; set; }

	/// <summary>
	/// Gets the Id of the root place of the universe
	/// </summary>
	long? RootPlaceId { get; }

	/// <summary>
	/// Gets the type of the creator, a user or a group
	/// </summary>
	string CreatorType { get; }

	/// <summary>
	/// Gets the actual Id of the creator of the universe.
	/// Group Id if it is a group, user Id if it is a user
	/// </summary>
	long CreatorTargetId { get; }

	/// <summary>
	/// Gets the created time.
	/// </summary>
	DateTime Created { get; }

	/// <summary>
	/// Gets the updated time.
	/// </summary>
	DateTime Updated { get; }

	/// <summary>
	/// Gets the the setting of Is Studio Access To Apis Allowed of the universe
	/// </summary>
	bool StudioAccessToApisAllowed { get; }

	/// <summary>
	/// The privacy of the universe
	/// </summary>
	string PrivacyType { get; }

	/// <summary>
	/// Update the name and description of the <see cref="T:Roblox.Platform.Universes.IUniverse" />
	/// </summary>
	/// <param name="newName">The new name to be updated to</param>
	/// <param name="newDescription">The new description to be updated to</param>
	/// <param name="clientTextAuthor">The text author of the name and description</param>
	/// <param name="allowPartiallyModerated">Whether to allow the name or description that were partially moderated.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown when the IClientTextAuthor is null</exception>
	/// <exception cref="T:System.ArgumentException">Thrown when the new name is null or white space or the length is too long</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown when the text filtering service is unavailable</exception>
	/// <exception cref="T:Roblox.Platform.Universes.PlatformUniverseTextFullyModeratedException">Thrown when the name or description is fully moderated</exception>
	/// <exception cref="T:Roblox.Platform.Universes.UniverseTextPartiallyModeratedException">Throw when <paramref name="allowPartiallyModerated" /> is <c>false</c> and the name or description is partially moderated.</exception>
	void UpdateNameDescription(string newName, string newDescription, IClientTextAuthor clientTextAuthor, bool allowPartiallyModerated = true);

	/// <summary>
	/// Skipping text filtering and directly update the name and description of the <see cref="T:Roblox.Platform.Universes.IUniverse" />
	/// [Warning!] This text does not get filtered. Use with extreme care.
	/// [Warning!] This should only be used through the internal (CS, Admin, or Moderation) websites.
	/// </summary>
	/// <param name="trustedName">The new name to be updated to</param>
	/// <param name="trustedDescription">The new description to be updated to</param>
	/// <exception cref="T:System.ArgumentException">Thrown when the new name is null or white space or the length is too long</exception>
	void UpdateNameDescriptionTrusted(string trustedName, string trustedDescription);

	/// <summary>
	/// Update the <see cref="P:Roblox.Platform.Universes.IUniverse.StudioAccessToApisAllowed" /> option of the <see cref="T:Roblox.Platform.Universes.IUniverse" />
	/// </summary>
	/// <param name="newStudioAccessToApisAllowed">The new <see cref="P:Roblox.Platform.Universes.IUniverse.StudioAccessToApisAllowed" /> to be updated to, or null if not to be updated</param>
	void UpdateBasicSettings(bool? newStudioAccessToApisAllowed);
}
