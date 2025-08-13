using System;
using Roblox.Agents;

namespace Roblox;

public struct CreatorRef : IEquatable<CreatorRef>
{
	private readonly long _AgentID;

	private readonly long _AssociatedEntityID;

	private readonly CreatorType _CreatorType;

	public long AgentID => _AgentID;

	public CreatorType CreatorType => _CreatorType;

	public static CreatorRef Empty => new CreatorRef(0L, 0L, (CreatorType)0);

	public long GetAssociatedEntityID()
	{
		if (IsEmpty())
		{
			throw new ApplicationException("Invalid agentId");
		}
		return _AssociatedEntityID;
	}

	public string GetCreatorUrl(string prepend = "~")
	{
		if (IsUserType())
		{
			return $"/users/{GetAssociatedEntityID()}/profile";
		}
		if (IsGroupType())
		{
			return $"/groups/group.aspx?gid={GetAssociatedEntityID()}";
		}
		return string.Empty;
	}

	public bool IsGroupType()
	{
		return _CreatorType == CreatorType.Group;
	}

	public bool IsUserType()
	{
		return _CreatorType == CreatorType.User;
	}

	public bool IsEmpty()
	{
		if (_AgentID == 0L && _AssociatedEntityID == 0L)
		{
			return _CreatorType == (CreatorType)0;
		}
		return false;
	}

	private CreatorRef(long agentId, long associatedEntityId, CreatorType creatorType)
	{
		_AgentID = agentId;
		_AssociatedEntityID = associatedEntityId;
		_CreatorType = creatorType;
	}

	public static CreatorRef CreateNewUserRef(long userId)
	{
		return new CreatorRef(userId, userId, CreatorType.User);
	}

	public static CreatorRef CreateNewGroupRef(long agentId, long groupId)
	{
		if (agentId == 0L)
		{
			throw new ApplicationException("Null agentId not accepted");
		}
		if (groupId == 0L)
		{
			throw new ApplicationException("Null groupId not accepted");
		}
		return new CreatorRef(agentId, groupId, CreatorType.Group);
	}

	public static CreatorRef CreateNewRefFromAgentId(long agentId)
	{
		IAgent agent = AgentFactory.MustGet(agentId);
		if (agent.AgentType == AgentType.User)
		{
			return CreateNewUserRef(agent.Id);
		}
		if (agent.AgentType == AgentType.Group)
		{
			return CreateNewGroupRef(agent.Id, agent.AgentTargetId);
		}
		throw new NotImplementedException("Invalid creator type.  AgentId: " + agentId);
	}

	public ICreator GetCreator()
	{
		return GetCreator(this);
	}

	public static ICreator GetCreator(CreatorRef creatorRef)
	{
		if (creatorRef.IsEmpty())
		{
			throw new ApplicationException("Invalid creatorRef object.");
		}
		return creatorRef.CreatorType switch
		{
			CreatorType.User => User.MustGet(creatorRef.GetAssociatedEntityID()), 
			CreatorType.Group => Group.MustGet(creatorRef.GetAssociatedEntityID()), 
			_ => throw new NotImplementedException("CreatorType not implemented."), 
		};
	}

	public override bool Equals(object o)
	{
		if (!(o is CreatorRef))
		{
			return false;
		}
		return Equals((CreatorRef)o);
	}

	public bool Equals(CreatorRef other)
	{
		return AgentID == other.AgentID;
	}

	public override int GetHashCode()
	{
		return AgentID.GetHashCode();
	}

	public bool IsReferenceTo(ICreator creator)
	{
		if (creator == null)
		{
			return false;
		}
		if (IsUserType())
		{
			return creator.ID == AgentID;
		}
		if (creator.CreatorType == CreatorType.Group)
		{
			return creator.ID == GetAssociatedEntityID();
		}
		return false;
	}
}
