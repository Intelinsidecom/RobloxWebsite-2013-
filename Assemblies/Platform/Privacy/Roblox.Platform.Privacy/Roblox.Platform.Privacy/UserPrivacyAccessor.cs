using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Roblox.ApiClientBase;
using Roblox.EventLog;
using Roblox.Locking;
using Roblox.Permissions.Client;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Privacy.Properties;

namespace Roblox.Platform.Privacy;

internal class UserPrivacyAccessor : IUserPrivacyAccessor
{
	private const string _CreatorType = "User";

	private readonly IPermissionGroupFactory _PermissionGroupFactory;

	private readonly IPermissionsClient _PermissionsClient;

	private readonly ILogger _Logger;

	private readonly ISettings _Settings;

	private readonly ILeasedLockFactory _LeasedLockFactory;

	private const string _LockKeyPrefix = "Roblox.Platform.Privacy_UserPrivacyAccessor:";

	internal UserPrivacyAccessor(IPermissionGroupFactory permissionGroupFactory, IPermissionsClient permissionsClient, ILogger logger, ISettings settings, ILeasedLockFactory leasedLockFactory)
	{
		_PermissionGroupFactory = permissionGroupFactory ?? throw new ArgumentNullException("permissionGroupFactory");
		_PermissionsClient = permissionsClient ?? throw new ArgumentNullException("permissionsClient");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_LeasedLockFactory = leasedLockFactory ?? throw new ArgumentNullException("leasedLockFactory");
	}

	internal virtual IPermissionGroup GetOrCreateUserPrivacySettingWithDefault(UserPrivacySettingType settingType, IUser user, UserPrivacyLevelType defaultPrivacyLevel)
	{
		IPermissionGroup permissionGroup = GetPermissionGroupForUserPrivacySetting(settingType, user.Id);
		if (permissionGroup != null)
		{
			return permissionGroup;
		}
		if (!_Settings.IsLeasedLockForGetOrCreateUserPrivacySettingEnabled)
		{
			SetPrivacyLevelForUserPrivacySetting(new UserPrivacySettingBase(settingType, user, defaultPrivacyLevel));
			permissionGroup = GetPermissionGroupForUserPrivacySetting(settingType, user.Id);
			if (permissionGroup == null)
			{
				_Logger.Error($"Permission Group for user {user.Id} of type {settingType.ToString()} settings type and privacy level {defaultPrivacyLevel.ToString()} is not available");
			}
		}
		else
		{
			using ILeasedLock leasedLock = _LeasedLockFactory.CreateLeasedLock("Roblox.Platform.Privacy_UserPrivacyAccessor:" + user.Id, _Settings.LeasedLockForGetOrCreateUserPrivacySettingTimeSpan);
			permissionGroup = GetPermissionGroupForUserPrivacySetting(settingType, user.Id);
			if (permissionGroup != null)
			{
				return permissionGroup;
			}
			if (leasedLock.IsLockAcquired)
			{
				SetPrivacyLevelForUserPrivacySetting(new UserPrivacySettingBase(settingType, user, defaultPrivacyLevel));
				permissionGroup = GetPermissionGroupForUserPrivacySetting(settingType, user.Id);
				if (permissionGroup == null)
				{
					_Logger.Error($"Permission Group for user {user.Id} of {settingType.ToString()} settings type and {defaultPrivacyLevel.ToString()} privacy level is not available");
				}
			}
			else
			{
				_Logger.Error($"GerOrCreate LeasedLock not acquired, Permission Group for user {user.Id} of {settingType.ToString()} type and {defaultPrivacyLevel.ToString()} privacy level unavailable");
			}
		}
		return permissionGroup;
	}

	/// <summary>
	/// If permission level is the obsolete <see cref="F:Roblox.Platform.Privacy.UserPrivacyLevelType.AllAuthenticatedUsers" />, the permission level will be migrated to <see cref="F:Roblox.Platform.Privacy.UserPrivacyLevelType.AllUsers" />   
	///
	/// Internal implementation note: this method only uses the first page of permissions in the permission group
	/// </summary>
	public IUserPrivacySetting GetOrCreatePrivacyLevelForUserPrivacySetting(UserPrivacySettingType settingType, IUser user, UserPrivacyLevelType defaultPrivacyLevel)
	{
		if (user == null)
		{
			throw new ArgumentNullException("Cannot lookup/create privacy setting for null user!");
		}
		IPermissionGroup permissionGroup = GetOrCreateUserPrivacySettingWithDefault(settingType, user, defaultPrivacyLevel);
		HashSet<string> hashSet = new HashSet<string>(from p in permissionGroup.GetPermissions(1).ToArray()
			select p.PermissionType);
		bool hasIsFriend = hashSet.Contains(PermissionType.IsFriend.ToString());
		bool hasIsFollower = hashSet.Contains(PermissionType.IsFollower.ToString());
		bool hasIsFollowedBy = hashSet.Contains(PermissionType.IsFollowedBy.ToString());
		bool hasNoOne = hashSet.Contains(PermissionType.NoOne.ToString());
		if (hashSet.Contains(PermissionType.AllUsers.ToString()))
		{
			if (!hasIsFriend && !hasIsFollower && !hasIsFollowedBy && !hasNoOne)
			{
				return new UserPrivacySettingBase(settingType, user, UserPrivacyLevelType.AllUsers);
			}
		}
		else if (hasNoOne)
		{
			if (!hasIsFriend && !hasIsFollower && !hasIsFollowedBy)
			{
				return new UserPrivacySettingBase(settingType, user, UserPrivacyLevelType.NoOne);
			}
		}
		else if (hasIsFriend)
		{
			if (hasIsFollowedBy)
			{
				return new UserPrivacySettingBase(settingType, user, hasIsFollower ? UserPrivacyLevelType.FriendsFollowingAndFollowers : UserPrivacyLevelType.FriendsAndFollowing);
			}
			if (!hasIsFollower)
			{
				return new UserPrivacySettingBase(settingType, user, UserPrivacyLevelType.Friends);
			}
		}
		DeletePermissionGroup(settingType, permissionGroup, user.Id);
		UserPrivacySettingBase newSetting = new UserPrivacySettingBase(settingType, user, defaultPrivacyLevel);
		SetPrivacyLevelForUserPrivacySetting(newSetting);
		return newSetting;
	}

	public virtual void SetPrivacyLevelForUserPrivacySetting(IUserPrivacySetting newSetting)
	{
		IPermissionGroup permissionGroup = GetPermissionGroupForUserPrivacySetting(newSetting.SettingType, newSetting.User.Id);
		IPermission[] permissions = new IPermission[0];
		if (permissionGroup == null)
		{
			permissionGroup = CreatePermissionGroupForUserPrivacySetting(newSetting.SettingType, newSetting.User.Id);
		}
		else
		{
			permissions = permissionGroup.GetPermissions(1).ToArray();
		}
		HashSet<string> permissionsHashSet = new HashSet<string>(permissions.Select((IPermission p) => p.PermissionType));
		switch (newSetting.PrivacyLevel)
		{
		case UserPrivacyLevelType.NoOne:
		{
			List<PermissionType> permsToSet = new List<PermissionType> { PermissionType.NoOne };
			SetPermissionsInPermissionGroupExclusively(permissionGroup, permissionsHashSet, newSetting.User.Id, permsToSet);
			break;
		}
		case UserPrivacyLevelType.Friends:
		{
			List<PermissionType> permsToSet = new List<PermissionType> { PermissionType.IsFriend };
			SetPermissionsInPermissionGroupExclusively(permissionGroup, permissionsHashSet, newSetting.User.Id, permsToSet);
			break;
		}
		case UserPrivacyLevelType.FriendsAndFollowing:
		{
			List<PermissionType> permsToSet = new List<PermissionType>
			{
				PermissionType.IsFriend,
				PermissionType.IsFollowedBy
			};
			SetPermissionsInPermissionGroupExclusively(permissionGroup, permissionsHashSet, newSetting.User.Id, permsToSet);
			break;
		}
		case UserPrivacyLevelType.FriendsFollowingAndFollowers:
		{
			List<PermissionType> permsToSet = new List<PermissionType>
			{
				PermissionType.IsFriend,
				PermissionType.IsFollowedBy,
				PermissionType.IsFollower
			};
			SetPermissionsInPermissionGroupExclusively(permissionGroup, permissionsHashSet, newSetting.User.Id, permsToSet);
			break;
		}
		case UserPrivacyLevelType.AllUsers:
		{
			List<PermissionType> permsToSet = new List<PermissionType> { PermissionType.AllUsers };
			SetPermissionsInPermissionGroupExclusively(permissionGroup, permissionsHashSet, newSetting.User.Id, permsToSet);
			break;
		}
		case UserPrivacyLevelType.AllAuthenticatedUsers:
			break;
		}
	}

	internal virtual void SetPermissionsInPermissionGroupExclusively(IPermissionGroup group, ICollection<string> existingPermissions, long targetUserId, IEnumerable<PermissionType> permissionsToSet)
	{
		foreach (PermissionType permission in Enum.GetValues(typeof(PermissionType)).Cast<PermissionType>())
		{
			string permissionTypeString2 = permission.ToString();
			if (!permissionsToSet.Contains(permission) && existingPermissions.Contains(permissionTypeString2))
			{
				group.RemovePermission(allowAccess: true, permissionTypeString2, targetUserId);
			}
		}
		foreach (PermissionType item in permissionsToSet)
		{
			string permissionTypeString = item.ToString();
			if (!existingPermissions.Contains(permissionTypeString))
			{
				group.AddPermission(allowAccess: true, permissionTypeString, targetUserId);
			}
		}
	}

	internal virtual IPermissionGroup CreatePermissionGroupForUserPrivacySetting(UserPrivacySettingType privacySettingType, long targetUserId)
	{
		string privacySettingTypeString = privacySettingType.ToString();
		IPermissionGroup permissionGroup = _PermissionGroupFactory.CreatePermissionGroup(evaluateByAND: false, $"UserPrivacy:{privacySettingTypeString}", targetUserId, "User");
		_PermissionsClient.ApplyPermissionGroupToAction(privacySettingTypeString, permissionGroup.Id, targetUserId, "User", (long?)targetUserId);
		return permissionGroup;
	}

	internal virtual IPermissionGroup GetPermissionGroupForUserPrivacySetting(UserPrivacySettingType privacySettingType, long targetUserId)
	{
		List<IPermissionGroup> groups = _PermissionGroupFactory.GetPermissionGroupsByAction(privacySettingType.ToString(), targetUserId).ToList();
		if (!groups.Any())
		{
			return null;
		}
		if (groups.Count() == 1)
		{
			return groups.First();
		}
		long highestId = groups.Max((IPermissionGroup g) => g.Id);
		foreach (IPermissionGroup group in groups)
		{
			if (group.Id != highestId)
			{
				try
				{
					DeletePermissionGroup(privacySettingType, group, targetUserId);
				}
				catch (ApiClientException ex) when (ex.StatusCode == HttpStatusCode.Conflict)
				{
					_Logger.Info($"Unable to delete unused permission group (409) Conflict: {ex}");
				}
				catch (Exception e)
				{
					_Logger.Error($"Failed to delete unused permission group: {e}");
				}
			}
		}
		return groups.First((IPermissionGroup g) => g.Id == highestId);
	}

	internal virtual void DeletePermissionGroup(UserPrivacySettingType settingType, IPermissionGroup permissionGroup, long targetUserId)
	{
		_PermissionsClient.RemovePermissionGroupFromAction(settingType.ToString(), permissionGroup.Id, targetUserId, "User", (long?)targetUserId);
		permissionGroup.Delete();
	}
}
