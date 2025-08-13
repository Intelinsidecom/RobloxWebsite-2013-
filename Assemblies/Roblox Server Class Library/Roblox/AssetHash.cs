using System;
using System.Collections.Generic;
using System.ComponentModel;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;
using Roblox.Moderation;
using Roblox.Properties;

namespace Roblox;

[Obsolete("Should use Roblox.Platform.Assets. This entity is going to be deleted.")]
[DataObject]
public class AssetHash : IRobloxEntity<long, AssetHashDAL>, ICacheableObject<long>, ICacheableObject, IReviewableAsset, IRemoteCacheableObject
{
	internal AssetHashDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "AssetHash", isNullCacheable: true);

	[DataObjectField(true, true)]
	public long ID => _EntityDAL.ID;

	[DataObjectField(false)]
	public int AssetTypeID => _EntityDAL.AssetTypeID;

	[DataObjectField(false)]
	public string Hash => _EntityDAL.Hash;

	[DataObjectField(false)]
	public bool IsApproved => _EntityDAL.IsApproved;

	[DataObjectField(false)]
	public bool IsReviewed => _EntityDAL.IsReviewed;

	[DataObjectField(false)]
	public long CreatorId => _EntityDAL.CreatorID;

	[DataObjectField(false)]
	public DateTime Created => _EntityDAL.Created;

	[DataObjectField(false)]
	public DateTime Updated => _EntityDAL.Updated;

	[DataObjectField(false)]
	public CreatorRef CreatorRefObject => CreatorRef.CreateNewRefFromAgentId(_EntityDAL.CreatorID);

	[DataObjectField(false)]
	public ICreator Creator => CreatorRefObject.GetCreator();

	public AssetType Type => GetAssetType();

	public long CreatorID => CreatorRefObject.AgentID;

	public long HashID => ID;

	public int TypeID => AssetTypeID;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static event Action<long> ApprovalChanged;

	public AssetHash()
	{
		_EntityDAL = new AssetHashDAL();
	}

	public AssetHash(AssetHashDAL dal)
	{
		_EntityDAL = dal;
	}

	internal void Save()
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

	public AssetType GetAssetType()
	{
		return AssetType.MustGet(AssetTypeID);
	}

	private static AssetHash DoGetOrCreate(int assetTypeId, string hash, ICreator creator, bool isApproved, bool isReviewed)
	{
		return EntityHelper.DoGetOrCreate<long, AssetHashDAL, AssetHash>(() => AssetHashDAL.GetOrCreate(assetTypeId, hash, isApproved, isReviewed, creator.GetAgentID(), (byte)creator.CreatorType));
	}

	private static AssetHash DoGetOrCreate(int assetTypeId, string hash, long creatorAgentId, bool isApproved, bool isReviewed)
	{
		return EntityHelper.DoGetOrCreate<long, AssetHashDAL, AssetHash>(() => AssetHashDAL.GetOrCreate(assetTypeId, hash, isApproved, isReviewed, (int)creatorAgentId));
	}

	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	public static void Delete(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID");
		}
		Get(id)?.Delete();
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public static AssetHash Get(long id)
	{
		return EntityHelper.GetEntity<long, AssetHashDAL, AssetHash>(EntityCacheInfo, id, () => AssetHashDAL.Get(id));
	}

	public static AssetHash Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public static AssetHash Get(int assetTypeID, string hash)
	{
		if (assetTypeID == 0 || string.IsNullOrEmpty(hash))
		{
			return null;
		}
		return EntityHelper.GetEntityByLookup<long, AssetHashDAL, AssetHash>(EntityCacheInfo, $"AssetTypeID:{assetTypeID}_Hash:{hash}".Trim(), () => AssetHashDAL.Get(assetTypeID, hash));
	}

	internal static AssetHash GetOrCreate(int assetTypeId, string hash, ICreator creator, bool isApproved, bool isReviewed)
	{
		if (assetTypeId == 0 || string.IsNullOrEmpty(hash) || creator == null)
		{
			throw new ApplicationException("GetOrCreate failure.");
		}
		return EntityHelper.GetOrCreateEntity<long, AssetHash>(EntityCacheInfo, $"AssetTypeID:{assetTypeId}_Hash:{hash}".Trim(), () => DoGetOrCreate(assetTypeId, hash, creator, isApproved, isReviewed));
	}

	internal static AssetHash GetOrCreate(int assetTypeId, string hash, long creatorAgentId, bool isApproved, bool isReviewed)
	{
		if (assetTypeId == 0)
		{
			throw new ApplicationException(string.Format("Invalid value for {0}", "assetTypeId"));
		}
		if (string.IsNullOrEmpty(hash))
		{
			throw new ApplicationException(string.Format("Invalid value for {0}", "hash"));
		}
		return EntityHelper.GetOrCreateEntity<long, AssetHash>(EntityCacheInfo, $"AssetTypeID:{assetTypeId}_Hash:{hash}".Trim(), () => DoGetOrCreate(assetTypeId, hash, creatorAgentId, isApproved, isReviewed));
	}

	public static ICollection<AssetHash> GetAssetHashesPaged(int assetTypeID, int startRowIndex, int maximumRows)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "AssetTypeID:" + assetTypeID), $"GetAssetHashesPaged_AssetTypeID:{assetTypeID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}", () => AssetHashDAL.GetAssetHashIDsPaged(assetTypeID, startRowIndex + 1, maximumRows), Get);
	}

	public static ICollection<AssetHash> GetAssetHashesPaged(string hash, int startRowIndex, int maximumRows)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "Hash:" + hash), $"GetAssetHashesPaged_Hash:{hash}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}", () => AssetHashDAL.GetAssetHashIDsPaged(hash, startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfAssetHashes(int assetTypeID)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "AssetTypeID:" + assetTypeID), "GetTotalNumberOfAssetHashes_AssetTypeID:" + assetTypeID, () => AssetHashDAL.GetTotalNumberOfAssetHashes(assetTypeID));
	}

	public static int GetTotalNumberOfAssetHashes(string hash)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "Hash:" + hash), "GetTotalNumberOfAssetHashes_Hash:" + hash, () => AssetHashDAL.GetTotalNumberOfAssetHashes(hash));
	}

	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public static int GetTotalNumberOfUnreviewedAssetHashes(int assetTypeId)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "AssetTypeID:" + assetTypeId), "GetTotalNumberOfUnreviewedAssetHashes_AssetTypeID:" + assetTypeId, () => AssetHashDAL.GetTotalNumberOfUnreviewedAssetHashes(assetTypeId));
	}

	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public static IEnumerable<AssetHash> GetUnreviewedAssetHashes(int assetTypeId, int startRowIndex, int maximumRows)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "AssetTypeID:" + assetTypeId), "GetUnreviewedAssetHashes_AssetTypeID:" + assetTypeId + "_StartRowIndex:" + startRowIndex + "_MaximumRows:" + maximumRows, () => AssetHashDAL.GetUnreviewedAssetHashIDs(assetTypeId, startRowIndex + 1, maximumRows), Get);
	}

	public static AssetHash MustGet(long id)
	{
		return EntityHelper.MustGet(id, Get);
	}

	public void SetApproval(bool isApproved, bool isReviewed)
	{
		if (!Settings.Default.AssetHashSetApprovalOnlyIfDifferentEnabled || IsApproved != isApproved || IsReviewed != isReviewed)
		{
			_EntityDAL.IsApproved = isApproved;
			_EntityDAL.IsReviewed = isReviewed;
			Save();
			AssetHash.ApprovalChanged?.Invoke(ID);
		}
	}

	public void SetOriginalCreatorForGroupItems(long userId)
	{
		_EntityDAL.CreatorID = userId;
		Save();
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public void Construct(AssetHashDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AssetTypeID:{AssetTypeID}_Hash:{Hash}".Trim();
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken("AssetTypeID:" + AssetTypeID);
		yield return new StateToken("Hash:" + Hash);
	}
}
