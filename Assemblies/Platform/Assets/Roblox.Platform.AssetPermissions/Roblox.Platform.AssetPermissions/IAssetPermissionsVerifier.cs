using Roblox.Platform.Assets;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AssetPermissions;

/// <summary>
/// A class for verifying permissions against assets
/// </summary>
public interface IAssetPermissionsVerifier
{
	/// <summary>
	/// Verifies if an <see cref="T:Roblox.Platform.Membership.IUser" /> has ownership of an <see cref="T:Roblox.Platform.Assets.IAsset" />
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="asset">The <see cref="T:Roblox.Platform.Assets.IAsset" />.</param>
	/// <returns><c>true</c> if <paramref name="user" /> has ownership of <paramref name="asset" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	/// <exception cref="T:Roblox.ApiClientBase.ApiClientException">Thrown if groups service is down</exception>
	bool IsOwner(IUser user, Roblox.Platform.Assets.IAsset asset);

	/// <summary>
	/// Verifies if an <see cref="T:Roblox.Platform.Membership.IUser" /> has access to manage/configure an <see cref="T:Roblox.Platform.Assets.IAsset" />
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="asset">The <see cref="T:Roblox.Platform.Assets.IAsset" />.</param>
	/// <returns><c>true</c> if <paramref name="user" /> has access to manage/configure <paramref name="asset" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	/// <exception cref="T:Roblox.ApiClientBase.ApiClientException">Thrown if groups service is down</exception>
	bool CanManage(IUser user, Roblox.Platform.Assets.IAsset asset);

	/// <summary>
	/// Verifies if an <see cref="T:Roblox.Platform.Membership.IUser" /> has permission to edit a place.
	/// </summary>
	/// <remarks>
	/// Do not use this check to check whether or not a user can publish a place.
	/// This is specifically whether or not the user is allowed to open it in studio.
	///
	/// Currently this only checks if the user CanManage, or if the place is not copylocked.
	/// Ideally this would also check if the user has access to TeamCreate the place. To do that
	/// we need to delete Roblox.Platform.CloudEdit dependency on Roblox.Platform.TeamCreate (WEBAPI-2627)
	/// </remarks>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> to check.</param>
	/// <param name="place">The <see cref="T:Roblox.Platform.Assets.IPlace" /> to be edited.</param>
	/// <returns><c>true</c> if the user can edit the <see cref="T:Roblox.Platform.Assets.IPlace" />.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="place" /> is null.</exception>
	/// <exception cref="T:Roblox.ApiClientBase.ApiClientException">Thrown if groups service is down</exception>
	bool CanEdit(IUser user, IPlace place);

	/// <summary>
	/// Verifies if an <see cref="T:Roblox.Platform.Membership.IUser" /> has permission to play a place.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> to check.</param>
	/// <param name="place">The <see cref="T:Roblox.Platform.Assets.IPlace" /> to be played.</param>
	/// <returns><c>true</c> if the user can play the <see cref="T:Roblox.Platform.Assets.IPlace" />.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="place" /> is null.</exception>
	/// <exception cref="T:Roblox.ApiClientBase.ApiClientException">Thrown if groups service is down</exception>
	bool CanPlay(IUser user, IPlace place);

	/// <summary>
	/// Wraps a try catch around CanEdit method.
	/// out parameter is true if the user canEdit, false otherwise (or if there was an ApiClientException)
	/// The return value is false if there was an exception while evaluating if user canEdit
	/// </summary>
	/// <remarks>
	/// Do not use this check to check whether or not a user can publish a place.
	/// This is specifically whether or not the user is allowed to open it in studio.
	///
	/// Currently this only checks if the user CanManage, or if the place is not copylocked.
	/// Ideally this would also check if the user has access to TeamCreate the place. To do that
	/// we need to delete Roblox.Platform.CloudEdit dependency on Roblox.Platform.TeamCreate (WEBAPI-2627)
	/// </remarks>
	bool TryCanEdit(IUser user, IPlace place, out bool canEdit);

	/// <summary>
	/// Wraps a try catch around CanManage method.
	/// out parameter is true if the user canManage, false otherwise (or if there was an ApiClientException)
	/// The return value is false if there was an exception while evaluating if user canManage
	/// </summary>
	bool TryCanManage(IUser user, Roblox.Platform.Assets.IAsset place, out bool canManage);

	/// <summary>
	/// Wraps a try catch around CanPlay method.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> to check.</param>
	/// <param name="place">The <see cref="T:Roblox.Platform.Assets.IPlace" /> to be played.</param>
	/// <param name="canPlay">Set to <c>true</c> if the user can play, <c>false</c> otherwise (or if there was an ApiClientException)
	/// </param>
	/// <returns><c>false</c> if there was an exception while evaluating if user can play the place, <c>true</c> otherwise.</returns>
	bool TryCanPlay(IUser user, IPlace place, out bool canPlay);
}
