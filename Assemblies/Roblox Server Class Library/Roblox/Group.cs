using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;

namespace Roblox;

[Serializable]
public class Group : ICreator, IRobloxEntity<long, GroupDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private GroupDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "Group", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		internal set
		{
			_EntityDAL.Name = value;
		}
	}

	public CreatorType CreatorType => CreatorType.Group;

	public long? AgentID
	{
		get
		{
			return _EntityDAL.AgentID;
		}
		set
		{
			_EntityDAL.AgentID = value;
		}
	}

	public long? OwnerUserID
	{
		get
		{
			return _EntityDAL.OwnerUserID;
		}
		set
		{
			_EntityDAL.OwnerUserID = value;
		}
	}

	public long PreviousOwnerUserID
	{
		get
		{
			return _EntityDAL.PreviousOwnerUserID;
		}
		set
		{
			_EntityDAL.PreviousOwnerUserID = value;
		}
	}

	public string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		internal set
		{
			_EntityDAL.Description = value;
		}
	}

	public long EmblemID
	{
		get
		{
			return _EntityDAL.EmblemID;
		}
		set
		{
			_EntityDAL.EmblemID = value;
		}
	}

	public bool PublicEntryAllowed
	{
		get
		{
			return _EntityDAL.PublicEntryAllowed;
		}
		set
		{
			_EntityDAL.PublicEntryAllowed = value;
		}
	}

	public bool BCOnlyJoin
	{
		get
		{
			return _EntityDAL.BCOnlyJoin;
		}
		set
		{
			_EntityDAL.BCOnlyJoin = value;
		}
	}

	public bool IsLocked
	{
		get
		{
			return _EntityDAL.IsLocked;
		}
		set
		{
			_EntityDAL.IsLocked = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public long GetAgentID()
	{
		return AgentID.Value;
	}

	public Group()
	{
		_EntityDAL = new GroupDAL();
	}

	public Group(GroupDAL entityDal)
	{
		_EntityDAL = entityDal;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Lock()
	{
		IsLocked = true;
		Save();
	}

	public void Unlock()
	{
		IsLocked = false;
		Save();
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static Group CreateNew(long ownerUserId, string name, string description, long emblemId, bool publicEntryAllowed, bool bcOnlyJoin)
	{
		Group entity = new Group
		{
			OwnerUserID = ownerUserId,
			PreviousOwnerUserID = ownerUserId,
			Name = name,
			Description = description,
			EmblemID = emblemId,
			PublicEntryAllowed = publicEntryAllowed,
			BCOnlyJoin = bcOnlyJoin,
			IsLocked = false
		};
		entity.Save();
		try
		{
			long agentId = User.UsersClient.GetOrCreateGroupAgentId(entity.ID);
			entity.AgentID = agentId;
			entity.Save();
			return entity;
		}
		catch (Exception)
		{
			entity.Delete();
			throw;
		}
	}

	public static Group Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static Group Get(long id)
	{
		return EntityHelper.GetEntity<long, GroupDAL, Group>(EntityCacheInfo, id, () => GroupDAL.Get(id));
	}

	public static Group Get(string name)
	{
		return EntityHelper.GetEntityByLookup<long, GroupDAL, Group>(EntityCacheInfo, name, () => GroupDAL.Get(name));
	}

	public static Group MustGet(long id)
	{
		return EntityHelper.MustGet(id, Get);
	}

	private ICollection<Asset> GetPlaces(int startRowIndex, int maximumRows)
	{
		return Asset.GetAssetsByTypeAndUserIDPaged(AssetType.PlaceID, AgentID.Value, CreatorType.Group, startRowIndex, maximumRows);
	}

	public Asset GetPlace()
	{
		List<Asset> places = (List<Asset>)GetPlaces(0, GroupManagementProperties.maximumNumberOfPlacesPerGroup);
		if (places == null || places.Count == 0)
		{
			return null;
		}
		return places[0];
	}

	public Asset GetEmblem()
	{
		return Asset.MustGet(EmblemID);
	}

	public bool HasPlace()
	{
		return Asset.GetTotalNumberOfAssetsByTypeAndAgentID(AssetType.PlaceID, AgentID.Value, CreatorType.Group) > 0;
	}

	public bool HasFeature(byte groupFeatureTypeId)
	{
		return GroupFeature.Get(ID, groupFeatureTypeId) != null;
	}

	public void AddFeature(byte groupFeatureTypeId)
	{
		if (!HasFeature(groupFeatureTypeId))
		{
			GroupFeature.CreateNew(ID, groupFeatureTypeId);
		}
	}

	public void RemoveFeature(byte groupFeatureTypeId)
	{
		if (HasFeature(groupFeatureTypeId))
		{
			GroupFeature.Get(ID, groupFeatureTypeId).Delete();
		}
	}

	public bool Equals(Group other)
	{
		if (other == null)
		{
			return false;
		}
		return ID == other.ID;
	}

	public void Construct(GroupDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return Name;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
