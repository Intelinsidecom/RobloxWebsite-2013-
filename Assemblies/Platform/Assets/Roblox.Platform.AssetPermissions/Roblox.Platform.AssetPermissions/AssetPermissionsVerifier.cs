using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.ApiClientBase;
using Roblox.EventLog;
using Roblox.PermissionResolution.Client;
using Roblox.Platform.Assets;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.AssetPermissions;

/// <inheritdoc cref="T:Roblox.Platform.AssetPermissions.IAssetPermissionsVerifier" />
public class AssetPermissionsVerifier : IAssetPermissionsVerifier
{
	private readonly IGroupMembershipFactory _GroupMembershipFactory;

	private readonly IUniverseFactory _UniverseFactory;

	private readonly IUniversePermissionsVerifier _UniversePermissionsVerifier;

	private readonly ILogger _Logger;

	private readonly IPermissionResolutionClient _PermissionResolutionClient;

	private const string _UniverseResourceType = "Universe";

	private const string _AdminAction = "Admin";

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.AssetPermissions.AssetPermissionsVerifier" />.
	/// </summary>
	/// <param name="groupMembershipFactory">An <see cref="T:Roblox.Platform.Groups.IGroupMembershipFactory" />.</param>
	/// <param name="universeFactory">An <see cref="T:Roblox.Platform.Universes.IUniverseFactory" />.</param>
	/// <param name="universePermissionsVerifier">An <see cref="T:Roblox.Platform.Universes.IUniversePermissionsVerifier" />.</param>
	/// <param name="permissionResolutionClient">An <see cref="T:Roblox.PermissionResolution.Client.IPermissionResolutionClient" />.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	public AssetPermissionsVerifier(IGroupMembershipFactory groupMembershipFactory, IUniverseFactory universeFactory, IUniversePermissionsVerifier universePermissionsVerifier, IPermissionResolutionClient permissionResolutionClient, ILogger logger = null)
	{
		_GroupMembershipFactory = groupMembershipFactory ?? throw new ArgumentNullException("groupMembershipFactory");
		_UniverseFactory = universeFactory ?? throw new ArgumentNullException("universeFactory");
		_UniversePermissionsVerifier = universePermissionsVerifier ?? throw new ArgumentNullException("universePermissionsVerifier");
		_PermissionResolutionClient = permissionResolutionClient ?? throw new ArgumentNullException("permissionResolutionClient");
		_Logger = logger;
	}

	/// <inheritdoc cref="M:Roblox.Platform.AssetPermissions.IAssetPermissionsVerifier.IsOwner(Roblox.Platform.Membership.IUser,Roblox.Platform.Assets.IAsset)" />
	public bool IsOwner(IUser user, Roblox.Platform.Assets.IAsset asset)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return asset.CreatorType switch
		{
			Roblox.Platform.Assets.CreatorType.User => asset.CreatorTargetId == user.Id, 
			Roblox.Platform.Assets.CreatorType.Group => _GroupMembershipFactory.CheckedGet(asset.CreatorTargetId, user.Id).RoleSet.IsOwner(), 
			_ => false, 
		};
	}

	/// <inheritdoc cref="M:Roblox.Platform.AssetPermissions.IAssetPermissionsVerifier.CanManage(Roblox.Platform.Membership.IUser,Roblox.Platform.Assets.IAsset)" />
	public bool CanManage(IUser user, Roblox.Platform.Assets.IAsset asset)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (asset.TypeId == 9)
		{
			IUniverse universe = _UniverseFactory.GetPlaceUniverse(asset.Id);
			if (universe != null)
			{
				return _UniversePermissionsVerifier.CanUserManageUniverse(user, universe);
			}
		}
		return asset.CreatorType switch
		{
			Roblox.Platform.Assets.CreatorType.User => asset.CreatorTargetId == user.Id, 
			Roblox.Platform.Assets.CreatorType.Group => _GroupMembershipFactory.CheckedGet(asset.CreatorTargetId, user.Id).RoleSet.HasPermission(Roblox.Platform.Groups.GroupRoleSetPermissionType.CanManageGroupGames), 
			_ => false, 
		};
	}

	/// <inheritdoc cref="M:Roblox.Platform.AssetPermissions.IAssetPermissionsVerifier.CanEdit(Roblox.Platform.Membership.IUser,Roblox.Platform.Assets.IPlace)" />
	public bool CanEdit(IUser user, IPlace place)
	{
		if (place == null)
		{
			throw new ArgumentNullException("place");
		}
		if (!IsCopyLocked(place))
		{
			return true;
		}
		if (user == null)
		{
			return false;
		}
		if (place.CreatorType == Roblox.Platform.Assets.CreatorType.User && user.Id == place.CreatorTargetId)
		{
			return true;
		}
		return CanManage(user, place);
	}

	/// <inheritdoc cref="M:Roblox.Platform.AssetPermissions.IAssetPermissionsVerifier.CanPlay(Roblox.Platform.Membership.IUser,Roblox.Platform.Assets.IPlace)" />
	public bool CanPlay(IUser user, IPlace place)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (place == null)
		{
			throw new ArgumentNullException("place");
		}
		IUniverse universe = _UniverseFactory.GetPlaceUniverse(place.Id);
		if (universe != null)
		{
			return _UniversePermissionsVerifier.CanUserPlayUniverse(user, universe);
		}
		_Logger.Error($"No universe found for place with ID: {place.Id}");
		return false;
	}

	/// <inheritdoc cref="M:Roblox.Platform.AssetPermissions.IAssetPermissionsVerifier.TryCanManage(Roblox.Platform.Membership.IUser,Roblox.Platform.Assets.IAsset,System.Boolean@)" />
	public bool TryCanManage(IUser user, Roblox.Platform.Assets.IAsset place, out bool canManage)
	{
		bool success = false;
		canManage = false;
		try
		{
			canManage = CanManage(user, place);
			return true;
		}
		catch (ApiClientException ace)
		{
			_Logger?.Error($"There was an exception while calling CanManage() :{ace}");
			return false;
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.AssetPermissions.IAssetPermissionsVerifier.TryCanEdit(Roblox.Platform.Membership.IUser,Roblox.Platform.Assets.IPlace,System.Boolean@)" />
	public bool TryCanEdit(IUser user, IPlace place, out bool canEdit)
	{
		bool success = false;
		canEdit = false;
		try
		{
			canEdit = CanEdit(user, place);
			return true;
		}
		catch (ApiClientException ace)
		{
			_Logger?.Error($"There was an exception while calling CanManage() :{ace}");
			return false;
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.AssetPermissions.IAssetPermissionsVerifier.TryCanPlay(Roblox.Platform.Membership.IUser,Roblox.Platform.Assets.IPlace,System.Boolean@)" />
	public bool TryCanPlay(IUser user, IPlace place, out bool canPlay)
	{
		bool success = false;
		canPlay = false;
		try
		{
			canPlay = CanPlay(user, place);
			return true;
		}
		catch (ApiClientException ace)
		{
			_Logger?.Error($"There was an exception while calling CanPlay() :{ace}");
			return false;
		}
	}

	/// <summary>
	/// Checks if a place is able to be copied.
	/// </summary>
	/// <remarks>
	/// This is different check from the <see cref="M:Roblox.Platform.AssetPermissions.AssetPermissionsVerifier.IsCopyLocked(Roblox.Platform.Assets.IPlace)" /> extension method.
	/// The extension method checks if the place is able to be copied as a template to be created by a universe.
	/// This method checks the AssetOption to see if it can be copied as a place to be created by a user.
	/// </remarks>
	/// <param name="place">The <see cref="T:Roblox.Platform.Assets.IPlace" />.</param>
	/// <returns><c>true</c> if the place can be copied by a user.</returns>
	[ExcludeFromCodeCoverage]
	internal virtual bool IsCopyLocked(IPlace place)
	{
		return AssetOption.GetOrCreate(place.Id).IsCopyLocked;
	}
}
