using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class GroupAssetCreator : IRobloxEntity<long, GroupAssetCreatorDAL>, ICacheableObject<long>, ICacheableObject
{
	private GroupAssetCreatorDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.GroupAssetCreator", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long AssetID
	{
		get
		{
			return _EntityDAL.AssetID;
		}
		set
		{
			_EntityDAL.AssetID = value;
		}
	}

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

	public long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
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

	public GroupAssetCreator()
	{
		_EntityDAL = new GroupAssetCreatorDAL();
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

	public static GroupAssetCreator CreateNew(long assetid, long groupid, long userid)
	{
		GroupAssetCreator groupAssetCreator = new GroupAssetCreator();
		groupAssetCreator.AssetID = assetid;
		groupAssetCreator.GroupID = groupid;
		groupAssetCreator.UserID = userid;
		groupAssetCreator.Save();
		return groupAssetCreator;
	}

	public static GroupAssetCreator Get(long id)
	{
		return EntityHelper.GetEntity<long, GroupAssetCreatorDAL, GroupAssetCreator>(EntityCacheInfo, id, () => GroupAssetCreatorDAL.Get(id));
	}

	public static GroupAssetCreator GetByAssetID(long assetId)
	{
		return EntityHelper.GetEntityByLookup<long, GroupAssetCreatorDAL, GroupAssetCreator>(EntityCacheInfo, $"AssetID:{assetId}", () => GroupAssetCreatorDAL.GetByAssetID(assetId));
	}

	public void Construct(GroupAssetCreatorDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AssetID:{AssetID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
