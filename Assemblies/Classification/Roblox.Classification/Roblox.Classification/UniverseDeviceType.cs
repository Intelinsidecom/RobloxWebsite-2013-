using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Classification;

public class UniverseDeviceType : IRobloxEntity<long, UniverseDeviceTypeDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private UniverseDeviceTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(UniverseDeviceType).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long UniverseID
	{
		get
		{
			return _EntityDAL.UniverseID;
		}
		set
		{
			_EntityDAL.UniverseID = value;
		}
	}

	public long DeviceTypes
	{
		get
		{
			return _EntityDAL.DeviceTypes;
		}
		set
		{
			_EntityDAL.DeviceTypes = value;
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

	public UniverseDeviceType()
	{
		_EntityDAL = new UniverseDeviceTypeDAL();
	}

	public UniverseDeviceType(UniverseDeviceTypeDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	public void Save()
	{
		EntityHelper.SaveEntityWithRemoteCache(this, delegate
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

	public static UniverseDeviceType Get(long id)
	{
		return EntityHelper.GetEntity<long, UniverseDeviceTypeDAL, UniverseDeviceType>(EntityCacheInfo, id, () => UniverseDeviceTypeDAL.Get(id));
	}

	public static UniverseDeviceType GetOrCreate(long universeId)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<long, UniverseDeviceType>(EntityCacheInfo, $"UniverseID:{universeId}", () => DoGetOrCreate(universeId), Get);
	}

	public static UniverseDeviceType GetByUniverseID(long universeId)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<long, UniverseDeviceTypeDAL, UniverseDeviceType>(EntityCacheInfo, $"UniverseID:{universeId}", () => UniverseDeviceTypeDAL.GetUniverseDeviceTypeByUniverseID(universeId), Get);
	}

	private static UniverseDeviceType DoGetOrCreate(long universeId)
	{
		return EntityHelper.DoGetOrCreate<long, UniverseDeviceTypeDAL, UniverseDeviceType>(() => UniverseDeviceTypeDAL.GetOrCreateUniverseDeviceType(universeId));
	}

	public void Construct(UniverseDeviceTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"UniverseID:{UniverseID}";
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
