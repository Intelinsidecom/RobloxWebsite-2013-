using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Demographics;

public class Country : IRobloxEntity<int, CountryDAL>, ICacheableObject<int>, ICacheableObject
{
	private CountryDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(Country).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public string Value
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

	public string Code
	{
		get
		{
			return _EntityDAL.Code;
		}
		set
		{
			_EntityDAL.Code = value;
		}
	}

	public bool IsActive
	{
		get
		{
			return _EntityDAL.IsActive;
		}
		set
		{
			_EntityDAL.IsActive = value;
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

	public static Country GetUSACountry()
	{
		return GetByCode("US");
	}

	public Country()
	{
		_EntityDAL = new CountryDAL();
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

	public static Country Get(int id)
	{
		return EntityHelper.GetEntity<int, CountryDAL, Country>(EntityCacheInfo, id, () => CountryDAL.Get(id));
	}

	public static Country GetByCode(string code)
	{
		return EntityHelper.GetEntityByLookup<int, CountryDAL, Country>(EntityCacheInfo, $"Code:{code}", () => CountryDAL.GetByCode(code));
	}

	public static ICollection<Country> GetAllCountries()
	{
		return GetCountriesPaged(0, 2147483646);
	}

	public static ICollection<Country> GetAllActiveCountries()
	{
		string collectionId = "GetAllActiveCountries";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => (from country in GetAllCountries()
			where country.IsActive
			select country into c
			select c.ID).ToList(), Get);
	}

	public static ICollection<Country> GetCountriesPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetCountries_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => CountryDAL.GetCountriesByID_Paged(startRowIndex + 1, maximumRows), Get);
	}

	public void Construct(CountryDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Code:{Code}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
