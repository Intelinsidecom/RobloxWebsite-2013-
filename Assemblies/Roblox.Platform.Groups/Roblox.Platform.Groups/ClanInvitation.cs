using System;
using Roblox.Platform.Groups.Entities;

namespace Roblox.Platform.Groups;

public class ClanInvitation : IClanInvitation
{
	private readonly GroupDomainFactories _DomainFactories;

	public long Id { get; private set; }

	public long GroupId { get; private set; }

	public long UserId { get; private set; }

	public DateTime Created { get; private set; }

	public ClanInvitation(long id, long groupId, long userId, DateTime created, GroupDomainFactories domainFactories)
	{
		Id = id;
		GroupId = groupId;
		UserId = userId;
		Created = created;
		_DomainFactories = domainFactories;
	}

	public virtual void Accept()
	{
		IGroupMembership groupMembership = _DomainFactories.GroupMembershipFactory.CheckedGet(GroupId, UserId);
		groupMembership.VerifyIsNotNull();
		if (groupMembership.RoleSet.IsGuest())
		{
			throw new NotAGroupMemberException();
		}
		groupMembership.JoinClan();
		Delete();
	}

	public void Cancel(IGroupMembership groupAdmin)
	{
		if (!groupAdmin.HasPermission(GroupRoleSetPermissionType.CanManageClan))
		{
			throw new InsufficientPermissionsException();
		}
		Delete();
	}

	public virtual void Delete()
	{
		Roblox.Platform.Groups.Entities.ClanInvitation.Get(Id)?.Delete();
	}
}
