using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

internal class SponsoredPageAgeRating : IRobloxEntity<int, SponsoredPageAgeRatingDAL>, ICacheableObject<int>, ICacheableObject
{
	private SponsoredPageAgeRatingDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(SponsoredPageAgeRating).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal int SponsoredPageID
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

	internal byte MinAge
	{
		get
		{
			return _EntityDAL.MinAge;
		}
		set
		{
			_EntityDAL.MinAge = value;
		}
	}

	internal byte MaxAge
	{
		get
		{
			return _EntityDAL.MaxAge;
		}
		set
		{
			_EntityDAL.MaxAge = value;
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

	public SponsoredPageAgeRating()
	{
		_EntityDAL = new SponsoredPageAgeRatingDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.UtcNow;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.UtcNow;
			_EntityDAL.Update();
		});
	}

	internal static SponsoredPageAgeRating Get(int id)
	{
		return EntityHelper.GetEntity<int, SponsoredPageAgeRatingDAL, SponsoredPageAgeRating>(EntityCacheInfo, id, () => SponsoredPageAgeRatingDAL.Get(id));
	}

	private static ICollection<SponsoredPageAgeRating> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, SponsoredPageAgeRatingDAL, SponsoredPageAgeRating>(ids, EntityCacheInfo, SponsoredPageAgeRatingDAL.MultiGet);
	}

	public static SponsoredPageAgeRating GetBySponsoredPageId(int sponsoredPageId)
	{
		return EntityHelper.GetEntityByLookup<int, SponsoredPageAgeRatingDAL, SponsoredPageAgeRating>(EntityCacheInfo, GetLookupCacheKeysBySponsoredPageID(sponsoredPageId), () => SponsoredPageAgeRatingDAL.GetSponsoredPageAgeRatingBySponsoredPageID(sponsoredPageId));
	}

	public void Construct(SponsoredPageAgeRatingDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysBySponsoredPageID(SponsoredPageID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysBySponsoredPageID(int sponsoredPageID)
	{
		return $"SponsoredPageID:{sponsoredPageID}";
	}
}
