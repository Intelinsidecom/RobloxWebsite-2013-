using System.Collections.Generic;
using System.Linq;
using Roblox.Permissions.Client;

namespace Roblox.Platform.Permissions.Core;

internal class CustomList : ICustomList
{
	private readonly IPermissionsClient _PermissionsApiClient;

	public long Id { get; }

	public string Name { get; private set; }

	public string CreatorType { get; }

	public long CreatorTargetId { get; }

	internal CustomList(IPermissionsClient permissionsApiClient, long id, string name, string creatorType, long creatorTargetId)
	{
		_PermissionsApiClient = permissionsApiClient;
		Id = id;
		Name = name;
		CreatorType = creatorType;
		CreatorTargetId = creatorTargetId;
	}

	public void AddMember(long userId)
	{
		_PermissionsApiClient.CreateListMember(Id, userId, CreatorTargetId, CreatorType);
	}

	public void Delete()
	{
		_PermissionsApiClient.DeleteList(Id, CreatorTargetId, CreatorType);
	}

	public IEnumerable<long> GetMembers(int page)
	{
		return _PermissionsApiClient.GetListMembers(Id, (int?)page).PageItems?.Select((long i) => i);
	}

	public IEnumerable<long> GetMembers(int page, out long count)
	{
		PageResult<long, long> listMembers = _PermissionsApiClient.GetListMembers(Id, (int?)page);
		count = listMembers.Count;
		return listMembers.PageItems?.Select((long i) => i);
	}

	public void RemoveMember(long userId)
	{
		_PermissionsApiClient.DeleteListMember(Id, userId, CreatorTargetId, CreatorType);
	}

	public void Update(string name)
	{
		_PermissionsApiClient.UpdateList(Id, name, CreatorTargetId, CreatorType);
		Name = name;
	}
}
