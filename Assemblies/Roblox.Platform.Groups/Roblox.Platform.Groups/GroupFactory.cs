using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Groups.Entities;
using Roblox.Platform.Groups.Implementation;

namespace Roblox.Platform.Groups;

public class GroupFactory : IGroupFactory
{
	private readonly GroupDomainFactories _DomainFactories;

	internal GroupFactory(GroupDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		_DomainFactories = domainFactories;
	}

	public IGroup GetById(long groupId, bool invalidIdThrows = true, bool shouldReturnLockedGroups = true)
	{
		if (groupId <= 0)
		{
			if (invalidIdThrows)
			{
				throw new UnknownGroupException(groupId);
			}
			return null;
		}
		IGroupEntity groupEntity = _DomainFactories.GroupEntityFactory.GetById(groupId);
		if (groupEntity == null)
		{
			return null;
		}
		IGroup group = Translate(groupEntity);
		if (!shouldReturnLockedGroups && group != null && group.IsLocked())
		{
			return null;
		}
		return group;
	}

	public IGroup CheckedGetById(long groupId)
	{
		IGroupEntity groupEntity = _DomainFactories.GroupEntityFactory.GetById(groupId);
		if (groupEntity == null)
		{
			throw new UnknownGroupException(groupId);
		}
		return Translate(groupEntity);
	}

	public IGroup GetByName(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			return null;
		}
		IGroupEntity groupEntity = _DomainFactories.GroupEntityFactory.GetByName(name);
		if (groupEntity == null)
		{
			return null;
		}
		return Translate(groupEntity);
	}

	private IGroup Translate(IGroupEntity groupEntity)
	{
		IGroupFeatureEntity clanFeature = _DomainFactories.GroupFeatureEntityFactory.GetGroupFeatureEntityByGroupIdAndFeatureTypeId(groupEntity.Id, GroupFeatureType.ClanID);
		return new Group(groupEntity, clanFeature != null, _DomainFactories);
	}

	private byte GetRelationshipTypeId(Roblox.Platform.Groups.Implementation.GroupRelationshipType type)
	{
		return type switch
		{
			Roblox.Platform.Groups.Implementation.GroupRelationshipType.Ally => GroupRelationshipType.AllyID, 
			Roblox.Platform.Groups.Implementation.GroupRelationshipType.Enemy => GroupRelationshipType.EnemyID, 
			_ => throw new NotImplementedException("Unsupported group relationship ID"), 
		};
	}

	public IEnumerable<IGroup> GetRelatedGroups(long groupId, Roblox.Platform.Groups.Implementation.GroupRelationshipType relationshipType, int startRow, int maxRows)
	{
		return from relationship in GroupRelationship.GetGroupRelationshipsByGroupIDAndTypeIDPaged(groupId, GetRelationshipTypeId(relationshipType), startRow, maxRows)
			select GetById(relationship.RelatedGroupID);
	}

	public int GetTotalRelatedGroups(long groupId, Roblox.Platform.Groups.Implementation.GroupRelationshipType relationshipType)
	{
		return GroupRelationship.GetTotalNumberOfGroupRelationshipsByGroupIDAndTypeID(groupId, GetRelationshipTypeId(relationshipType));
	}

	public IEnumerable<IGroup> GetGroupRelationshipRequests(long groupId, Roblox.Platform.Groups.Implementation.GroupRelationshipType relationshipType, int startRow, int maxRows)
	{
		return from relationship in GroupRelationshipRequest.GetGroupRelationshipRequestsByGroupIDAndTypeIDPaged(groupId, GetRelationshipTypeId(relationshipType), startRow, maxRows)
			select GetById(relationship.RelatedGroupID);
	}

	public int GetTotalGroupRelationshipRequests(long groupId, Roblox.Platform.Groups.Implementation.GroupRelationshipType relationshipType)
	{
		return GroupRelationshipRequest.GetTotalNumberOfGroupRelationshipRequestsByGroupIDAndTypeID(groupId, GetRelationshipTypeId(relationshipType));
	}
}
