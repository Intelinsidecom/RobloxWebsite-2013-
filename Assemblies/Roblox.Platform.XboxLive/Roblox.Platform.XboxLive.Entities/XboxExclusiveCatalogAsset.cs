using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.XboxLive.Entities;

internal class XboxExclusiveCatalogAsset : IRobloxEntity<int, XboxExclusiveCatalogAssetDAL>, ICacheableObject<int>, ICacheableObject
{
	private XboxExclusiveCatalogAssetDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(XboxExclusiveCatalogAsset).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal long AssetID
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

	public XboxExclusiveCatalogAsset()
	{
		_EntityDAL = new XboxExclusiveCatalogAssetDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
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

	internal static XboxExclusiveCatalogAsset CreateNew(long assetId)
	{
		XboxExclusiveCatalogAsset xboxExclusiveCatalogAsset = new XboxExclusiveCatalogAsset();
		xboxExclusiveCatalogAsset.AssetID = assetId;
		xboxExclusiveCatalogAsset.Save();
		return xboxExclusiveCatalogAsset;
	}

	internal static XboxExclusiveCatalogAsset Get(int id)
	{
		return EntityHelper.GetEntity<int, XboxExclusiveCatalogAssetDAL, XboxExclusiveCatalogAsset>(EntityCacheInfo, id, () => XboxExclusiveCatalogAssetDAL.Get(id));
	}

	internal static ICollection<XboxExclusiveCatalogAsset> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, XboxExclusiveCatalogAssetDAL, XboxExclusiveCatalogAsset>(ids, EntityCacheInfo, XboxExclusiveCatalogAssetDAL.MultiGet);
	}

	public static XboxExclusiveCatalogAsset GetByAssetID(long assetID)
	{
		return EntityHelper.GetEntityByLookup<int, XboxExclusiveCatalogAssetDAL, XboxExclusiveCatalogAsset>(EntityCacheInfo, $"AssetID:{assetID}", () => XboxExclusiveCatalogAssetDAL.GetXboxExclusiveCatalogAssetByAssetID(assetID));
	}

	internal static ICollection<XboxExclusiveCatalogAsset> GetXboxExclusiveCatalogAssets(int count, int exclusiveStartId)
	{
		string collectionId = $"GetXboxExclusiveCatalogAssets_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => XboxExclusiveCatalogAssetDAL.GetXboxExclusiveCatalogAssetIDs(count, exclusiveStartId), MultiGet);
	}

	internal static HashSet<long> GetAllXboxExclusiveCatalogAssetIds()
	{
		return (HashSet<long>)EntityHelper.GetEntityIDCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetAllXboxExclusiveCatalogAssetIds", delegate
		{
			HashSet<long> hashSet = new HashSet<long>();
			int exclusiveStartId = 0;
			ICollection<int> xboxExclusiveCatalogAssetIDs;
			do
			{
				xboxExclusiveCatalogAssetIDs = XboxExclusiveCatalogAssetDAL.GetXboxExclusiveCatalogAssetIDs(100, exclusiveStartId);
				foreach (XboxExclusiveCatalogAsset current in MultiGet(xboxExclusiveCatalogAssetIDs))
				{
					hashSet.Add(current.AssetID);
					exclusiveStartId = current.ID;
				}
			}
			while (xboxExclusiveCatalogAssetIDs.Count >= 100);
			return hashSet;
		});
	}

	public void Construct(XboxExclusiveCatalogAssetDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AssetID:{AssetID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
