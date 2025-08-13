using System;
using Roblox.Agents;
using Roblox.Platform.AssetsCore;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;
using Roblox.TextFilter;

namespace Roblox.Platform.Assets;

public interface IAsset : IAssetIdentifier
{
	int TypeId { get; }

	string Name { get; }

	string Description { get; }

	CreatorType CreatorType { get; }

	long CreatorTargetId { get; }

	ulong AssetGenres { get; }

	bool? IsArchived { get; }

	DateTime Created { get; }

	DateTime Updated { get; }

	/// <summary>
	/// Set the Name and Description for the current Asset.
	/// Both will be filtered according to the rules for the given ITextFilter + IUser + Language defined in the <see cref="T:Roblox.Platform.Assets.IAssetNameAndDescription" />.
	/// </summary>
	/// <param name="textInfo">The <see cref="T:Roblox.Platform.Assets.IAssetNameAndDescription" /> to use for updating the Asset.</param>
	/// <param name="actorUserIdentity">
	///     The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> of the agent performing the update, which may be different from the text author. 
	///     For migrators and sanitization processes, pass null for the actorUserIdentity.
	/// </param>
	/// <exception cref="T:System.InvalidOperationException">If there is trouble loading the data entity to be updated.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">In the case where the filtering service is simply unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Assets.PlatformAssetTextFullyModeratedException">In the case where the text is fully moderated.</exception>
	/// <exception cref="T:Roblox.Platform.Core.LongDescriptionException">In the case where the description is too long.</exception>
	void UpdateNameAndDescription(IAssetNameAndDescription textInfo, IUserIdentifier actorUserIdentity);

	/// <summary>
	/// Skipping text filtering and directly set the Name and Description for the current Asset.
	/// [Warning!] This text does not get filtered. Use with extreme care.
	/// [Warning!] This should only be used through the internal (CS, Admin, or Moderation) websites and performed by Roblox staff!
	/// </summary>
	/// <param name="textInfo">The <see cref="T:Roblox.Platform.Assets.ITrustedAssetTextInfo" /> to use for updating the Asset.</param>
	/// <param name="actorUserIdentity">
	///     The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> of the agent performing the update, which may be different from the text author.
	///     For migrators and sanitization processes, pass null for the actorUserIdentity.
	/// </param>
	/// <exception cref="T:System.InvalidOperationException">If there is trouble loading the data entity to be updated.</exception>
	void UpdateNameAndDescriptionTrusted(ITrustedAssetTextInfo textInfo, IUserIdentifier actorUserIdentity);

	/// <summary>
	/// Updates the Name for a <see cref="T:Roblox.DelayedReleaseAsset" />.
	/// [Warning!] This text does not get filtered. Use with extreme care.
	/// [Warning!] This should only be used through the Admin website!
	/// </summary>
	/// <exception cref="T:System.InvalidOperationException">If there is trouble loading the data entity to be updated.</exception>
	void DelayedReleaseUpdateNameAndDescription(IAssetNameAndDescription textInfo, IUser actorUser);

	/// <summary>
	/// Passes the existing name and description through the AssetTextFilter using the given textAuthor, and saves any changes.
	/// </summary>
	/// <returns>
	/// [True] If either the name and/or description was altered by the AssetTextFilter. [False] If both the name and description remain unchanged through the AssetTextFilter.
	/// </returns>
	/// <exception cref="T:System.InvalidOperationException">If there is trouble loading the data entity to be updated.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">In the case where the filtering service is simply unavailable.</exception>
	bool Sanitize(ITextAuthor textAuthor);

	/// <summary>
	/// Updates the Genres of the Asset
	/// </summary>
	/// <exception cref="T:System.InvalidOperationException">If there is trouble loading the data entity to be updated.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">If the genre is null.</exception>
	/// <exception cref="T:System.ApplicationException">If the asset's id is less than 1 (asset not yet saved to persistent storage)</exception>
	void UpdateGenres(Roblox.AssetGenre genre, bool isForceUpdate = false);

	/// <summary>
	/// Updates the Genres of the Asset
	/// </summary>
	/// <exception cref="T:System.InvalidOperationException">If there is trouble loading the data entity to be updated.</exception>
	/// <exception cref="T:System.ApplicationException">If the asset's id is less than 1 (asset not yet saved to persistent storage)</exception>
	void UpdateGenres(ulong genres, bool isForceUpdate = false);

	/// <summary>
	/// Updates the categories of the Asset via a bitfield
	/// </summary>
	/// <exception cref="T:System.InvalidOperationException">If there is trouble loading the data entity to be updated.</exception>
	/// <exception cref="T:System.ApplicationException">If the asset's id is less than 1 (asset not yet saved to persistent storage)</exception>
	void UpdateCategories(ulong catsBitfield, bool isForceUpdate = false);

	/// <summary>
	/// Updates the agent id of the Asset's creator
	/// </summary>
	/// <exception cref="T:System.InvalidOperationException">If there is trouble loading the data entity to be updated.</exception>
	/// <exception cref="T:System.ApplicationException">If the asset's id is less than 1 (asset not yet saved to persistent storage)</exception>
	/// <exception cref="T:System.ArgumentNullException">If the newCreatorAgent is null.</exception>
	void UpdateCreatorAgentId(IAgent newCreatorAgent);

	/// <summary>
	/// Updates the timestamp when the asset was updated
	/// </summary>
	/// <exception cref="T:System.InvalidOperationException">If there is trouble loading the data entity to be updated.</exception>
	/// <exception cref="T:System.ApplicationException">If the asset's id is less than 1 (asset not yet saved to persistent storage)</exception>
	void UpdateUpdated();

	/// <summary>
	/// Archives the asset
	/// </summary>
	/// <param name="actorUserIdentity">
	///     The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> of the agent performing the update, which may be different from the text author.
	///     For migrators and sanitization processes, pass null for the actorUserIdentity.
	/// </param>
	void Archive(IUserIdentifier actorUserIdentity);

	/// <summary>
	/// Restores, or unarchives, the asset
	/// </summary>
	/// <param name="actorUserIdentity">
	///     The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> of the agent performing the update, which may be different from the text author.
	///     For migrators and sanitization processes, pass null for the actorUserIdentity.
	/// </param>
	void Restore(IUserIdentifier actorUserIdentity);
}
