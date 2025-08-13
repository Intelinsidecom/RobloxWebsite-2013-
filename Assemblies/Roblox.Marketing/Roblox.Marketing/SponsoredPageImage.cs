using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class SponsoredPageImage : IRobloxEntity<int, SponsoredPageImageDAL>, ICacheableObject<int>, ICacheableObject
{
	private SponsoredPageImageDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Marketing.SponsoredPageImage", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public string Key
	{
		get
		{
			return _EntityDAL.Key;
		}
		set
		{
			_EntityDAL.Key = value;
		}
	}

	public string Md5Hash
	{
		get
		{
			return _EntityDAL.Md5Hash;
		}
		set
		{
			_EntityDAL.Md5Hash = value;
		}
	}

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

	public SponsoredPageImage()
	{
		_EntityDAL = new SponsoredPageImageDAL();
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

	public static SponsoredPageImage CreateNew(string key, string md5Hash, int sponsoredpageid)
	{
		SponsoredPageImage sponsoredPageImage = new SponsoredPageImage();
		sponsoredPageImage.Key = key;
		sponsoredPageImage.Md5Hash = md5Hash;
		sponsoredPageImage.SponsoredPageID = sponsoredpageid;
		sponsoredPageImage.Save();
		return sponsoredPageImage;
	}

	public static SponsoredPageImage Get(int id)
	{
		return EntityHelper.GetEntity<int, SponsoredPageImageDAL, SponsoredPageImage>(EntityCacheInfo, id, () => SponsoredPageImageDAL.Get(id));
	}

	public static ICollection<SponsoredPageImage> GetSponsoredPageImagesBySponsoredPageID_Paged(int sponsoredPageID, int startIndex, int maxRows)
	{
		string collectionId = string.Format("GetSponsoredPageImagesBySponsoredPageID_SponsoredPageID:{0}_StartRowIndex:{0}_MaximumRows:{1}", sponsoredPageID, startIndex, maxRows);
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"SponsoredPageID:{sponsoredPageID}"), collectionId, () => SponsoredPageImageDAL.GetSponsoredPageImageIDsBySponsoredPageID_Paged(sponsoredPageID, startIndex, maxRows), Get);
	}

	public static ICollection<SponsoredPageImage> GetAllSponsoredPageImagesBySponsoredPageID(int sponsoredPageID)
	{
		return GetSponsoredPageImagesBySponsoredPageID_Paged(sponsoredPageID, 0, int.MaxValue);
	}

	public static SponsoredPageImage GetByKeyAndSponsoredPageID(string key, int sponsoredPageId)
	{
		string id = $"Key:{key}_SponsoredPageID:{sponsoredPageId}";
		return EntityHelper.GetEntityByLookup<int, SponsoredPageImageDAL, SponsoredPageImage>(EntityCacheInfo, id, () => SponsoredPageImageDAL.GetByKeyAndSponsoredPageID(key, sponsoredPageId));
	}

	public void Construct(SponsoredPageImageDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Key:{Key}_SponsoredPageID:{SponsoredPageID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"SponsoredPageID:{SponsoredPageID}");
	}
}
