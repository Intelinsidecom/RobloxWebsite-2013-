using System;
using System.Collections.Generic;
using Roblox.Permissions.Client;
using Roblox.Platform.Permissions.Core;

namespace Roblox.Platform.Permissions;

public class PermissionTesterFactory : IPermissionTesterFactory
{
	private readonly Dictionary<PermissionType, Func<IPermissionTester>> _PermissionTestersDictionary;

	public PermissionTesterFactory()
	{
		_PermissionTestersDictionary = new Dictionary<PermissionType, Func<IPermissionTester>>();
	}

	public void Register(PermissionType permissionType, Func<IPermissionTester> permissionTester)
	{
		if (permissionTester == null)
		{
			throw new ArgumentNullException("permissionTester");
		}
		try
		{
			_PermissionTestersDictionary.Add(permissionType, permissionTester);
		}
		catch (ArgumentException e)
		{
			throw new ArgumentException($"PermissionType {permissionType} is already registered.", e);
		}
	}

	private IPermissionTester DoGetPermissionTester(IPermission permissionDefinition)
	{
		if (!Enum.TryParse<PermissionType>(permissionDefinition.PermissionType, out var permissionType))
		{
			return null;
		}
		if (_PermissionTestersDictionary.TryGetValue(permissionType, out var permissionTester))
		{
			return permissionTester();
		}
		return null;
	}

	public IPermissionTester GetPermissionTester(IPermission permissionDefinition)
	{
		return DoGetPermissionTester(permissionDefinition);
	}
}
