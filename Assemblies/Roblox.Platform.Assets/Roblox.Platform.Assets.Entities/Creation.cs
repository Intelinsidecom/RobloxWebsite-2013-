using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets.Entities;

internal class Creation : IRobloxEntity<long, CreationDAL>, ICacheableObject<long>, ICacheableObject
{
	private CreationDAL _EntityDAL;

	/// <summary>
	/// The creation context ID of the previous creation context.
	/// </summary>
	/// <remarks>Used for cache invalidation.</remarks>
	private long? _OriginalCreationContextId;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Creation).ToString(), isNullCacheable: true, Settings.Default.AssetCreationsCacheInvalidationPort);

	public long ID => _EntityDAL.ID;

	internal long CreationContextId
	{
		get
		{
			return _EntityDAL.CreationContextId;
		}
		set
		{
			if (!_OriginalCreationContextId.HasValue)
			{
				_OriginalCreationContextId = _EntityDAL.CreationContextId;
			}
			_EntityDAL.CreationContextId = value;
		}
	}

	internal long AssetId
	{
		get
		{
			return _EntityDAL.AssetId;
		}
		set
		{
			_EntityDAL.AssetId = value;
		}
	}

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime? Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Creation()
	{
		_EntityDAL = new CreationDAL();
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
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
		_OriginalCreationContextId = null;
	}

	private static Creation DoGetOrCreate(long creationContextType, long assetId)
	{
		return EntityHelper.DoGetOrCreate<long, CreationDAL, Creation>(() => CreationDAL.GetOrCreate(creationContextType, assetId));
	}

	internal static Creation CreateNew(long creationContextId, long assetId)
	{
		Creation creation = new Creation();
		creation.CreationContextId = creationContextId;
		creation.AssetId = assetId;
		creation.Save();
		return creation;
	}

	internal static Creation Get(long id)
	{
		return EntityHelper.GetEntity<long, CreationDAL, Creation>(EntityCacheInfo, id, () => CreationDAL.Get(id));
	}

	internal static ICollection<Creation> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, CreationDAL, Creation>(ids, EntityCacheInfo, CreationDAL.MultiGet);
	}

	internal static Creation GetByAssetId(long assetId)
	{
		return EntityHelper.GetEntityByLookup<long, CreationDAL, Creation>(EntityCacheInfo, "AssetId:" + assetId, () => CreationDAL.GetByAssetId(assetId));
	}

	internal static Creation GetByCreationContextIdAndAssetId(long creationContextId, long assetId)
	{
		return EntityHelper.GetEntityByLookup<long, CreationDAL, Creation>(EntityCacheInfo, "CreationContextId:" + creationContextId + "_AssetId:" + assetId, () => CreationDAL.GetByCreationContextIdAndAssetId(creationContextId, assetId));
	}

	internal static ICollection<Creation> GetCreationsByCreationContextIdPaged(long creationContextId, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetCreationsByCreationContextIdPaged_CreationContextId:{creationContextId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		if (Settings.Default.UseMultigetForCreations)
		{
			return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy("CreationContextId:" + creationContextId), collectionId, () => CreationDAL.GetCreationIdsByCreationContextIdPaged(creationContextId, startRowIndex + 1, maximumRows), MultiGet);
		}
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy("CreationContextId:" + creationContextId), collectionId, () => CreationDAL.GetCreationIdsByCreationContextIdPaged(creationContextId, startRowIndex + 1, maximumRows), Get);
	}

	internal static Creation GetOrCreate(long creationContextId, long assetId)
	{
		return EntityHelper.GetOrCreateEntity<long, Creation>(EntityCacheInfo, "CreationContextId:" + creationContextId + "_AssetId:" + assetId, () => DoGetOrCreate(creationContextId, assetId));
	}

	internal static long GetTotalNumberOfCreationsByCreationContextId(long creationContextId)
	{
		string countId = "GetTotalNumberOfCreationsByCreationContextId_CreationContextId:" + creationContextId;
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy("CreationContextId:" + creationContextId), countId, () => CreationDAL.GetTotalNumberOfCreationsByCreationContextId(creationContextId));
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return "CreationContextId:" + CreationContextId + "_AssetId:" + AssetId;
			yield return "AssetId:" + AssetId;
			if (_OriginalCreationContextId.HasValue)
			{
				yield return "CreationContextId:" + _OriginalCreationContextId + "_AssetId:" + AssetId;
			}
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken("CreationContextId:" + CreationContextId);
		if (_OriginalCreationContextId.HasValue)
		{
			yield return new StateToken("CreationContextId:" + _OriginalCreationContextId);
		}
	}

	public void Construct(CreationDAL dal)
	{
		_EntityDAL = dal;
	}
}
