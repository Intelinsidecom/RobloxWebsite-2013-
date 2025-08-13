using System;
using System.Collections.Generic;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.CloudEdit.Permissions;

/// <summary>
/// Manager for CloudEdit access to a universe
/// </summary>
public interface ICloudEditPermissionManager
{
	/// <summary>
	/// Raise this event after adding user to CloudEdit session
	/// </summary>
	event Action<IUniverse, IUser, IUser> UserAddedToCloudEdit;

	/// <summary>
	/// Is the universe enabled/disabled for cloud edit
	/// </summary>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.CloudEdit.Permissions.Exceptions.CloudEditPermissionsPlatformException">Thrown if a dependency service is down</exception>
	bool IsCloudEditEnabled();

	/// <summary>
	/// Disabled -&gt; Enabled
	/// </summary>
	/// <exception cref="T:Roblox.Platform.CloudEdit.Permissions.Exceptions.CloudEditPermissionsPlatformException">Thrown if a dependency service is down</exception>
	void EnableForCloudEdit();

	/// <summary>
	/// Enabled -&gt; Disabled
	/// </summary>
	/// <exception cref="T:Roblox.Platform.CloudEdit.Permissions.Exceptions.CloudEditPermissionsPlatformException">Thrown if a dependency service is down</exception>
	void DisableForCloudEdit();

	/// <summary>
	/// Determines if user has sufficient permission to CloudEdit a place
	/// </summary>
	/// <param name="user"></param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.CloudEdit.Permissions.Exceptions.CloudEditPermissionsPlatformException">Thrown if a dependency service is down</exception>
	bool CanUserCloudEdit(IUser user);

	/// <summary>
	/// Whitelist the user
	/// </summary>
	/// <param name="userToAdd"><see cref="T:Roblox.Platform.Membership.IUser" /> which has to be added to CloudEdit</param>
	/// <param name="inviter"><see cref="T:Roblox.Platform.Membership.IUser" /> Initiator of specified user adding</param>
	/// <exception cref="T:Roblox.Platform.CloudEdit.Permissions.Exceptions.CloudEditPermissionsPlatformException">Thrown if a dependency service is down</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFloodedException">Thrown when user reached the execution limit for specified universe</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// thrown when either argument is null
	/// </exception>
	void AddUserToEditorsList(IUser userToAdd, IUser inviter);

	/// <summary>
	/// De-Whitelist the user
	/// </summary>
	/// <param name="user"></param>
	/// <exception cref="T:Roblox.Platform.CloudEdit.Permissions.Exceptions.CloudEditPermissionsPlatformException">Thrown if a dependency service is down</exception>
	void RemoveUserFromEditorsList(IUser user);

	/// <summary>
	/// Get list of editors
	/// </summary>
	/// <param name="page"></param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.CloudEdit.Permissions.Exceptions.CloudEditPermissionsPlatformException">Thrown if a dependency service is down</exception>
	IEnumerable<long> GetEditorsListPage(int page);
}
