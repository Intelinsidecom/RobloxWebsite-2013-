using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class SponsoredPagePlace : IRobloxEntity<int, SponsoredPagePlaceDAL>, ICacheableObject<int>, ICacheableObject
{
	private SponsoredPagePlaceDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: false, hasUnqualifiedCollections: false), "Roblox.SponsoredPagePlace", isNullCacheable: true);

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

	public long PlaceID
	{
		get
		{
			return _EntityDAL.PlaceID;
		}
		set
		{
			_EntityDAL.PlaceID = value;
		}
	}

	public int SortOrder
	{
		get
		{
			return _EntityDAL.SortOrder;
		}
		set
		{
			_EntityDAL.SortOrder = value;
		}
	}

	public string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		set
		{
			_EntityDAL.Description = value;
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

	public SponsoredPagePlace()
	{
		_EntityDAL = new SponsoredPagePlaceDAL();
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

	public static SponsoredPagePlace CreateNew(int sponsoredpageid, long assetid, int sortorder)
	{
		SponsoredPagePlace sponsoredPagePlace = new SponsoredPagePlace();
		sponsoredPagePlace.SponsoredPageID = sponsoredpageid;
		sponsoredPagePlace.PlaceID = assetid;
		sponsoredPagePlace.SortOrder = sortorder;
		sponsoredPagePlace.Save();
		return sponsoredPagePlace;
	}

	public static SponsoredPagePlace Get(int id)
	{
		return EntityHelper.GetEntity<int, SponsoredPagePlaceDAL, SponsoredPagePlace>(EntityCacheInfo, id, () => SponsoredPagePlaceDAL.Get(id));
	}

	public static ICollection<SponsoredPagePlace> GetSponsoredPagePlacesBySponsoredPageID_Paged(int SponsoredPageID, int startIndex, int maxRows)
	{
		string collectionId = $"GetSponsoredPagePlacesBySponsoredPageID_SponsoredPageID:{SponsoredPageID}_StartRowIndex:{startIndex}_MaximumRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"SponsoredPageID:{SponsoredPageID}"), collectionId, () => SponsoredPagePlaceDAL.GetSponsoredPagePlaceIDsBySponsoredPageID_Paged(SponsoredPageID, startIndex, maxRows), Get);
	}

	public void Construct(SponsoredPagePlaceDAL dal)
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
	}
}
