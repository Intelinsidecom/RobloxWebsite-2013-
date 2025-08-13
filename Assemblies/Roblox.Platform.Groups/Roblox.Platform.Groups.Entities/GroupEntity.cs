using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Groups.Entities;

[ExcludeFromCodeCoverage]
internal class GroupEntity : IGroupEntity, IUpdateableEntity<long>, IEntity<long>
{
	private readonly Roblox.Group _DBEntity;

	public long Id => _DBEntity.ID;

	public DateTime Created => _DBEntity.Created;

	public DateTime Updated => _DBEntity.Updated;

	public long AgentId
	{
		get
		{
			return _DBEntity.AgentID.Value;
		}
		set
		{
			_DBEntity.AgentID = value;
		}
	}

	public long PreviousOwnerUserId
	{
		get
		{
			return _DBEntity.PreviousOwnerUserID;
		}
		set
		{
			_DBEntity.PreviousOwnerUserID = value;
		}
	}

	public long? OwnerUserId
	{
		get
		{
			return _DBEntity.OwnerUserID;
		}
		set
		{
			_DBEntity.OwnerUserID = value;
		}
	}

	public string Name
	{
		get
		{
			return _DBEntity.Name;
		}
		set
		{
			_DBEntity.Name = value;
		}
	}

	public long EmblemId
	{
		get
		{
			return _DBEntity.EmblemID;
		}
		set
		{
			_DBEntity.EmblemID = value;
		}
	}

	public bool PublicEntryAllowed
	{
		get
		{
			return _DBEntity.PublicEntryAllowed;
		}
		set
		{
			_DBEntity.PublicEntryAllowed = value;
		}
	}

	public bool BCOnly
	{
		get
		{
			return _DBEntity.BCOnlyJoin;
		}
		set
		{
			_DBEntity.BCOnlyJoin = value;
		}
	}

	public string Description
	{
		get
		{
			return _DBEntity.Description;
		}
		set
		{
			_DBEntity.Description = value;
		}
	}

	public GroupEntity(Roblox.Group dbEntity)
	{
		_DBEntity = dbEntity;
	}

	public void Update()
	{
		_DBEntity.Save();
	}

	public void Delete()
	{
		_DBEntity.Delete();
	}
}
