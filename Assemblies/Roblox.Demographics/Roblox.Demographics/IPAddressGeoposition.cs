using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.Data.Interfaces;
using Roblox.Demographics.Properties;

namespace Roblox.Demographics;

public class IPAddressGeoposition : IRobloxEntity<long, IPAddressGeopositionDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private IPAddressGeopositionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(IPAddressGeoposition).ToString(), isNullCacheable: true, null, new RemoteCachabilitySettings(Settings.Default.ToSingleSetting((Settings s) => s.MemcacheClusterGroupName)), new MigrationCacheabilitySettings(Settings.Default.ToSingleSetting((Settings s) => s.MemcachedMigrationGroupName), Settings.Default.ToSingleSetting((Settings s) => s.MemcachedMigrationState)));

	public long ID => _EntityDAL.ID;

	public int IPAddressID
	{
		get
		{
			return _EntityDAL.IPAddressID;
		}
		set
		{
			_EntityDAL.IPAddressID = value;
		}
	}

	public long? GeopositionID
	{
		get
		{
			return _EntityDAL.GeopositionID;
		}
		set
		{
			_EntityDAL.GeopositionID = value;
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

	public IPAddressGeoposition()
	{
		_EntityDAL = new IPAddressGeopositionDAL();
	}

	public IPAddressGeoposition(IPAddressGeopositionDAL ipAddressGeopositionDAL)
	{
		_EntityDAL = ipAddressGeopositionDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
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

	public static IPAddressGeoposition Get(long id)
	{
		return EntityHelper.GetEntity<long, IPAddressGeopositionDAL, IPAddressGeoposition>(EntityCacheInfo, id, () => IPAddressGeopositionDAL.Get(id));
	}

	internal static ICollection<IPAddressGeoposition> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, IPAddressGeopositionDAL, IPAddressGeoposition>(ids, EntityCacheInfo, IPAddressGeopositionDAL.MultiGet);
	}

	public static IPAddressGeoposition GetByIPAddressID(int ipAddressId)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<long, IPAddressGeopositionDAL, IPAddressGeoposition>(EntityCacheInfo, GetCacheQualifierByIpAddressId(ipAddressId), () => IPAddressGeopositionDAL.GetIPAddressGeopositionByIPAddressID(ipAddressId), Get);
	}

	public static IPAddressGeoposition GetOrCreate(int ipAddressId, long? geopositionId)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<long, IPAddressGeoposition>(EntityCacheInfo, GetCacheQualifierByIpAddressIdAndGeopositionId(ipAddressId, geopositionId), () => DoGetOrCreate(ipAddressId, geopositionId), Get);
	}

	public void Construct(IPAddressGeopositionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetCacheQualifierByIpAddressId(IPAddressID);
		yield return GetCacheQualifierByIpAddressIdAndGeopositionId(IPAddressID, GeopositionID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static IPAddressGeoposition DoGetOrCreate(int ipAddressId, long? geopositionId)
	{
		return EntityHelper.DoGetOrCreate<long, IPAddressGeopositionDAL, IPAddressGeoposition>(() => IPAddressGeopositionDAL.GetOrCreateIPAddressGeoposition(ipAddressId, geopositionId));
	}

	private static string GetCacheQualifierByIpAddressIdAndGeopositionId(int ipAddressId, long? geopositionId)
	{
		return $"IPAddressID:{ipAddressId}_GeopositionID:{geopositionId}";
	}

	private static string GetCacheQualifierByIpAddressId(int ipAddressId)
	{
		return $"IPAddressID:{ipAddressId}";
	}
}
