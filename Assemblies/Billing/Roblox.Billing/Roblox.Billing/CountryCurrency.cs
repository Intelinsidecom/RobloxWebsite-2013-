using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class CountryCurrency : IRobloxEntity<int, CountryCurrencyDAL>, ICacheableObject<int>, ICacheableObject
{
	private CountryCurrencyDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.CountryCurrency", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public byte CountryTypeID
	{
		get
		{
			return _EntityDAL.CountryTypeID;
		}
		set
		{
			_EntityDAL.CountryTypeID = value;
		}
	}

	public byte CurrencyTypeID
	{
		get
		{
			return _EntityDAL.CurrencyTypeID;
		}
		set
		{
			_EntityDAL.CurrencyTypeID = value;
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

	public CountryCurrency()
	{
		_EntityDAL = new CountryCurrencyDAL();
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

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public static CountryCurrency CreateNew(byte countryTypeID, byte currencyTypeID)
	{
		CountryCurrency countryCurrency = new CountryCurrency();
		countryCurrency.CountryTypeID = countryTypeID;
		countryCurrency.CurrencyTypeID = currencyTypeID;
		countryCurrency.Save();
		return countryCurrency;
	}

	public static CountryCurrency Get(int id)
	{
		return EntityHelper.GetEntity<int, CountryCurrencyDAL, CountryCurrency>(EntityCacheInfo, id, () => CountryCurrencyDAL.Get(id));
	}

	public static CountryCurrency GetByCountryTypeIDAndCurrencyTypeID(int countryTypeID, byte currencyTypeID)
	{
		if (countryTypeID == 0)
		{
			return null;
		}
		if (currencyTypeID == 0)
		{
			return null;
		}
		return EntityHelper.GetEntityByLookup<int, CountryCurrencyDAL, CountryCurrency>(EntityCacheInfo, $"CountryTypeID:{countryTypeID}_CurrencyTypeID:{currencyTypeID}", () => CountryCurrencyDAL.GetByCountryIDAndCurrencyID(countryTypeID, currencyTypeID));
	}

	public static CountryCurrency GetOrCreateCountryCurrency(int countryTypeID, byte currencyTypeID)
	{
		return EntityHelper.GetOrCreateEntity<int, CountryCurrency>(EntityCacheInfo, $"CountryTypeID:{countryTypeID}_CurrencyTypeID:{currencyTypeID}", () => DoGetOrCreate(countryTypeID, currencyTypeID));
	}

	private static CountryCurrency DoGetOrCreate(int countryTypeID, byte currencyTypeID)
	{
		return EntityHelper.DoGetOrCreate<int, CountryCurrencyDAL, CountryCurrency>(() => CountryCurrencyDAL.GetOrCreateCountryCurrency(countryTypeID, currencyTypeID));
	}

	public static ICollection<CountryCurrency> GetCountryCurrencies_Paged(int startIndex, int maxRows)
	{
		string collectionId = $"GetCountryCurrencies_Paged_StartRowIndex:{startIndex}_MaximumRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => CountryCurrencyDAL.GetCountryCurrencyIDs_Paged(startIndex + 1, maxRows), Get);
	}

	public static ICollection<CountryCurrency> GetCountryCurrenciesByCountryID_Paged(int startIndex, int maxRows, int countryTypeID)
	{
		string collectionId = $"GetCountryCurrenciesByCountryID_Paged_StartRowIndex:{startIndex}_MaximumRows:{maxRows}_CountryID:{countryTypeID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => CountryCurrencyDAL.GetCountryCurrencyIDsByCountryID_Paged(startIndex + 1, maxRows, countryTypeID), Get);
	}

	public static ICollection<CountryCurrency> GetAllCountryCurrencies()
	{
		return GetCountryCurrencies_Paged(0, 255);
	}

	public void Construct(CountryCurrencyDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"CountryTypeID:{CountryTypeID}_CurrencyTypeID:{CurrencyTypeID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"CountryTypeID:{CountryTypeID}");
	}
}
