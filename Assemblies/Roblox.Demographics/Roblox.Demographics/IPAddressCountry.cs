using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.Data.Interfaces;
using Roblox.Demographics.Properties;

namespace Roblox.Demographics;

public class IPAddressCountry : IRobloxEntity<int, IPAddressCountryDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private IPAddressCountryDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(IPAddressCountry).ToString(), isNullCacheable: true, null, new RemoteCachabilitySettings(Settings.Default.ToSingleSetting((Settings s) => s.MemcacheClusterGroupName)), new MigrationCacheabilitySettings(Settings.Default.ToSingleSetting((Settings s) => s.MemcachedMigrationGroupName), Settings.Default.ToSingleSetting((Settings s) => s.MemcachedMigrationState)));

	public int ID => _EntityDAL.ID;

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

	public int? CountryID
	{
		get
		{
			return _EntityDAL.CountryID;
		}
		set
		{
			_EntityDAL.CountryID = value;
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

	public IPAddressCountry()
	{
		_EntityDAL = new IPAddressCountryDAL();
	}

	public IPAddressCountry(IPAddressCountryDAL ipAddressCountryDAL)
	{
		_EntityDAL = ipAddressCountryDAL;
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

	public static IPAddressCountry Get(int id)
	{
		return EntityHelper.GetEntity<int, IPAddressCountryDAL, IPAddressCountry>(EntityCacheInfo, id, () => IPAddressCountryDAL.Get(id));
	}

	public static IPAddressCountry GetByIPAddressID(int ipAddressId)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<int, IPAddressCountryDAL, IPAddressCountry>(EntityCacheInfo, GetCacheQualifierByIpAddressId(ipAddressId), () => IPAddressCountryDAL.GetIPAddressCountryByIPAddressID(ipAddressId), Get);
	}

	public static ICollection<IPAddressCountry> GetIPAddressCountriesByCountryID_Paged(int? countryId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetIPAddressCountriesByCountryID_CountryID:{countryId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, GetCacheQualifierByCountryId(countryId)), collectionId, () => IPAddressCountryDAL.GetIPAddressCountryIDsByCountryID_Paged(countryId, startRowIndex, maximumRows), Get);
	}

	public static IPAddressCountry GetOrCreateIPAddressCountryByIPAddressIDAndCountryID(int ipAddressId, int? countryId)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<int, IPAddressCountry>(EntityCacheInfo, GetCacheQualifierByIpAddressIdAndCountryId(ipAddressId, countryId), () => DoGetOrCreate(ipAddressId, countryId), Get);
	}

	public void Construct(IPAddressCountryDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetCacheQualifierByIpAddressId(IPAddressID);
		yield return GetCacheQualifierByIpAddressIdAndCountryId(IPAddressID, CountryID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetCacheQualifierByCountryId(CountryID));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static IPAddressCountry DoGetOrCreate(int ipAddressId, int? countryId)
	{
		return EntityHelper.DoGetOrCreate<int, IPAddressCountryDAL, IPAddressCountry>(() => IPAddressCountryDAL.GetOrCreateIPAddressCountryByIPAddressIDAndCountryID(ipAddressId, countryId));
	}

	private static string GetCacheQualifierByCountryId(int? countryId)
	{
		return $"CountryID:{countryId}";
	}

	private static string GetCacheQualifierByIpAddressId(int ipAddressId)
	{
		return $"IPAddressID:{ipAddressId}";
	}

	private static string GetCacheQualifierByIpAddressIdAndCountryId(int ipAddressId, int? countryId)
	{
		return $"IPAddressCountry_IPAddressID:{ipAddressId}_CountryID:{countryId}";
	}
}
