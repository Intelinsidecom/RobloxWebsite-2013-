using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets.Entities;

internal class CreationContext : IRobloxEntity<long, CreationContextDAL>, ICacheableObject<long>, ICacheableObject
{
	private CreationContextDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(CreationContext).ToString(), isNullCacheable: true, Settings.Default.AssetCreationsCacheInvalidationPort);

	public long ID => _EntityDAL.ID;

	internal byte ContextTypeId
	{
		get
		{
			return _EntityDAL.ContextTypeId;
		}
		set
		{
			_EntityDAL.ContextTypeId = value;
		}
	}

	internal byte CreatorTypeId
	{
		get
		{
			return _EntityDAL.CreatorTypeId;
		}
		set
		{
			_EntityDAL.CreatorTypeId = value;
		}
	}

	internal long CreatorTargetId
	{
		get
		{
			return _EntityDAL.CreatorTargetId;
		}
		set
		{
			_EntityDAL.CreatorTargetId = value;
		}
	}

	internal int AssetTypeId
	{
		get
		{
			return _EntityDAL.AssetTypeId;
		}
		set
		{
			_EntityDAL.AssetTypeId = value;
		}
	}

	internal long? UniverseId
	{
		get
		{
			return _EntityDAL.UniverseId;
		}
		set
		{
			_EntityDAL.UniverseId = value;
		}
	}

	internal DateTime Created => _EntityDAL.Created;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public CreationContext()
	{
		_EntityDAL = new CreationContextDAL();
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
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	private static CreationContext DoGetOrCreate(byte contextTypeId, byte creatorTypeId, long creatorTargetId, int assetTypeId, long? universeId)
	{
		return EntityHelper.DoGetOrCreate<long, CreationContextDAL, CreationContext>(() => CreationContextDAL.GetOrCreate(contextTypeId, creatorTypeId, creatorTargetId, assetTypeId, universeId));
	}

	internal static CreationContext CreateNew(byte contextTypeId, byte creatorTypeId, long creatorTargetId, int assetTypeId, long? universeId)
	{
		CreationContext creationContext = new CreationContext();
		creationContext.ContextTypeId = contextTypeId;
		creationContext.CreatorTypeId = creatorTypeId;
		creationContext.CreatorTargetId = creatorTargetId;
		creationContext.AssetTypeId = assetTypeId;
		creationContext.UniverseId = universeId;
		creationContext.Save();
		return creationContext;
	}

	internal static CreationContext Get(long id)
	{
		return EntityHelper.GetEntity<long, CreationContextDAL, CreationContext>(EntityCacheInfo, id, () => CreationContextDAL.Get(id));
	}

	internal static ICollection<CreationContext> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, CreationContextDAL, CreationContext>(ids, EntityCacheInfo, CreationContextDAL.MultiGet);
	}

	internal static CreationContext GetByContextTypeIdCreatorTypeIdCreatorTargetIdAssetTypeIdAndUniverseId(byte contextTypeId, byte creatorTypeId, long creatorTargetId, int assetTypeId, long? universeId)
	{
		return EntityHelper.GetEntityByLookup<long, CreationContextDAL, CreationContext>(EntityCacheInfo, "ContextTypeId:" + contextTypeId + "_CreatorTypeId:" + creatorTypeId + "_CreatorTargetId:" + creatorTargetId + "_AssetTypeId:" + assetTypeId + "_UniverseId:" + universeId, () => CreationContextDAL.GetByContextTypeIdCreatorTypeIdCreatorTargetIdAssetTypeIdAndUniverseId(contextTypeId, creatorTypeId, creatorTargetId, assetTypeId, universeId));
	}

	internal static ICollection<CreationContext> GetCreationContextsByContextTypeIdCreatorTypeIdCreatorTargetIdAndAssetTypeIdPaged(byte contextTypeId, byte creatorTypeId, long creatorTargetId, int assetTypeId, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetCreationContextsByContextTypeIdCreatorTypeIdCreatorTargetIdAndAssetTypeIdPaged_ContextTypeId:{contextTypeId}_CreatorTypeId:{creatorTypeId}_CreatorTargetId:{creatorTargetId}_AssetTypeId:{assetTypeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		if (Settings.Default.UseMultigetForCreationContexts)
		{
			return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"ContextTypeId:{contextTypeId}_CreatorTypeId:{creatorTypeId}_CreatorTargetId:{creatorTargetId}_AssetTypeId:{assetTypeId}"), collectionId, () => CreationContextDAL.GetCreationContextIdsByContextTypeIdCreatorTypeIdCreatorTargetIdAssetTypeIdPaged(contextTypeId, creatorTypeId, creatorTargetId, assetTypeId, startRowIndex + 1, maximumRows), MultiGet);
		}
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"ContextTypeId:{contextTypeId}_CreatorTypeId:{creatorTypeId}_CreatorTargetId:{creatorTargetId}_AssetTypeId:{assetTypeId}"), collectionId, () => CreationContextDAL.GetCreationContextIdsByContextTypeIdCreatorTypeIdCreatorTargetIdAssetTypeIdPaged(contextTypeId, creatorTypeId, creatorTargetId, assetTypeId, startRowIndex + 1, maximumRows), Get);
	}

	internal static CreationContext GetOrCreate(byte contextTypeId, byte creatorTypeId, long creatorTargetId, int assetTypeId, long? universeId)
	{
		return EntityHelper.GetOrCreateEntity<long, CreationContext>(EntityCacheInfo, "ContextTypeId:" + contextTypeId + "_CreatorTypeId:" + creatorTypeId + "_CreatorTargetId:" + creatorTargetId + "_AssetTypeId:" + assetTypeId + "_UniverseId:" + universeId, () => DoGetOrCreate(contextTypeId, creatorTypeId, creatorTargetId, assetTypeId, universeId));
	}

	internal static long GetTotalNumberOfCreationContextsByContextTypeIdCreatorTypeIdCreatorTargetIdAndAssetTypeId(byte contextTypeId, byte creatorTypeId, long creatorTargetId, int assetTypeId)
	{
		string countId = $"GetTotalNumberOfCreationContextsByContextTypeIdCreatorTypeIdCreatorTargetIdAndAssetTypeId_ContextTypeId:{contextTypeId}_CreatorTypeId:{creatorTypeId}_CreatorTargetId:{creatorTargetId}_AssetTypeId:{assetTypeId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"ContextTypeId:{contextTypeId}_CreatorTypeId:{creatorTypeId}_CreatorTargetId:{creatorTargetId}_AssetTypeId:{assetTypeId}"), countId, () => CreationContextDAL.GetTotalNumberOfCreationContextsByContextTypeIdCreatorTypeIdCreatorTargetIdAndAssetTypeId(contextTypeId, creatorTypeId, creatorTargetId, assetTypeId));
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return "ContextTypeId:" + ContextTypeId + "_CreatorTypeId:" + CreatorTypeId + "_CreatorTargetId:" + CreatorTargetId + "_AssetTypeId:" + AssetTypeId + "_UniverseId:" + UniverseId;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"ContextTypeId:{ContextTypeId}_CreatorTypeId:{CreatorTypeId}_CreatorTargetId:{CreatorTargetId}_AssetTypeId:{AssetTypeId}");
	}

	public void Construct(CreationContextDAL dal)
	{
		_EntityDAL = dal;
	}
}
