using System;
using Roblox.Permissions.Client;

namespace Roblox.Platform.Permissions.Core;

public class CustomListFactory : ICustomListFactory
{
	private readonly IPermissionsClient _PermissionsApiClient;

	/// <summary>
	/// Constructor for <see cref="T:Roblox.Platform.Permissions.Core.CustomListFactory" />
	/// </summary>
	/// <param name="permissionsApiClient">An <see cref="T:Roblox.Permissions.Client.IPermissionsClient" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="permissionsApiClient" /></exception>
	public CustomListFactory(IPermissionsClient permissionsApiClient)
	{
		_PermissionsApiClient = permissionsApiClient ?? throw new ArgumentNullException("permissionsApiClient");
	}

	/// <inheritdoc />
	public ICustomList CheckedGetCustomList(long? id)
	{
		ICustomList customList = GetCustomList(id);
		customList.VerifyIsNotNull();
		return customList;
	}

	/// <inheritdoc />
	public ICustomList GetCustomList(long? id)
	{
		if (!id.HasValue)
		{
			return null;
		}
		return _PermissionsApiClient.GetList(id.Value).Translate(_PermissionsApiClient);
	}

	/// <inheritdoc />
	public ICustomList CreateList(string listName, long creatorId, string creatorType)
	{
		return _PermissionsApiClient.CreateList(listName, creatorId, creatorType).Translate(_PermissionsApiClient);
	}
}
