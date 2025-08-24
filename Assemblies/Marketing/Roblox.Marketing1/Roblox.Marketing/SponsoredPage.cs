using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class SponsoredPage : IRobloxEntity<int, SponsoredPageDAL>, ICacheableObject<int>, ICacheableObject
{
	private SponsoredPageDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.SponsoredPage", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	public string Title
	{
		get
		{
			return _EntityDAL.Title;
		}
		set
		{
			_EntityDAL.Title = value;
		}
	}

	public int? ContestID
	{
		get
		{
			return _EntityDAL.ContestID;
		}
		set
		{
			_EntityDAL.ContestID = value;
		}
	}

	public string VideoURL
	{
		get
		{
			return _EntityDAL.VideoURL;
		}
		set
		{
			_EntityDAL.VideoURL = value;
		}
	}

	public bool VideoIsYoutube
	{
		get
		{
			return _EntityDAL.VideoIsYoutube;
		}
		set
		{
			_EntityDAL.VideoIsYoutube = value;
		}
	}

	public bool Enabled
	{
		get
		{
			return _EntityDAL.Enabled;
		}
		set
		{
			_EntityDAL.Enabled = value;
		}
	}

	public bool PreviewEnabled
	{
		get
		{
			return _EntityDAL.PreviewEnabled;
		}
		set
		{
			_EntityDAL.PreviewEnabled = value;
		}
	}

	public string AdSlot728x90
	{
		get
		{
			return _EntityDAL.AdSlot728x90;
		}
		set
		{
			_EntityDAL.AdSlot728x90 = value;
		}
	}

	public string AdSlot300x250
	{
		get
		{
			return _EntityDAL.AdSlot300x250;
		}
		set
		{
			_EntityDAL.AdSlot300x250 = value;
		}
	}

	public DateTime StartDate
	{
		get
		{
			return _EntityDAL.StartDate;
		}
		set
		{
			_EntityDAL.StartDate = value;
		}
	}

	public DateTime EndDate
	{
		get
		{
			return _EntityDAL.EndDate;
		}
		set
		{
			_EntityDAL.EndDate = value;
		}
	}

	public string OriginalCssMd5Hash
	{
		get
		{
			return _EntityDAL.OriginalCssMd5Hash;
		}
		set
		{
			_EntityDAL.OriginalCssMd5Hash = value;
		}
	}

	public string CurrentCssMd5Hash
	{
		get
		{
			return _EntityDAL.CurrentCssMd5Hash;
		}
		set
		{
			_EntityDAL.CurrentCssMd5Hash = value;
		}
	}

	public string NavigationLogoImageMd5Hash
	{
		get
		{
			return _EntityDAL.NavigationLogoImageMd5Hash;
		}
		set
		{
			_EntityDAL.NavigationLogoImageMd5Hash = value;
		}
	}

	public string NavigationOverrideUrl
	{
		get
		{
			return _EntityDAL.NavigationOverrideUrl;
		}
		set
		{
			_EntityDAL.NavigationOverrideUrl = value;
		}
	}

	public string IFrameUrl
	{
		get
		{
			return _EntityDAL.IFrameUrl;
		}
		set
		{
			_EntityDAL.IFrameUrl = value;
		}
	}

	public byte PageTypeID
	{
		get
		{
			return _EntityDAL.PageTypeID;
		}
		set
		{
			_EntityDAL.PageTypeID = value;
		}
	}

	public string JavascriptMd5Hash
	{
		get
		{
			return _EntityDAL.JavascriptMd5Hash;
		}
		set
		{
			_EntityDAL.JavascriptMd5Hash = value;
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

	public SponsoredPage()
	{
		_EntityDAL = new SponsoredPageDAL();
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

	/// <summary>
	///
	/// </summary>
	/// <param name="name">Internal name of the Sponsored Page</param>
	/// <param name="description">Description of the Sponsored Page</param>
	/// <param name="title">User facing name of the Sponsored Page</param>
	/// <param name="pageTypeId">Sponsored / Event (could be deprecated as cleanup task)</param>
	/// <param name="startDate">When to start Sponsored Page</param>
	/// <param name="endDate"></param>
	/// <param name="enabled"></param>
	/// <param name="previewEnabled"></param>
	/// <param name="originalCssMd5Hash"></param>
	/// <param name="currentCssMd5Hash"></param>
	/// <param name="navigationLogoImageMd5Hash"></param>
	/// <param name="navigationOverrideUrl">External Link</param>
	/// <param name="iFrameUrl">Poll for Event or iFrame Game for Sponsored Page</param>
	/// <param name="videoUrl"></param>
	/// <param name="videoIsYoutube"></param>
	/// <param name="adSlot728x90"></param>
	/// <param name="adSlot300x250"></param>
	/// <param name="contestId"></param>
	/// <param name="javascriptMd5Hash"></param>
	/// <returns></returns>
	public static SponsoredPage CreateNew(string name, string description, string title, byte pageTypeId, DateTime startDate, DateTime endDate, bool enabled = false, bool previewEnabled = false, string originalCssMd5Hash = null, string currentCssMd5Hash = null, string navigationLogoImageMd5Hash = null, string navigationOverrideUrl = "", string iFrameUrl = "", string videoUrl = "", bool videoIsYoutube = false, string adSlot728x90 = "", string adSlot300x250 = "", int? contestId = null, string javascriptMd5Hash = null)
	{
		SponsoredPage sponsoredPage = new SponsoredPage();
		sponsoredPage.Name = name;
		sponsoredPage.Description = description;
		sponsoredPage.Title = title;
		sponsoredPage.PageTypeID = pageTypeId;
		sponsoredPage.StartDate = startDate;
		sponsoredPage.EndDate = endDate;
		sponsoredPage.Enabled = enabled;
		sponsoredPage.PreviewEnabled = previewEnabled;
		sponsoredPage.OriginalCssMd5Hash = originalCssMd5Hash;
		sponsoredPage.CurrentCssMd5Hash = currentCssMd5Hash;
		sponsoredPage.NavigationLogoImageMd5Hash = navigationLogoImageMd5Hash;
		sponsoredPage.IFrameUrl = iFrameUrl;
		sponsoredPage.VideoURL = videoUrl;
		sponsoredPage.VideoIsYoutube = videoIsYoutube;
		sponsoredPage.AdSlot728x90 = adSlot728x90;
		sponsoredPage.AdSlot300x250 = adSlot300x250;
		sponsoredPage.ContestID = contestId;
		sponsoredPage.NavigationOverrideUrl = navigationOverrideUrl;
		sponsoredPage.JavascriptMd5Hash = javascriptMd5Hash;
		sponsoredPage.Save();
		return sponsoredPage;
	}

	public static SponsoredPage Get(int id)
	{
		return EntityHelper.GetEntity<int, SponsoredPageDAL, SponsoredPage>(EntityCacheInfo, id, () => SponsoredPageDAL.Get(id));
	}

	public static SponsoredPage GetByName(string name)
	{
		return EntityHelper.GetEntityByLookup<int, SponsoredPageDAL, SponsoredPage>(EntityCacheInfo, $"Name:{name}", () => SponsoredPageDAL.GetByName(name));
	}

	public static ICollection<SponsoredPage> GetSponsoredPages_Paged(int startIndex, int maxRows)
	{
		string collectionId = $"GetSponsoredPages_Paged_StartRowIndex:{startIndex}_MaximumRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => SponsoredPageDAL.GetSponsoredPageIDs_Paged(startIndex + 1, maxRows), Get);
	}

	public static ICollection<SponsoredPage> GetAllSponsoredPages()
	{
		return GetSponsoredPages_Paged(0, 255);
	}

	public void Construct(SponsoredPageDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Name:{Name}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
