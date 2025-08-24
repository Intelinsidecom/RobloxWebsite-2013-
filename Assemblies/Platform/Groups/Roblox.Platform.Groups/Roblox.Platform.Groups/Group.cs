using System;
using Roblox.Platform.Groups.Entities;
using Roblox.Platform.Groups.Entities.GroupRoleSets;
using Roblox.Platform.Groups.Events;
using Roblox.Platform.Membership;
using Roblox.Users.Properties;

namespace Roblox.Platform.Groups;

public class Group : IGroup
{
	private bool? _IsLocked;

	public long Id { get; private set; }

	public long AgentId { get; private set; }

	public long? PreviousOwnerUserId { get; private set; }

	public long? OwnerUserId { get; private set; }

	public string Name { get; set; }

	public long EmblemId { get; private set; }

	public bool PublicEntryAllowed { get; private set; }

	public bool BCOnly { get; private set; }

	public bool HasClan { get; private set; }

	public DateTime Created { get; private set; }

	public DateTime Updated { get; private set; }

	public string Description { get; set; }

	public GroupDomainFactories DomainFactories { get; }

	private int _RobloxUserId => Settings.Default.RobloxUserId;

	internal Group(long id, long agentId, long? ownerUserId, long? previousOwnerUserId, string name, long emblemId, bool hasClan, DateTime created, DateTime updated, string description, bool publicEntryAllowed, bool bcOnly, GroupDomainFactories domainFactories)
	{
		Id = id;
		AgentId = agentId;
		OwnerUserId = ownerUserId;
		PreviousOwnerUserId = previousOwnerUserId;
		Name = name;
		EmblemId = emblemId;
		HasClan = hasClan;
		Created = created;
		Updated = updated;
		Description = description;
		PublicEntryAllowed = publicEntryAllowed;
		BCOnly = bcOnly;
		DomainFactories = domainFactories;
	}

	internal Group(IGroupEntity groupEntity, bool hasClan, GroupDomainFactories domainFactories)
	{
		Id = groupEntity.Id;
		AgentId = groupEntity.AgentId;
		OwnerUserId = groupEntity.OwnerUserId;
		PreviousOwnerUserId = groupEntity.PreviousOwnerUserId;
		Name = groupEntity.Name;
		EmblemId = groupEntity.EmblemId;
		Created = groupEntity.Created;
		Updated = groupEntity.Updated;
		Description = groupEntity.Description;
		PublicEntryAllowed = groupEntity.PublicEntryAllowed;
		BCOnly = groupEntity.BCOnly;
		HasClan = hasClan;
		DomainFactories = domainFactories;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Groups.IGroup.IsLocked" />
	public bool IsLocked()
	{
		if (!_IsLocked.HasValue)
		{
			_IsLocked = Roblox.Group.Get(Id)?.IsLocked ?? false;
		}
		return _IsLocked.Value;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Groups.IGroup.Unlock(Roblox.Platform.Membership.IUser)" />
	public void Unlock(IUser user)
	{
		Roblox.Group dbEntity = Roblox.Group.Get(Id);
		if (dbEntity != null)
		{
			dbEntity.Unlock();
			GroupManagement.LogGroupAction(_RobloxUserId, Id, GroupActionType.Unlock.ID, new GroupManagement.InitiatorUserJson
			{
				InitiatorId = user.Id
			});
			_IsLocked = dbEntity.IsLocked;
		}
		DomainFactories.GroupEventPublisher.Publish(Id, GroupEventType.Updated, null);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Groups.IGroup.Lock(Roblox.Platform.Membership.IUser)" />
	public void Lock(IUser user)
	{
		Roblox.Group dbEntity = Roblox.Group.Get(Id);
		if (dbEntity != null)
		{
			dbEntity.Lock();
			GroupManagement.LogGroupAction(_RobloxUserId, Id, GroupActionType.Lock.ID, new GroupManagement.InitiatorUserJson
			{
				InitiatorId = user.Id
			});
			_IsLocked = dbEntity.IsLocked;
		}
		DomainFactories.GroupEventPublisher.Publish(Id, GroupEventType.Updated, null);
	}

	public IGroupRoleSet GetGroupRoleSetByUserId(IUser user)
	{
		IGroupRoleSetEntity groupRoleSetEntity = DomainFactories.GroupRoleSetEntityFactory.GetByGroupIdAndUserId(Id, user?.Id);
		return DomainFactories.GroupRoleSetAccessor_Internal.GetByEntity(groupRoleSetEntity);
	}
}
