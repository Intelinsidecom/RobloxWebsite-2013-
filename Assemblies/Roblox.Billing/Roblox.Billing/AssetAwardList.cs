using System;
using System.Collections.Generic;
using Roblox.Billing.Properties;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class AssetAwardList : IRobloxEntity<int, AssetAwardListDAL>, ICacheableObject<int>, ICacheableObject
{
	private AssetAwardListDAL _EntityDAL;

	private List<Asset> _Assets;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.AssetAwardList", isNullCacheable: true);

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

	public DateTime ActivationDate
	{
		get
		{
			return _EntityDAL.ActivationDate;
		}
		set
		{
			_EntityDAL.ActivationDate = value;
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

	public List<Asset> Assets
	{
		get
		{
			_Assets = new List<Asset>();
			if (!Settings.Default.InCommAssetAwardsEnabled)
			{
				return _Assets;
			}
			foreach (AssetAwardListItem assetAwardListItem in AssetAwardListItems)
			{
				_Assets.Add(Asset.Get(assetAwardListItem.AssetID));
			}
			return _Assets;
		}
	}

	public List<AssetAwardListItem> AssetAwardListItems => (List<AssetAwardListItem>)AssetAwardListItem.GetAssetAwardListItemsByAssetAwardListID(ID);

	public CacheInfo CacheInfo => EntityCacheInfo;

	public bool IsNullCacheable => true;

	public AssetAwardList()
	{
		_EntityDAL = new AssetAwardListDAL();
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

	public static AssetAwardList CreateNew(byte merchantid, DateTime activationdate)
	{
		AssetAwardList assetAwardList = new AssetAwardList();
		assetAwardList.MerchantID = merchantid;
		assetAwardList.ActivationDate = activationdate;
		assetAwardList.Save();
		return assetAwardList;
	}

	public static AssetAwardList Get(int id)
	{
		return EntityHelper.GetEntity<int, AssetAwardListDAL, AssetAwardList>(EntityCacheInfo, id, () => AssetAwardListDAL.Get(id));
	}

	public static ICollection<AssetAwardList> GetAssetAwardListsByMerchantID(byte MerchantID)
	{
		string collectionId = $"GetAssetAwardListsByMerchantID_MerchantID:{MerchantID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"MerchantID:{MerchantID}"), collectionId, () => AssetAwardListDAL.GetAssetAwardListIDsByMerchantID(MerchantID), Get);
	}

	public static ICollection<AssetAwardList> GetAssetAwardListsByMerchantIDActivationDateBefore(byte MerchantID, DateTime ActivationDate)
	{
		string collectionId = $"GetAssetAwardListsByMerchantID_MerchantID:{MerchantID}_ActivationDateBefore:{ActivationDate}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"MerchantID:{MerchantID}"), collectionId, () => AssetAwardListDAL.GetAssetAwardListIDsByMerchantIDActivationDateBefore(MerchantID, ActivationDate), Get);
	}

	public static ICollection<AssetAwardList> GetAssetAwardListsByMerchantIDActivationDateAfter(byte MerchantID, DateTime ActivationDate)
	{
		string collectionId = $"GetAssetAwardListsByMerchantID_MerchantID:{MerchantID}_ActivationDateAfter:{ActivationDate}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"MerchantID:{MerchantID}"), collectionId, () => AssetAwardListDAL.GetAssetAwardListIDsByMerchantIDActivationDateAfter(MerchantID, ActivationDate), Get);
	}

	public static AssetAwardList GetCurrentAssetAwardList(byte merchantID)
	{
		AssetAwardList currentActive = null;
		foreach (AssetAwardList awardList in GetAssetAwardListsByMerchantID(merchantID))
		{
			if (awardList.ActivationDate <= DateTime.Now && (currentActive == null || currentActive.ActivationDate < awardList.ActivationDate))
			{
				currentActive = awardList;
			}
		}
		return currentActive;
	}

	public void Construct(AssetAwardListDAL dal)
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

	public string GetIdentifier()
	{
		return ID.ToString();
	}
}
