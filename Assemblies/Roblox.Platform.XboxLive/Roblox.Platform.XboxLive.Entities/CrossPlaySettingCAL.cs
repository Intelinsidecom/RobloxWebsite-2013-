using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.XboxLive.Entities;

internal class CrossPlaySettingCAL : IRobloxEntity<long, CrossPlaySettingDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private CrossPlaySettingDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(CrossPlaySettingCAL).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long UserId
	{
		get
		{
			return _EntityDAL.UserId;
		}
		set
		{
			_EntityDAL.UserId = value;
		}
	}

	internal bool IsEnabled
	{
		get
		{
			return _EntityDAL.IsEnabled;
		}
		set
		{
			_EntityDAL.IsEnabled = value;
		}
	}

	internal DateTime Created
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

	internal DateTime Updated
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

	public CrossPlaySettingCAL()
	{
		_EntityDAL = new CrossPlaySettingDAL();
	}

	public CrossPlaySettingCAL(CrossPlaySettingDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static CrossPlaySettingCAL Get(long id)
	{
		return EntityHelper.GetEntity<long, CrossPlaySettingDAL, CrossPlaySettingCAL>(EntityCacheInfo, id, () => CrossPlaySettingDAL.Get(id));
	}

	private static ICollection<CrossPlaySettingCAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, CrossPlaySettingDAL, CrossPlaySettingCAL>(ids, EntityCacheInfo, CrossPlaySettingDAL.MultiGet);
	}

	public static CrossPlaySettingCAL GetByUserId(long userId)
	{
		return EntityHelper.GetEntityByLookup<long, CrossPlaySettingDAL, CrossPlaySettingCAL>(EntityCacheInfo, GetLookupCacheKeysByUserID(userId), () => CrossPlaySettingDAL.GetCrossPlaySettingByUserId(userId));
	}

	public void Construct(CrossPlaySettingDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByUserID(UserId);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByUserID(long userId)
	{
		return $"UserID:{userId}";
	}
}
