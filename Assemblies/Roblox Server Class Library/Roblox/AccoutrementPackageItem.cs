using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class AccoutrementPackageItem : IRobloxEntity<long, AccoutrementPackageItemDAL>, ICacheableObject<long>, ICacheableObject
{
	private AccoutrementPackageItemDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: false, hasUnqualifiedCollections: false), "Roblox.AccoutrementPackageItem", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long AccoutrementPackageAssetID
	{
		get
		{
			return _EntityDAL.AccoutrementPackageAssetID;
		}
		set
		{
			_EntityDAL.AccoutrementPackageAssetID = value;
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

	public int AssetTypeID
	{
		get
		{
			return _EntityDAL.AssetTypeID;
		}
		set
		{
			_EntityDAL.AssetTypeID = value;
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

	public Asset Asset => Asset.Get(AssetID);

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AccoutrementPackageItem()
	{
		_EntityDAL = new AccoutrementPackageItemDAL();
	}

	public static AccoutrementPackageItem CreateNew(long accoutrementpackageassetid, long assetid, int assettypeid)
	{
		if (Asset.Get(accoutrementpackageassetid) == null)
		{
			throw new ApplicationException("Package asset does not exist!");
		}
		AccoutrementPackageItem accoutrementPackageItem = new AccoutrementPackageItem();
		accoutrementPackageItem.AccoutrementPackageAssetID = accoutrementpackageassetid;
		accoutrementPackageItem.AssetID = assetid;
		accoutrementPackageItem.AssetTypeID = assettypeid;
		accoutrementPackageItem.Save();
		return accoutrementPackageItem;
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

	public static AccoutrementPackageItem Get(long id)
	{
		return EntityHelper.GetEntity<long, AccoutrementPackageItemDAL, AccoutrementPackageItem>(EntityCacheInfo, id, () => AccoutrementPackageItemDAL.Get(id));
	}

	public static ICollection<AccoutrementPackageItem> GetAccoutrementPackageItems(long accoutrementPackageAssetId)
	{
		string collectionId = $"GetAccoutrementPackageItems_AccoutrementPackageAssetID:{accoutrementPackageAssetId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AccoutrementPackageAssetID:{accoutrementPackageAssetId}"), collectionId, () => AccoutrementPackageItemDAL.GetAccoutrementPackageItemIDsByAccoutrementPackageAssetID(accoutrementPackageAssetId), Get);
	}

	public void Construct(AccoutrementPackageItemDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"AccoutrementPackageAssetID:{AccoutrementPackageAssetID}");
	}
}
