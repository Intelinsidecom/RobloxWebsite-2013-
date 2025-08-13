using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class SponsoredPageItem : IRobloxEntity<int, SponsoredPageItemDAL>, ICacheableObject<int>, ICacheableObject
{
	private SponsoredPageItemDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: false), "Roblox.SponsoredPageItem", isNullCacheable: true);

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

	public long AssetID
	{
		get
		{
			return _EntityDAL.AssetID;
		}
		set
		{
			_EntityDAL.AssetID = value;
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

	public SponsoredPageItem()
	{
		_EntityDAL = new SponsoredPageItemDAL();
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

	public static SponsoredPageItem CreateNew(int sponsoredpageid, long assetid, int sortorder)
	{
		SponsoredPageItem sponsoredPageItem = new SponsoredPageItem();
		sponsoredPageItem.SponsoredPageID = sponsoredpageid;
		sponsoredPageItem.AssetID = assetid;
		sponsoredPageItem.SortOrder = sortorder;
		sponsoredPageItem.Save();
		return sponsoredPageItem;
	}

	public static SponsoredPageItem Get(int id)
	{
		return EntityHelper.GetEntity<int, SponsoredPageItemDAL, SponsoredPageItem>(EntityCacheInfo, id, () => SponsoredPageItemDAL.Get(id));
	}

	public static ICollection<SponsoredPageItem> GetSponsoredPageItemsBySponsoredPageID_Paged(int SponsoredPageID, int startIndex, int maxRows)
	{
		string collectionId = $"GetSponsoredPageItemsBySponsoredPageID_SponsoredPageID:{SponsoredPageID}_StartRowIndex:{startIndex}_MaximumRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"SponsoredPageID:{SponsoredPageID}"), collectionId, () => SponsoredPageItemDAL.GetSponsoredPageItemIDsBySponsoredPageID_Paged(SponsoredPageID, startIndex, maxRows), Get);
	}

	public void Construct(SponsoredPageItemDAL dal)
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
