using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

[Obsolete("Should use Roblox.Platform.Assets. This entity is going to be deleted.")]
public class AssetCounter : IRobloxEntity<long, AssetCounterDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AssetCounterDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "AssetCounter", isNullCacheable: true);

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

	public byte AssetCounterTypeID
	{
		get
		{
			return _EntityDAL.AssetCounterTypeID;
		}
		set
		{
			_EntityDAL.AssetCounterTypeID = value;
		}
	}

	public long Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AssetCounter()
	{
		_EntityDAL = new AssetCounterDAL();
	}

	public AssetCounter(AssetCounterDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	public void Increment()
	{
		Increment(1L);
	}

	public void Increment(long amount)
	{
		if (amount != 0L)
		{
			_EntityDAL.Increment(amount);
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
		}
	}

	public void Decrement()
	{
		Decrement(1L);
	}

	public void Decrement(long amount)
	{
		if (amount != 0L)
		{
			_EntityDAL.Decrement(amount);
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
		}
	}

	private static AssetCounter DoGetOrCreate(long assetId, byte assetCounterTypeId)
	{
		return EntityHelper.DoGetOrCreate<long, AssetCounterDAL, AssetCounter>(() => AssetCounterDAL.GetOrCreate(assetId, assetCounterTypeId));
	}

	public static AssetCounter GetOrCreate(long assetId, byte assetCounterTypeId)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<long, AssetCounter>(EntityCacheInfo, $"AssetID:{assetId}_AssetCounterTypeID:{assetCounterTypeId}", () => DoGetOrCreate(assetId, assetCounterTypeId), Get);
	}

	public static AssetCounter GetOrCreate(long assetId, byte assetCounterTypeId, Action<AssetCounter> onCreateHandler)
	{
		if (onCreateHandler == null)
		{
			return GetOrCreate(assetId, assetCounterTypeId);
		}
		bool created = false;
		AssetCounter entity = EntityHelper.GetOrCreateEntityWithRemoteCache<long, AssetCounter>(EntityCacheInfo, $"AssetID:{assetId}_AssetCounterTypeID:{assetCounterTypeId}", () => EntityHelper.DoGetOrCreate<long, AssetCounterDAL, AssetCounter>(delegate
		{
			EntityHelper.GetOrCreateDALWrapper<AssetCounterDAL> orCreate = AssetCounterDAL.GetOrCreate(assetId, assetCounterTypeId);
			created = orCreate.CreatedNewEntity;
			return orCreate;
		}), Get);
		if (created)
		{
			onCreateHandler(entity);
		}
		return entity;
	}

	public static AssetCounter Get(long id)
	{
		return EntityHelper.GetEntity<long, AssetCounterDAL, AssetCounter>(EntityCacheInfo, id, () => AssetCounterDAL.Get(id));
	}

	public void Construct(AssetCounterDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"AssetID:{AssetID}_AssetCounterTypeID:{AssetCounterTypeID}";
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
