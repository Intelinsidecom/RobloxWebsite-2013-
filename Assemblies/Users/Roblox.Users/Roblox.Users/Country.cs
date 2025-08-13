using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Users;

public class Country : IRobloxEntity<byte, CountryDAL>, ICacheableObject<byte>, ICacheableObject
{
	private CountryDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Users.Country", isNullCacheable: true);

	public byte ID => _EntityDAL.ID;

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

	public bool Active
	{
		get
		{
			return _EntityDAL.Active;
		}
		set
		{
			_EntityDAL.Active = value;
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

	public static Country CreateNew(string value, string code, bool active)
	{
		Country country = new Country();
		country.Value = value;
		country.Code = code;
		country.Active = active;
		country.Save();
		return country;
	}

	public static Country Get(byte id)
	{
		return EntityHelper.GetEntity<byte, CountryDAL, Country>(EntityCacheInfo, id, () => CountryDAL.Get(id));
	}

	public static ICollection<Country> GetAllCountries()
	{
		return GetCountriesPaged(0, byte.MaxValue);
	}

	public static ICollection<Country> GetAllActiveCountries()
	{
		return GetActiveCountriesPaged(0, byte.MaxValue);
	}

	public static ICollection<Country> GetCountriesPaged(byte startRowIndex, byte maximumRows)
	{
		string collectionId = $"GetCountries_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => CountryDAL.GetCountriesByID_Paged((byte)(startRowIndex + 1), maximumRows), Get);
	}

	public static ICollection<Country> GetActiveCountriesPaged(byte startRowIndex, byte maximumRows)
	{
		string collectionId = $"GetActiveCountries_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => CountryDAL.GetActiveCountryIDs_Paged((byte)(startRowIndex + 1), maximumRows), Get);
	}

	public static Country GetByCode(string code)
	{
		return EntityHelper.GetEntityByLookup<byte, CountryDAL, Country>(EntityCacheInfo, $"Code:{code}", () => CountryDAL.GetByCode(code));
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
		yield return new StateToken($"Active:{Active}");
	}
}
