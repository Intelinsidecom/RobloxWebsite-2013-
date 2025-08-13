using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.Data.Interfaces;
using Roblox.Demographics.Properties;

namespace Roblox.Demographics;

public class Geoposition : IRobloxEntity<long, GeopositionDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private GeopositionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Geoposition).ToString(), isNullCacheable: true, null, new RemoteCachabilitySettings(Settings.Default.ToSingleSetting((Settings s) => s.MemcachedGroupName)));

	public long ID => _EntityDAL.ID;

	public double Latitude
	{
		get
		{
			return _EntityDAL.Latitude;
		}
		set
		{
			_EntityDAL.Latitude = value;
		}
	}

	public double Longitude
	{
		get
		{
			return _EntityDAL.Longitude;
		}
		set
		{
			_EntityDAL.Longitude = value;
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Geoposition()
	{
		_EntityDAL = new GeopositionDAL();
	}

	public Geoposition(GeopositionDAL entityDal)
	{
		_EntityDAL = entityDal;
	}

	internal void Delete()
	{
		if (Settings.Default.IsRemoteCachingForGeopositionLookupsEnabled)
		{
			EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
		}
		else
		{
			EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		}
	}

	internal void Save()
	{
		if (Settings.Default.IsRemoteCachingForGeopositionLookupsEnabled)
		{
			EntityHelper.SaveEntityWithRemoteCache(this, delegate
			{
				_EntityDAL.Created = DateTime.Now;
				_EntityDAL.Insert();
			}, delegate
			{
				_EntityDAL.Update();
			});
		}
		else
		{
			EntityHelper.SaveEntity(this, delegate
			{
				_EntityDAL.Created = DateTime.Now;
				_EntityDAL.Insert();
			}, delegate
			{
				_EntityDAL.Update();
			});
		}
	}

	public static Geoposition Get(long id)
	{
		return EntityHelper.GetEntity<long, GeopositionDAL, Geoposition>(EntityCacheInfo, id, () => GeopositionDAL.Get(id));
	}

	internal static ICollection<Geoposition> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, GeopositionDAL, Geoposition>(ids, EntityCacheInfo, GeopositionDAL.MultiGet);
	}

	public static Geoposition GetOrCreate(double latitude, double longitude)
	{
		if (Settings.Default.IsRemoteCachingForGeopositionLookupsEnabled)
		{
			return EntityHelper.GetOrCreateEntityWithRemoteCache<long, Geoposition>(EntityCacheInfo, GetLookupCacheKeyByLatitudeAndLongitude(latitude, longitude), () => DoGetOrCreate(latitude, longitude), Get);
		}
		return EntityHelper.GetOrCreateEntity<long, Geoposition>(EntityCacheInfo, GetLookupCacheKeyByLatitudeAndLongitude(latitude, longitude), () => DoGetOrCreate(latitude, longitude));
	}

	public void Construct(GeopositionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeyByLatitudeAndLongitude(Latitude, Longitude);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static Geoposition DoGetOrCreate(double latitude, double longitude)
	{
		return EntityHelper.DoGetOrCreate<long, GeopositionDAL, Geoposition>(() => GeopositionDAL.GetOrCreateGeoposition(latitude, longitude));
	}

	private static string GetLookupCacheKeyByLatitudeAndLongitude(double latitude, double longitude)
	{
		if (!Settings.Default.IsNewFormatForGeoPositionLookupCacheKeysEnabled)
		{
			return $"Latitude:{latitude}_Longitude:{longitude}";
		}
		return $"Latitude:{latitude:0.0000}_Longitude:{longitude:0.0000}";
	}
}
