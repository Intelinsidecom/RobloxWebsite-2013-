using System;
using System.Collections.Generic;
using Roblox.ApiClientBase;
using Roblox.EventLog;
using Roblox.Permissions.Client;
using Roblox.Platform.CallContext;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Permissions.Core.Properties;

namespace Roblox.Platform.Permissions;

public class PermissionsChecker : IPermissionsChecker
{
	private const string _LegacyTargetIdKey = "targetId";

	private readonly ICallContextFactory _CallContextFactory;

	private readonly IPermissionsClient _PermissionsClient;

	private readonly IPermissionTesterFactory _PermissionTesterFactory;

	private readonly ILogger _Logger;

	private readonly ISettings _CoreSettings;

	public PermissionsChecker(ICallContextFactory callContextFactory, IPermissionsClient permissionsClient, IPermissionTesterFactory permissionTesterFactory, ILogger logger)
		: this(callContextFactory, permissionsClient, permissionTesterFactory, logger, Settings.Default)
	{
	}

	internal PermissionsChecker(ICallContextFactory callContextFactory, IPermissionsClient permissionsClient, IPermissionTesterFactory permissionTesterFactory, ILogger logger, ISettings coreSettings)
	{
		_CallContextFactory = callContextFactory ?? throw new ArgumentNullException("callContextFactory");
		_PermissionsClient = permissionsClient ?? throw new ArgumentNullException("permissionsClient");
		_PermissionTesterFactory = permissionTesterFactory ?? throw new ArgumentNullException("permissionTesterFactory");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_CoreSettings = coreSettings ?? throw new ArgumentNullException("coreSettings");
	}

	public PermissionsStatus CheckPermissions(string action, IDictionary<string, object> actionParams)
	{
		if (!_CoreSettings.PermissionsServiceEnabled)
		{
			return PermissionsStatus.Unavailable();
		}
		ICallContext callContext = _CallContextFactory.GetCallContext();
		if (callContext == null)
		{
			throw new NotSupportedException("At minimum, ICallContext loader must produce empty dictionary.");
		}
		PermissionType? permissionFailureType = null;
		try
		{
			long? targetIdValue = null;
			if (actionParams != null)
			{
				actionParams.TryGetValue("targetId", out var targetIdObject);
				targetIdValue = targetIdObject as long?;
			}
			ICollection<PermissionGroup> permissionGroups = _PermissionsClient.GetPermissions(action, targetIdValue);
			if (IsNullOrEmpty(permissionGroups))
			{
				return PermissionsStatus.Success();
			}
			foreach (PermissionGroup permissionGroup in permissionGroups)
			{
				if (IsNullOrEmpty(permissionGroup.Permissions))
				{
					return PermissionsStatus.Success();
				}
				bool isAllowed = false;
				foreach (Permission permissionDefinition in permissionGroup.Permissions)
				{
					IPermissionTester permissionTester = _PermissionTesterFactory.GetPermissionTester((IPermission)(object)permissionDefinition);
					if (permissionTester == null)
					{
						permissionFailureType = PermissionType.PermissionTypeNotFoundError;
						_Logger.Error($"Error getting PermissionTester: PermissionType {GetPermissionTypeFromIPermission((IPermission)(object)permissionDefinition)} not found.");
						continue;
					}
					isAllowed = (permissionTester.Test(callContext, actionParams, null) ? permissionDefinition.AllowAccess : (!permissionDefinition.AllowAccess));
					if (!isAllowed)
					{
						permissionFailureType = permissionFailureType ?? GetPermissionTypeFromIPermission((IPermission)(object)permissionDefinition);
					}
					if ((!isAllowed || permissionGroup.EvaluateByAND) && (isAllowed || !permissionGroup.EvaluateByAND))
					{
						continue;
					}
					break;
				}
				if (isAllowed)
				{
					return PermissionsStatus.Success();
				}
			}
		}
		catch (ApiClientException ex)
		{
			_Logger.Error(ex);
			return PermissionsStatus.Unavailable();
		}
		return PermissionsStatus.Failure(permissionFailureType.Value);
	}

	internal static PermissionType? GetPermissionTypeFromIPermission(IPermission permissionDefinition)
	{
		if (!Enum.TryParse<PermissionType>(permissionDefinition.PermissionType, out var permissionType))
		{
			return null;
		}
		return permissionType;
	}

	private static bool IsNullOrEmpty<T>(ICollection<T> collection)
	{
		if (collection != null)
		{
			return collection.Count < 1;
		}
		return true;
	}
}
