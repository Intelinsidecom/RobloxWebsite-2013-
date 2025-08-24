using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class SponsoredPageSection : IRobloxEntity<int, SponsoredPageSectionDAL>, ICacheableObject<int>, ICacheableObject
{
	private SponsoredPageSectionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: false, hasUnqualifiedCollections: false), "Roblox.SponsoredPageSection", isNullCacheable: true);

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

	public byte SponsoredPageSectionTypeID
	{
		get
		{
			return _EntityDAL.SponsoredPageSectionTypeID;
		}
		set
		{
			_EntityDAL.SponsoredPageSectionTypeID = value;
		}
	}

	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
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

	public int TargetTopPixel
	{
		get
		{
			return _EntityDAL.TargetTopPixel;
		}
		set
		{
			_EntityDAL.TargetTopPixel = value;
		}
	}

	public string CssOverrideMd5Hash
	{
		get
		{
			return _EntityDAL.CssOverrideMd5Hash;
		}
		set
		{
			_EntityDAL.CssOverrideMd5Hash = value;
		}
	}

	public bool HasNavigation
	{
		get
		{
			return _EntityDAL.HasNavigation;
		}
		set
		{
			_EntityDAL.HasNavigation = value;
		}
	}

	public string CustomHtml
	{
		get
		{
			return _EntityDAL.CustomHtml;
		}
		set
		{
			_EntityDAL.CustomHtml = value;
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

	public SponsoredPageSection()
	{
		_EntityDAL = new SponsoredPageSectionDAL();
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

	public static SponsoredPageSection CreateNew(int sponsoredPageId, byte sponsoredPageSectionTypeId, string name, int sortOrder, int targetTopPixel, bool hasNavigation, string cssOverrideMd5Hash = "", string customHtml = "")
	{
		SponsoredPageSection sponsoredPageSection = new SponsoredPageSection();
		sponsoredPageSection.SponsoredPageID = sponsoredPageId;
		sponsoredPageSection.SponsoredPageSectionTypeID = sponsoredPageSectionTypeId;
		sponsoredPageSection.Name = name;
		sponsoredPageSection.TargetTopPixel = targetTopPixel;
		sponsoredPageSection.SortOrder = sortOrder;
		sponsoredPageSection.CssOverrideMd5Hash = cssOverrideMd5Hash;
		sponsoredPageSection.HasNavigation = hasNavigation;
		sponsoredPageSection.CustomHtml = customHtml;
		sponsoredPageSection.Save();
		return sponsoredPageSection;
	}

	public static SponsoredPageSection Get(int id)
	{
		return EntityHelper.GetEntity<int, SponsoredPageSectionDAL, SponsoredPageSection>(EntityCacheInfo, id, () => SponsoredPageSectionDAL.Get(id));
	}

	public static ICollection<SponsoredPageSection> GetSponsoredPageSectionsBySponsoredPageID_Paged(int sponsoredPageId, int startIndex, int maxRows)
	{
		string collectionId = $"GetSponsoredPageSectionsBySponsoredPageID_SponsoredPageID:{sponsoredPageId}_StartRowIndex:{startIndex}_MaximumRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"SponsoredPageID:{sponsoredPageId}"), collectionId, () => SponsoredPageSectionDAL.GetSponsoredPageSectionIDsBySponsoredPageID_Paged(sponsoredPageId, startIndex, maxRows), Get);
	}

	public void Construct(SponsoredPageSectionDAL dal)
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
