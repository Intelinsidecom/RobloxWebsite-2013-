using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class MerchantDisplay : IRobloxEntity<int, MerchantDisplayDAL>, ICacheableObject<int>, ICacheableObject
{
	private MerchantDisplayDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: false), typeof(MerchantDisplay).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public string ImageMd5Hash
	{
		get
		{
			return _EntityDAL.ImageMd5Hash;
		}
		set
		{
			_EntityDAL.ImageMd5Hash = value;
		}
	}

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

	public string DisplayName
	{
		get
		{
			return _EntityDAL.DisplayName;
		}
		set
		{
			_EntityDAL.DisplayName = value;
		}
	}

	public string LocatorURL
	{
		get
		{
			return _EntityDAL.LocatorURL;
		}
		set
		{
			_EntityDAL.LocatorURL = value;
		}
	}

	public bool IsHidden
	{
		get
		{
			return _EntityDAL.IsHidden;
		}
		set
		{
			_EntityDAL.IsHidden = value;
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

	public bool RequiresFileExtension
	{
		get
		{
			return _EntityDAL.RequiresFileExtension;
		}
		set
		{
			_EntityDAL.RequiresFileExtension = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public MerchantDisplay()
	{
		_EntityDAL = new MerchantDisplayDAL();
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

	public static MerchantDisplay CreateNew(string imagemd5hash, byte merchantid, string displayname, string locatorurl, bool ishidden, bool requiresFileExtension)
	{
		MerchantDisplay merchantDisplay = new MerchantDisplay();
		merchantDisplay.ImageMd5Hash = imagemd5hash;
		merchantDisplay.MerchantID = merchantid;
		merchantDisplay.DisplayName = displayname;
		merchantDisplay.LocatorURL = locatorurl;
		merchantDisplay.IsHidden = ishidden;
		merchantDisplay.RequiresFileExtension = requiresFileExtension;
		merchantDisplay.Save();
		return merchantDisplay;
	}

	public static MerchantDisplay Get(int id)
	{
		return EntityHelper.GetEntity<int, MerchantDisplayDAL, MerchantDisplay>(EntityCacheInfo, id, () => MerchantDisplayDAL.Get(id));
	}

	public static ICollection<MerchantDisplay> GetMerchantDisplaysPaged(int startRowIndex, int maximumRows)
	{
		string collectionID = $"GetMerchantDisplaysPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionID, () => MerchantDisplayDAL.GetMerchantDisplayIDsPaged(startRowIndex, maximumRows), Get);
	}

	public static ICollection<MerchantDisplay> GetMerchantDisplaysByMerchantIDPaged(byte merchantID, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetMerchantDisplaysByMerchantIDPaged_MerchantID:{merchantID}_StartRowIndex:{startRowIndex}_MaxRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"MerchantID:{merchantID}"), collectionId, () => MerchantDisplayDAL.GetMerchantDisplayIDsByMerchantIDPaged(merchantID, startRowIndex, maximumRows), Get);
	}

	public static ICollection<MerchantDisplay> GetAllMerchantDisplaysByMerchantID(byte merchantID)
	{
		return GetMerchantDisplaysByMerchantIDPaged(merchantID, 0, 2147483646);
	}

	public void Construct(MerchantDisplayDAL dal)
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
