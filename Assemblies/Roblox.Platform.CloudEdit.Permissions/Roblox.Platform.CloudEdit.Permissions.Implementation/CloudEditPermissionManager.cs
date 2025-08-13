using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.ApiClientBase;
using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;
using Roblox.Permissions.Client;
using Roblox.Platform.CloudEdit.Permissions.Exceptions;
using Roblox.Platform.CloudEdit.Permissions.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Studio;
using Roblox.Platform.Universes;

namespace Roblox.Platform.CloudEdit.Permissions.Implementation;

internal class CloudEditPermissionManager : ICloudEditPermissionManager
{
	private const string _CloudEditActionType = "CloudEditor";

	private const string _IsInListPermissionType = "IsInList";

	private readonly IUniverse _Universe;

	private readonly IPermissionsClient _PermissionsClient;

	private readonly IPermissionGroupFactory _PermissionGroupFactory;

	private readonly ICustomListFactory _CustomListFactory;

	private readonly IUserPermissionsChecker _UserPermissionsChecker;

	private readonly IUniverseCloudEditStatusProvider _UniverseCloudEditStatusProvider;

	private readonly IUniversePermissionsVerifier _UniversePermissionsVerifier;

	protected virtual bool IsGlobalEnabled => Settings.Default.GlobalEnabled;

	protected virtual bool IsPublicBetaEnabled => Settings.Default.PublicBetaEnabled;

	protected virtual int MaxAdditionalEditorWhitelistSize => Settings.Default.MaxAdditionalEditorWhitelistSize;

	/// <inheritdoc cref="E:Roblox.Platform.CloudEdit.Permissions.ICloudEditPermissionManager.UserAddedToCloudEdit" />
	public event Action<IUniverse, IUser, IUser> UserAddedToCloudEdit;

	internal CloudEditPermissionManager(IUniverse universe, IPermissionsClient permissionsClient, IPermissionGroupFactory permissionGroupFactory, ICustomListFactory customListFactory, IUserPermissionsChecker userPermissionsChecker, IUniverseCloudEditStatusProvider universeCloudEditStatusProvider, IUniversePermissionsVerifier universePermissionsVerifier)
	{
		_Universe = universe;
		_PermissionsClient = permissionsClient;
		_PermissionGroupFactory = permissionGroupFactory;
		_CustomListFactory = customListFactory;
		_UserPermissionsChecker = userPermissionsChecker;
		_UniverseCloudEditStatusProvider = universeCloudEditStatusProvider;
		_UniversePermissionsVerifier = universePermissionsVerifier.AssignOrThrowIfNull("universePermissionsVerifier");
	}

	internal virtual bool IsUserSoothSayer(IUser user)
	{
		return user.IsSoothSayer();
	}

	internal virtual bool IsUserBetaTester(IUser user)
	{
		return user.IsBetaTester();
	}

	internal virtual bool CanUserManageUniverse(IUser user)
	{
		return _UniversePermissionsVerifier.CanUserManageUniverse(user, _Universe);
	}

	internal virtual PermissionsStatus CheckPermissionsForUser(IUser user)
	{
		return user.CheckPermissions(_UserPermissionsChecker, "CloudEditor", _Universe.Id);
	}

	public bool IsCloudEditEnabled()
	{
		try
		{
			return _UniverseCloudEditStatusProvider.IsCloudEditEnabled(_Universe.Id) ?? (GetPermissionGroup() != null);
		}
		catch (ApiClientException e)
		{
			throw new CloudEditPermissionsPlatformException(e);
		}
	}

	public void EnableForCloudEdit()
	{
		try
		{
			bool? isCloudEditEnabled = _UniverseCloudEditStatusProvider.IsCloudEditEnabled(_Universe.Id);
			if (!isCloudEditEnabled.HasValue || !isCloudEditEnabled.Value)
			{
				IPermissionGroup permissionGroup = GetPermissionGroup();
				if (permissionGroup == null)
				{
					long ownerId = _Universe.CreatorTargetId;
					string ownerType = _Universe.CreatorType;
					long permissionTargetId = _Universe.Id;
					string name = $"CloudEditor whitelist for {permissionTargetId}";
					permissionGroup = _PermissionGroupFactory.CreatePermissionGroup(evaluateByAND: false, name, ownerId, ownerType);
					_PermissionsClient.ApplyPermissionGroupToAction("CloudEditor", permissionGroup.Id, ownerId, ownerType, (long?)permissionTargetId);
					ICustomList customList = _CustomListFactory.CreateList(name, ownerId, ownerType);
					permissionGroup.AddPermission(allowAccess: true, "IsInList", customList.Id);
				}
				_UniverseCloudEditStatusProvider.UpdateCloudEditStatus(_Universe.Id, isCloudEditEnabled: true);
			}
		}
		catch (ApiClientException e)
		{
			throw new CloudEditPermissionsPlatformException(e);
		}
	}

	public void DisableForCloudEdit()
	{
		try
		{
			bool? isCloudEditEnabled = _UniverseCloudEditStatusProvider.IsCloudEditEnabled(_Universe.Id);
			if (!isCloudEditEnabled.HasValue || isCloudEditEnabled.Value)
			{
				_UniverseCloudEditStatusProvider.UpdateCloudEditStatus(_Universe.Id, isCloudEditEnabled: false);
			}
		}
		catch (ApiClientException e)
		{
			throw new CloudEditPermissionsPlatformException(e);
		}
	}

	public bool CanUserCloudEdit(IUser user)
	{
		try
		{
			if ((!IsPublicBetaEnabled && !IsGlobalEnabled) || user == null || !IsCloudEditEnabled())
			{
				return false;
			}
			if (!IsGlobalEnabled && IsPublicBetaEnabled && !IsUserSoothSayer(user) && !IsUserBetaTester(user))
			{
				return false;
			}
			if (CanUserManageUniverse(user))
			{
				return true;
			}
			PermissionsStatus permissionStatus = CheckPermissionsForUser(user);
			return permissionStatus.WasTested && permissionStatus.IsSuccess;
		}
		catch (ApiClientException e)
		{
			throw new CloudEditPermissionsPlatformException(e);
		}
	}

	public void AddUserToEditorsList(IUser user, IUser inviter)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (inviter == null)
		{
			throw new PlatformArgumentNullException("inviter");
		}
		IFloodChecker floodChecker = GetAddCloudEditorFloodChecker(inviter.Id, _Universe.Id);
		if (floodChecker.IsFlooded())
		{
			throw new PlatformFloodedException("User reached the execution limit for specified universe");
		}
		try
		{
			ICustomList whitelist = GetWhitelist();
			bool isUserAlreadyInList = false;
			int currentSize = 0;
			int previousSize = -1;
			int page = 1;
			while (currentSize != previousSize)
			{
				long[] members = whitelist.GetMembers(page).ToArray();
				if (members.Any((long m) => m == user.Id))
				{
					isUserAlreadyInList = true;
				}
				previousSize = currentSize;
				currentSize += members.Length;
				page++;
			}
			if (!isUserAlreadyInList)
			{
				if (currentSize >= MaxAdditionalEditorWhitelistSize)
				{
					throw new CloudEditPermissionsPlatformException("Adding user would exceed max cloud editor count");
				}
				whitelist.AddMember(user.Id);
				floodChecker.UpdateCount();
				this.UserAddedToCloudEdit?.Invoke(_Universe, inviter, user);
			}
		}
		catch (ApiClientException e)
		{
			throw new CloudEditPermissionsPlatformException(e);
		}
	}

	public void RemoveUserFromEditorsList(IUser user)
	{
		try
		{
			GetWhitelist().RemoveMember(user.Id);
		}
		catch (ApiClientException e)
		{
			throw new CloudEditPermissionsPlatformException(e);
		}
	}

	public IEnumerable<long> GetEditorsListPage(int page)
	{
		try
		{
			return GetWhitelist().GetMembers(page);
		}
		catch (ApiClientException e)
		{
			throw new CloudEditPermissionsPlatformException(e);
		}
	}

	protected virtual IFloodChecker GetAddCloudEditorFloodChecker(long inviterId, long universeId)
	{
		return new AddCloudEditorFloodChecker(inviterId, universeId);
	}

	private IPermissionGroup GetPermissionGroup()
	{
		IEnumerable<IPermissionGroup> permissionGroups = _PermissionGroupFactory.GetPermissionGroupsByAction("CloudEditor", _Universe.Id);
		if (!permissionGroups.Any())
		{
			return null;
		}
		if (permissionGroups.Count() > 1)
		{
			throw new CloudEditPermissionsPlatformException($"Multiple permission groups exist for universe {_Universe.Id}");
		}
		return permissionGroups.FirstOrDefault();
	}

	private ICustomList GetWhitelist()
	{
		bool? isCloudEditEnabled = _UniverseCloudEditStatusProvider.IsCloudEditEnabled(_Universe.Id);
		IPermissionGroup permissionGroup = GetPermissionGroup();
		if ((isCloudEditEnabled.HasValue && !isCloudEditEnabled.Value) || permissionGroup == null)
		{
			throw new CloudEditPermissionsPlatformException("CloudEdit not enabled");
		}
		IEnumerable<IPermission> permissions = permissionGroup.GetPermissions(1);
		if (!permissions.Any())
		{
			throw new CloudEditPermissionsPlatformException($"Empty permission group {permissionGroup.Id} for universe {_Universe.Id}");
		}
		if (permissions.Count() > 1)
		{
			throw new CloudEditPermissionsPlatformException($"Multiple permissions exist for universe {_Universe.Id} in permission group {permissionGroup.Id}");
		}
		IPermission permission = permissions.FirstOrDefault();
		if (permission.PermissionType != "IsInList")
		{
			throw new CloudEditPermissionsPlatformException("Permission not a whitelist");
		}
		return _CustomListFactory.GetCustomList(permission.PermissionTypeTargetId) ?? throw new CloudEditPermissionsPlatformException($"Could not load whitelist {permission.PermissionTypeTargetId} for permission {permission.Id}");
	}
}
