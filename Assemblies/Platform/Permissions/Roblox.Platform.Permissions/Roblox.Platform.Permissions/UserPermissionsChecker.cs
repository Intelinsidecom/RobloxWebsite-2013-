using System;
using System.Collections.Generic;
using Roblox.ApiClientBase;
using Roblox.EventLog;
using Roblox.Permissions.Client;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Permissions.Core.Properties;

namespace Roblox.Platform.Permissions;

internal class UserPermissionsChecker : IUserPermissionsChecker
{
	private readonly IPermissionsClient _PermissionsClient;

	private readonly IUserPermissionTestFactory _UserPermissionTestFactory;

	private readonly ILogger _Logger;

	private readonly ISettings _CoreSettings;

	public UserPermissionsChecker(IPermissionsClient permissionsClient, IUserPermissionTestFactory userPermissionTestFactory, ILogger logger, ISettings coreSettings)
	{
		_PermissionsClient = permissionsClient ?? throw new ArgumentNullException("permissionsClient");
		_UserPermissionTestFactory = userPermissionTestFactory ?? throw new ArgumentNullException("userPermissionTestFactory");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_CoreSettings = coreSettings ?? throw new ArgumentNullException("coreSettings");
	}

	/// <summary>
	/// Checks the permissions for a specific action.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> whose permissions are being checked, may be null.</param>
	/// <param name="action">The action.</param>
	/// <param name="targetId">The target id.</param>
	public PermissionsStatus DoCheckPermissions(IUser user, string action, long? targetId)
	{
		if (!_CoreSettings.PermissionsServiceEnabled)
		{
			return PermissionsStatus.Unavailable();
		}
		switch (action)
		{
		case "EnterSocialMediaInfo":
		case "ViewSocialMediaOnProfile":
		case "StoreOwnEmailAddress":
		case "StorePhoneNumber":
		case "UpdateOwnBirthday":
		case "UploadVideo":
		case "SignupForDevEx":
		{
			IUserPermissionTest permissionTest = _UserPermissionTestFactory.GetIsCoppaAdultAndNotGdprChildTest(user);
			if (permissionTest.Test())
			{
				return PermissionsStatus.Success();
			}
			return PermissionsStatus.Failure(permissionTest.PermissionType);
		}
		case "BeInGdprJurisdiction":
		{
			IUserPermissionTest permissionTest = _UserPermissionTestFactory.GetIsInGdprJurisdictionTest(user);
			if (permissionTest.Test())
			{
				return PermissionsStatus.Success();
			}
			return PermissionsStatus.Failure(permissionTest.PermissionType);
		}
		default:
		{
			bool isAllowed = true;
			PermissionType? permissionFailureType = null;
			try
			{
				ICollection<PermissionGroup> permissionGroups = _PermissionsClient.GetPermissions(action, targetId);
				foreach (PermissionGroup permissionGroup in permissionGroups)
				{
					foreach (Permission permissionDefinition in permissionGroup.Permissions)
					{
						IUserPermissionTest permissionTest = _UserPermissionTestFactory.GetPermissionTest((IPermission)(object)permissionDefinition, user, targetId);
						if (permissionTest != null)
						{
							isAllowed = (permissionTest.Test() ? permissionDefinition.AllowAccess : (!permissionDefinition.AllowAccess));
							if (!isAllowed)
							{
								permissionFailureType = permissionFailureType ?? permissionTest.PermissionType;
							}
							if ((isAllowed && !permissionGroup.EvaluateByAND) || (!isAllowed && permissionGroup.EvaluateByAND))
							{
								break;
							}
						}
					}
					if (isAllowed)
					{
						return PermissionsStatus.Success();
					}
				}
				if (permissionGroups.Count == 0)
				{
					return PermissionsStatus.Success();
				}
			}
			catch (ApiClientException ex)
			{
				_Logger.Error(ex);
				return PermissionsStatus.Unavailable();
			}
			return PermissionsStatus.Failure(permissionFailureType.Value);
		}
		}
	}
}
