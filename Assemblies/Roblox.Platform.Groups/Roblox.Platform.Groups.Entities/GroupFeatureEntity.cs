using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Groups.Entities;

[ExcludeFromCodeCoverage]
internal class GroupFeatureEntity : IGroupFeatureEntity, IUpdateableEntity<long>, IEntity<long>
{
	private readonly GroupFeature _DbEntity;

	public long Id => _DbEntity.ID;

	public DateTime Created => _DbEntity.Created;

	public DateTime Updated => _DbEntity.Updated;

	public long GroupId
	{
		get
		{
			return _DbEntity.GroupID;
		}
		set
		{
			_DbEntity.GroupID = value;
		}
	}

	public byte GroupFeatureTypeId
	{
		get
		{
			return _DbEntity.GroupFeatureTypeID;
		}
		set
		{
			_DbEntity.GroupFeatureTypeID = value;
		}
	}

	internal GroupFeatureEntity(GroupFeature dbEntity)
	{
		_DbEntity = dbEntity;
	}

	public void Update()
	{
		_DbEntity.Save();
	}

	public void Delete()
	{
		_DbEntity.Delete();
	}
}
