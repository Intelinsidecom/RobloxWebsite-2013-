using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class CountryMerchant : IRobloxEntity<int, CountryMerchantDAL>, ICacheableObject<int>, ICacheableObject
{
	private CountryMerchantDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(CountryMerchant).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public byte MerchantID
	{
		get
		{
			return _EntityDAL.MerchantID;
		}
		set
		{
			_EntityDAL.MerchantID = value;
		}
	}

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

	public CountryMerchant()
	{
		_EntityDAL = new CountryMerchantDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
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

	public static CountryMerchant CreateNew(byte merchantid, byte countrytypeid)
	{
		CountryMerchant countryMerchant = new CountryMerchant();
		countryMerchant.MerchantID = merchantid;
		countryMerchant.CountryTypeID = countrytypeid;
		countryMerchant.Save();
		return countryMerchant;
	}

	public static CountryMerchant Get(int id)
	{
		return EntityHelper.GetEntity<int, CountryMerchantDAL, CountryMerchant>(EntityCacheInfo, id, () => CountryMerchantDAL.Get(id));
	}

	public static CountryMerchant GetByCountryTypeIDAndMerchantID(byte countryTypeID, byte merchantID)
	{
		if (countryTypeID == 0)
		{
			return null;
		}
		if (merchantID == 0)
		{
			return null;
		}
		return EntityHelper.GetEntityByLookup<int, CountryMerchantDAL, CountryMerchant>(EntityCacheInfo, $"CountryTypeID:{countryTypeID}_MerchantID:{merchantID}", () => CountryMerchantDAL.GetByCountryTypeIDAndMerchantID(countryTypeID, merchantID));
	}

	public static ICollection<CountryMerchant> GetCountryMerchantsByMerchantID_Paged(int startIndex, int maxRows, byte merchantID)
	{
		string collectionId = $"GetCountryMerchantsByMerchantID_Paged_StartRowIndex:{startIndex}_MaximumRows:{maxRows}_merchantID:{merchantID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => CountryMerchantDAL.GetCountryMerchantIDsByMerchantID_Paged(startIndex + 1, maxRows, merchantID), Get);
	}

	public void Construct(CountryMerchantDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"MerchantID:{MerchantID}");
	}
}
