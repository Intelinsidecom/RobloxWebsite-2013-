using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class SponsoredPageCountry : IRobloxEntity<int, SponsoredPageCountryDAL>, ICacheableObject<int>, ICacheableObject
{
	private SponsoredPageCountryDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(SponsoredPageCountry).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public int SponsoredPageID
	{
		get
		{
			return _EntityDAL.SponsoredPageID;
		}
		set
		{
			_EntityDAL.SponsoredPageID = value;
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

	public SponsoredPageCountry()
	{
		_EntityDAL = new SponsoredPageCountryDAL();
	}

	public void Delete()
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

	public static SponsoredPageCountry CreateNew(int sponsoredpageId, int countryId)
	{
		SponsoredPageCountry sponsoredPageCountry = new SponsoredPageCountry();
		sponsoredPageCountry.SponsoredPageID = sponsoredpageId;
		sponsoredPageCountry.CountryID = countryId;
		sponsoredPageCountry.Save();
		return sponsoredPageCountry;
	}

	public static SponsoredPageCountry Get(int id)
	{
		return EntityHelper.GetEntity<int, SponsoredPageCountryDAL, SponsoredPageCountry>(EntityCacheInfo, id, () => SponsoredPageCountryDAL.Get(id));
	}

	public static ICollection<SponsoredPageCountry> GetSponsoredPageCountriesBySponsoredPageIDPaged(int sponsoredPageId, int startIndex, int maxRows)
	{
		string collectionId = $"GetSponsoredPageCountriesBySponsoredPageID_SponsoredPageID:{sponsoredPageId}_StartRowIndex:{startIndex}_MaximumRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"SponsoredPageID:{sponsoredPageId}"), collectionId, () => SponsoredPageCountryDAL.GetSponsoredPageCountryIDsBySponsoredPageID_Paged(sponsoredPageId, startIndex, maxRows), Get);
	}

	public static ICollection<SponsoredPageCountry> GetSponsoredPageCountriesByCountryIDPaged(int countryId, int startIndex, int maxRows)
	{
		string collectionId = $"GetSponsoredPageCountriesByCountryID_CountryID:{countryId}_StartRowIndex:{startIndex}_MaximumRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"CountryID:{countryId}"), collectionId, () => SponsoredPageCountryDAL.GetSponsoredPageCountryIDsByCountryID_Paged(countryId, startIndex, maxRows), Get);
	}

	public void Construct(SponsoredPageCountryDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"SponsoredPageID:{SponsoredPageID}");
		yield return new StateToken($"CountryID:{CountryID}");
	}
}
