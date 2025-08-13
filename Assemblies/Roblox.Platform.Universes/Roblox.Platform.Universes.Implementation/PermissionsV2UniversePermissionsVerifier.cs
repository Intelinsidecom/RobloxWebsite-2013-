using System;
using System.Collections.Generic;
using Roblox.PermissionResolution.Client;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Universes.Implementation;

/// <summary>
/// A very simple wrapper class that encapsulates invoking the Permissions V2 data source
/// to determine if a user has permission to manage the given universe.
/// </summary>
/// <inheritdoc cref="T:Roblox.Platform.Universes.IUniversePermissionsVerifier" />
public class PermissionsV2UniversePermissionsVerifier : IUniversePermissionsVerifier
{
	private readonly IPermissionResolutionClient _PermissionResolutionClient;

	private const string _AdminAction = "Admin";

	private const string _PlayAction = "Play";

	private const string _UniverseResourceType = "Universe";

	/// <summary>
	/// Primary constructor.
	/// </summary>
	/// <param name="permissionResolutionClient"></param>
	public PermissionsV2UniversePermissionsVerifier(IPermissionResolutionClient permissionResolutionClient)
	{
		_PermissionResolutionClient = permissionResolutionClient ?? throw new ArgumentNullException("permissionResolutionClient");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Universes.IUniversePermissionsVerifier.CanUserManageUniverse(Roblox.Platform.Membership.IUser,Roblox.Platform.Universes.IUniverse)" />
	public bool CanUserManageUniverse(IUser user, IUniverse universe)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (universe == null)
		{
			throw new ArgumentNullException("universe");
		}
		return _PermissionResolutionClient.UserHasPermission(user.Id, "Universe", universe.Id.ToString(), (IList<ValueTuple<string, string>>)null, "Admin");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Universes.IUniversePermissionsVerifier.CanUserPlayUniverse(Roblox.Platform.Membership.IUser,Roblox.Platform.Universes.IUniverse)" />
	public bool CanUserPlayUniverse(IUser user, IUniverse universe)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (universe == null)
		{
			throw new ArgumentNullException("universe");
		}
		return _PermissionResolutionClient.UserHasPermission(user.Id, "Universe", universe.Id.ToString(), (IList<ValueTuple<string, string>>)null, "Play");
	}
}
