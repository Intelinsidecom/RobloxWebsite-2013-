using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class TakeoverCountry : IRobloxEntity<int, TakeoverCountryDAL>, ICacheableObject<int>, ICacheableObject
{
	private TakeoverCountryDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(TakeoverCountry).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal int TakeoverID
	{
		get
		{
			return _EntityDAL.TakeoverID;
		}
		set
		{
			_EntityDAL.TakeoverID = value;
		}
	}

	public int CountryID
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

	public TakeoverCountry()
	{
		_EntityDAL = new TakeoverCountryDAL();
	}

	public void Delete()
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

	public static TakeoverCountry CreateNew(int takeoverid, int countryid)
	{
		TakeoverCountry takeoverCountry = new TakeoverCountry();
		takeoverCountry.TakeoverID = takeoverid;
		takeoverCountry.CountryID = countryid;
		takeoverCountry.Save();
		return takeoverCountry;
	}

	internal static TakeoverCountry Get(int id)
	{
		return EntityHelper.GetEntity<int, TakeoverCountryDAL, TakeoverCountry>(EntityCacheInfo, id, () => TakeoverCountryDAL.Get(id));
	}

	public static TakeoverCountry GetByTakeoverIDAndCountryID(int takeoverId, int countryId)
	{
		return EntityHelper.GetEntityByLookup<int, TakeoverCountryDAL, TakeoverCountry>(EntityCacheInfo, $"TakeoverID:{takeoverId}_CountryID:{countryId}", () => TakeoverCountryDAL.GetByTakeoverIDAndCountryID(takeoverId, countryId));
	}

	public static ICollection<TakeoverCountry> GetTakeoverCountriesByTakeoverID(int takeoverId, int startIndex, int maxRows)
	{
		string collectionId = $"GetTakeoverCountriesByTakeoverID_TakeoverID:{takeoverId}_StartRowIndex:{startIndex}_MaximumRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"TakeoverID:{takeoverId}"), collectionId, () => TakeoverCountryDAL.GetTakeoverCountryIDsByTakeoverID_Paged(takeoverId, startIndex + 1, maxRows), Get);
	}

	public static int GetTotalNumberOfTakeoverCountriesByTakeoverID(int takeoverId)
	{
		string countID = $"TakeoverID:{takeoverId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"TakeoverID:{takeoverId}"), countID, () => TakeoverCountryDAL.GetTotalNumberOfTakeoverCountriesByTakeoverID(takeoverId));
	}

	public void Construct(TakeoverCountryDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"TakeoverID:{TakeoverID}_CountryID:{CountryID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"TakeoverID:{TakeoverID}");
	}
}
