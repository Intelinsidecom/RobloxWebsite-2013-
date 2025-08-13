using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class GroupFeature : IRobloxEntity<long, GroupFeatureDAL>, ICacheableObject<long>, ICacheableObject
{
	private GroupFeatureDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.GroupFeature", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long GroupID
	{
		get
		{
			return _EntityDAL.GroupID;
		}
		set
		{
			_EntityDAL.GroupID = value;
		}
	}

	public byte GroupFeatureTypeID
	{
		get
		{
			return _EntityDAL.GroupFeatureTypeID;
		}
		set
		{
			_EntityDAL.GroupFeatureTypeID = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public GroupFeature()
	{
		_EntityDAL = new GroupFeatureDAL();
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
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

	public static GroupFeature CreateNew(long groupid, byte groupfeaturetypeid)
	{
		GroupFeature groupFeature = new GroupFeature();
		groupFeature.GroupID = groupid;
		groupFeature.GroupFeatureTypeID = groupfeaturetypeid;
		groupFeature.Save();
		return groupFeature;
	}

	public static GroupFeature Get(long id)
	{
		return EntityHelper.GetEntity<long, GroupFeatureDAL, GroupFeature>(EntityCacheInfo, id, () => GroupFeatureDAL.Get(id));
	}

	public static GroupFeature Get(long groupId, byte groupFeatureTypeId)
	{
		return EntityHelper.GetEntityByLookup<long, GroupFeatureDAL, GroupFeature>(EntityCacheInfo, $"GroupID:{groupId}_GroupFeatureTypeID:{groupFeatureTypeId}", () => GroupFeatureDAL.Get(groupId, groupFeatureTypeId));
	}

	public static ICollection<GroupFeature> GetGroupFeaturesByGroupID_Paged(long groupId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetGroupFeaturesByGroupID_Paged_GroupID:{groupId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupFeatureDAL.GetGroupFeatureIDsByGroupID_Paged(groupId, startRowIndex + 1, maximumRows), Get);
	}

	public void Construct(GroupFeatureDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"GroupID:{GroupID}_GroupFeatureTypeID:{GroupFeatureTypeID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"GroupID:{GroupID}");
	}
}
