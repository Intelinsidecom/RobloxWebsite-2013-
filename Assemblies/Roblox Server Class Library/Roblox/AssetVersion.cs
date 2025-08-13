using System;
using System.Collections.Generic;
using System.ComponentModel;
using Roblox.Assets.Properties;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;
using Roblox.DataV2.Core;

namespace Roblox;

[Obsolete("Should use Roblox.Platform.Assets. This entity is going to be deleted.")]
[DataObject]
public class AssetVersion : IAsset, IRobloxEntity<long, AssetVersionDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	public enum LookupFilter
	{
		AssetHashID,
		AssetID
	}

	internal AssetVersionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Roblox.AssetVersion", isNullCacheable: true);

	private bool _IsAssetVersionIdLoggingEnabled => Settings.Default.IsAssetVersionIdSetToZeroLoggingEnabled;

	[DataObjectField(true, true)]
	public long ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		set
		{
			_EntityDAL.ID = value;
		}
	}

	[DataObjectField(false)]
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

	[DataObjectField(false)]
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

	[DataObjectField(false)]
	public long AssetHashID
	{
		get
		{
			return _EntityDAL.AssetHashID;
		}
		set
		{
			_EntityDAL.AssetHashID = value;
		}
	}

	[DataObjectField(false)]
	public AssetHash AssetHash
	{
		get
		{
			return GetAssetHash();
		}
		set
		{
			_EntityDAL.AssetHashID = value?.ID ?? 0;
		}
	}

	[DataObjectField(false)]
	public Asset Asset
	{
		get
		{
			return GetAsset();
		}
		set
		{
			if (value != null)
			{
				_EntityDAL.AssetID = value.ID;
				AssetTypeID = value.AssetTypeID;
			}
			else
			{
				_EntityDAL.AssetID = 0L;
				AssetTypeID = 0;
			}
		}
	}

	[DataObjectField(false)]
	public int VersionNumber
	{
		get
		{
			return _EntityDAL.VersionNumber;
		}
		set
		{
			_EntityDAL.VersionNumber = value;
		}
	}

	[DataObjectField(false)]
	public string Hash
	{
		get
		{
			return _EntityDAL.Hash;
		}
		set
		{
			_EntityDAL.Hash = value;
		}
	}

	[DataObjectField(false)]
	public long? ParentAssetVersionID
	{
		get
		{
			return _EntityDAL.ParentAssetVersionID;
		}
		set
		{
			_EntityDAL.ParentAssetVersionID = value;
		}
	}

	[DataObjectField(false)]
	public AssetVersion Parent
	{
		get
		{
			return GetParentAssetVersion();
		}
		set
		{
			if (value != null)
			{
				_EntityDAL.ParentAssetVersionID = value.ID;
			}
			else
			{
				_EntityDAL.ParentAssetVersionID = null;
			}
		}
	}

	public long CreatorID
	{
		get
		{
			return _EntityDAL.CreatorID;
		}
		set
		{
			_EntityDAL.CreatorID = value;
		}
	}

	[DataObjectField(false)]
	public DateTime Created => _EntityDAL.Created;

	[DataObjectField(false)]
	public DateTime Updated => _EntityDAL.Updated;

	public long? CreatingUniverseID
	{
		get
		{
			return _EntityDAL.CreatingUniverseID;
		}
		set
		{
			_EntityDAL.CreatingUniverseID = value;
		}
	}

	[DataObjectField(false)]
	public ICreator Creator => CreatorRefObject.GetCreator();

	public CreatorRef CreatorRefObject => CreatorRef.CreateNewRefFromAgentId(_EntityDAL.CreatorID);

	public AssetVersion CurrentVersion => this;

	[DataObjectField(false)]
	public string Description => Asset.Description;

	public bool IsHashDynamic => false;

	public bool IsApproved => AssetHash.IsApproved;

	public bool IsReviewed => AssetHash.IsReviewed;

	[DataObjectField(false)]
	public string Name => Asset.Name;

	[DataObjectField(false)]
	public AssetType Type => AssetType.Get(_EntityDAL.AssetTypeID);

	public bool? IsArchived => Asset.IsArchived;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static event Action<Asset> VersionChanged;

	public AssetVersion()
	{
		_EntityDAL = new AssetVersionDAL();
	}

	public AssetVersion(AssetVersionDAL dal)
	{
		_EntityDAL = dal;
	}

	private AssetVersion(Asset asset, CreatorRef creatorRef, string hash, long? parentAssetVersionId, int versionNumber, long assetHashId, long? creatingUniverseId)
	{
		if (asset == null)
		{
			throw new ApplicationException("Invalid Asset specified: null.");
		}
		if (hash == null || hash.Trim().Length == 0)
		{
			throw new ApplicationException("Invalid file hash specified.");
		}
		if (creatorRef.IsEmpty())
		{
			throw new ApplicationException("Invalid AssetVersion Creator specified: null.");
		}
		_EntityDAL = new AssetVersionDAL();
		Asset = asset;
		Hash = hash;
		_EntityDAL.CreatorID = creatorRef.AgentID;
		ParentAssetVersionID = parentAssetVersionId;
		VersionNumber = versionNumber;
		AssetHashID = assetHashId;
		CreatingUniverseID = creatingUniverseId;
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public Asset GetAsset()
	{
		return Asset.MustGet(AssetID);
	}

	public AssetType GetAssetType()
	{
		return AssetType.MustGet(AssetTypeID);
	}

	public AssetHash GetAssetHash()
	{
		return AssetHash.MustGet(AssetHashID);
	}

	public AssetVersion GetParentAssetVersion()
	{
		if (!ParentAssetVersionID.HasValue)
		{
			return null;
		}
		return MustGet(ParentAssetVersionID.Value);
	}

	public void Save()
	{
		if (_EntityDAL.AssetHashID == 0L && !string.IsNullOrEmpty(_EntityDAL.Hash))
		{
			_EntityDAL.AssetHashID = AssetHash.Get(_EntityDAL.AssetTypeID, _EntityDAL.Hash).ID;
		}
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.UtcNow;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
			Asset asset2 = Asset.Get(AssetID);
			if (asset2 == null && _IsAssetVersionIdLoggingEnabled)
			{
				throw new ApplicationException($"Asset should exist for asset Id {AssetID}");
			}
			if (asset2.CurrentVersionID != ID)
			{
				asset2.Hash = Hash;
				asset2.AssetHashID = AssetHashID;
				asset2.CurrentVersionID = ID;
				asset2.Save();
				if (AssetVersion.VersionChanged != null && VersionNumber > 1)
				{
					AssetVersion.VersionChanged(asset2);
				}
			}
		}, delegate
		{
			Asset asset = Asset.Get(AssetID);
			if (asset == null && _IsAssetVersionIdLoggingEnabled)
			{
				throw new ApplicationException($"Asset should exist for asset Id {AssetID}");
			}
			if (ID == asset.CurrentVersionID)
			{
				asset.AssetHashID = AssetHashID;
				asset.Hash = Hash;
				asset.Save();
			}
			_EntityDAL.Updated = DateTime.UtcNow;
			_EntityDAL.Update();
		});
	}

	/// <summary>
	/// Create a new AssetVersion for the given Asset and Creator using the given Hash
	/// </summary>
	/// <param name="asset"></param>
	/// <param name="creatorRef"></param>
	/// <param name="contentHash">Hash value, will result in the <see cref="P:Roblox.AssetVersion.AssetHash" /> being loaded.</param>
	/// <param name="creatingUniverseId"></param>
	/// <returns>newly created <see cref="T:Roblox.AssetVersion" /></returns>
	internal static AssetVersion CreateNew_PLATFORMONLY(Asset asset, CreatorRef creatorRef, string contentHash, long? creatingUniverseId = null)
	{
		if (asset == null)
		{
			throw new ApplicationException("Required value not specified: Asset.");
		}
		AssetVersion parentAssetVersion = asset.GetCurrentVersion();
		int versionNumber = GetNextVersionNumber(asset);
		long assetHashId = AssetHash.Get(asset.AssetTypeID, contentHash).ID;
		AssetVersion assetVersion = new AssetVersion(asset, creatorRef, contentHash, parentAssetVersion?.ID, versionNumber, assetHashId, creatingUniverseId);
		assetVersion.Save();
		return assetVersion;
	}

	/// <summary>
	/// Create a new AssetVersion for the given Asset and Creator based on the given Parent AssetVersion.
	/// This is effectively a pass-through used to revert an AssetVersion. 
	/// There is no validation of Hash or HashId against the Parent AssetVersion
	/// </summary>
	/// <param name="asset"></param>
	/// <param name="creatorRef"></param>
	/// <param name="hash"></param>
	/// <param name="parentAssetVersionId"></param>
	/// <param name="assetHashId"></param>
	/// <param name="creatingUniverseId"></param>
	/// <returns>newly created <see cref="T:Roblox.AssetVersion" /></returns>
	internal static AssetVersion CreateNew_PLATFORMONLY(Asset asset, CreatorRef creatorRef, string hash, long? parentAssetVersionId, long assetHashId, long? creatingUniverseId = null)
	{
		int versionNumber = GetNextVersionNumber(asset);
		AssetVersion assetVersion = new AssetVersion(asset, creatorRef, hash, parentAssetVersionId, versionNumber, assetHashId, creatingUniverseId);
		assetVersion.Save();
		if (assetVersion.VersionNumber > 1 && AssetVersion.VersionChanged != null)
		{
			AssetVersion.VersionChanged(asset);
		}
		return assetVersion;
	}

	private static int GetNextVersionNumber(Asset asset)
	{
		return GetTotalNumberOfAssetVersionsByAssetID(asset.ID) + 1;
	}

	internal static int GetNextVersionNumber(long assetId)
	{
		return GetTotalNumberOfAssetVersionsByAssetID(assetId) + 1;
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
	public static AssetVersion Get(long id)
	{
		return EntityHelper.GetEntity<long, AssetVersionDAL, AssetVersion>(EntityCacheInfo, id, () => AssetVersionDAL.Get(id));
	}

	public static AssetVersion Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public static AssetVersion Get(long assetId, int versionNumber)
	{
		if (assetId == 0L || versionNumber == 0)
		{
			return null;
		}
		return EntityHelper.GetEntityByLookup<long, AssetVersionDAL, AssetVersion>(EntityCacheInfo, $"AssetID:{assetId}_VersionNumber:{versionNumber}", () => AssetVersionDAL.Get(assetId, versionNumber));
	}

	/// <summary>
	/// Gets <see cref="T:Roblox.AssetVersion" /> by ids.
	/// </summary>
	/// <remarks>Should only be used by Roblox.Assets service.</remarks>
	internal static IEnumerable<AssetVersion> MultiGet(IReadOnlyCollection<long> ids)
	{
		if (ids == null)
		{
			throw new ArgumentNullException("ids");
		}
		return EntityHelper.GetEntitiesByIds<AssetVersion, AssetVersionDAL, long>(EntityCacheInfo, ids, AssetVersionDAL.MultiGet);
	}

	[Obsolete("Use GetAssetVersionsPagedByAssetID instead")]
	public static ICollection<AssetVersion> GetAssetVersionsPaged(long assetId, int startRowIndex, int maximumRows)
	{
		return GetAssetVersionsPagedByAssetID(assetId, startRowIndex, maximumRows);
	}

	[Obsolete("Use GetAssetVersionsPagedByAssetID or GetAssetVersionsPagedByAssetHashID instead")]
	public static ICollection<AssetVersion> GetAssetVersionsPaged(LookupFilter lookupFilter, long id, int startRowIndex, int maximumRows)
	{
		return lookupFilter switch
		{
			LookupFilter.AssetHashID => GetAssetVersionsPagedByAssetHashID(id, startRowIndex, maximumRows), 
			LookupFilter.AssetID => GetAssetVersionsPagedByAssetID(id, startRowIndex, maximumRows), 
			_ => null, 
		};
	}

	public static ICollection<AssetVersion> GetAssetVersionsPagedByAssetID(long assetId, int startRowIndex, int maximumRows)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "AssetID:" + assetId), $"GetAssetVersionsPagedByAssetID:{assetId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}", () => AssetVersionDAL.GetAssetVersionIDsPaged(LookupFilter.AssetID, assetId, startRowIndex + 1, maximumRows), Get);
	}

	public static ICollection<AssetVersion> GetAssetVersionsPagedByAssetHashID(long assetHashId, int startRowIndex, int maximumRows)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "AssetHashID:" + assetHashId), $"GetAssetVersionsPagedByAssetHashID:{assetHashId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}", () => AssetVersionDAL.GetAssetVersionIDsPaged(LookupFilter.AssetHashID, assetHashId, startRowIndex + 1, maximumRows), Get);
	}

	public static ICollection<AssetVersion> GetAssetVersionsPagedByAssetID(long assetId, int? exclusiveStartVersionNumber, int count, SortOrder sortOrder)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "AssetID:" + assetId), $"GetAssetVersionsPagedByAssetID:{assetId}_ExclusiveStartVersionNumber:{exclusiveStartVersionNumber}_Count:{count}_SortOrder:{sortOrder}", () => AssetVersionDAL.GetAssetVersionIDsPaged(assetId, exclusiveStartVersionNumber, count, sortOrder), Get);
	}

	[Obsolete("Use GetTotalNumberOfAssetVersionsByAssetID or GetTotalNumberOfAssetVersionsByAssetHashID instead")]
	public static int GetTotalNumberOfAssetVersions(LookupFilter lookupFilter, long id)
	{
		return lookupFilter switch
		{
			LookupFilter.AssetHashID => GetTotalNumberOfAssetVersionsByAssetID(id), 
			LookupFilter.AssetID => GetTotalNumberOfAssetVersionsByAssetHashID(id), 
			_ => 0, 
		};
	}

	public static int GetTotalNumberOfAssetVersionsByAssetID(long assetId)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "AssetID:" + assetId), "GetTotalNumberOfAssetVersionsByAssetID:" + assetId, () => AssetVersionDAL.GetTotalNumberOfAssetVersions(LookupFilter.AssetID, assetId));
	}

	public static int GetTotalNumberOfAssetVersionsByAssetHashID(long assetHashId)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "AssetHashID:" + assetHashId), "GetTotalNumberOfAssetVersionsByAssetHashID:" + assetHashId, () => AssetVersionDAL.GetTotalNumberOfAssetVersions(LookupFilter.AssetHashID, assetHashId));
	}

	[Obsolete("Use GetTotalNumberOfAssetVersionsByAssetID")]
	public static int GetTotalNumberOfAssetVersions(long assetId)
	{
		return GetTotalNumberOfAssetVersionsByAssetID(assetId);
	}

	public static AssetVersion MustGet(long id)
	{
		return EntityHelper.MustGet(id, Get);
	}

	public bool IsCreator(ICreator creator)
	{
		return CreatorRefObject.IsReferenceTo(creator);
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public void Construct(AssetVersionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AssetID:{AssetID}_VersionNumber:{VersionNumber}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken("AssetID:" + AssetID);
		yield return new StateToken("AssetHashID:" + AssetHashID);
		yield return new StateToken("VersionNumber:" + VersionNumber);
	}
}
